<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnChangePrinter = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnClearSheet = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblPrinter = New System.Windows.Forms.Label()
        Me.BtnPreviewSheet = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAddtoSheet = New System.Windows.Forms.Button()
        Me.LblNumCards = New System.Windows.Forms.Label()
        Me.TxtPN = New System.Windows.Forms.TextBox()
        Me.TxtLoc = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GridQueue = New System.Windows.Forms.DataGridView()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BinSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YellowID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RedID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReplStrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridQueue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1170, 65)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.IndianRed
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1170, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kanban Printing"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnChangePrinter)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 570)
        Me.Panel2.TabIndex = 1
        '
        'BtnChangePrinter
        '
        Me.BtnChangePrinter.BackColor = System.Drawing.Color.IndianRed
        Me.BtnChangePrinter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnChangePrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnChangePrinter.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnChangePrinter.Location = New System.Drawing.Point(0, 509)
        Me.BtnChangePrinter.Name = "BtnChangePrinter"
        Me.BtnChangePrinter.Size = New System.Drawing.Size(131, 59)
        Me.BtnChangePrinter.TabIndex = 1
        Me.BtnChangePrinter.Text = "Change Printer"
        Me.BtnChangePrinter.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PrintPreviewControl1)
        Me.Panel3.Controls.Add(Me.BtnPrint)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(576, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(461, 570)
        Me.Panel3.TabIndex = 2
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(461, 534)
        Me.PrintPreviewControl1.TabIndex = 0
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.IndianRed
        Me.BtnPrint.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnPrint.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnPrint.Location = New System.Drawing.Point(0, 534)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(461, 36)
        Me.BtnPrint.TabIndex = 0
        Me.BtnPrint.Text = "Print Document"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(133, 65)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1037, 570)
        Me.Panel4.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.TabControl1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(576, 570)
        Me.Panel5.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(576, 570)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnClearSheet)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.LblPrinter)
        Me.TabPage1.Controls.Add(Me.BtnPreviewSheet)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.BtnAddtoSheet)
        Me.TabPage1.Controls.Add(Me.LblNumCards)
        Me.TabPage1.Controls.Add(Me.TxtPN)
        Me.TabPage1.Controls.Add(Me.TxtLoc)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(568, 537)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnClearSheet
        '
        Me.BtnClearSheet.BackColor = System.Drawing.Color.IndianRed
        Me.BtnClearSheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnClearSheet.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnClearSheet.Location = New System.Drawing.Point(311, 101)
        Me.BtnClearSheet.Name = "BtnClearSheet"
        Me.BtnClearSheet.Size = New System.Drawing.Size(160, 45)
        Me.BtnClearSheet.TabIndex = 12
        Me.BtnClearSheet.Text = "Clear Sheet"
        Me.BtnClearSheet.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.ProgressBar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 505)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(562, 29)
        Me.Panel6.TabIndex = 11
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(562, 29)
        Me.ProgressBar.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(28, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Part Number: "
        '
        'LblPrinter
        '
        Me.LblPrinter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblPrinter.AutoSize = True
        Me.LblPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPrinter.Location = New System.Drawing.Point(7, 481)
        Me.LblPrinter.Name = "LblPrinter"
        Me.LblPrinter.Size = New System.Drawing.Size(110, 20)
        Me.LblPrinter.TabIndex = 8
        Me.LblPrinter.Text = "Active Printer: "
        '
        'BtnPreviewSheet
        '
        Me.BtnPreviewSheet.BackColor = System.Drawing.Color.IndianRed
        Me.BtnPreviewSheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnPreviewSheet.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnPreviewSheet.Location = New System.Drawing.Point(145, 152)
        Me.BtnPreviewSheet.Name = "BtnPreviewSheet"
        Me.BtnPreviewSheet.Size = New System.Drawing.Size(160, 45)
        Me.BtnPreviewSheet.TabIndex = 9
        Me.BtnPreviewSheet.Text = "Preview Sheet"
        Me.BtnPreviewSheet.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kanban Location: "
        '
        'BtnAddtoSheet
        '
        Me.BtnAddtoSheet.BackColor = System.Drawing.Color.IndianRed
        Me.BtnAddtoSheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddtoSheet.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAddtoSheet.Location = New System.Drawing.Point(145, 101)
        Me.BtnAddtoSheet.Name = "BtnAddtoSheet"
        Me.BtnAddtoSheet.Size = New System.Drawing.Size(160, 45)
        Me.BtnAddtoSheet.TabIndex = 2
        Me.BtnAddtoSheet.Text = "Add to Sheet"
        Me.BtnAddtoSheet.UseVisualStyleBackColor = False
        '
        'LblNumCards
        '
        Me.LblNumCards.AutoSize = True
        Me.LblNumCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNumCards.Location = New System.Drawing.Point(5, 70)
        Me.LblNumCards.Name = "LblNumCards"
        Me.LblNumCards.Size = New System.Drawing.Size(146, 20)
        Me.LblNumCards.TabIndex = 5
        Me.LblNumCards.Text = "Number of Cards: 0"
        '
        'TxtPN
        '
        Me.TxtPN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPN.Location = New System.Drawing.Point(145, 11)
        Me.TxtPN.Name = "TxtPN"
        Me.TxtPN.Size = New System.Drawing.Size(188, 24)
        Me.TxtPN.TabIndex = 6
        '
        'TxtLoc
        '
        Me.TxtLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtLoc.Location = New System.Drawing.Point(145, 39)
        Me.TxtLoc.Name = "TxtLoc"
        Me.TxtLoc.Size = New System.Drawing.Size(188, 24)
        Me.TxtLoc.TabIndex = 7
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridQueue)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(568, 537)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Queue"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GridQueue
        '
        Me.GridQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.GridQueue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridQueue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PN, Me.Location, Me.BinSize, Me.YellowID, Me.RedID, Me.Desc, Me.ReplStrat})
        Me.GridQueue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridQueue.Location = New System.Drawing.Point(3, 3)
        Me.GridQueue.Name = "GridQueue"
        Me.GridQueue.RowTemplate.Height = 25
        Me.GridQueue.Size = New System.Drawing.Size(562, 531)
        Me.GridQueue.TabIndex = 0
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PN
        '
        Me.PN.HeaderText = "PN"
        Me.PN.Name = "PN"
        Me.PN.Width = 55
        '
        'Location
        '
        Me.Location.HeaderText = "Location"
        Me.Location.Name = "Location"
        Me.Location.Width = 95
        '
        'BinSize
        '
        Me.BinSize.HeaderText = "BinSize"
        Me.BinSize.Name = "BinSize"
        Me.BinSize.Width = 88
        '
        'YellowID
        '
        Me.YellowID.HeaderText = "YellowID"
        Me.YellowID.Name = "YellowID"
        Me.YellowID.Width = 97
        '
        'RedID
        '
        Me.RedID.HeaderText = "RedID"
        Me.RedID.Name = "RedID"
        Me.RedID.Width = 81
        '
        'Desc
        '
        Me.Desc.HeaderText = "Desc"
        Me.Desc.Name = "Desc"
        Me.Desc.Width = 71
        '
        'ReplStrat
        '
        Me.ReplStrat.HeaderText = "ReplStrat"
        Me.ReplStrat.Name = "ReplStrat"
        Me.ReplStrat.Width = 102
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1170, 635)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridQueue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnChangePrinter As Button
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents BtnPrint As Button
    Friend WithEvents LblPrinter As Label
    Friend WithEvents TxtLoc As TextBox
    Friend WithEvents TxtPN As TextBox
    Friend WithEvents LblNumCards As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BtnPreviewSheet As Button
    Friend WithEvents BtnAddtoSheet As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GridQueue As DataGridView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents BtnClearSheet As Button
    Friend WithEvents PN As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents BinSize As DataGridViewTextBoxColumn
    Friend WithEvents YellowID As DataGridViewTextBoxColumn
    Friend WithEvents RedID As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents ReplStrat As DataGridViewTextBoxColumn
End Class
