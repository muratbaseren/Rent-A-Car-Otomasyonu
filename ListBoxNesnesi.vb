Public Class ListBoxNesnesi

#Region "Yerel Degiskenler"
    Private mValue As String
    Private mID As Integer
#End Region

#Region "Kurucu Kod"
    Public Sub New(ByVal strValue As String, ByVal intID As Integer)
        mValue = strValue
        mID = intID
    End Sub

    Public Sub New()
        mValue = ""
        mID = 0
    End Sub
#End Region

#Region "Ozellikler"
    Property value()
        Get
            Return mValue
        End Get
        Set(ByVal Value)
            mValue = Value
        End Set
    End Property

    Property ID()
        Get
            Return mID
        End Get
        Set(ByVal Value)
            mID = Value
        End Set
    End Property
#End Region

#Region "Metotlar"
    Public Overrides Function ToString() As String
        Return mValue
    End Function
#End Region

End Class
