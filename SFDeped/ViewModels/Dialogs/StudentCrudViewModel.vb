
Imports Prism.Commands
Imports Prism.Services.Dialogs

Public Class StudentCrudViewModel
    Inherits PageBase
    Implements IDialogAware


    Public Overrides ReadOnly Property Title As String = "Students"

    Private ReadOnly Property IDialogAware_Title As String Implements IDialogAware.Title
        Get
            Return Title
        End Get
    End Property

    Sub New()
        Title += " - "
    End Sub

    Public Function CanCloseDialog() As Boolean Implements IDialogAware.CanCloseDialog
        Return True
    End Function

    Public Sub OnDialogClosed() Implements IDialogAware.OnDialogClosed

    End Sub

    Public Event RequestClose As Action(Of IDialogResult) Implements IDialogAware.RequestClose

    Public Sub OnDialogOpened(parameters As IDialogParameters) Implements IDialogAware.OnDialogOpened

    End Sub

    Private _dialogCommand As DelegateCommand(Of String)
    Public ReadOnly Property DialogCommand() As DelegateCommand(Of String)
        Get
            Return If(IsNothing(_dialogCommand), New DelegateCommand(Of String)(AddressOf HandleCommand), _dialogCommand)
        End Get
    End Property

    Private Sub HandleCommand(cmd As String)
        Select Case cmd.ToLower
            Case "ok"

            Case "cancel"
                RaiseEvent RequestClose(New DialogResult(ButtonResult.Cancel))
            Case Else

        End Select
    End Sub
End Class
