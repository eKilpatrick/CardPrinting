Imports System.Drawing
'Ethan Kilpatrick 2022
Public Class Form1
    Dim printer As String = ""
    Dim SheetList As New List(Of Card)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDefaultPrinter()
        ProgressBar.Step = 33.333333
    End Sub

    Public Sub GetDefaultPrinter()
        Try
            printer = PrintDialog1.PrinterSettings.PrinterName
            LblPrinter.Text &= printer
        Catch ex As Exception
            MsgBox("Error retrieving the computer's default printer: " & ex.Message)
        End Try
    End Sub

    Private Sub btnChangePrinter_Click(sender As Object, e As EventArgs) Handles BtnChangePrinter.Click
        Try
            Dim dialog As New PrintDialog()
            dialog.ShowDialog()
            printer = dialog.PrinterSettings.PrinterName
            PrintDialog1.PrinterSettings.PrinterName = printer
            LblPrinter.Text = "Active Printer: " & printer
        Catch ex As Exception
            MsgBox("Error when attempting to change the active printer: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnAddtoSheet_Click(sender As Object, e As EventArgs) Handles BtnAddtoSheet.Click
        Try
            ProgressBar.Value = 0
            If TxtPN.Text = String.Empty Or TxtLoc.Text = String.Empty Then
                MsgBox("You must enter the PN and the Location")
                Exit Sub
            ElseIf SheetList.Count = 8 Then
                MsgBox("There are already 8 cards on the sheet, preview and print or delete them")
            Else
                Dim CardInfo As DataRowCollection = DatabaseQueries.GetKanbanInfo(TxtPN.Text, TxtLoc.Text)
                ProgressBar.PerformStep()
                ProgressBar.Update()

                Dim Description = DatabaseQueries.GetDescription(TxtPN.Text)
                ProgressBar.PerformStep()
                ProgressBar.Update()

                If CardInfo Is Nothing Or Description Is Nothing Then
                    MsgBox("Something went wrong when searching for that partnumber, make sure it is valid on SAP before continuing", "ERROR")
                    Exit Sub
                End If

                Dim Card As New Card(TxtPN.Text, TxtLoc.Text, CardInfo(0).Item(0).ToString.Trim(), CardInfo(1).Item(0).ToString.Trim(), Description, CardInfo(0).Item(2), CardInfo(0).Item(1))
                SheetList.Add(Card)
                LblNumCards.Text = "Number of Cards: " & SheetList.Count

                GridQueue.Rows.Add(Card.PN, Card.Loc, Card.BinSize, Card.YellowID, Card.RedID, Card.Desc, Card.ReplStrat)
                GridQueue.Update()

                ProgressBar.Value = 100
                ProgressBar.Update()
            End If
        Catch ex As Exception
            MsgBox("Error adding this card to the sheet")
        End Try
    End Sub

    Private Sub BtnPreviewSheet_Click(sender As Object, e As EventArgs) Handles BtnPreviewSheet.Click
        Try
            PrintPreviewControl1.Document = PrintDocument1
        Catch ex As Exception
            MsgBox("Error previewing the sheet")
        End Try
    End Sub

    'New Changes
    'Move Desc line 1 and 2 up slightly
    'Insert row for Replacement Strategy underneath Desc
    'Move Qty and Loc down slightly
    'Every Y was decreased by 10
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
#Region "Styles"
        Dim Barcode As New System.Drawing.Font("IDAutomationHC39M", 11, FontStyle.Regular)
        Dim Title = New Drawing.Font("Arial", 9, FontStyle.Bold)
        Dim partNum = New Drawing.Font("Arial", 15, FontStyle.Bold)
        Dim Body = New Drawing.Font("Arial", 8, FontStyle.Regular)

        Dim blackPen As New Pen(Brushes.Black)
        Dim redPen As New Pen(Brushes.Red)
        Dim yellowPen As New Pen(Brushes.Yellow)
        Dim whitePen As New Pen(Brushes.White)

        Dim ySpacing = 233
        Dim xSpacing = 378
#End Region
        Dim i = 0
        While i < SheetList.Count

            If i < 4 Then
#Region "Left Side"
                Dim redRec As New System.Drawing.Rectangle(71, 83 + (i * ySpacing), 200, 50)
                Dim mainRec As New System.Drawing.Rectangle(71, 84 + (i * ySpacing), 200, 150)
                Dim yellowRec As New System.Drawing.Rectangle(71, 220 + (i * ySpacing), 200, 50)
                Dim whiteRec As New System.Drawing.Rectangle(100, 85 + (i * ySpacing), 135, 48)
                Dim whiteRec2 As New System.Drawing.Rectangle(100, 222 + (i * ySpacing), 135, 50)

                e.Graphics.DrawRectangle(redPen, redRec)
                e.Graphics.DrawRectangle(blackPen, mainRec)
                e.Graphics.DrawRectangle(yellowPen, yellowRec)
                e.Graphics.DrawRectangle(whitePen, whiteRec)
                e.Graphics.DrawRectangle(whitePen, whiteRec2)

                e.Graphics.FillRectangle(Brushes.Red, redRec)
                e.Graphics.FillRectangle(Brushes.Yellow, yellowRec)
                e.Graphics.FillRectangle(Brushes.White, whiteRec)
                e.Graphics.FillRectangle(Brushes.White, whiteRec2)

                If SheetList(i).Desc.Length > 22 Then
                    e.Graphics.DrawString("DESC: ", Title, Brushes.Black, 80, 165 + (i * ySpacing))
                    e.Graphics.DrawString("ReplStrat: ", Title, Brushes.Black, 80, 188 + (i * ySpacing))
                    e.Graphics.DrawString("Qty: ", Title, Brushes.Black, 80, 200 + (i * ySpacing))
                    e.Graphics.DrawString("Loc: ", Title, Brushes.Black, 150, 200 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).PN, partNum, Brushes.Black, 75, 140 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).Desc.Substring(0, 22), Body, Brushes.Black, 120, 165 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).Desc.Substring(22, SheetList(i).Desc.Length - 22), Body, Brushes.Black, 120, 175 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).ReplStrat, Body, Brushes.Black, 140, 190 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).BinSize, Body, Brushes.Black, 115, 200 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).Loc, Body, Brushes.Black, 180, 200 + (i * ySpacing))
                Else
                    e.Graphics.DrawString("DESC: ", Title, Brushes.Black, 80, 165 + (i * ySpacing))
                    e.Graphics.DrawString("Qty: ", Title, Brushes.Black, 80, 200 + (i * ySpacing))
                    e.Graphics.DrawString("ReplStrat: ", Title, Brushes.Black, 80, 188 + (i * ySpacing))
                    e.Graphics.DrawString("Loc: ", Title, Brushes.Black, 150, 200 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).PN, partNum, Brushes.Black, 75, 140 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).Desc, Body, Brushes.Black, 120, 170 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).ReplStrat, Body, Brushes.Black, 140, 190 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).BinSize, Body, Brushes.Black, 110, 200 + (i * ySpacing))
                    e.Graphics.DrawString(SheetList(i).Loc, Body, Brushes.Black, 180, 200 + (i * ySpacing))
                End If

                e.Graphics.TranslateTransform(200, 300 + (i * ySpacing))
                e.Graphics.DrawString("*" & SheetList(i).RedID & "*", Barcode, Brushes.Black, -90, -215)

                e.Graphics.DrawString("*" & SheetList(i).YellowID & "*", Barcode, Brushes.Black, -90, -80)
                e.Graphics.TranslateTransform(-200, -300 - (i * ySpacing))
#End Region

            Else
#Region "Right Side"
                Dim redRec As New System.Drawing.Rectangle(71 + xSpacing, 83 + ((i - 4) * ySpacing), 200, 50)
                Dim mainRec As New System.Drawing.Rectangle(71 + xSpacing, 83 + ((i - 4) * ySpacing), 200, 150)
                Dim yellowRec As New System.Drawing.Rectangle(71 + xSpacing, 220 + ((i - 4) * ySpacing), 200, 50)
                Dim whiteRec As New System.Drawing.Rectangle(100 + xSpacing, 85 + ((i - 4) * ySpacing), 135, 48)
                Dim whiteRec2 As New System.Drawing.Rectangle(100 + xSpacing, 221 + ((i - 4) * ySpacing), 135, 50)

                e.Graphics.DrawRectangle(redPen, redRec)
                e.Graphics.DrawRectangle(blackPen, mainRec)
                e.Graphics.DrawRectangle(yellowPen, yellowRec)
                e.Graphics.DrawRectangle(whitePen, whiteRec)
                e.Graphics.DrawRectangle(whitePen, whiteRec2)

                e.Graphics.FillRectangle(Brushes.Red, redRec)
                e.Graphics.FillRectangle(Brushes.Yellow, yellowRec)
                e.Graphics.FillRectangle(Brushes.White, whiteRec)
                e.Graphics.FillRectangle(Brushes.White, whiteRec2)

                If SheetList(i).Desc.Length > 22 Then
                    e.Graphics.DrawString("DESC: ", Title, Brushes.Black, 461, 170 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString("ReplStrat: ", Title, Brushes.Black, 461, 188 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString("Qty: ", Title, Brushes.Black, 461, 200 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString("Loc: ", Title, Brushes.Black, 531, 200 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString(SheetList(i).PN, partNum, Brushes.Black, 456, 140 + ((i - 4) * ySpacing)) ' was 140 for x-coord.
                    e.Graphics.DrawString(SheetList(i).Desc.Substring(0, 22), Body, Brushes.Black, 501, 170 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString(SheetList(i).Desc.Substring(22, SheetList(i).Desc.Length - 22), Body, Brushes.Black, 501, 180 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString(SheetList(i).ReplStrat, Body, Brushes.Black, 521, 190 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString(SheetList(i).BinSize, Body, Brushes.Black, 491, 200 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString(SheetList(i).Loc, Body, Brushes.Black, 561, 200 + ((i - 4) * ySpacing))
                Else
                    e.Graphics.DrawString("DESC: ", Title, Brushes.Black, 461, 170 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString("ReplStrat: ", Title, Brushes.Black, 461, 188 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString("Qty: ", Title, Brushes.Black, 461, 200 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString("Loc: ", Title, Brushes.Black, 531, 200 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString(SheetList(i).PN, partNum, Brushes.Black, 456, 140 + ((i - 4) * ySpacing)) ' was 140 for x-coord.
                    e.Graphics.DrawString(SheetList(i).Desc, Body, Brushes.Black, 501, 170 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString(SheetList(i).ReplStrat, Body, Brushes.Black, 521, 190 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString(SheetList(i).BinSize, Body, Brushes.Black, 491, 200 + ((i - 4) * ySpacing))
                    e.Graphics.DrawString(SheetList(i).Loc, Body, Brushes.Black, 561, 200 + ((i - 4) * ySpacing))

                End If

                e.Graphics.TranslateTransform(581, 300 + ((i - 4) * ySpacing))
                e.Graphics.DrawString("*" & SheetList(i).RedID & "*", Barcode, Brushes.Black, -90, -215) '65, 120)

                e.Graphics.DrawString("*" & SheetList(i).YellowID & "*", Barcode, Brushes.Black, -90, -80) '390, 120)
                e.Graphics.TranslateTransform(-581, -300 - ((i - 4) * ySpacing))
#End Region
            End If

            i += 1
        End While
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Try
            If PrintPreviewControl1.Document Is Nothing Then
                MsgBox("Nothing has been prepared to print yet")
                Exit Sub
            End If
            Dim answer = MsgBox("Does the preview look good?", vbYesNo)
            If answer = vbYes Then
                PrintDocument1.Print()
                'SheetList.Clear()
                'GridQueue.Rows.Clear()
                'LblNumCards.Text = "Number of Cards: 0"
            End If
        Catch ex As Exception
            MsgBox("Error printing the document:" & ex.Message)
        End Try
    End Sub

    Private Sub BtnClearSheet_Click(sender As Object, e As EventArgs) Handles BtnClearSheet.Click
        SheetList.Clear()
        GridQueue.Rows.Clear()
        LblNumCards.Text = "Number of Cards: 0"
        PrintPreviewControl1.Document = Nothing
    End Sub
End Class
