Imports MahApps.Metro.Controls

Public Class MenuItemViewModel
    Inherits HamburgerMenuIconItem

    Private _navigationPath As String
    Public Property NavigationPath() As String
        Get
            Return _navigationPath
        End Get
        Set(ByVal value As String)
            _navigationPath = value
        End Set
    End Property
    Private _navigationType As Type
    Public Property NavigationType() As Type
        Get
            Return _navigationType
        End Get
        Set(ByVal value As Type)
            _navigationType = value
        End Set
    End Property
End Class
