Option Strict On

Imports System.Collections.ObjectModel
Imports MahApps.Metro.Controls

Public Class MainViewModel
    Inherits PageBase

    Private _menuItems As New ObservableCollection(Of MenuItemViewModel)
    Private _optionMenuItems As New ObservableCollection(Of MenuItemViewModel)
    Public ReadOnly Property Menu() As ObservableCollection(Of MenuItemViewModel)
        Get
            Return _menuItems
        End Get
    End Property

    Public ReadOnly Property OptionsMenu() As ObservableCollection(Of MenuItemViewModel)
        Get
            Return _optionMenuItems
        End Get
    End Property



    Public Overrides ReadOnly Property Title As String
        Get
            Return "DEPED SCHOOL FORMS - PROJECT FAST"
        End Get
    End Property

    Public Sub New()
        SetupMenu()
    End Sub

    Private Sub SetupMenu()
        _menuItems.Add(New MenuItemViewModel With {
            .Label = "Subjects",
            .NavigationPath = "Subjects",
            .Icon = New MahApps.Metro.IconPacks.PackIconFontAwesome With {
                .Kind = MahApps.Metro.IconPacks.PackIconFontAwesomeKind.BookSolid
            }
        })

        '_menuItems.Add(New MenuItemViewModel With {
        '    .Label = "Grades",
        '    .Icon = New MahApps.Metro.IconPacks.PackIconFontAwesome With {
        '        .Kind = MahApps.Metro.IconPacks.PackIconFontAwesomeKind.DigitalTachographSolid
        '    }
        '})

        _menuItems.Add(New MenuItemViewModel With {
            .Label = "Students",
            .NavigationPath = "Students",
            .NavigationType = GetType(Students),
            .Icon = New MahApps.Metro.IconPacks.PackIconFontAwesome With {
                .Kind = MahApps.Metro.IconPacks.PackIconFontAwesomeKind.PeopleArrowsSolid
            }
        })

        _optionMenuItems.Add(New MenuItemViewModel With {
            .Label = "Settings",
            .NavigationPath = "Settings",
            .NavigationType = GetType(Settings),
            .Icon = New MahApps.Metro.IconPacks.PackIconFontAwesome With {
                .Kind = MahApps.Metro.IconPacks.PackIconFontAwesomeKind.ToolboxSolid
            }
        })

    End Sub
End Class
