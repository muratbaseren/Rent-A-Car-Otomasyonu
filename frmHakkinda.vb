Public Class frmHakkinda
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
    Friend WithEvents picBackground As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSorularBaslik As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHakkinda))
        Me.picBackground = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblSorularBaslik = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBackground.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBackground.Image = CType(resources.GetObject("picBackground.Image"), System.Drawing.Image)
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(624, 416)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblSorularBaslik
        '
        Me.lblSorularBaslik.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblSorularBaslik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSorularBaslik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSorularBaslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSorularBaslik.Location = New System.Drawing.Point(16, 352)
        Me.lblSorularBaslik.Name = "lblSorularBaslik"
        Me.lblSorularBaslik.Size = New System.Drawing.Size(256, 32)
        Me.lblSorularBaslik.TabIndex = 2
        Me.lblSorularBaslik.Text = "...::: Rent A Car Otomasyonu v1.0 :::..."
        Me.lblSorularBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(16, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 56)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "...::: Oser Copyright :::..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(16, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "...::: Tüm haklarý saklýdýr :::..."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHakkinda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 18)
        Me.ClientSize = New System.Drawing.Size(624, 416)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSorularBaslik)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picBackground)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHakkinda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHakkinda"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmHakkinda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Label1.Text = "Yazar : K.Murat BAÞEREN" & vbCrLf & vbCrLf & "...::: FreeWareSoft Copyright :::..."
    End Sub

    Private Sub picBackground_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBackground.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Shell("explorer.exe " & Application.StartupPath & "\InfoImg.jpg", AppWinStyle.NormalFocus)
    End Sub
End Class
