Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports Prism.Commands
Imports Prism.Services.Dialogs

Public Class SubjectsViewModel
    Inherits PageBase
    Private _subjects As ICollectionView
    Private _subjectsList As New ObservableCollection(Of StudentItemViewModel)
    Public Property Subjects() As ICollectionView
        Get
            Return _subjects
        End Get
        Set(ByVal value As ICollectionView)
            SetProperty(_subjects, value)
        End Set
    End Property

    Public Overrides ReadOnly Property Title As String
        Get
            Return "Subjects"
        End Get
    End Property

    Sub New(pDialogService As IDialogService)
        Subjects = CollectionViewSource.GetDefaultView(_subjectsList)
        _dialogService = pDialogService
    End Sub

    Private _newItemCommand As DelegateCommand
    Private ReadOnly _dialogService As IDialogService

    Public ReadOnly Property NewItemCommand() As DelegateCommand
        Get
            _newItemCommand = If(IsNothing(_newItemCommand), New DelegateCommand(AddressOf HandleNewItem), _newItemCommand)
            Return _newItemCommand
        End Get
    End Property

    Private Sub HandleNewItem()
        '_dialogService.ShowDialog("SubjectCrud")
    End Sub
End Class
