using Prism.DryIoc;
using Prism.Ioc;
using SFDepedSharp.ViewModels;
using SFDepedSharp.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SFDepedSharp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Main>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<ICollection<NavMenuItem>>(new List<NavMenuItem>
            {
                new NavMenuItem
                {
                    Label="Students",
                    Icon = new MahApps.Metro.IconPacks.PackIconMaterial
                    {
                        Kind=MahApps.Metro.IconPacks.PackIconMaterialKind.NaturePeople
                    },
                    NavigationType=typeof(Students),
                },
                
                new NavMenuItem
                {
                    Label="Subjects",
                    Icon = new MahApps.Metro.IconPacks.PackIconMaterial
                    {
                        Kind=MahApps.Metro.IconPacks.PackIconMaterialKind.Bookshelf
                    },
                    NavigationType=typeof(Subjects),
                },

                new NavMenuItem
                {
                    Label="Grades",
                    Icon = new MahApps.Metro.IconPacks.PackIconMaterial
                    {
                        Kind=MahApps.Metro.IconPacks.PackIconMaterialKind.Numeric
                    },
                    NavigationType = typeof(Grades) 
                },
            }, "menuItems");

            containerRegistry.RegisterInstance<ICollection<NavMenuItem>>(new List<NavMenuItem>
            {
                new NavMenuItem
                {
                    Label="Settings",
                    Icon = new MahApps.Metro.IconPacks.PackIconMaterial
                    {
                        Kind=MahApps.Metro.IconPacks.PackIconMaterialKind.Tools
                    },
                    NavigationType=typeof(Settings)
                }
            }, "optionMenuItems");

            foreach (var item in Container.Resolve<ICollection<NavMenuItem>>("menuItems"))
            {
                if (item.NavigationType != null)
                    containerRegistry.RegisterForNavigation(item.NavigationType, item.NavigationPath);
            }


            foreach (var item in Container.Resolve<ICollection<NavMenuItem>>("optionMenuItems"))
            {
                if (item.NavigationType != null)
                    containerRegistry.RegisterForNavigation(item.NavigationType, item.NavigationPath);
            }




        }
    }
}
