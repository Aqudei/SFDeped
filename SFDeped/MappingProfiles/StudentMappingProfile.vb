Imports AutoMapper

Public Class StudentMappingProfile
    Inherits Profile

    Public Sub New()
        CreateMap(Of Student, StudentItemViewModel)().ReverseMap()
    End Sub
End Class
