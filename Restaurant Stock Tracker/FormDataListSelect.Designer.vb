﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataListSelect
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
		Me.components = New System.ComponentModel.Container()
		Me.lstDataList = New System.Windows.Forms.ListBox()
		Me.lblSelectHeader = New System.Windows.Forms.Label()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnSelect = New System.Windows.Forms.Button()
		Me.btnCreate = New System.Windows.Forms.Button()
		Me.Timer100 = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'lstDataList
		'
		Me.lstDataList.FormattingEnabled = True
		Me.lstDataList.Location = New System.Drawing.Point(16, 32)
		Me.lstDataList.Name = "lstDataList"
		Me.lstDataList.Size = New System.Drawing.Size(243, 212)
		Me.lstDataList.TabIndex = 0
		'
		'lblSelectHeader
		'
		Me.lblSelectHeader.AutoSize = True
		Me.lblSelectHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSelectHeader.Location = New System.Drawing.Point(12, 9)
		Me.lblSelectHeader.Name = "lblSelectHeader"
		Me.lblSelectHeader.Size = New System.Drawing.Size(218, 20)
		Me.lblSelectHeader.TabIndex = 1
		Me.lblSelectHeader.Text = "Select or Create Data List"
		'
		'btnCancel
		'
		Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnCancel.Location = New System.Drawing.Point(16, 310)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(243, 54)
		Me.btnCancel.TabIndex = 3
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnSelect
		'
		Me.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.btnSelect.Enabled = False
		Me.btnSelect.Location = New System.Drawing.Point(157, 250)
		Me.btnSelect.Name = "btnSelect"
		Me.btnSelect.Size = New System.Drawing.Size(102, 54)
		Me.btnSelect.TabIndex = 2
		Me.btnSelect.Text = "Select"
		Me.btnSelect.UseVisualStyleBackColor = True
		'
		'btnCreate
		'
		Me.btnCreate.Location = New System.Drawing.Point(16, 250)
		Me.btnCreate.Name = "btnCreate"
		Me.btnCreate.Size = New System.Drawing.Size(102, 54)
		Me.btnCreate.TabIndex = 4
		Me.btnCreate.Text = "Create"
		Me.btnCreate.UseVisualStyleBackColor = True
		'
		'Timer100
		'
		Me.Timer100.Enabled = True
		'
		'FormDataListSelect
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(284, 376)
		Me.Controls.Add(Me.btnCreate)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnSelect)
		Me.Controls.Add(Me.lblSelectHeader)
		Me.Controls.Add(Me.lstDataList)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.MaximizeBox = False
		Me.Name = "FormDataListSelect"
		Me.Text = "Open Data List"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lstDataList As ListBox
	Friend WithEvents lblSelectHeader As Label
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnSelect As Button
	Friend WithEvents btnCreate As Button
	Friend WithEvents Timer100 As Timer
End Class
