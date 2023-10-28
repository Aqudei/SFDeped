Imports Prism.Mvvm

Public MustInherit Class PageBase
    Inherits BindableBase
    Public MustOverride ReadOnly Property Title As String
    Public Shared UIDispatcher = Application.Current.Dispatcher

End Class
