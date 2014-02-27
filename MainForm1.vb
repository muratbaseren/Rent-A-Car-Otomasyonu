#Region "imports"
Imports System
Imports System.Data
Imports System.Data.OleDb
#End Region

Public Class Form1
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents ConMenuList As System.Windows.Forms.ContextMenu
    Friend WithEvents cmnuYeniEkle As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuKaydet As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuIptal As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuSil As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYardim As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHakkinda As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYazdir As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCikis As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents btnYeniEkle As System.Windows.Forms.Button
    Friend WithEvents btnKaydet As System.Windows.Forms.Button
    Friend WithEvents btnIptal As System.Windows.Forms.Button
    Friend WithEvents btnSil As System.Windows.Forms.Button
    Friend WithEvents btnAnaCikis As System.Windows.Forms.Button
    Friend WithEvents picBackGround As System.Windows.Forms.PictureBox
    Friend WithEvents mnuTumunuSil As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAyarlar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuArkaPlanResmi As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVarsayilan As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuTumunuSil As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents mnuHTMLYardim As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMusteriler As System.Windows.Forms.Label
    Friend WithEvents lstMusteriler As System.Windows.Forms.ListBox
    Friend WithEvents lblIsim As System.Windows.Forms.Label
    Friend WithEvents lblSoyad As System.Windows.Forms.Label
    Friend WithEvents txtIsim As System.Windows.Forms.TextBox
    Friend WithEvents txtSoyad As System.Windows.Forms.TextBox
    Friend WithEvents txtUcret As System.Windows.Forms.TextBox
    Friend WithEvents txtAlinanGun As System.Windows.Forms.TextBox
    Friend WithEvents lblUcret As System.Windows.Forms.Label
    Friend WithEvents lblAlinanGun As System.Windows.Forms.Label
    Friend WithEvents txtAracIsmý As System.Windows.Forms.TextBox
    Friend WithEvents lblAracIsmi As System.Windows.Forms.Label
    Friend WithEvents txtTesAlSaat As System.Windows.Forms.TextBox
    Friend WithEvents lblTeslimAlinanSaat As System.Windows.Forms.Label
    Friend WithEvents lblTeslimAlinanTarih As System.Windows.Forms.Label
    Friend WithEvents txtTesEdSaat As System.Windows.Forms.TextBox
    Friend WithEvents lblTeslimEdilenSaat As System.Windows.Forms.Label
    Friend WithEvents txtAracPlaka As System.Windows.Forms.TextBox
    Friend WithEvents lblAracPlaka As System.Windows.Forms.Label
    Friend WithEvents mnuFormSeffafligi As System.Windows.Forms.MenuItem
    Friend WithEvents cmnuTumMusSayisi As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYedekleme As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSecileniSil As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYedekAl As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYedekKonumu As System.Windows.Forms.MenuItem
    Friend WithEvents mnuYeniEkle As System.Windows.Forms.MenuItem
    Friend WithEvents mnuKaydet As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnaSil As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuIptal As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents dtpTesAlTar As System.Windows.Forms.DateTimePicker
    Friend WithEvents mnuGoster As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTumKayitlar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSonKayitlar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents lblTesEdTar As System.Windows.Forms.Label
    Friend WithEvents dtpTesEdTar As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListeleme As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListAd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListSoyad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListArac As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListPlaka As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListTesAlTar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListTesEdTar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents chkTeslim As System.Windows.Forms.CheckBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents mnuAyarlarYedekAl As System.Windows.Forms.MenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuMenu = New System.Windows.Forms.MenuItem
        Me.mnuYeniEkle = New System.Windows.Forms.MenuItem
        Me.mnuKaydet = New System.Windows.Forms.MenuItem
        Me.mnuIptal = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnuAnaSil = New System.Windows.Forms.MenuItem
        Me.mnuSecileniSil = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.mnuTumunuSil = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.mnuYazdir = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.mnuYedekAl = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.mnuCikis = New System.Windows.Forms.MenuItem
        Me.mnuAyarlar = New System.Windows.Forms.MenuItem
        Me.mnuListeleme = New System.Windows.Forms.MenuItem
        Me.mnuListAd = New System.Windows.Forms.MenuItem
        Me.mnuListSoyad = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.mnuListArac = New System.Windows.Forms.MenuItem
        Me.mnuListPlaka = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.mnuListTesAlTar = New System.Windows.Forms.MenuItem
        Me.mnuListTesEdTar = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.mnuArkaPlanResmi = New System.Windows.Forms.MenuItem
        Me.mnuFormSeffafligi = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.mnuYedekleme = New System.Windows.Forms.MenuItem
        Me.mnuAyarlarYedekAl = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.mnuYedekKonumu = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.mnuVarsayilan = New System.Windows.Forms.MenuItem
        Me.mnuGoster = New System.Windows.Forms.MenuItem
        Me.mnuSonKayitlar = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.mnuTumKayitlar = New System.Windows.Forms.MenuItem
        Me.mnuYardim = New System.Windows.Forms.MenuItem
        Me.mnuHTMLYardim = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.mnuHakkinda = New System.Windows.Forms.MenuItem
        Me.ConMenuList = New System.Windows.Forms.ContextMenu
        Me.cmnuYeniEkle = New System.Windows.Forms.MenuItem
        Me.cmnuKaydet = New System.Windows.Forms.MenuItem
        Me.cmnuIptal = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.cmnuSil = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.cmnuTumunuSil = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.cmnuTumMusSayisi = New System.Windows.Forms.MenuItem
        Me.lblMusteriler = New System.Windows.Forms.Label
        Me.lstMusteriler = New System.Windows.Forms.ListBox
        Me.lblIsim = New System.Windows.Forms.Label
        Me.lblSoyad = New System.Windows.Forms.Label
        Me.txtIsim = New System.Windows.Forms.TextBox
        Me.btnYeniEkle = New System.Windows.Forms.Button
        Me.btnKaydet = New System.Windows.Forms.Button
        Me.btnIptal = New System.Windows.Forms.Button
        Me.btnSil = New System.Windows.Forms.Button
        Me.btnAnaCikis = New System.Windows.Forms.Button
        Me.picBackGround = New System.Windows.Forms.PictureBox
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.txtSoyad = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUcret = New System.Windows.Forms.TextBox
        Me.txtAlinanGun = New System.Windows.Forms.TextBox
        Me.lblUcret = New System.Windows.Forms.Label
        Me.lblAlinanGun = New System.Windows.Forms.Label
        Me.txtAracIsmý = New System.Windows.Forms.TextBox
        Me.lblAracIsmi = New System.Windows.Forms.Label
        Me.txtTesAlSaat = New System.Windows.Forms.TextBox
        Me.lblTeslimAlinanSaat = New System.Windows.Forms.Label
        Me.lblTeslimAlinanTarih = New System.Windows.Forms.Label
        Me.txtTesEdSaat = New System.Windows.Forms.TextBox
        Me.lblTeslimEdilenSaat = New System.Windows.Forms.Label
        Me.lblTesEdTar = New System.Windows.Forms.Label
        Me.txtAracPlaka = New System.Windows.Forms.TextBox
        Me.lblAracPlaka = New System.Windows.Forms.Label
        Me.dtpTesAlTar = New System.Windows.Forms.DateTimePicker
        Me.dtpTesEdTar = New System.Windows.Forms.DateTimePicker
        Me.txtID = New System.Windows.Forms.TextBox
        Me.lblId = New System.Windows.Forms.Label
        Me.chkTeslim = New System.Windows.Forms.CheckBox
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMenu, Me.mnuAyarlar, Me.mnuGoster, Me.mnuYardim})
        '
        'mnuMenu
        '
        Me.mnuMenu.Index = 0
        Me.mnuMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuYeniEkle, Me.mnuKaydet, Me.mnuIptal, Me.MenuItem3, Me.mnuAnaSil, Me.MenuItem8, Me.mnuYazdir, Me.MenuItem6, Me.mnuYedekAl, Me.MenuItem9, Me.mnuCikis})
        Me.mnuMenu.Text = "Menü"
        '
        'mnuYeniEkle
        '
        Me.mnuYeniEkle.Index = 0
        Me.mnuYeniEkle.Text = "Yeni Ekl&e"
        '
        'mnuKaydet
        '
        Me.mnuKaydet.Index = 1
        Me.mnuKaydet.Text = "K&aydet"
        '
        'mnuIptal
        '
        Me.mnuIptal.Index = 2
        Me.mnuIptal.Text = "Ýpta&l"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Text = "-"
        '
        'mnuAnaSil
        '
        Me.mnuAnaSil.Index = 4
        Me.mnuAnaSil.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSecileniSil, Me.MenuItem18, Me.mnuTumunuSil})
        Me.mnuAnaSil.Text = "Sil"
        '
        'mnuSecileniSil
        '
        Me.mnuSecileniSil.Index = 0
        Me.mnuSecileniSil.Text = "Seçileni Sil"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Text = "-"
        '
        'mnuTumunuSil
        '
        Me.mnuTumunuSil.Index = 2
        Me.mnuTumunuSil.Text = "Tümü&nü Sil"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 5
        Me.MenuItem8.Text = "-"
        '
        'mnuYazdir
        '
        Me.mnuYazdir.Index = 6
        Me.mnuYazdir.Text = "Tümünü Ya&zdýr"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 7
        Me.MenuItem6.Text = "-"
        '
        'mnuYedekAl
        '
        Me.mnuYedekAl.Index = 8
        Me.mnuYedekAl.Text = "Yedek Al"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 9
        Me.MenuItem9.Text = "-"
        '
        'mnuCikis
        '
        Me.mnuCikis.Index = 10
        Me.mnuCikis.Text = "Çý&kýþ"
        '
        'mnuAyarlar
        '
        Me.mnuAyarlar.Index = 1
        Me.mnuAyarlar.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuListeleme, Me.MenuItem12, Me.mnuArkaPlanResmi, Me.mnuFormSeffafligi, Me.MenuItem7, Me.mnuYedekleme, Me.MenuItem14, Me.mnuVarsayilan})
        Me.mnuAyarlar.Text = "Ayarlar"
        '
        'mnuListeleme
        '
        Me.mnuListeleme.Index = 0
        Me.mnuListeleme.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuListAd, Me.mnuListSoyad, Me.MenuItem22, Me.mnuListArac, Me.mnuListPlaka, Me.MenuItem23, Me.mnuListTesAlTar, Me.mnuListTesEdTar})
        Me.mnuListeleme.Text = "Listeleme"
        '
        'mnuListAd
        '
        Me.mnuListAd.Checked = True
        Me.mnuListAd.Index = 0
        Me.mnuListAd.Text = "Ad 'a Göre"
        '
        'mnuListSoyad
        '
        Me.mnuListSoyad.Index = 1
        Me.mnuListSoyad.Text = "Soyad 'a Göre"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 2
        Me.MenuItem22.Text = "-"
        '
        'mnuListArac
        '
        Me.mnuListArac.Index = 3
        Me.mnuListArac.Text = "Araç Ismine Göre"
        '
        'mnuListPlaka
        '
        Me.mnuListPlaka.Index = 4
        Me.mnuListPlaka.Text = "Plaka 'ya Göre"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 5
        Me.MenuItem23.Text = "-"
        '
        'mnuListTesAlTar
        '
        Me.mnuListTesAlTar.Index = 6
        Me.mnuListTesAlTar.Text = "Teslim Al. Tar. Göre"
        '
        'mnuListTesEdTar
        '
        Me.mnuListTesEdTar.Index = 7
        Me.mnuListTesEdTar.Text = "Teslim Ed. Tar. Göre"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "-"
        '
        'mnuArkaPlanResmi
        '
        Me.mnuArkaPlanResmi.Index = 2
        Me.mnuArkaPlanResmi.Text = "Arka Plan Res&mi"
        '
        'mnuFormSeffafligi
        '
        Me.mnuFormSeffafligi.Index = 3
        Me.mnuFormSeffafligi.Text = "Form Þeffaflýðý"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Text = "-"
        '
        'mnuYedekleme
        '
        Me.mnuYedekleme.Index = 5
        Me.mnuYedekleme.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAyarlarYedekAl, Me.MenuItem11, Me.mnuYedekKonumu})
        Me.mnuYedekleme.Text = "Yedekleme"
        '
        'mnuAyarlarYedekAl
        '
        Me.mnuAyarlarYedekAl.Index = 0
        Me.mnuAyarlarYedekAl.Text = "Yedek Al"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "-"
        '
        'mnuYedekKonumu
        '
        Me.mnuYedekKonumu.Index = 2
        Me.mnuYedekKonumu.Text = "Yedekleme Yeri Seç"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 6
        Me.MenuItem14.Text = "-"
        '
        'mnuVarsayilan
        '
        Me.mnuVarsayilan.Index = 7
        Me.mnuVarsayilan.Text = "Varsayýlan"
        '
        'mnuGoster
        '
        Me.mnuGoster.Index = 2
        Me.mnuGoster.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSonKayitlar, Me.MenuItem13, Me.mnuTumKayitlar})
        Me.mnuGoster.Text = "Göster"
        '
        'mnuSonKayitlar
        '
        Me.mnuSonKayitlar.Checked = True
        Me.mnuSonKayitlar.Index = 0
        Me.mnuSonKayitlar.Text = "Son Kayýtlar(Silinenler Hariç)"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Text = "-"
        '
        'mnuTumKayitlar
        '
        Me.mnuTumKayitlar.Index = 2
        Me.mnuTumKayitlar.Text = "Tüm Kayýtlar(Silinenler Dahil)"
        '
        'mnuYardim
        '
        Me.mnuYardim.Index = 3
        Me.mnuYardim.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHTMLYardim, Me.MenuItem4, Me.mnuHakkinda})
        Me.mnuYardim.Text = "Yardým"
        '
        'mnuHTMLYardim
        '
        Me.mnuHTMLYardim.Index = 0
        Me.mnuHTMLYardim.Text = "Yardým"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.Text = "-"
        '
        'mnuHakkinda
        '
        Me.mnuHakkinda.Index = 2
        Me.mnuHakkinda.Text = "Hakkýnda"
        '
        'ConMenuList
        '
        Me.ConMenuList.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmnuYeniEkle, Me.cmnuKaydet, Me.cmnuIptal, Me.MenuItem5, Me.cmnuSil, Me.MenuItem1, Me.cmnuTumunuSil, Me.MenuItem2, Me.cmnuTumMusSayisi})
        '
        'cmnuYeniEkle
        '
        Me.cmnuYeniEkle.Index = 0
        Me.cmnuYeniEkle.Text = "Yeni Ekl&e"
        '
        'cmnuKaydet
        '
        Me.cmnuKaydet.Index = 1
        Me.cmnuKaydet.Text = "K&aydet"
        '
        'cmnuIptal
        '
        Me.cmnuIptal.Index = 2
        Me.cmnuIptal.Text = "Ýpta&l"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 3
        Me.MenuItem5.Text = "-"
        '
        'cmnuSil
        '
        Me.cmnuSil.Index = 4
        Me.cmnuSil.Text = "Seçileni Sil"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 5
        Me.MenuItem1.Text = "-"
        '
        'cmnuTumunuSil
        '
        Me.cmnuTumunuSil.Index = 6
        Me.cmnuTumunuSil.Text = "Tümünü Sil"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 7
        Me.MenuItem2.Text = "-"
        '
        'cmnuTumMusSayisi
        '
        Me.cmnuTumMusSayisi.Index = 8
        Me.cmnuTumMusSayisi.Text = "Tüm Müþteri Sayýsý"
        '
        'lblMusteriler
        '
        Me.lblMusteriler.BackColor = System.Drawing.Color.Brown
        Me.lblMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMusteriler.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMusteriler.Location = New System.Drawing.Point(8, 8)
        Me.lblMusteriler.Name = "lblMusteriler"
        Me.lblMusteriler.Size = New System.Drawing.Size(176, 23)
        Me.lblMusteriler.TabIndex = 0
        Me.lblMusteriler.Text = "...::: Müþteriler :::..."
        Me.lblMusteriler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstMusteriler
        '
        Me.lstMusteriler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstMusteriler.ContextMenu = Me.ConMenuList
        Me.lstMusteriler.ItemHeight = 17
        Me.lstMusteriler.Location = New System.Drawing.Point(8, 32)
        Me.lstMusteriler.Name = "lstMusteriler"
        Me.lstMusteriler.Size = New System.Drawing.Size(176, 325)
        Me.lstMusteriler.Sorted = True
        Me.lstMusteriler.TabIndex = 1
        '
        'lblIsim
        '
        Me.lblIsim.BackColor = System.Drawing.Color.Brown
        Me.lblIsim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIsim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIsim.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblIsim.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIsim.Location = New System.Drawing.Point(264, 32)
        Me.lblIsim.Name = "lblIsim"
        Me.lblIsim.Size = New System.Drawing.Size(96, 25)
        Me.lblIsim.TabIndex = 2
        Me.lblIsim.Text = "ÝSÝM"
        Me.lblIsim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSoyad
        '
        Me.lblSoyad.BackColor = System.Drawing.Color.Brown
        Me.lblSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSoyad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSoyad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSoyad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSoyad.Location = New System.Drawing.Point(264, 64)
        Me.lblSoyad.Name = "lblSoyad"
        Me.lblSoyad.Size = New System.Drawing.Size(96, 25)
        Me.lblSoyad.TabIndex = 3
        Me.lblSoyad.Text = "SOYAD"
        Me.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIsim
        '
        Me.txtIsim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIsim.Location = New System.Drawing.Point(368, 32)
        Me.txtIsim.Name = "txtIsim"
        Me.txtIsim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIsim.Size = New System.Drawing.Size(168, 25)
        Me.txtIsim.TabIndex = 4
        Me.txtIsim.Text = ""
        Me.txtIsim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnYeniEkle
        '
        Me.btnYeniEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYeniEkle.Image = CType(resources.GetObject("btnYeniEkle.Image"), System.Drawing.Image)
        Me.btnYeniEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYeniEkle.Location = New System.Drawing.Point(8, 376)
        Me.btnYeniEkle.Name = "btnYeniEkle"
        Me.btnYeniEkle.Size = New System.Drawing.Size(96, 40)
        Me.btnYeniEkle.TabIndex = 6
        Me.btnYeniEkle.Text = "Yeni Ekl&e"
        Me.btnYeniEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnKaydet
        '
        Me.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaydet.Image = CType(resources.GetObject("btnKaydet.Image"), System.Drawing.Image)
        Me.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaydet.Location = New System.Drawing.Point(8, 424)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(96, 40)
        Me.btnKaydet.TabIndex = 8
        Me.btnKaydet.Text = "K&aydet"
        Me.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnIptal
        '
        Me.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIptal.Image = CType(resources.GetObject("btnIptal.Image"), System.Drawing.Image)
        Me.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIptal.Location = New System.Drawing.Point(112, 376)
        Me.btnIptal.Name = "btnIptal"
        Me.btnIptal.Size = New System.Drawing.Size(72, 40)
        Me.btnIptal.TabIndex = 9
        Me.btnIptal.Text = "Ýpta&l"
        Me.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSil
        '
        Me.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSil.Image = CType(resources.GetObject("btnSil.Image"), System.Drawing.Image)
        Me.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSil.Location = New System.Drawing.Point(112, 424)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(72, 40)
        Me.btnSil.TabIndex = 10
        Me.btnSil.Text = "&Sil"
        Me.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAnaCikis
        '
        Me.btnAnaCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnaCikis.Image = CType(resources.GetObject("btnAnaCikis.Image"), System.Drawing.Image)
        Me.btnAnaCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnaCikis.Location = New System.Drawing.Point(592, 424)
        Me.btnAnaCikis.Name = "btnAnaCikis"
        Me.btnAnaCikis.Size = New System.Drawing.Size(88, 40)
        Me.btnAnaCikis.TabIndex = 11
        Me.btnAnaCikis.Text = "Çý&kýþ"
        '
        'picBackGround
        '
        Me.picBackGround.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBackGround.Location = New System.Drawing.Point(0, 0)
        Me.picBackGround.Name = "picBackGround"
        Me.picBackGround.Size = New System.Drawing.Size(690, 499)
        Me.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackGround.TabIndex = 12
        Me.picBackGround.TabStop = False
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 477)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Size = New System.Drawing.Size(690, 22)
        Me.StatusBar1.TabIndex = 15
        '
        'txtSoyad
        '
        Me.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSoyad.Location = New System.Drawing.Point(368, 64)
        Me.txtSoyad.Name = "txtSoyad"
        Me.txtSoyad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSoyad.Size = New System.Drawing.Size(168, 25)
        Me.txtSoyad.TabIndex = 16
        Me.txtSoyad.Text = ""
        Me.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(288, 248)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(168, 25)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "TextBox2"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(288, 216)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(168, 25)
        Me.TextBox3.TabIndex = 19
        Me.TextBox3.Text = "TextBox1"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Brown
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(184, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "...::: Cevap :::..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Brown
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(184, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "...::: Seçili Soru :::..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUcret
        '
        Me.txtUcret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUcret.Location = New System.Drawing.Point(368, 144)
        Me.txtUcret.Name = "txtUcret"
        Me.txtUcret.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUcret.Size = New System.Drawing.Size(128, 25)
        Me.txtUcret.TabIndex = 22
        Me.txtUcret.Text = ""
        Me.txtUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlinanGun
        '
        Me.txtAlinanGun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlinanGun.Location = New System.Drawing.Point(368, 112)
        Me.txtAlinanGun.Name = "txtAlinanGun"
        Me.txtAlinanGun.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlinanGun.Size = New System.Drawing.Size(168, 25)
        Me.txtAlinanGun.TabIndex = 21
        Me.txtAlinanGun.Text = ""
        Me.txtAlinanGun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUcret
        '
        Me.lblUcret.BackColor = System.Drawing.Color.Brown
        Me.lblUcret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUcret.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUcret.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblUcret.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUcret.Location = New System.Drawing.Point(264, 144)
        Me.lblUcret.Name = "lblUcret"
        Me.lblUcret.Size = New System.Drawing.Size(96, 25)
        Me.lblUcret.TabIndex = 20
        Me.lblUcret.Text = "ÜCRET"
        Me.lblUcret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlinanGun
        '
        Me.lblAlinanGun.BackColor = System.Drawing.Color.Brown
        Me.lblAlinanGun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlinanGun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAlinanGun.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAlinanGun.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAlinanGun.Location = New System.Drawing.Point(264, 112)
        Me.lblAlinanGun.Name = "lblAlinanGun"
        Me.lblAlinanGun.Size = New System.Drawing.Size(96, 25)
        Me.lblAlinanGun.TabIndex = 19
        Me.lblAlinanGun.Text = "ALINAN GÜN"
        Me.lblAlinanGun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAracIsmý
        '
        Me.txtAracIsmý.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAracIsmý.Location = New System.Drawing.Point(368, 192)
        Me.txtAracIsmý.Name = "txtAracIsmý"
        Me.txtAracIsmý.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAracIsmý.Size = New System.Drawing.Size(168, 25)
        Me.txtAracIsmý.TabIndex = 25
        Me.txtAracIsmý.Text = ""
        Me.txtAracIsmý.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAracIsmi
        '
        Me.lblAracIsmi.BackColor = System.Drawing.Color.Brown
        Me.lblAracIsmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAracIsmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAracIsmi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAracIsmi.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAracIsmi.Location = New System.Drawing.Point(264, 192)
        Me.lblAracIsmi.Name = "lblAracIsmi"
        Me.lblAracIsmi.Size = New System.Drawing.Size(96, 25)
        Me.lblAracIsmi.TabIndex = 23
        Me.lblAracIsmi.Text = "ARAÇ ÝSMÝ"
        Me.lblAracIsmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTesAlSaat
        '
        Me.txtTesAlSaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTesAlSaat.Location = New System.Drawing.Point(472, 312)
        Me.txtTesAlSaat.Name = "txtTesAlSaat"
        Me.txtTesAlSaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTesAlSaat.Size = New System.Drawing.Size(208, 25)
        Me.txtTesAlSaat.TabIndex = 29
        Me.txtTesAlSaat.Text = ""
        Me.txtTesAlSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTeslimAlinanSaat
        '
        Me.lblTeslimAlinanSaat.BackColor = System.Drawing.Color.Brown
        Me.lblTeslimAlinanSaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeslimAlinanSaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTeslimAlinanSaat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTeslimAlinanSaat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTeslimAlinanSaat.Location = New System.Drawing.Point(304, 312)
        Me.lblTeslimAlinanSaat.Name = "lblTeslimAlinanSaat"
        Me.lblTeslimAlinanSaat.Size = New System.Drawing.Size(160, 25)
        Me.lblTeslimAlinanSaat.TabIndex = 27
        Me.lblTeslimAlinanSaat.Text = "TESLÝM ALINAN SAAT"
        Me.lblTeslimAlinanSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTeslimAlinanTarih
        '
        Me.lblTeslimAlinanTarih.BackColor = System.Drawing.Color.Brown
        Me.lblTeslimAlinanTarih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeslimAlinanTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTeslimAlinanTarih.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTeslimAlinanTarih.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTeslimAlinanTarih.Location = New System.Drawing.Point(304, 280)
        Me.lblTeslimAlinanTarih.Name = "lblTeslimAlinanTarih"
        Me.lblTeslimAlinanTarih.Size = New System.Drawing.Size(160, 25)
        Me.lblTeslimAlinanTarih.TabIndex = 26
        Me.lblTeslimAlinanTarih.Text = "TESLÝM ALINAN TARÝH"
        Me.lblTeslimAlinanTarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTesEdSaat
        '
        Me.txtTesEdSaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTesEdSaat.Location = New System.Drawing.Point(472, 384)
        Me.txtTesEdSaat.Name = "txtTesEdSaat"
        Me.txtTesEdSaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTesEdSaat.Size = New System.Drawing.Size(208, 25)
        Me.txtTesEdSaat.TabIndex = 33
        Me.txtTesEdSaat.Text = ""
        Me.txtTesEdSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTeslimEdilenSaat
        '
        Me.lblTeslimEdilenSaat.BackColor = System.Drawing.Color.Brown
        Me.lblTeslimEdilenSaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTeslimEdilenSaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTeslimEdilenSaat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTeslimEdilenSaat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTeslimEdilenSaat.Location = New System.Drawing.Point(304, 384)
        Me.lblTeslimEdilenSaat.Name = "lblTeslimEdilenSaat"
        Me.lblTeslimEdilenSaat.Size = New System.Drawing.Size(160, 25)
        Me.lblTeslimEdilenSaat.TabIndex = 31
        Me.lblTeslimEdilenSaat.Text = "TESLÝM EDÝLEN SAAT"
        Me.lblTeslimEdilenSaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTesEdTar
        '
        Me.lblTesEdTar.BackColor = System.Drawing.Color.Brown
        Me.lblTesEdTar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTesEdTar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTesEdTar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTesEdTar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTesEdTar.Location = New System.Drawing.Point(304, 352)
        Me.lblTesEdTar.Name = "lblTesEdTar"
        Me.lblTesEdTar.Size = New System.Drawing.Size(160, 25)
        Me.lblTesEdTar.TabIndex = 30
        Me.lblTesEdTar.Text = "TESLÝM EDÝLEN TARÝH"
        Me.lblTesEdTar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAracPlaka
        '
        Me.txtAracPlaka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAracPlaka.Location = New System.Drawing.Point(368, 224)
        Me.txtAracPlaka.Name = "txtAracPlaka"
        Me.txtAracPlaka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAracPlaka.Size = New System.Drawing.Size(168, 25)
        Me.txtAracPlaka.TabIndex = 35
        Me.txtAracPlaka.Text = ""
        Me.txtAracPlaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAracPlaka
        '
        Me.lblAracPlaka.BackColor = System.Drawing.Color.Brown
        Me.lblAracPlaka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAracPlaka.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAracPlaka.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblAracPlaka.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAracPlaka.Location = New System.Drawing.Point(264, 224)
        Me.lblAracPlaka.Name = "lblAracPlaka"
        Me.lblAracPlaka.Size = New System.Drawing.Size(96, 25)
        Me.lblAracPlaka.TabIndex = 34
        Me.lblAracPlaka.Text = "ARAÇ PLAKA"
        Me.lblAracPlaka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpTesAlTar
        '
        Me.dtpTesAlTar.Location = New System.Drawing.Point(472, 280)
        Me.dtpTesAlTar.Name = "dtpTesAlTar"
        Me.dtpTesAlTar.Size = New System.Drawing.Size(208, 25)
        Me.dtpTesAlTar.TabIndex = 36
        '
        'dtpTesEdTar
        '
        Me.dtpTesEdTar.Location = New System.Drawing.Point(472, 352)
        Me.dtpTesEdTar.Name = "dtpTesEdTar"
        Me.dtpTesEdTar.Size = New System.Drawing.Size(208, 25)
        Me.dtpTesEdTar.TabIndex = 37
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(368, 424)
        Me.txtID.Name = "txtID"
        Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtID.Size = New System.Drawing.Size(63, 25)
        Me.txtID.TabIndex = 39
        Me.txtID.Text = ""
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtID.Visible = False
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.Color.Brown
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblId.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblId.Location = New System.Drawing.Point(304, 424)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(56, 25)
        Me.lblId.TabIndex = 38
        Me.lblId.Text = "ID"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblId.Visible = False
        '
        'chkTeslim
        '
        Me.chkTeslim.BackColor = System.Drawing.Color.Brown
        Me.chkTeslim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTeslim.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.chkTeslim.Location = New System.Drawing.Point(544, 32)
        Me.chkTeslim.Name = "chkTeslim"
        Me.chkTeslim.Size = New System.Drawing.Size(136, 24)
        Me.chkTeslim.TabIndex = 40
        Me.chkTeslim.Text = "Teslim edildi.."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Brown
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(496, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 25)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "YTL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 18)
        Me.ClientSize = New System.Drawing.Size(690, 499)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkTeslim)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.dtpTesEdTar)
        Me.Controls.Add(Me.dtpTesAlTar)
        Me.Controls.Add(Me.txtAracPlaka)
        Me.Controls.Add(Me.lblAracPlaka)
        Me.Controls.Add(Me.txtTesEdSaat)
        Me.Controls.Add(Me.lblTeslimEdilenSaat)
        Me.Controls.Add(Me.lblTesEdTar)
        Me.Controls.Add(Me.txtTesAlSaat)
        Me.Controls.Add(Me.lblTeslimAlinanSaat)
        Me.Controls.Add(Me.lblTeslimAlinanTarih)
        Me.Controls.Add(Me.txtAracIsmý)
        Me.Controls.Add(Me.lblAracIsmi)
        Me.Controls.Add(Me.txtUcret)
        Me.Controls.Add(Me.txtAlinanGun)
        Me.Controls.Add(Me.lblUcret)
        Me.Controls.Add(Me.lblAlinanGun)
        Me.Controls.Add(Me.txtSoyad)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.btnAnaCikis)
        Me.Controls.Add(Me.btnSil)
        Me.Controls.Add(Me.btnIptal)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnYeniEkle)
        Me.Controls.Add(Me.txtIsim)
        Me.Controls.Add(Me.lblSoyad)
        Me.Controls.Add(Me.lblIsim)
        Me.Controls.Add(Me.lstMusteriler)
        Me.Controls.Add(Me.lblMusteriler)
        Me.Controls.Add(Me.picBackGround)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "...::: OSER OTO KÝRALAMA PROGRAMI :::..."
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Yerel Degiskenler"
    Private myConn As OleDbConnection
    Private myCmd As OleDbCommand
    Private myDR As OleDbDataReader

    Private Mode As String
    Private ReadMode As String
    Private AyarMode As String
    Private DeleteMode As String

#End Region

#Region "Metotlar"
    'Kullanýcýný yaptýðý ayarlarýn okunmasý ve form da uygulanmasý..
    Private Sub Ayarlari_Oku()
        Try
            myConn = New OleDbConnection
            myConn.ConnectionString = Module1.myConnStr

            'Database den ayarlar tablosundan kullanýcýnýn girdiði ayarlar okunuyor..
            'ID=1 olan kýsým kullanýcý ayarlarý..
            'ID=2 olan kýsým varsayýlan ayarlar..
            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = "SELECT * FROM Ayarlar WHERE ID=1"

            Dim myDR As OleDbDataReader

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Do While myDR.Read
                Me.Opacity = myDR.Item("Opacity")

                If Not myDR.Item("ArkaPlanResmi") = "Yok" Then
                    Me.picBackGround.Image = Image.FromFile(myDR.Item("ArkaPlanResmi"))
                ElseIf myDR.Item("ArkaPlanResmi") = "Yok" Then
                    Me.picBackGround.Image = Nothing
                End If
            Loop

            myConn.Close()
            myCmd.Dispose()
            myDR.Close()
            myConn.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message, "ACCESS DATABASE HATA", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    'Kullanýcýnýn yaptýðý ayarlarýn database > Ayarlar a yazýlmasý..
    Private Sub Ayarlari_Yaz()
        myConn = New OleDbConnection
        myConn.ConnectionString = Module1.myConnStr

        Try

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text

            If AyarMode = "Opacity" Then
                'inputbox için deðiþken tanýmlýyoruz..
                Dim Giris

                'Sayý girilmediði sürece kullanýcýdan bir 
                'deðer isteyecek döngü yazýlýyor..
                Do
                    Giris = InputBox("Lütfen 0-100 arasý bir deðer giriniz:" & vbCrLf & vbCrLf & "< 0 > deðeri form penceresinin tamamen görünmez olmasýna neden olacaktýr!" & vbCrLf & vbCrLf & "Varsayýlan Deðer : 100 'dür.", "ÞEFFAFLIK DEÐERÝ", "100")
                Loop While (IsNumeric(Giris) = False)

                Giris = CDbl(Giris)

                'Eðer sýfýrdan küçük ise bu hataya 
                'yol açacaðýndan minimum sýfýr deðerinin 
                'almasý saðlanýyor..
                If Giris < 0 Then
                    Giris = 0
                    'Eðer 100 den buyuk bir deger girilirse 
                    'bu hataya yol açacaðýndan maksimum 100 
                    'degerinin girilmesi saðlanýyor..
                ElseIf Giris > 100 Then
                    Giris = 100
                End If

                Giris = Giris / 100

                Me.Opacity = Giris

                'Bu koþula göre CommandText düzenleniyor..
                myCmd.CommandText = _
                    "UPDATE Ayarlar SET Opacity=@opacity " & _
                    "WHERE ID=1"

                myCmd.Parameters.Add("@opacity", Giris)

                'Varsayýlan ayarlar seçilirse..
            ElseIf AyarMode = "Reset" Then

                myCmd.CommandText = "UPDATE Ayarlar SET " & _
                        "ArkaPlanResmi=@resim, " & _
                        "Opacity=@opacity " & _
                        "WHERE ID=1"

                myCmd.Parameters.AddWithValue("@resim", "Yok")
                myCmd.Parameters.AddWithValue("@opacity", "1")

            End If

            myConn.Open()
            myCmd.ExecuteNonQuery()

        Catch exOLE As OleDbException
            MessageBox.Show(exOLE.Message, "ACCESS HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            'Bu blokta program bir hataya yakalansada yakalanmasada veya yukarda sub içinde her hangi bir yerde "exit sub" komutunu kullansakta bu kýsýmdaki kodlarý yapmasý saðlanýyor.. 
            myConn.Close()
            myCmd.Dispose()
            myConn.Dispose()
        End Try
    End Sub

    'Form kontrollerinin içeriklerinin sýfýrlanmasý..
    Private Sub Ekran_Temizle()

        'Form daki herbir kontrol için sýrasýyla "kontrol" adlý deðiþkene aktarýlýyor..
        For Each Kontrol As Control In Me.Controls
            'Eðer "kontrol" textbox ise..
            If TypeOf Kontrol Is TextBox Then
                '"Kontrol" tam olarak textbox a dönüþtürülüyor ve text i temizleniyor..
                CType(Kontrol, TextBox).Text = Nothing
            End If
        Next

        Me.dtpTesAlTar.Text = Now
        Me.dtpTesEdTar.Text = Now
    End Sub

    'yeni kayýt giriþi yada guncelleme yapýlmasýna 
    'göre butonlarýn pasif hale getirilmesi..
    Private Sub Button_Aktivasyonu()
        'Eðer yeni kayýt eklenmiyorsa kayýt guncelleniyordur,hiçbir buton pasif hale getirilmez..
        If Mode = "Update" Then
            Me.btnYeniEkle.Enabled = True
            Me.btnSil.Enabled = True

            'Eðer yeni kayýt giriþi yapýlýyorsa yeni butonu ile Sil butonu pasif hale getirilir..
        ElseIf Mode = "Add" Then
            Me.btnYeniEkle.Enabled = False
            Me.btnSil.Enabled = False

            'Yeni kayýt giriþi yapýldýktan sonra ekran temizlenir..
            Ekran_Temizle()
        End If
    End Sub

    'Program çýkýþýnda yada istenildiðinde databasse 
    'in yedeðinin alýnmasý iþlemi..
    Private Sub Yedek_Alma()
        Dim strFilePath As String

        myConn = New OleDbConnection
        myConn.ConnectionString = Module1.myConnStr

        Try
            '*******************************************************************
            'N O T:
            'Database de Options adlý tablo Programýn varsayýlan 
            'ayarlarýný tutmak ve kullanýcýnýn yaptýðýayarlarý tutmak içindir..

            'Options tablosunda ID=2 nolu satýr programýn varsayýlan 
            'ayar satýrlarýdýr,Bu kýsýmda programýn hiçbir bolumunde 
            'kayýt yapýlmaz çünkü varsayýlan ayarlara buradan okuma 
            'yaparak ulaþacaðýz..

            'Kullanýcýnýn yaptýðý tüm ayarlar ID=1 de kaydedilir 
            've buradan okunarak program baþladýðýnda uygulanýr..
            '*****************************************************

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = _
                "SELECT StandbyPath FROM Ayarlar WHERE ID=1"

            Dim myDR As OleDbDataReader

            myConn.Open()
            myDR = myCmd.ExecuteReader

            'Database den database imizi yedekleyeceðimiz konum okunur..
            Do While myDR.Read
                strFilePath = myDR.Item("StandbyPath").ToString
            Loop

            'Database den database imizin yedekleneceði konum okunur 
            've "strFilePath" adlý deðiþkene aktarýlýr..
            'Eger database de records adlý database in yedeðini 
            'alacaðýmýz bir konum belirtilmemiþse..
            If Not strFilePath = "Yedek" Then
                FileCopy(Application.StartupPath & "\database.mdb", strFilePath & "\database.mdb")
            Else

                'Eger Yedek klasörü onceden yaratýlmýþsa buraya 
                'database i kopyalarken tekrar Yedek klasörünü oluþtur 
                'demek hataya sebep olcaktýr.Bu yuzden eger Programýn 
                'bulunduðu konumda Yedek klasörü yoksa Yedek klasörünü 
                'oluþtur diye bir kontrol oluþturdum..

                '*****************************************************
                'Uygulamanýn bulunduðu klasörde "Yedek" adlý klasör 
                'olup olmadýðýný kontrol eden kod satýrý..
                If Not System.IO.Directory.Exists(Application.StartupPath & "\Yedek") Then
                    MkDir(Application.StartupPath & "\Yedek")
                End If
                '*****************************************************

                'Dosya kopyalama 'kopyalancak dosya konumu 
                've(adý) ' , 'oluþturulacak kopyanýn konumu ve adý' 
                FileCopy(Application.StartupPath & "\database.mdb", Application.StartupPath & "\Yedek\database.mdb")
            End If

            MessageBox.Show("Yedek Alýnmýþtýr..", "YEDEKLEME", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        Catch exOLE As OleDbException
            MessageBox.Show(exOLE.Message, "ACCESS HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            'Bu blokta program bir hataya yakalansada yakalanmasada
            'veya yukarda sub içinde her hangi bir yerde "exit sub" 
            'komutunu kullansakta bu kýsýmdaki kodlarý yapmasý saðlanýyor.. 
            myCmd.Dispose()
            myConn.Close()
            myConn.Dispose()
        End Try
    End Sub

    'Database de ki verilerin okunup listeye listelenemesi..
    Private Sub Data_Oku()
        myConn = New OleDbConnection
        myConn.ConnectionString = Module1.myConnStr

        myCmd = New OleDbCommand
        myCmd.Connection = myConn
        myCmd.CommandType = CommandType.Text
        myCmd.CommandText = "SELECT * FROM Data"

        Dim myDR As OleDbDataReader
        Dim OkunacakAlan As String
        'Hocanýn derste yaptýðý örnek teki gibi bir nesne tanýmadýk 
        'bunu Class ýnýda oluþturuyoruz..
        'Ayný hocanýn yaptýðý gibi Class hazýrlanýyor..
        Dim objListBoxNesnesi As ListBoxNesnesi

        Try

            myConn.Open()
            myDR = myCmd.ExecuteReader

            'Eger database de hiç kayýt yok ise bir listeleme yapmadan çýk..
            If myDR Is Nothing Then
                Exit Sub
            End If

            'Liste temizleniyor..
            Me.lstMusteriler.Items.Clear()

            'Kullanýcý hangi listeleme türünü seçtiyse program 
            'ona göre kayýtlardan okunacak kolon u okuyor..
            If Me.mnuListAd.Checked = True Then
                OkunacakAlan = "Ad"
            ElseIf Me.mnuListSoyad.Checked = True Then
                OkunacakAlan = "Soyad"
            ElseIf Me.mnuListArac.Checked = True Then
                OkunacakAlan = "AracIsmi"
            ElseIf Me.mnuListPlaka.Checked = True Then
                OkunacakAlan = "Plaka"
            ElseIf Me.mnuListTesAlTar.Checked = True Then
                OkunacakAlan = "TesAlTar"
            ElseIf Me.mnuListTesEdTar.Checked = True Then
                OkunacakAlan = "TesEdTar"
            End If

            If Me.mnuSonKayitlar.Checked = True Then
                ReadMode = "SonKayitlar"
            ElseIf Me.mnuTumKayitlar.Checked = True Then
                ReadMode = "TumKayitlar"
            End If

            Do While myDR.Read
                If ReadMode = "SonKayitlar" AndAlso myDR.Item("Silindi") = "Hayýr" Then
                    objListBoxNesnesi = New ListBoxNesnesi _
                        (myDR.Item(OkunacakAlan).ToString, _
                        CInt(myDR.Item("ID")))

                    Me.lstMusteriler.Items.Add(objListBoxNesnesi)
                    'AndAlso (myDR.Item("Silindi") = True OrElse myDR.Item("Silindi") = False)
                ElseIf ReadMode = "TumKayitlar" Then

                    objListBoxNesnesi = New ListBoxNesnesi _
                        (myDR.Item(OkunacakAlan).ToString, _
                        CInt(myDR.Item("ID")))

                    Me.lstMusteriler.Items.Add(objListBoxNesnesi)
                End If
            Loop

        Catch exOLE As OleDbException
            MessageBox.Show(exOLE.Message, "ACCESS HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            'Bu blokta program bir hataya yakalansada yakalanmasada 
            'veya yukarda sub içinde her hangi bir yerde "exit sub" 
            'komutunu kullansakta bu kýsýmdaki kodlarý yapmasý saðlanýyor.. 
            myConn.Close()
            myCmd.Dispose()
            myConn.Dispose()

            'Eger listedeki kiþi saýsý sýfýr deðilse en üsttekini seç..
            If Not Me.lstMusteriler.Items.Count = 0 Then
                Me.lstMusteriler.SelectedIndex = 0
            End If

            Me.StatusBar1.Text = Me.lstMusteriler.Items.Count & " adet kayýt listede vardýr.."

        End Try
    End Sub

    'Database e  yeni kayýt girilmesi..
    Private Sub Data_Yaz()
        myConn = New OleDbConnection
        myConn.ConnectionString = Module1.myConnStr

        Try
            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = _
            "INSERT INTO Data (Ad, Soyad, AlinanGun, Ucret, AracIsmi, Plaka, TesAlTar, TesAlSaat, TesEdTar, TesEdSaat, TeslimEdildi, Silindi) " & _
            "VALUES (@Ad,@Soyad,@AlinanGun,@Ucret,@AracIsmi,@Plaka,@TesAlTar,@TesAlSaat,@TesEdTar,@TesEdSaat,@TeslimEdildi,@Silindi)"

            myCmd.Parameters.AddWithValue("@Ad", Me.txtIsim.Text)
            myCmd.Parameters.AddWithValue("@Soyad", Me.txtSoyad.Text)
            myCmd.Parameters.AddWithValue("@AlinanGun", CInt(Me.txtAlinanGun.Text))
            myCmd.Parameters.AddWithValue("@Ucret", CInt(Me.txtUcret.Text))
            myCmd.Parameters.AddWithValue("@AracIsmi", Me.txtAracIsmý.Text)
            myCmd.Parameters.AddWithValue("@Plaka", Me.txtAracPlaka.Text)
            myCmd.Parameters.AddWithValue("@TesAlTar", CDate(Me.dtpTesAlTar.Text))
            myCmd.Parameters.AddWithValue("@TesAlSaat", Me.txtTesAlSaat.Text)
            myCmd.Parameters.AddWithValue("@TesEdTar", CDate(Me.dtpTesEdTar.Text))
            myCmd.Parameters.AddWithValue("@TesEdSaat", Me.txtTesEdSaat.Text)
            myCmd.Parameters.AddWithValue("@TeslimEdildi", Me.chkTeslim.Checked)
            myCmd.Parameters.AddWithValue("@Silindi", "Hayýr")

            myConn.Open()
            myCmd.ExecuteNonQuery()

        Catch exOLE As OleDbException
            MessageBox.Show(exOLE.Message, "ACCESS HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            'Bu blokta program bir hataya yakalansada yakalanmasada
            'veya yukarda sub içinde her hangi bir yerde "exit sub" 
            'komutunu kullansakta bu kýsýmdaki kodlarý yapmasý saðlanýyor.. 
            'myConn.Close()
            'myCmd.Dispose()
            'myConn.Dispose()
        End Try

        'Burdaki kodlarý "Finally" blogu dýþýna yazdým.Çünkü Eðer 
        'yukardaki hata kontrollerinden birinde hata çýkarsa "exit sub" 
        'deyimi ile sub dan çýkýlacak eðer bunlarý "Finally" bloguna 
        'yazsaydým Exit sub desemde "Finally" blogu çalýþacaðýndan 
        'hata oluþacaktý..halbuki yukardaki hata kontrollerinde hata 
        'yakalandýysa bu iþlemleride yapmadan sub dan çýkýlmasýný istiyorum..
        Mode = "Update"

        Button_Aktivasyonu()

        Data_Oku()
    End Sub

    'Kayýt guncelleme(var olan kayýt bilgilerinin deðiþtirilmesinde) 
    'çalýþacak metot..
    Private Sub Data_Update()
        myConn = New OleDbConnection
        myConn.ConnectionString = Module1.myConnStr

        Try

            Dim objListBoxNesnesi As ListBoxNesnesi
            objListBoxNesnesi = CType(Me.lstMusteriler.SelectedItem, ListBoxNesnesi)

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = _
                "UPDATE Data SET " & _
                    "Ad=@Ad," & _
                    "Soyad=@Soyad," & _
                    "AlinanGun=@AlinanGun," & _
                    "Ucret=@Ucret," & _
                    "AracIsmi=@AracIsmi," & _
                    "Plaka=@Plaka," & _
                    "TesAlTar=@TesAlTar," & _
                    "TesAlSaat=@TesAlSaat," & _
                    "TesEdTar=@TesEdTar," & _
                    "TesEdSaat=@TesEdSaat," & _
                    "TeslimEdildi=@TeslimEdildi," & _
                    "Silindi=@Silindi " & _
                "WHERE ID=" & objListBoxNesnesi.ID

            '******************************************
            '<<<  H A T A   K O N T R O L L E R Ý >>>
            '******************************************
            '******************************************
            If IsNumeric(Me.txtUcret.Text) = False Or IsNumeric(Me.txtAlinanGun.Text) = False Then
                MessageBox.Show("Ücret yada Aracýn Alýnan Gün sayýsý bir sayý olmalýdýr..Lütfen düzeltip kaydetme iþlemi yapýnýz..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtUcret.Focus()
                Exit Sub
            End If

            myCmd.Parameters.AddWithValue("@Ad", Me.txtIsim.Text)
            myCmd.Parameters.AddWithValue("@Soyad", Me.txtSoyad.Text)
            myCmd.Parameters.AddWithValue("@AlinanGun", CInt(Me.txtAlinanGun.Text))
            myCmd.Parameters.AddWithValue("@Ucret", CInt(Me.txtUcret.Text))
            myCmd.Parameters.AddWithValue("@AracIsmi", Me.txtAracIsmý.Text)
            myCmd.Parameters.AddWithValue("@Plaka", Me.txtAracPlaka.Text)
            myCmd.Parameters.AddWithValue("@TesAlTar", CDate(Me.dtpTesAlTar.Text))
            myCmd.Parameters.AddWithValue("@TesAlSaat", Me.txtTesAlSaat.Text)
            myCmd.Parameters.AddWithValue("@TesEdTar", CDate(Me.dtpTesEdTar.Text))
            myCmd.Parameters.AddWithValue("@TesEdSaat", Me.txtTesEdSaat.Text)
            myCmd.Parameters.AddWithValue("@TeslimEdildi", Me.chkTeslim.Checked)
            myCmd.Parameters.AddWithValue("@Silindi", "Hayýr")

            myConn.Open()
            myCmd.ExecuteNonQuery()

        Catch exOLE As OleDbException
            MessageBox.Show(exOLE.Message, "ACCESS HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            'Bu blokta program bir hataya yakalansada yakalanmasada 
            'veya yukarda sub içinde her hangi bir yerde "exit sub" 
            'komutunu kullansakta bu kýsýmdaki kodlarý yapmasý saðlanýyor.. 
            'myConn.Close()
            'myCmd.Dispose()
            'myConn.Dispose()
        End Try

        Data_Oku()
    End Sub

    'Listede seçilen kiþinin bilgilerinin textbox lara aktarýlmasý..
    Private Sub Data_Aktar()
        myConn = New OleDbConnection
        myConn.ConnectionString = Module1.myConnStr

        Try

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = _
            "SELECT * FROM Data WHERE ID=@ID"

            Dim objListBoxNesnesi As ListBoxNesnesi

            'Listeden seçilen nesnenin tipini listboxnesnesi 
            'ne dönüþtürüyorum..Böylece Value ve ID deðerine ulaþacaðým.. 
            objListBoxNesnesi = CType(Me.lstMusteriler.SelectedItem, ListBoxNesnesi)

            Dim myDR As OleDbDataReader

            myCmd.Parameters.Add("@ID", objListBoxNesnesi.ID)

            myConn.Open()
            myDR = myCmd.ExecuteReader

            Ekran_Temizle()

            'Listeden Seçilen kiþinin diðer bilgilerine 
            'ulaþýyorum ve ekrandaki textboxlara aktarýyorum..
            Do While myDR.Read
                Me.txtID.Text = _
                myDR.Item("ID")
                '-----------------------------
                Me.txtIsim.Text = _
                myDR.Item("Ad").ToString
                '-----------------------------
                Me.txtSoyad.Text = _
                myDR.Item("Soyad").ToString
                '-----------------------------
                Me.txtAlinanGun.Text = _
                myDR.Item("AlinanGun")
                '-----------------------------
                Me.txtUcret.Text = _
                myDR.Item("Ucret")
                '-----------------------------
                Me.txtAracIsmý.Text = _
                myDR.Item("AracIsmi").ToString
                '-----------------------------
                Me.txtAracPlaka.Text = _
                myDR.Item("Plaka").ToString
                '-----------------------------
                Me.dtpTesAlTar.Text = _
                myDR.Item("TesAlTar")
                '-----------------------------
                Me.txtTesAlSaat.Text = _
                myDR.Item("TesAlSaat").ToString
                '-----------------------------
                Me.dtpTesEdTar.Text = _
                myDR.Item("TesEdTar")
                '-----------------------------
                Me.txtTesEdSaat.Text = _
                myDR.Item("TesEdSaat").ToString
                '-----------------------------
                Me.chkTeslim.Checked = _
                myDR.Item("TeslimEdildi")
            Loop

        Catch exOLE As OleDbException
            MessageBox.Show(exOLE.Message, "ACCESS HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            'Bu blokta program bir hataya yakalansada 
            'yakalanmasada veya yukarda sub içinde her hangi 
            'bir yerde "exit sub" komutunu kullansakta bu 
            'kýsýmdaki kodlarý yapmasý saðlanýyor.. 
            'myCmd.Dispose()
            'myConn.Close()
            'myConn.Dispose()
        End Try

    End Sub

    'Database den kayýt silme..
    Private Sub Data_Sil()
        myConn = New OleDbConnection
        myConn.ConnectionString = Module1.myConnStr

        Try
            Dim objListBoxNesnesi As ListBoxNesnesi
            'Listeden seçilen nesnenin tipini listboxnesnesi 
            'ne dönüþtürüyorum..Böylece Value ve ID
            'deðerine ulaþacaðým.. 
            objListBoxNesnesi = CType(Me.lstMusteriler.SelectedItem, ListBoxNesnesi)

            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text

            If DeleteMode = "Single" Then
                myCmd.CommandText = _
                    "UPDATE Data SET " & _
                        "Ad=@Ad," & _
                        "Soyad=@Soyad," & _
                        "AlinanGun=@AlinanGun," & _
                        "Ucret=@Ucret," & _
                        "AracIsmi=@AracIsmi," & _
                        "Plaka=@Plaka," & _
                        "TesAlTar=@TesAlTar," & _
                        "TesAlSaat=@TesAlSaat," & _
                        "TesEdTar=@TesEdTar," & _
                        "TesEdSaat=@TesEdSaat," & _
                        "TeslimEdildi=@TeslimEdildi," & _
                        "Silindi=@Silindi " & _
                    "WHERE ID=" & objListBoxNesnesi.ID

                'Seçilen kiþinin ID sine ulaþýp kayýt ý silindi 
                'olarak iþaretliyoruz..
                myCmd.Parameters.AddWithValue("@Ad", Me.txtIsim.Text)
                myCmd.Parameters.AddWithValue("@Soyad", Me.txtSoyad.Text)
                myCmd.Parameters.AddWithValue("@AlinanGun", CInt(Me.txtAlinanGun.Text))
                myCmd.Parameters.AddWithValue("@Ucret", CInt(Me.txtUcret.Text))
                myCmd.Parameters.AddWithValue("@AracIsmi", Me.txtAracIsmý.Text)
                myCmd.Parameters.AddWithValue("@Plaka", Me.txtAracPlaka.Text)
                myCmd.Parameters.AddWithValue("@TesAlTar", CDate(Me.dtpTesAlTar.Text))
                myCmd.Parameters.AddWithValue("@TesAlSaat", Me.txtTesAlSaat.Text)
                myCmd.Parameters.AddWithValue("@TesEdTar", CDate(Me.dtpTesEdTar.Text))
                myCmd.Parameters.AddWithValue("@TesEdSaat", Me.txtTesEdSaat.Text)
                myCmd.Parameters.AddWithValue("@TeslimEdildi", Me.chkTeslim.Checked)
                myCmd.Parameters.AddWithValue("@Silindi", "Evet")

            ElseIf DeleteMode = "Full" Then
                myCmd.CommandText = _
                                "DELETE FROM Data"
            End If

            myConn.Open()
            myCmd.ExecuteNonQuery()

            'myCmd.Dispose()
            'myConn.Close()
            'myConn.Dispose()

            Data_Oku()

        Catch exOLE As OleDbException
            MessageBox.Show(exOLE.Message, "ACCESS HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    'Tüm listeleme özellikleri false yapýlacak ve seçilen 
    'listeleme türü true olcak..
    Private Sub ListelemeCheckFalse()
        Me.mnuListAd.Checked = False
        Me.mnuListArac.Checked = False
        Me.mnuListPlaka.Checked = False
        Me.mnuListSoyad.Checked = False
        Me.mnuListTesAlTar.Checked = False
        Me.mnuListTesEdTar.Checked = False
    End Sub

    'Yedekleme konumu database e kaydetme..
    Private Sub YedeklemeKonumuKaydetme()
        Dim strFilePath As String

        'Yedekleme yapýlacak konum database e kaydediliyor...
        If Me.FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            strFilePath = Me.FolderBrowserDialog1.SelectedPath()
        Else
            Exit Sub
        End If

        myConn = New OleDbConnection
        myConn.ConnectionString = Module1.myConnStr

        Try
            myCmd = New OleDbCommand
            myCmd.Connection = myConn
            myCmd.CommandType = CommandType.Text
            myCmd.CommandText = _
                "UPDATE Ayarlar SET " & _
                    "StandbyPath = @standbypath " & _
                "WHERE ID = 1"

            myCmd.Parameters.AddWithValue("@standbypath", strFilePath)

            myConn.Open()
            myCmd.ExecuteNonQuery()

            myConn.Close()
            myCmd.Dispose()
            myConn.Dispose()

        Catch exOLE As OleDbException
            MessageBox.Show(exOLE.Message, "ACCESS HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "GENEL HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
#End Region

#Region "Olaylar"
    Private Sub mnuArkaPlanResmi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuArkaPlanResmi.Click
        Dim frm As New frmResimSecme

        frm.ShowDialog()
    End Sub

    Private Sub mnuHakkinda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHakkinda.Click
        Dim frm As New frmHakkinda

        frm.ShowDialog()
    End Sub

    Private Sub mnuHTMLYardim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHTMLYardim.Click
        Shell("explorer.exe " & Application.StartupPath & "\Yardim\index.htm", AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub mnuListAd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuListAd.Click
        ListelemeCheckFalse()
        Me.mnuListAd.Checked = True
        Data_Oku()
    End Sub

    Private Sub mnuListSoyad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuListSoyad.Click
        ListelemeCheckFalse()
        Me.mnuListSoyad.Checked = True
        Data_Oku()
    End Sub

    Private Sub mnuListArac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuListArac.Click
        ListelemeCheckFalse()
        Me.mnuListArac.Checked = True
        Data_Oku()
    End Sub

    Private Sub mnuListPlaka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuListPlaka.Click
        ListelemeCheckFalse()
        Me.mnuListPlaka.Checked = True
        Data_Oku()
    End Sub

    Private Sub mnuListTesAlTar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuListTesAlTar.Click
        ListelemeCheckFalse()
        Me.mnuListTesAlTar.Checked = True
        Data_Oku()
    End Sub

    Private Sub mnuListTesEdTar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuListTesEdTar.Click
        ListelemeCheckFalse()
        Me.mnuListTesEdTar.Checked = True
        Data_Oku()
    End Sub

    Private Sub mnuFormSeffafligi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFormSeffafligi.Click
        AyarMode = "Opacity"
        Ayarlari_Yaz()
    End Sub

    Private Sub mnuVarsayilan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVarsayilan.Click
        AyarMode = "Reset"
        Ayarlari_Yaz()
    End Sub

    Private Sub mnuAyarlarYedekAl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAyarlarYedekAl.Click
        Yedek_Alma()
    End Sub

    Private Sub mnuYedekAl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYedekAl.Click
        mnuAyarlarYedekAl_Click(sender, e)
    End Sub

    Private Sub mnuYedekKonumu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYedekKonumu.Click
        YedeklemeKonumuKaydetme()
    End Sub

    Private Sub mnuSonKayitlar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSonKayitlar.Click
        Me.mnuSonKayitlar.Checked = True
        Me.mnuTumKayitlar.Checked = False
        ReadMode = "SonKayitlar"
        Data_Oku()
    End Sub

    Private Sub mnuTumKayitlar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTumKayitlar.Click
        Me.mnuSonKayitlar.Checked = False
        Me.mnuTumKayitlar.Checked = True
        ReadMode = "TumKayitlar"
        Data_Oku()
    End Sub

    Private Sub btnYeniEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYeniEkle.Click
        'Mod un yeni kayýt ekleme olmasý..
        Mode = "Add"

        Me.lstMusteriler.Items.Clear()

        'Butonlarýn pasif olmasýnýn ayarlanmasý..
        Button_Aktivasyonu()
        'Kaydet butonuna odaklanama..
        Me.txtIsim.Focus()
    End Sub

    Private Sub btnKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKaydet.Click
        'Eger kaydet e basýldýðýnda yeni kayýt giriþi 
        'yapýlýyorsa "Data_yaz" metodu çalýþýr..
        If Mode = "Add" Then

            If IsNumeric(Me.txtUcret.Text) = False Or IsNumeric(Me.txtAlinanGun.Text) = False Then
                MessageBox.Show("Ücret yada Aracýn Alýnan Gün sayýsý bir sayý olmalýdýr..Lütfen düzeltip yeni kayýt ekleme iþlemi yapýnýz..", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Me.txtUcret.Focus()
                Exit Sub
            End If

            Data_Yaz()
            Me.btnYeniEkle.Enabled = True
            Me.btnSil.Enabled = True

            'Eðer kaydet e basýldýðýnda guncellme yapýlýyorsa 
            '"Data_Update" metodu çalýþýr..
        ElseIf Mode = "Update" Then
            Data_Update()
        End If

        Mode = "Update"
        Data_Oku()

        Me.StatusBar1.Text = Me.lstMusteriler.Items.Count & " adet kayýt listede vardýr.."
    End Sub

    Private Sub btnSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSil.Click

        'Kayýt sil e basýldýðýnda listeden hiçbir kayýt 
        'seçilmediyse ekrana uyarý gelmesi ve sub dan çýkma..
        If Me.lstMusteriler.SelectedIndex = -1 Then
            MessageBox.Show("Lütfen Listeden Bir Kayýt Seçiniz...", "SÝLME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        DialogResult = MessageBox.Show(Me.lstMusteriler.SelectedItem.ToString & " adlý kayýdý silmek istediðinizden emin misiniz?", "KAYIT SÝLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = DialogResult.No Then
            Exit Sub
        End If

        DeleteMode = "Single"

        'Rehber den kayýt silinmesi için çaðýrýlan metot..
        Data_Sil()

        Me.StatusBar1.Text = Me.lstMusteriler.Items.Count & " adet kayýt listede vardýr.."
    End Sub

    Private Sub btnIptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIptal.Click
        'kayýt ekleme iþlemi iptal edildiðinde ekranýn temizlenmesi, listenin tekrar doldurulmasý.
        Ekran_Temizle()
        Data_Oku()

        If Mode = "Add" Then
            Me.btnYeniEkle.Enabled = True
            Me.btnSil.Enabled = True
        End If

        'Guncelleme mod una geçilmesi..
        Mode = "Update"

    End Sub

    Private Sub lstMusteriler_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMusteriler.SelectedIndexChanged
        'Listeden seçilen kaydýn bilgilerinin textbox lara aktarýlmasý..
        Data_Aktar()
    End Sub

    Private Sub mnuYeniEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYeniEkle.Click
        btnYeniEkle_Click(sender, e)
    End Sub

    Private Sub mnuKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuKaydet.Click
        btnKaydet_Click(sender, e)
    End Sub

    Private Sub mnuIptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIptal.Click
        btnIptal_Click(sender, e)
    End Sub

    Private Sub mnuSecileniSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSecileniSil.Click
        btnSil_Click(sender, e)
    End Sub

    Private Sub mnuTumunuSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTumunuSil.Click
        DialogResult = MessageBox.Show("Tüm Kayýtlarýn Silinmesini istiyor musunuz?", "TÜM KAYITLARI SÝL", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If DialogResult = DialogResult.Yes Then
            DeleteMode = "Full"
            Data_Sil()
            Ekran_Temizle()
        End If
    End Sub

    Private Sub mnuCikis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCikis.Click
        btnAnaCikis_Click(sender, e)
    End Sub

    Private Sub btnAnaCikis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnaCikis.Click
        DialogResult = MessageBox.Show("Çýkmak istediðinize emin misiniz?", "ÇIKIÞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If DialogResult = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub cmnuYeniEkle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuYeniEkle.Click
        btnYeniEkle_Click(sender, e)
    End Sub

    Private Sub cmnuKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuKaydet.Click
        btnKaydet_Click(sender, e)
    End Sub

    Private Sub cmnuIptal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuIptal.Click
        btnIptal_Click(sender, e)
    End Sub

    Private Sub cmnuSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuSil.Click
        btnSil_Click(sender, e)
    End Sub

    Private Sub cmnuTumunuSil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTumunuSil.Click
        mnuTumunuSil_Click(sender, e)
    End Sub

    Private Sub cmnuTumMusSayisi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuTumMusSayisi.Click
        MessageBox.Show(Me.lstMusteriler.Items.Count & " adet kayýt listede vardýr..", "KAYIT SAYISI", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ayarlari_Oku()
        Mode = "Update"
        Data_Oku()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Opacity = 1
        End If
    End Sub

    Private Sub txtIsim_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIsim.TextChanged
        If Me.txtIsim.Text = "txtid" Then
            Me.lblId.Visible = True
            Me.txtID.Visible = True
        ElseIf Me.txtIsim.Text = "reset" Then
            Me.picBackGround.Image = Nothing
            Me.txtID.Visible = False
            Me.lblId.Visible = False
        ElseIf Me.txtIsim.Text = "myprogram" Then
            Me.picBackGround.Image = Image.FromFile(Application.StartupPath & "\background\Arabalar (74).jpg")
        ElseIf Me.txtIsim.Text = "alldelete" Then
            mnuTumunuSil_Click(sender, e)
        End If
    End Sub

    Private Sub mnuYazdir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuYazdir.Click
        Dim frm As New frmYazdir

        frm.ShowDialog()
    End Sub

    Private Sub txtAlinanGun_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlinanGun.TextChanged
        If IsNumeric(Me.txtAlinanGun.Text) = True Then
            Me.txtAlinanGun.Text = CInt(Me.txtAlinanGun.Text)
            Me.dtpTesEdTar.Text = Me.dtpTesEdTar.Value.AddDays(Me.txtAlinanGun.Text)
        End If
    End Sub

    Private Sub txtTesAlSaat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTesAlSaat.TextChanged
        Me.txtTesEdSaat.Text = Me.txtTesAlSaat.Text
    End Sub
#End Region


End Class
