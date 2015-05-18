Imports System.IO
Imports System.Xml
Imports QBFC13Lib

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
                    If PropName.Equals("VendorNameColumn") Then
                        TextBox7.Text = PropValue
                    End If
                    If PropName.Equals("InvoiceNumberColumn") Then
                        TextBox14.Text = PropValue
                    End If
                    If PropName.Equals("Amount1Column") Then
                        TextBox1.Text = PropValue
                    End If
                    If PropName.Equals("Amount1Account") Then
                        TextBox2.Text = PropValue
                    End If
                    If PropName.Equals("Amount2Column") Then
                        TextBox3.Text = PropValue
                    End If
                    If PropName.Equals("Amount2Account") Then
                        TextBox4.Text = PropValue
                    End If
                    If PropName.Equals("Amount3Column") Then
                        TextBox5.Text = PropValue
                    End If
                    If PropName.Equals("Amount3Account") Then
                        TextBox6.Text = PropValue
                    End If
                    If PropName.Equals("Amount4Column") Then
                        TextBox10.Text = PropValue
                    End If
                    If PropName.Equals("Amount4Account") Then
                        TextBox11.Text = PropValue
                    End If
                    If PropName.Equals("Amount5Column") Then
                        TextBox12.Text = PropValue
                    End If
                    If PropName.Equals("Amount5Account") Then
                        TextBox13.Text = PropValue
                    End If
                    If PropName.Equals("Amount6Column") Then
                        TextBox16.Text = PropValue
                    End If
                    If PropName.Equals("Amount6Account") Then
                        TextBox17.Text = PropValue
                    End If
                    If PropName.Equals("PostingDateColumn") Then
                        TextBox15.Text = PropValue
                    End If
                    If PropName.Equals("Title2") Then
                        Me.Text = PropValue
                    End If
                    If PropName.Equals("StartRow2") Then
                        StartRow = CInt(PropValue)
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(250, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Amount 1 Column"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(44, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Amount 1 Account Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(185, 123)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount 2 Column"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(47, 163)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Amount 2 Account Name"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(185, 162)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Amount 3 Column"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(47, 202)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(185, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Amount 3 Account Name"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(185, 201)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(44, 83)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Vendor Name Column"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(514, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Results:"
        '
        'TextBox8
        '
        Me.TextBox8.AllowDrop = True
        Me.TextBox8.Location = New System.Drawing.Point(517, 58)
        Me.TextBox8.MaxLength = 64000
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox8.Size = New System.Drawing.Size(344, 211)
        Me.TextBox8.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(46, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 364)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Posting Date Column"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(44, 28)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(312, 20)
        Me.TextBox9.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "CSV File:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(362, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Choose File"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Amount 4 Column"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(185, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Amount 4 Account Name"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(47, 249)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 25
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(185, 248)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(47, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Amount 5 Column"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(185, 277)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Amount 5 Account Name"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(47, 296)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 29
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(185, 295)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(185, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Invoice Column"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(185, 83)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 32
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(47, 380)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 33
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(47, 341)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.TextBox16.TabIndex = 34
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(185, 342)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.TextBox17.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(46, 322)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Amount 6 Column"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(185, 322)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Amount 6 Account Name"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 450)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Farmers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

        Me.readPropsFile("./properties.txt")
    End Sub


    Private Sub sendBill(SessMgr As QBSessionManager, VendorName As String,
                         InvoiceNum As String,
                         Amount1 As Decimal, AccountName1 As String,
                         Amount2 As Decimal, AccountName2 As String,
                         Amount3 As Decimal, AccountName3 As String,
                         Amount4 As Decimal, AccountName4 As String,
                         Amount5 As Decimal, AccountName5 As String,
                         Amount6 As Decimal, AccountName6 As String,
                         PostDate As String,
                         LineCtr As Integer)

        Dim msgReq As IMsgSetRequest
        Dim newBill As IBillAdd

        msgReq = SessMgr.CreateMsgSetRequest("US", 3, 0)
        msgReq.Attributes.OnError = ENRqOnError.roeContinue
        If VendorName.Length() > 1 Then
            If VendorName.Equals("BADVALUE") Then
                Console.WriteLine("Blank value")
            Else
                newBill = msgReq.AppendBillAddRq()
                newBill.TxnDate.SetValue(PostDate)
                Console.WriteLine("Adding bill to " + VendorName)
                newBill.VendorRef.FullName.SetValue(VendorName)
                newBill.Memo.SetValue("INV# " + InvoiceNum)
                If Amount1 > 0 Then
                    Dim newExpenseRef As IExpenseLineAdd = newBill.ExpenseLineAddList.Append
                    newExpenseRef.AccountRef.FullName.SetValue(AccountName1)
                    newExpenseRef.Amount.SetValue(Amount1)
                End If
                If Amount2 > 0 Then
                    Dim newExpenseRef As IExpenseLineAdd = newBill.ExpenseLineAddList.Append
                    newExpenseRef.AccountRef.FullName.SetValue(AccountName2)
                    newExpenseRef.Amount.SetValue(Amount2)
                End If

                If Amount3 > 0 Then
                    Dim newExpenseRef As IExpenseLineAdd = newBill.ExpenseLineAddList.Append
                    newExpenseRef.AccountRef.FullName.SetValue(AccountName3)
                    newExpenseRef.Amount.SetValue(Amount3)

                End If
                If Amount4 > 0 Then
                    Dim newExpenseRef As IExpenseLineAdd = newBill.ExpenseLineAddList.Append
                    newExpenseRef.AccountRef.FullName.SetValue(AccountName4)
                    newExpenseRef.Amount.SetValue(Amount4)

                End If
                If Amount5 > 0 Then
                    Dim newExpenseRef As IExpenseLineAdd = newBill.ExpenseLineAddList.Append
                    newExpenseRef.AccountRef.FullName.SetValue(AccountName5)
                    newExpenseRef.Amount.SetValue(Amount5)

                End If
                If Amount6 > 0 Then
                    Dim newExpenseRef As IExpenseLineAdd = newBill.ExpenseLineAddList.Append
                    newExpenseRef.AccountRef.FullName.SetValue(AccountName6)
                    newExpenseRef.Amount.SetValue(Amount6)

                End If
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


    Private Sub readCSVFile(SessMgr As QBSessionManager, fileName As String,
                            VendorNameIdx As String, InvoiceNumIdx As String,
                            Amount1Idx As String, AccountName1 As String,
                            Amount2Idx As String, AccountName2 As String,
                            Amount3Idx As String, AccountName3 As String,
                            Amount4Idx As String, AccountName4 As String,
                            Amount5Idx As String, AccountName5 As String,
                            Amount6Idx As String, AccountName6 As String,
                            PostDateIdx As String
                            )
        Using MyReader As New FileIO.TextFieldParser(fileName)

            Dim Ctr As Integer
            Dim LineCtr As Integer
            Dim VendorName As String
            Dim InvoiceNum As String
            Dim Amount1 As Decimal
            Dim Amount2 As Decimal
            Dim Amount3 As Decimal
            Dim Amount4 As Decimal
            Dim Amount5 As Decimal
            Dim Amount6 As Decimal
            Dim PostDate As String

            Console.WriteLine("Entered read csv.")
            VendorName = ""
            InvoiceNum = ""
            PostDate = ""
            Amount1 = 0
            Amount2 = 0
            Amount3 = 0
            Amount4 = 0
            Amount5 = 0
            Amount6 = 0
            ResultsMsg = ""
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
                            If Ctr.Equals(CInt(VendorNameIdx - 1)) Then
                                If currentField.Contains("Weekly Total Earned") Then
                                    Exit For
                                End If
                                If currentField.Length() > 1 Then
                                    VendorName = currentField
                                Else
                                    VendorName = "BADVALUE"
                                    Exit For
                                End If

                            End If
                            If Ctr.Equals(CInt(InvoiceNumIdx - 1)) Then
                                If currentField.Length() > 1 Then
                                    InvoiceNum = currentField
                                End If
                            End If
                            If Ctr.Equals(CInt(PostDateIdx - 1)) Then
                                If currentField.Length() > 1 Then
                                    PostDate = currentField
                                End If
                            End If
                            If Ctr.Equals(CInt(Amount1Idx - 1)) Then
                                    Try
                                        Amount1 = CDec(currentField)
                                    Catch valex As InvalidCastException
                                        Amount1 = 0
                                    End Try

                                End If

                                If Ctr.Equals(CInt(Amount2Idx - 1)) Then
                                    Try
                                        Amount2 = CDec(currentField)
                                    Catch valex As InvalidCastException
                                        Amount2 = 0
                                    End Try

                                End If
                                If Ctr.Equals(CInt(Amount3Idx - 1)) Then
                                    Try
                                        Amount3 = CDec(currentField)
                                    Catch valex As InvalidCastException
                                        Amount3 = 0
                                    End Try

                                End If
                                If Ctr.Equals(CInt(Amount4Idx - 1)) Then
                                    Try
                                        Amount4 = CDec(currentField)
                                    Catch valex As InvalidCastException
                                        Amount4 = 0
                                    End Try

                                End If
                                If Ctr.Equals(CInt(Amount5Idx - 1)) Then
                                    Try
                                        Amount5 = CDec(currentField)
                                    Catch valex As InvalidCastException
                                        Amount5 = 0
                                    End Try

                                End If
                            If Ctr.Equals(CInt(Amount6Idx - 1)) Then
                                Try
                                    Amount6 = CDec(currentField)
                                Catch valex As InvalidCastException
                                    Amount6 = 0
                                End Try

                            End If

                            Ctr = Ctr + 1
                            End If
                    Next

                    sendBill(SessMgr, VendorName, InvoiceNum, Amount1, AccountName1, Amount2, AccountName2, Amount3, AccountName3, Amount4, AccountName4, Amount5, AccountName5, Amount6, AccountName6, PostDate, LineCtr)
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
                VendorName = ""
                Amount1 = 0
                Amount2 = 0
                Amount3 = 0

            End While

        End Using

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        objForm2.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
            TextBox9.Text = openFileDialog1.FileName.ToString
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SessMgr As New QBSessionManager
        SessMgr.OpenConnection("", "CSVToQuickbooks")
        SessMgr.BeginSession("", ENOpenMode.omDontCare)
        Console.WriteLine("FileName:" + TextBox9.ToString())
        readCSVFile(SessMgr, TextBox9.Text.ToString(),
                    TextBox7.Text.ToString(),
                    TextBox14.Text.ToString(),
                    TextBox1.Text.ToString(), TextBox2.Text.ToString(),
                    TextBox3.Text.ToString(), TextBox4.Text.ToString(),
                    TextBox5.Text.ToString(), TextBox6.Text.ToString(),
                    TextBox10.Text.ToString(), TextBox11.Text.ToString(),
                    TextBox12.Text.ToString(), TextBox13.Text.ToString(),
                    TextBox16.Text.ToString(), TextBox17.Text.ToString(),
                    TextBox15.Text.ToString())

        SessMgr.EndSession()
        SessMgr.CloseConnection()

        TextBox8.Clear()
        TextBox8.AppendText(ResultsMsg)


    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
End Class
