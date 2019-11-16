﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.Strip = New System.Windows.Forms.ToolStrip
        Me.SaveBtn = New System.Windows.Forms.ToolStripSplitButton
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Sep = New System.Windows.Forms.ToolStripSeparator
        Me.UndoBtn = New System.Windows.Forms.ToolStripButton
        Me.RedoBtn = New System.Windows.Forms.ToolStripButton
        Me.Sep2 = New System.Windows.Forms.ToolStripSeparator
        Me.CutBtn = New System.Windows.Forms.ToolStripButton
        Me.CopyBtn = New System.Windows.Forms.ToolStripButton
        Me.PasteBtn = New System.Windows.Forms.ToolStripButton
        Me.CloseBtn = New System.Windows.Forms.ToolStripButton
        Me.Sep3 = New System.Windows.Forms.ToolStripSeparator
        Me.Find = New System.Windows.Forms.ToolStripButton
        Me.GTo = New System.Windows.Forms.ToolStripButton
        Me.Replace = New System.Windows.Forms.ToolStripButton
        Me.Sep4 = New System.Windows.Forms.ToolStripSeparator
        Me.Preview = New System.Windows.Forms.ToolStripSplitButton
        Me.LivePreview = New System.Windows.Forms.ToolStripMenuItem
        Me.Sep5 = New System.Windows.Forms.ToolStripSeparator
        Me.Build = New System.Windows.Forms.ToolStripButton
        Me.ViewOutput = New System.Windows.Forms.ToolStripButton
        Me.Code = New FastColoredTextBoxNS.FastColoredTextBox
        Me.Context = New System.Windows.Forms.ContextMenu
        Me.Undo = New System.Windows.Forms.MenuItem
        Me.Redo = New System.Windows.Forms.MenuItem
        Me.ConSep = New System.Windows.Forms.MenuItem
        Me.Cut = New System.Windows.Forms.MenuItem
        Me.Copy = New System.Windows.Forms.MenuItem
        Me.Paste = New System.Windows.Forms.MenuItem
        Me.ConSep2 = New System.Windows.Forms.MenuItem
        Me.SelectAll = New System.Windows.Forms.MenuItem
        Me.ConSep3 = New System.Windows.Forms.MenuItem
        Me.InsertConditional = New System.Windows.Forms.MenuItem
        Me.Strip.SuspendLayout()
        CType(Me.Code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Strip
        '
        Me.Strip.BackColor = System.Drawing.SystemColors.Window
        Me.Strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveBtn, Me.Sep, Me.UndoBtn, Me.RedoBtn, Me.Sep2, Me.CutBtn, Me.CopyBtn, Me.PasteBtn, Me.CloseBtn, Me.Sep3, Me.Find, Me.GTo, Me.Replace, Me.Sep4, Me.Preview, Me.Sep5, Me.Build, Me.ViewOutput})
        Me.Strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Strip.Location = New System.Drawing.Point(0, 0)
        Me.Strip.Name = "Strip"
        Me.Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Strip.Size = New System.Drawing.Size(596, 27)
        Me.Strip.TabIndex = 1
        Me.Strip.Text = "ToolStrip1"
        '
        'SaveBtn
        '
        Me.SaveBtn.AutoToolTip = False
        Me.SaveBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAllToolStripMenuItem})
        Me.SaveBtn.Enabled = False
        Me.SaveBtn.Image = CType(resources.GetObject("SaveBtn.Image"), System.Drawing.Image)
        Me.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(72, 24)
        Me.SaveBtn.Text = "Save"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Image = CType(resources.GetObject("SaveAllToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        Me.SaveAllToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.SaveAllToolStripMenuItem.Text = "Save All"
        '
        'Sep
        '
        Me.Sep.Name = "Sep"
        Me.Sep.Size = New System.Drawing.Size(6, 27)
        '
        'UndoBtn
        '
        Me.UndoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoBtn.Image = CType(resources.GetObject("UndoBtn.Image"), System.Drawing.Image)
        Me.UndoBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoBtn.Name = "UndoBtn"
        Me.UndoBtn.Size = New System.Drawing.Size(23, 24)
        Me.UndoBtn.Text = "Undo"
        '
        'RedoBtn
        '
        Me.RedoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RedoBtn.Image = CType(resources.GetObject("RedoBtn.Image"), System.Drawing.Image)
        Me.RedoBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RedoBtn.Name = "RedoBtn"
        Me.RedoBtn.Size = New System.Drawing.Size(23, 24)
        Me.RedoBtn.Text = "Redo"
        '
        'Sep2
        '
        Me.Sep2.Name = "Sep2"
        Me.Sep2.Size = New System.Drawing.Size(6, 27)
        '
        'CutBtn
        '
        Me.CutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutBtn.Image = CType(resources.GetObject("CutBtn.Image"), System.Drawing.Image)
        Me.CutBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutBtn.Name = "CutBtn"
        Me.CutBtn.Size = New System.Drawing.Size(23, 24)
        Me.CutBtn.Text = "Cut"
        '
        'CopyBtn
        '
        Me.CopyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyBtn.Image = CType(resources.GetObject("CopyBtn.Image"), System.Drawing.Image)
        Me.CopyBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyBtn.Name = "CopyBtn"
        Me.CopyBtn.Size = New System.Drawing.Size(23, 24)
        Me.CopyBtn.Text = "Copy"
        '
        'PasteBtn
        '
        Me.PasteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteBtn.Image = CType(resources.GetObject("PasteBtn.Image"), System.Drawing.Image)
        Me.PasteBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteBtn.Name = "PasteBtn"
        Me.PasteBtn.Size = New System.Drawing.Size(23, 24)
        Me.PasteBtn.Text = "Paste"
        '
        'CloseBtn
        '
        Me.CloseBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseBtn.Image = CType(resources.GetObject("CloseBtn.Image"), System.Drawing.Image)
        Me.CloseBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(23, 24)
        Me.CloseBtn.Text = "Close"
        '
        'Sep3
        '
        Me.Sep3.Name = "Sep3"
        Me.Sep3.Size = New System.Drawing.Size(6, 27)
        '
        'Find
        '
        Me.Find.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Find.Image = CType(resources.GetObject("Find.Image"), System.Drawing.Image)
        Me.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Find.Name = "Find"
        Me.Find.Size = New System.Drawing.Size(23, 24)
        Me.Find.Text = "Find"
        '
        'GTo
        '
        Me.GTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GTo.Image = CType(resources.GetObject("GTo.Image"), System.Drawing.Image)
        Me.GTo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GTo.Name = "GTo"
        Me.GTo.Size = New System.Drawing.Size(23, 24)
        Me.GTo.Text = "Go To"
        '
        'Replace
        '
        Me.Replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Replace.Image = CType(resources.GetObject("Replace.Image"), System.Drawing.Image)
        Me.Replace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Replace.Name = "Replace"
        Me.Replace.Size = New System.Drawing.Size(23, 24)
        Me.Replace.Text = "Replace"
        '
        'Sep4
        '
        Me.Sep4.Name = "Sep4"
        Me.Sep4.Size = New System.Drawing.Size(6, 27)
        '
        'Preview
        '
        Me.Preview.AutoToolTip = False
        Me.Preview.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LivePreview})
        Me.Preview.Image = CType(resources.GetObject("Preview.Image"), System.Drawing.Image)
        Me.Preview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(92, 24)
        Me.Preview.Text = "Preview"
        '
        'LivePreview
        '
        Me.LivePreview.CheckOnClick = True
        Me.LivePreview.Name = "LivePreview"
        Me.LivePreview.Size = New System.Drawing.Size(159, 24)
        Me.LivePreview.Text = "Live Preview"
        '
        'Sep5
        '
        Me.Sep5.Name = "Sep5"
        Me.Sep5.Size = New System.Drawing.Size(6, 27)
        '
        'Build
        '
        Me.Build.Image = CType(resources.GetObject("Build.Image"), System.Drawing.Image)
        Me.Build.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Build.Name = "Build"
        Me.Build.Size = New System.Drawing.Size(63, 24)
        Me.Build.Text = "Build"
        '
        'ViewOutput
        '
        Me.ViewOutput.Image = CType(resources.GetObject("ViewOutput.Image"), System.Drawing.Image)
        Me.ViewOutput.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewOutput.Name = "ViewOutput"
        Me.ViewOutput.Size = New System.Drawing.Size(111, 24)
        Me.ViewOutput.Text = "View Output"
        '
        'Code
        '
        Me.Code.AllowSeveralTextStyleDrawing = True
        Me.Code.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.Code.AutoIndentCharsPatterns = Global.AutoSite.My.Resources.Resources.openProject
        Me.Code.AutoScrollMinSize = New System.Drawing.Size(31, 18)
        Me.Code.BackBrush = Nothing
        Me.Code.CharHeight = 18
        Me.Code.CharWidth = 10
        Me.Code.CommentPrefix = Nothing
        Me.Code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Code.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Code.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Code.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.Code.IndentBackColor = System.Drawing.SystemColors.Window
        Me.Code.IsReplaceMode = False
        Me.Code.Language = FastColoredTextBoxNS.Language.HTML
        Me.Code.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.Code.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.Code.Location = New System.Drawing.Point(0, 27)
        Me.Code.Margin = New System.Windows.Forms.Padding(4)
        Me.Code.Name = "Code"
        Me.Code.Paddings = New System.Windows.Forms.Padding(0)
        Me.Code.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.Code.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.Code.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Code.ServiceColors = CType(resources.GetObject("Code.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.Code.Size = New System.Drawing.Size(596, 460)
        Me.Code.TabIndex = 2
        Me.Code.Zoom = 100
        '
        'Context
        '
        Me.Context.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.Undo, Me.Redo, Me.ConSep, Me.Cut, Me.Copy, Me.Paste, Me.ConSep2, Me.SelectAll, Me.ConSep3, Me.InsertConditional})
        '
        'Undo
        '
        Me.Undo.Index = 0
        Me.Undo.Text = "Undo"
        '
        'Redo
        '
        Me.Redo.Index = 1
        Me.Redo.Text = "Redo"
        '
        'ConSep
        '
        Me.ConSep.Index = 2
        Me.ConSep.Text = "-"
        '
        'Cut
        '
        Me.Cut.Index = 3
        Me.Cut.Text = "Cut"
        '
        'Copy
        '
        Me.Copy.Index = 4
        Me.Copy.Text = "Copy"
        '
        'Paste
        '
        Me.Paste.Index = 5
        Me.Paste.Text = "Paste"
        '
        'ConSep2
        '
        Me.ConSep2.Index = 6
        Me.ConSep2.Text = "-"
        '
        'SelectAll
        '
        Me.SelectAll.Index = 7
        Me.SelectAll.Text = "Select All"
        '
        'ConSep3
        '
        Me.ConSep3.Index = 8
        Me.ConSep3.Text = "-"
        '
        'InsertConditional
        '
        Me.InsertConditional.Index = 9
        Me.InsertConditional.Text = "Insert Conditional..."
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Code)
        Me.Controls.Add(Me.Strip)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Editor"
        Me.Size = New System.Drawing.Size(596, 487)
        Me.Strip.ResumeLayout(False)
        Me.Strip.PerformLayout()
        CType(Me.Code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Strip As System.Windows.Forms.ToolStrip
    Friend WithEvents UndoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents RedoBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents Code As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Context As System.Windows.Forms.ContextMenu
    Friend WithEvents Undo As System.Windows.Forms.MenuItem
    Friend WithEvents Redo As System.Windows.Forms.MenuItem
    Friend WithEvents Sep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Cut As System.Windows.Forms.MenuItem
    Friend WithEvents Copy As System.Windows.Forms.MenuItem
    Friend WithEvents Paste As System.Windows.Forms.MenuItem
    Friend WithEvents ConSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents ConSep As System.Windows.Forms.MenuItem
    Friend WithEvents SelectAll As System.Windows.Forms.MenuItem
    Friend WithEvents Sep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents CopyBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasteBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents CloseBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveBtn As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Find As System.Windows.Forms.ToolStripButton
    Friend WithEvents GTo As System.Windows.Forms.ToolStripButton
    Friend WithEvents Replace As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Preview As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents LivePreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConSep3 As System.Windows.Forms.MenuItem
    Friend WithEvents InsertConditional As System.Windows.Forms.MenuItem
    Friend WithEvents Build As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sep5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewOutput As System.Windows.Forms.ToolStripButton

End Class