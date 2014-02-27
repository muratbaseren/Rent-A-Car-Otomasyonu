#Region "imports"
Imports System
Imports System.Data
Imports System.Data.OleDb
#End Region

Public Class frmResimSecme
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
    Friend WithEvents btnKaydet As System.Windows.Forms.Button
    Friend WithEvents lstResimler As System.Windows.Forms.ListBox
    Friend WithEvents lblListBaslik As System.Windows.Forms.Label
    Friend WithEvents picResim As System.Windows.Forms.PictureBox
    Friend WithEvents btnCikis As System.Windows.Forms.Button
    Friend WithEvents btnYeniResimEkle As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmResimSecme))
        Me.btnKaydet = New System.Windows.Forms.Button
        Me.lstResimler = New System.Windows.Forms.ListBox
        Me.lblListBaslik = New System.Windows.Forms.Label
        Me.picResim = New System.Windows.Forms.PictureBox
        Me.btnCikis = New System.Windows.Forms.Button
        Me.btnYeniResimEkle = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'btnKaydet
        '
        Me.btnKaydet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Image = CType(resources.GetObject("btnKaydet.Image"), System.Drawing.Image)
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaydet.Location = New System.Drawing.Point(200, 280)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(240, 40)
        Me.btnKaydet.TabIndex = 11
        Me.btnKaydet.Text = "Arka Plan Resmi Olarak  Ay&arla"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lstResimler
        '
        Me.lstResimler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstResimler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstResimler.ItemHeight = 17
        Me.lstResimler.Location = New System.Drawing.Point(8, 40)
        Me.lstResimler.Name = "lstResimler"
        Me.lstResimler.Size = New System.Drawing.Size(176, 223)
        Me.lstResimler.TabIndex = 10
        '
        'lblListBaslik
        '
        Me.lblListBaslik.BackColor = System.Drawing.Color.Brown
        Me.lblListBaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblListBaslik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblListBaslik.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblListBaslik.Location = New System.Drawing.Point(8, 16)
        Me.lblListBaslik.Name = "lblListBaslik"
        Me.lblListBaslik.Size = New System.Drawing.Size(176, 23)
        Me.lblListBaslik.TabIndex = 9
        Me.lblListBaslik.Text = "...::: Resimler :::..."
        Me.lblListBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picResim
        '
        Me.picResim.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picResim.Location = New System.Drawing.Point(200, 16)
        Me.picResim.Name = "picResim"
        Me.picResim.Size = New System.Drawing.Size(320, 248)
        Me.picResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picResim.TabIndex = 12
        Me.picResim.TabStop = False
        '
        'btnCikis
        '
        Me.btnCikis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCikis.Image = CType(resources.GetObject("btnCikis.Image"), System.Drawing.Image)
        Me.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCikis.Location = New System.Drawing.Point(448, 280)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(72, 40)
        Me.btnCikis.TabIndex = 13
        Me.btnCikis.Text = "Çý&kýþ"
        Me.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnYeniResimEkle
        '
        Me.btnYeniResimEkle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnYeniResimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYeniResimEkle.Image = CType(resources.GetObject("btnYeniResimEkle.Image"), System.Drawing.Image)
        Me.btnYeniResimEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYeniResimEkle.Location = New System.Drawing.Point(8, 280)
        Me.btnYeniResimEkle.Name = "btnYeniResimEkle"
        Me.btnYeniResimEkle.Size = New System.Drawing.Size(144, 40)
        Me.btnYeniResimEkle.TabIndex = 14
        Me.btnYeniResimEkle.Text = "Yeni Resim Ekl&e"
        Me.btnYeniResimEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmResimSecme
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 18)
        Me.ClientSize = New System.Drawing.Size(528, 336)
        Me.Controls.Add(Me.btnYeniResimEkle)
        Me.Controls.Add(Me.btnCikis)
        Me.Controls.Add(Me.picResim)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.lstResimler)
        Me.Controls.Add(Me.lblListBaslik)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResimSecme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "...::: ARKA PLAN RESMÝ BELÝRLEME :::..."
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Yerel Degiskenler"
    Dim DosyaAdi, ResimAdi As String
#End Region

#Region "Metotlar"
    Private Sub ResimAdiAl()
        Dim Deger As String

        For i As Integer = Len(DosyaAdi) To 1 Step -1
            Deger = Mid(DosyaAdi, i, 1)

            'Sirayla dosya adini kontrol ediyor ve \ isaretine gelince duruyor..
            If Deger = "\" Then
                ResimAdi = Mid(DosyaAdi, i + 1, Len(DosyaAdi) - i)
                Exit For
            End If
        Next
    End Sub
#End Region

#Region "Olaylar"
    Private Sub btnCikis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCikis.Click
        Shell(Application.StartupPath & "\RentACarOtomasyonu.exe", AppWinStyle.NormalFocus)
        End
    End Sub

    Private Sub frmResimSecme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lstResimler.Items.Clear()

        Me.lstResimler.Items.Add("Yok")

        'Dim DosyaAdi As String = System.IO.File.Exists(Application.StartupPath & "\background")

        For Each DosyaAdi In System.IO.Directory.GetFiles(Application.StartupPath & "\background")

            ResimAdiAl()

            If Mid(DosyaAdi, Len(DosyaAdi) - 2, 3) = "jpg" Then
                Me.lstResimler.Items.Add(ResimAdi)
            End If
        Next
    End Sub

    Private Sub btnYeniResimEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYeniResimEkle.Click

        Me.OpenFileDialog1.Title = "Resim Seç"
        Me.OpenFileDialog1.Filter = "Resim Dosyalarý(*.jpg)|*.jpg"

        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            DosyaAdi = Me.OpenFileDialog1.FileName

            ResimAdiAl()

            FileCopy(Me.OpenFileDialog1.FileName, Application.StartupPath & "\background\" & ResimAdi)
        End If

        frmResimSecme_Load(sender, e)
    End Sub

    Private Sub lstResimler_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstResimler.SelectedIndexChanged

        If Me.lstResimler.SelectedItem = "Yok" Then
            Me.picResim.Image = Nothing
            Exit Sub
        End If

        Me.picResim.Image = Image.FromFile(Application.StartupPath & "\background\" & Me.lstResimler.SelectedItem)
    End Sub

    Private Sub picResim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picResim.Click
        Shell("explorer.exe " & Application.StartupPath & "\background\" & Me.lstResimler.SelectedItem)
    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydet.Click

        If Me.lstResimler.SelectedItem = "Yok" Then
            DosyaAdi = "Yok"
        ElseIf Me.lstResimler.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen listeden bir resim seçiniz..", "Seçili Deðer Yok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        Else
            DosyaAdi = Application.StartupPath & "\background\" & Me.lstResimler.SelectedItem
        End If

        Try
            Dim myConn As New OleDbConnection
            myConn.ConnectionString = Module1.myConnStr

            Dim myCmd As New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "UPDATE Ayarlar SET ArkaPlanResmi=@arkaplanresmi WHERE ID=1"

            myCmd.Parameters.Add("@arkaplanresmi", DosyaAdi)

            myConn.Open()
            myCmd.ExecuteNonQuery()

            myConn.Close()
            myCmd.Dispose()
            myConn.Dispose()

            'MessageBox.Show("Programý tekrar baþlattýðýnýzda arka plan resmi uygulanacaktýr..", "Kaydedildi..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "ACCESS DATABASE HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

    End Sub

#End Region



End Class
