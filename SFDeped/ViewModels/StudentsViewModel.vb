Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports Prism.Commands
Imports Prism.Services.Dialogs

Public Class StudentsViewModel
    Inherits PageBase
    Private _students As ICollectionView
    Private _studentList As New ObservableCollection(Of StudentItemViewModel)
    Public Property Students() As ICollectionView
        Get
            Return _students
        End Get
        Set(ByVal value As ICollectionView)
            SetProperty(_students, value)
        End Set
    End Property

    Public Overrides ReadOnly Property Title As String
        Get
            Return "Students"
        End Get
    End Property

    Sub New(pDialogService As IDialogService)
        Students = CollectionViewSource.GetDefaultView(_studentList)
        _dialogService = pDialogService
    End Sub

    Private _newStudentCommand As DelegateCommand
    Private ReadOnly _dialogService As IDialogService

    Public ReadOnly Property NewStudentCommand() As DelegateCommand
        Get
            _newStudentCommand = If(IsNothing(_newStudentCommand), New DelegateCommand(AddressOf HandleNewStudent), _newStudentCommand)
            Return _newStudentCommand
        End Get
    End Property

    Private Sub HandleNewStudent()
        _dialogService.ShowDialog("StudentCrud")
    End Sub
End Class
