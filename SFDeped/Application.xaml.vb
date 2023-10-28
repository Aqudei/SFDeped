Imports AutoMapper
Imports Prism.DryIoc
Imports Prism.Ioc
Imports Prism.Regions

Class Application
    Inherits PrismApplication

    Protected Overrides Sub RegisterTypes(containerRegistry As IContainerRegistry)
        containerRegistry.RegisterForNavigation(Of Students)
        containerRegistry.RegisterForNavigation(Of Subjects)
        containerRegistry.RegisterDialog(Of StudentCrud)

        Dim config As New MapperConfiguration(Sub(cfg)
                                                  cfg.AddProfile(Of StudentMappingProfile)()
                                              End Sub)

        Dim mapper As IMapper = config.CreateMapper()
        containerRegistry.RegisterInstance(mapper)

    End Sub


    Protected Overrides Function CreateShell() As Window
        Return Container.Resolve(Of Main)
    End Function

    Protected Overrides Sub OnStartup(e As StartupEventArgs)
        MyBase.OnStartup(e)

        Dim regionManager = Container.Resolve(Of IRegionManager)

    End Sub



    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

End Class
