
Option Strict On
Imports MahApps.Metro.Controls
Imports Prism.Regions

Class Main
    Inherits MetroWindow

    Private ReadOnly _regionManager As IRegionManager

    Private Sub HamburgerMenuControl_ItemInvoked(sender As Object, args As MahApps.Metro.Controls.HamburgerMenuItemInvokedEventArgs)

    End Sub

    Sub New(regionManager As IRegionManager)

        ' This call is required by the designer.

        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _regionManager = regionManager
        Prism.Regions.RegionManager.SetRegionManager(ContentRegion, regionManager)
        Prism.Regions.RegionManager.SetRegionName(ContentRegion, "ContentRegion")
        AddHandler Loaded, AddressOf WindowLoaded
    End Sub

    Private Sub WindowLoaded(sender As Object, e As RoutedEventArgs)
        '_regionManager.RequestNavigate("ContentRegion", "ViewName")
        '_regionManager.RequestNavigate("ContentRegion", "OrderProcessingView");
        '    HamburgerMenu.SelectedItem = HamburgerMenu.Items.OfType < MyMenuItem > ()
        '.FirstOrDefault(x >= x.NavigationPath == "OrderProcessingView");


        '    HamburgerMenu.ItemInvoked += HamburgerMenu_ItemInvoked;
        AddHandler HamburgerMenuControl.ItemInvoked, AddressOf HamburgerMenu_ItemInvoked

    End Sub

    Private Sub HamburgerMenu_ItemInvoked(sender As Object, args As HamburgerMenuItemInvokedEventArgs)
        Dim navPath = DirectCast(args.InvokedItem, MenuItemViewModel).NavigationPath
        _regionManager.RequestNavigate("ContentRegion", navPath)
    End Sub
End Class
