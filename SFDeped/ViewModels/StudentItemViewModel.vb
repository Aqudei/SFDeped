Imports Prism.Mvvm

Public Class StudentItemViewModel
    Inherits BindableBase

    Private _firstName As String

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            SetProperty(_id, value)
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set(ByVal value As String)
            SetProperty(_firstName, value)
        End Set
    End Property

    Private _middleName As String
    Public Property MiddleName() As String
        Get
            Return _middleName
        End Get
        Set(ByVal value As String)
            SetProperty(_middleName, value)
        End Set
    End Property

    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            SetProperty(_lastName, value)
        End Set
    End Property

    Private _learnerReferenceNumber As Integer
    Public Property LearnerReferenceNumber() As Integer
        Get
            Return _learnerReferenceNumber
        End Get
        Set(ByVal value As Integer)
            SetProperty(_learnerReferenceNumber, value)
        End Set
    End Property

End Class
