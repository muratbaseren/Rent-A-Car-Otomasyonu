#Region "imports"
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.IO.FileStream
#End Region

Public Class frmYazdir
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnAnaCikis As System.Windows.Forms.Button
    Friend WithEvents btnKaydet As System.Windows.Forms.Button
    Friend WithEvents btnYaziTipi As System.Windows.Forms.Button
    Friend WithEvents txtYazdir As System.Windows.Forms.TextBox
    Friend WithEvents lblSorucevapBaslik As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmYazdir))
        Me.btnAnaCikis = New System.Windows.Forms.Button
        Me.btnYaziTipi = New System.Windows.Forms.Button
        Me.txtYazdir = New System.Windows.Forms.TextBox
        Me.lblSorucevapBaslik = New System.Windows.Forms.Label
        Me.btnKaydet = New System.Windows.Forms.Button
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'btnAnaCikis
        '
        Me.btnAnaCikis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnaCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnaCikis.Image = CType(resources.GetObject("btnAnaCikis.Image"), System.Drawing.Image)
        Me.btnAnaCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnaCikis.Location = New System.Drawing.Point(360, 344)
        Me.btnAnaCikis.Name = "btnAnaCikis"
        Me.btnAnaCikis.Size = New System.Drawing.Size(88, 40)
        Me.btnAnaCikis.TabIndex = 15
        Me.btnAnaCikis.Text = "Çý&kýþ"
        '
        'btnYaziTipi
        '
        Me.btnYaziTipi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnYaziTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYaziTipi.Image = CType(resources.GetObject("btnYaziTipi.Image"), System.Drawing.Image)
        Me.btnYaziTipi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYaziTipi.Location = New System.Drawing.Point(8, 344)
        Me.btnYaziTipi.Name = "btnYaziTipi"
        Me.btnYaziTipi.Size = New System.Drawing.Size(96, 40)
        Me.btnYaziTipi.TabIndex = 14
        Me.btnYaziTipi.Text = "Ya&zý Tipi"
        Me.btnYaziTipi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtYazdir
        '
        Me.txtYazdir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtYazdir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYazdir.Location = New System.Drawing.Point(8, 40)
        Me.txtYazdir.Multiline = True
        Me.txtYazdir.Name = "txtYazdir"
        Me.txtYazdir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtYazdir.Size = New System.Drawing.Size(440, 288)
        Me.txtYazdir.TabIndex = 13
        Me.txtYazdir.Text = "TextBox1"
        '
        'lblSorucevapBaslik
        '
        Me.lblSorucevapBaslik.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSorucevapBaslik.BackColor = System.Drawing.Color.Brown
        Me.lblSorucevapBaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSorucevapBaslik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSorucevapBaslik.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSorucevapBaslik.Location = New System.Drawing.Point(8, 16)
        Me.lblSorucevapBaslik.Name = "lblSorucevapBaslik"
        Me.lblSorucevapBaslik.Size = New System.Drawing.Size(440, 23)
        Me.lblSorucevapBaslik.TabIndex = 12
        Me.lblSorucevapBaslik.Text = "...::: SORULAR VE CEVAPLAR :::..."
        Me.lblSorucevapBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKaydet
        '
        Me.btnKaydet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Image = CType(resources.GetObject("btnKaydet.Image"), System.Drawing.Image)
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaydet.Location = New System.Drawing.Point(112, 344)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(96, 40)
        Me.btnKaydet.TabIndex = 16
        Me.btnKaydet.Text = "K&aydet"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmYazdir
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 18)
        Me.ClientSize = New System.Drawing.Size(456, 398)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnAnaCikis)
        Me.Controls.Add(Me.btnYaziTipi)
        Me.Controls.Add(Me.txtYazdir)
        Me.Controls.Add(Me.lblSorucevapBaslik)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmYazdir"
        Me.Text = "...::: TÜM SORULAR VE CEVAPLAR :::..."
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Metotlar"
    Private Sub SorularVeCevaplar()
        Me.txtYazdir.Text = Nothing

        Try
            Dim myConn As New OleDbConnection
            myConn.ConnectionString = Module1.myConnStr

            Dim myCmd As New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM Data order by Ad asc"

            Dim myDR As OleDbDataReader

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                If myDR.Item("Silindi") = "Hayýr" Then
                    Me.txtYazdir.Text += _
                        "ÝSÝM : " & myDR.Item("Ad") & vbCrLf & _
                        "SOYAD : " & myDR.Item("Soyad") & vbCrLf & _
                        vbCrLf & _
                        "ALINAN GÜN SAYISI : " & myDR.Item("AlinanGun") & vbCrLf & _
                        "ÜCRET : " & myDR.Item("Ucret") & vbCrLf & _
                        vbCrLf & _
                        "ARAÇ ÝSMÝ : " & myDR.Item("AracIsmi") & vbCrLf & _
                        "ARAÇ PLAKA : " & myDR.Item("Plaka") & vbCrLf & _
                        vbCrLf & _
                        "TESLÝM ALINAN TARÝH : " & myDR.Item("TesAlTar") & vbCrLf & _
                        "TESLÝM ALINAN SAAT : " & myDR.Item("TesAlSaat") & vbCrLf & _
                        "TESLÝM EDÝLEN TARÝH : " & myDR.Item("TesEdTar") & vbCrLf & _
                        "TESLÝM EDÝLEN SAAT : " & myDR.Item("TesEdSaat") & vbCrLf & _
                        vbCrLf
                    If myDR.Item("TeslimEdildi") = True Then
                        Me.txtYazdir.Text += "Araç Teslim Edildi.." & vbCrLf & _
                        vbCrLf
                    ElseIf myDR.Item("TeslimEdildi") = False Then
                        Me.txtYazdir.Text += "Araç Teslim Edilmedi.." & vbCrLf & _
                        vbCrLf
                    End If

                    Me.txtYazdir.Text += "================================================" & vbCrLf & vbCrLf
                End If

            Loop

            myConn.Close()
            myCmd.Dispose()
            myConn.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "ACCESS DATABASE HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
#End Region


    Private Sub btnAnaCikis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnaCikis.Click
        Me.Close()
    End Sub

    Private Sub btnYaziTipi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYaziTipi.Click
        If Me.FontDialog1.ShowDialog = DialogResult.OK Then
            Me.txtYazdir.Font = Me.FontDialog1.Font
        End If
    End Sub

    Private Sub frmYazdir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SorularVeCevaplar()
    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydet.Click
        Me.SaveFileDialog1.Title = "KAYDET"
        Me.SaveFileDialog1.Filter = "Metin Belgesi(*.txt)|*.txt|WORD Belgesi(*.doc)|*.doc"

        If Me.SaveFileDialog1.ShowDialog = DialogResult.OK Then
            'Dosyayý olusturacak ve dosyaya veri girecek degisken tanýmlanýyor..
            Dim myFileStream As FileStream
            Dim myFileWriter As StreamWriter

            'Dosya olusuruluyor..
            myFileStream = New FileStream(Me.SaveFileDialog1.FileName, FileMode.Create)
            'Dosyaya veri yazacak degisken olusturulup,veri yazacaðý dosya belirtiliyor..
            myFileWriter = New StreamWriter(myFileStream)

            'Textbox içeriði dosyaya yazýlýyor..
            myFileWriter.WriteLine(Me.txtYazdir.Text)

            'Dosya ve yazma degiskeni kapatýlýyor..
            myFileWriter.Close()
            myFileStream.Close()

            MsgBox("Dosyanýz oluþturuldu..", MsgBoxStyle.Information, "KAYDEDÝLDÝ !!")
        End If
    End Sub
End Class
