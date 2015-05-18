<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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

    Private Sub readPropsFile(fileName As String)
        Using MyPropsReader As New FileIO.TextFieldParser(fileName)
            MyPropsReader.TextFieldType = FileIO.FieldType.Delimited
            MyPropsReader.SetDelimiters("=")
            Dim currentRow As String()
            While Not MyPropsReader.EndOfData
                Try
                    Console.WriteLine(" Inside Loop")
                    currentRow = MyPropsReader.ReadFields()
                    Dim currentField As String
                    Dim fieldCount As Integer
                    fieldCount = 1
                    Dim PropName As String
                    Dim PropValue As String
                    PropName = ""
                    PropValue = ""
                    For Each currentField In currentRow
                        If fieldCount.Equals(1) Then
                            PropName = currentField
                        Else
                            PropValue = currentField
                        End If
                        fieldCount = fieldCount + 1

                    Next
                    If PropName.Equals("Title1") Then
                        Button2.Text = PropValue
                    End If
                    If PropName.Equals("Title2") Then
                        Button1.Text = PropValue
                    End If
                Catch
                    Console.WriteLine("Error")
                End Try
            End While
        End Using
    End Sub

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(211, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Farmers"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(45, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Commissions"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 111)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.readPropsFile("./properties.txt")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objForm2.Show()
        objForm1.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        objForm1.Show()
        objForm2.Hide()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
