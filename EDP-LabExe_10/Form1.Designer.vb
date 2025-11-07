<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonInput = New System.Windows.Forms.Button()
        Me.TextBoxNumberInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxNumbers = New System.Windows.Forms.ListBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 3
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel.Controls.Add(Me.ButtonRead, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonSave, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonInput, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxNumberInput, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ListBoxNumbers, 2, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonClear, 1, 1)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 3
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'ButtonRead
        '
        Me.ButtonRead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonRead.Location = New System.Drawing.Point(269, 303)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(260, 144)
        Me.ButtonRead.TabIndex = 5
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSave.Location = New System.Drawing.Point(3, 303)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(260, 144)
        Me.ButtonSave.TabIndex = 4
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonInput
        '
        Me.ButtonInput.AutoSize = True
        Me.ButtonInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonInput.Location = New System.Drawing.Point(269, 3)
        Me.ButtonInput.Name = "ButtonInput"
        Me.ButtonInput.Size = New System.Drawing.Size(260, 144)
        Me.ButtonInput.TabIndex = 1
        Me.ButtonInput.Text = "Next Input"
        Me.ButtonInput.UseVisualStyleBackColor = True
        '
        'TextBoxNumberInput
        '
        Me.TextBoxNumberInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNumberInput.Location = New System.Drawing.Point(3, 153)
        Me.TextBoxNumberInput.Name = "TextBoxNumberInput"
        Me.TextBoxNumberInput.Size = New System.Drawing.Size(260, 20)
        Me.TextBoxNumberInput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 150)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Numbers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBoxNumbers
        '
        Me.ListBoxNumbers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxNumbers.FormattingEnabled = True
        Me.ListBoxNumbers.Location = New System.Drawing.Point(535, 3)
        Me.ListBoxNumbers.Name = "ListBoxNumbers"
        Me.TableLayoutPanel.SetRowSpan(Me.ListBoxNumbers, 3)
        Me.ListBoxNumbers.Size = New System.Drawing.Size(262, 444)
        Me.ListBoxNumbers.TabIndex = 6
        '
        'ButtonClear
        '
        Me.ButtonClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonClear.Location = New System.Drawing.Point(269, 153)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(260, 144)
        Me.ButtonClear.TabIndex = 7
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents TextBoxNumberInput As TextBox
    Friend WithEvents ButtonInput As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonRead As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ListBoxNumbers As ListBox
    Friend WithEvents ButtonClear As Button
End Class
