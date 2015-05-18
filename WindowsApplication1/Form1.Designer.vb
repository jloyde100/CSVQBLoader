Imports System.IO
Imports System.Xml
Imports QBFC13Lib

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

    Dim ResultsMsg As String
    Dim StartRow As Integer


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
                    If PropName.Equals("FirstNameColumn") Then
                        TextBox2.Text = PropValue
                    End If
                    If PropName.Equals("LastNameColumn") Then
                        TextBox3.Text = PropValue
                    End If
                    If PropName.Equals("AmountColumn") Then
                        TextBox4.Text = PropValue
                    End If
                    If PropName.Equals("AccountNameColumn") Then
                        TextBox5.Text = PropValue
                    End If
                    If PropName.Equals("Title1") Then
                        Me.Text = PropValue
                    End If
                    If PropName.Equals("StartRow1") Then
                        StartRow = CInt(PropValue)
                    End If
                Catch

                End Try
            End While
        End Using
    End Sub
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Upload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(45, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(213, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CSV File:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Vendor First Name Column:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(48, 98)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name Column:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(202, 98)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Amount Column:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(48, 144)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Account Name Column:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(51, 202)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(468, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Results:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(264, 46)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Choose File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(202, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Transaction Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(202, 145)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(471, 63)
        Me.TextBox6.MaxLength = 64000
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox6.Size = New System.Drawing.Size(407, 241)
        Me.TextBox6.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(304, 270)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(904, 316)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Commisons Bill Loader"
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.readPropsFile("./properties.txt")

    End Sub

    Private Sub sendBill(SessMgr As QBSessionManager, FirstName As String, LastName As String, Amount As Decimal, AccountName As String, LineCtr As Integer)

        Dim msgReq As IMsgSetRequest
        Dim newBill As IBillAdd

        msgReq = SessMgr.CreateMsgSetRequest("US", 3, 0)
        msgReq.Attributes.OnError = ENRqOnError.roeContinue
        If FirstName.Equals("BADVALUE") Then
            Console.WriteLine("Blank value")
        Else
            If Amount > 0 Then
                newBill = msgReq.AppendBillAddRq()
                newBill.TxnDate.SetValue(DateTimePicker1.Value)
                Console.WriteLine("Adding bill to " + FirstName + " " + LastName)
                newBill.VendorRef.FullName.SetValue(FirstName + " " + LastName)
                Dim newExpenseRef As IExpenseLineAdd = newBill.ExpenseLineAddList.Append
                newExpenseRef.AccountRef.FullName.SetValue(AccountName)
                newExpenseRef.Amount.SetValue(Amount)
                ' Dim newBillItemRef = newBill.ORItemLineAddList.Append.ItemLineAdd

                ' newBillItemRef.OverrideItemAccountRef.FullName.SetValue(AccountName)
                ' newBillItemRef.Amount.SetValue(Amount)
                Dim msgResp As IMsgSetResponse
                msgResp = SessMgr.DoRequests(msgReq)
                If msgResp.ToXMLString.Contains("Error") Then
                    Using reader As XmlReader = XmlReader.Create(New StringReader(msgResp.ToXMLString))
                        reader.ReadToFollowing("BillAddRs")
                        reader.MoveToAttribute("statusMessage")
                        ResultsMsg = ResultsMsg + vbNewLine + "Error " + LineCtr.ToString + ": " + reader.Value.ToString()
                    End Using
                End If

            End If
        End If

    End Sub

    Private Sub readCSVFile(SessMgr As QBSessionManager, fileName As String, firstNameIdx As String,
                            lastNameIdx As String, AmountIdx As String, AccountNameIdx As String)
        Using MyReader As New FileIO.TextFieldParser(fileName)
            Dim Ctr As Integer
            Dim LineCtr As Integer
            Dim FirstName As String
            Dim LastName As String
            Dim Amount As Decimal
            Dim AccountName As String
            FirstName = ""
            LastName = ""
            Amount = 0
            ResultsMsg = ""
            AccountName = ""
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            LineCtr = 0
            While Not MyReader.EndOfData
                Try
                    LineCtr = LineCtr + 1
                    Console.WriteLine(" Inside Loop")
                    Ctr = 0
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    For Each currentField In currentRow
                        If LineCtr >= StartRow Then
                            If Ctr.Equals(CInt(firstNameIdx - 1)) Then
                                If currentField.Contains("Weekly Total Earned") Then
                                    Exit For
                                End If
                                If currentField.Length() > 1 Then
                                    FirstName = currentField
                                Else
                                    FirstName = "BADVALUE"
                                    Exit For
                                End If

                            End If
                            If Ctr.Equals(CInt(lastNameIdx - 1)) Then
                                LastName = currentField
                            End If
                            If Ctr.Equals(CInt(AmountIdx - 1)) Then
                                Try
                                    Amount = CDec(currentField)
                                Catch valex As InvalidCastException
                                    Amount = 0
                                End Try

                            End If

                            If Ctr.Equals(CInt(AccountNameIdx - 1)) Then
                                AccountName = currentField
                            End If

                            Ctr = Ctr + 1
                        End If
                    Next

                    sendBill(SessMgr, FirstName, LastName, Amount, AccountName, LineCtr)
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
                FirstName = ""
                LastName = ""
                Amount = 0
                AccountName = ""

            End While

        End Using

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SessMgr As New QBSessionManager
        SessMgr.OpenConnection("", "CSVToQuickbooks")
        SessMgr.BeginSession("", ENOpenMode.omDontCare)
        readCSVFile(SessMgr, TextBox1.Text.ToString(), TextBox2.Text.ToString(), TextBox3.Text.ToString(), TextBox4.Text.ToString(), TextBox5.Text.ToString())

        SessMgr.EndSession()
        SessMgr.CloseConnection()

        TextBox6.Clear()
        TextBox6.AppendText(ResultsMsg)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create an instance of the open file dialog box.
        Dim openFileDialog1 As OpenFileDialog = New OpenFileDialog

        ' Set filter options and filter index.
        openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        openFileDialog1.FilterIndex = 1

        openFileDialog1.Multiselect = True

        ' Call the ShowDialog method to show the dialogbox.
        Dim UserClickedOK As Boolean = openFileDialog1.ShowDialog

        ' Process input if the user clicked OK.
        If (UserClickedOK = True) Then
            'Open the selected file to read.
            TextBox1.Text = openFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        objForm1.Hide()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button3 As Button

End Class
