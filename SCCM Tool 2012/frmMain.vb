﻿'==========================================================================
'
' 
' NAME: SCCM Ninja
' VERSION: 1.1.0.0
'
' AUTHOR: Scott Stevens
' DATE  : 04/21/2015
'
' COMMENT: To help with the addition of machines to certain IDS SCCM collections. (For pushing out software easily.)
'
' 
' CHANGES: 0.9.2.1 - First Stable Version
'          0.9.5.0 - New version with sorting code, because now there's not two lists for names and IDs.
'          0.9.6.0 - Last Ninja Version before DART/Window projects.
'          0.9.9.5 - Updated testing version, after failures with SCCM Dart/Window due to server access problems.
'          1.0.0.0 - Final version for production. Added clipboard use, scrolling collection results, progress bar, logging, batch add multiuse, design, UI, BUGS! New icons, etc.
'          1.1.0.0 - Same as above, cerimonial version.
'          1.1.1.0 - Allow clipboard of lots of names. Fixed label issues.
'		
'==========================================================================

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'give me a wonderful name and version number on the main title bar
        Me.Text = Application.ProductName & " v" & Application.ProductVersion

        'connect to SCCM
        ConnectToSCCM(ProgressBar)

        WriteToLog("***********************************" & "Program started v" & Application.ProductVersion & "******************************")

        'If AreWeConnectedToSCCM = False Then
        ' MsgBox("The Ninja was unable to connect to SCCM, try again later.", MsgBoxStyle.Critical)
        ' WriteToLog("The Ninja was unable to connect to SCCM, closing.")
        ' End
        ' End If

        LoadedCollections = LoadSubCollections("# IDS - Daily")

        'load collections into collection listbox
        For Each strBuffy As String In LoadedCollections
            lstCollections.Items.Add(strBuffy)
        Next

        UpdateStatus("Connected successfully to: " & SiteServer)
        WriteToLog("Connected successfully to: " & SiteServer)

    End Sub

    Private Sub btnSelectedClear_Click(sender As Object, e As EventArgs)
        lstIDsToAdd.Items.Clear()
        CollectionsToAdd.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        lstUsers.Items.Clear()
        SystemsToAdd.Clear()
    End Sub

    Private Sub btnAddTitles_Click(sender As Object, e As EventArgs) Handles btnAddTitles.Click

        Dim selectedOnes As Windows.Forms.ListBox.SelectedIndexCollection
        selectedOnes = lstCollections.SelectedIndices

        For Each intBuff As Integer In selectedOnes
            'new code to allow sorting of listbox
            lstIDsToAdd.Items.Add(lstCollections.Items(intBuff))
            CollectionsToAdd.Add(lstCollections.Items(intBuff))
        Next
    End Sub

    Private Sub btnAddNames_Click(sender As Object, e As EventArgs) Handles btnAddNames.Click

        If txtComputers.Text = "" Then Exit Sub

        Dim buffer() As String = Split(txtComputers.Text, vbNewLine)

        For Each temper As String In buffer
            If temper <> "" Then
                lstUsers.Items.Add(UCase(temper))
                SystemsToAdd.Add(UCase(temper))
            End If
        Next

        txtComputers.Text = ""

    End Sub


    Private Sub txtCollections_TextChanged(sender As Object, e As EventArgs) Handles txtCollections.TextChanged

        ' If chkShowAll.Checked = False Then

        lstCollections.Items.Clear()

        For Each strTempCollection As String In LoadedCollections
            If UCase(strTempCollection).Contains(UCase(txtCollections.Text)) Then lstCollections.Items.Add(strTempCollection)
        Next
        'Else
        '
        '        lstCollections.Items.Clear()
        '
        '        For Each strTempCollection As String In LoadedCollections
        ' If UCase(strTempCollection).Contains(UCase(txtCollections.Text)) Then
        ' If Not UCase(strTempCollection).Contains("/") Then lstCollections.Items.Add(strTempCollection)
        ' End If
        ' Next
        '
        '        End If
        '
    End Sub

    Private Sub btnAddFromClipboard_Click(sender As Object, e As EventArgs) Handles btnAddFromClipboard.Click

        Dim grabClipboard = Clipboard.GetText
        If grabClipboard = "" Then Exit Sub

        If grabClipboard.Contains(vbNewLine) Then

            Dim splitter = Split(grabClipboard, vbNewLine)
            For Each littlepiece As String In splitter
                If Len(littlepiece) < 15 And Len(littlepiece) > 5 Then
                    lstUsers.Items.Add(UCase(littlepiece))
                    SystemsToAdd.Add(UCase(littlepiece))
                End If
            Next

        Else
            If Len(grabClipboard) > 14 Or Len(grabClipboard) < 5 Then
                MsgBox("The clipboard values are whack. Please try copying again.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            lstUsers.Items.Add(UCase(grabClipboard))
            SystemsToAdd.Add(UCase(grabClipboard))
        End If

    End Sub

    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click

        If lstIDsToAdd.Items.Count = 0 Or lstUsers.Items.Count = 0 Then
            UpdateStatus("You must add more information to continue. Check data fields.")
            MsgBox("Please enter more information to continue.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        AllowEvents()
        ProgressBar.Style = ProgressBarStyle.Marquee
        AllowEvents()

        Dim addBuffer As String = ""
        Dim addUsers As String = ""
        Dim splitResult()
        Dim inResult As Boolean = False
        Dim IDstoAdd As New ArrayList

        'get a arraylist of all collections to add to
        For Each addBuffer In CollectionsToAdd

            splitResult = Split(addBuffer, ";")
            'MsgBox("Added to the array IDstoAdd: " & splitResult(1))
            'MsgBox("addbuffer = " & addBuffer)
            splitResult = Split(addBuffer, ";")
            'MsgBox("Added to the array IDstoAdd: " & splitResult(1))
            IDstoAdd.Add(splitResult(1))
            AllowEvents()
        Next

        'loop through each user, to add all machines to each user.
        For Each addUsers In SystemsToAdd

            'set the computer to be added
            strComputer = addUsers

            'loop through all COLIDs and load them one by one.
            For Each addBuffer In IDstoAdd
                inResult = IsItInTheCollection(addBuffer, strComputer)

                If inResult = False Then
                    UpdateStatus("Workstation is not in the collection, adding now.")
                    AddingCollectionId = addBuffer
                    UpdateStatus("Adding CollectionID : " & addBuffer)
                    AddMachineToCollection(strComputer, addBuffer)
                    UpdateStatus("Added workstation to collection successfully!")
                    WriteToLog("Added workstation to collection successfully!")
                Else
                    'skipping because already in collection
                    UpdateStatus("Workstation not added due to duplicate found.")
                    WriteToLog("Workstation not added due to duplicate found.")
                    Threading.Thread.Sleep(500)
                End If

                Threading.Thread.Sleep(2000)
                AllowEvents()
            Next
            AllowEvents()
        Next

        AllowEvents()
        WriteToLog("All workstations added to the selected collections successfully!")
        UpdateStatus("All workstations added to the selected collections successfully!")
        AllowEvents()
        ProgressBar.Style = ProgressBarStyle.Continuous
        AllowEvents()
    End Sub

    Private Sub lstCollections_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstCollections.MouseDoubleClick

        Dim selectedOnes As Windows.Forms.ListBox.SelectedIndexCollection
        selectedOnes = lstCollections.SelectedIndices

        For Each intBuff As Integer In selectedOnes
            'new code to allow sorting of listbox
            lstIDsToAdd.Items.Add(lstCollections.Items(intBuff))
            CollectionsToAdd.Add(lstCollections.Items(intBuff))
        Next
    End Sub

    Private Sub lstIDsToAdd_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstIDsToAdd.MouseDoubleClick
        lstIDsToAdd.Items.Clear()
        CollectionsToAdd.Clear()
    End Sub

    Private Sub lstUsers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstUsers.MouseDoubleClick
        lstUsers.Items.Clear()
        SystemsToAdd.Clear()
    End Sub

    Private Sub lstUsers_MouseEnter(sender As Object, e As EventArgs) Handles lstUsers.MouseEnter
        UpdateStatus("Clear the lists by double-clicking the listbox.")
    End Sub

    Private Sub lstUsers_MouseLeave(sender As Object, e As EventArgs) Handles lstUsers.MouseLeave
        UpdateStatus("Ready.")
    End Sub

    Private Sub lstIDsToAdd_MouseEnter(sender As Object, e As EventArgs) Handles lstIDsToAdd.MouseEnter
        UpdateStatus("Clear the lists by double-clicking the listbox.")
    End Sub

    Private Sub lstIDsToAdd_MouseLeave(sender As Object, e As EventArgs) Handles lstIDsToAdd.MouseLeave
        UpdateStatus("Ready.")
    End Sub

    Private Sub lstCollections_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCollections.SelectedIndexChanged
        UpdateStatus(lstCollections.SelectedItem.ToString)
    End Sub
End Class
