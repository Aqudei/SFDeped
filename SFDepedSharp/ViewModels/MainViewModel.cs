using MahApps.Metro.Controls;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SFDepedSharp.ViewModels
{
    class MainViewModel : PageBase
    {
        private readonly IContainerProvider _container;

        public ObservableCollection<NavMenuItem> MenuItems { get; set; } = new();
        public ObservableCollection<NavMenuItem> OptionMenuItems { get; set; } = new();
        public override string Title => "DepEd School Forms - Project Fast";

        public MainViewModel(IContainerProvider container)
        {

            _container = container;

            SetupMenu();

        }

        private void SetupMenu()
        {
            var menuItems = _container.Resolve<ICollection<NavMenuItem>>("menuItems");
            MenuItems.AddRange(menuItems);

            var optionMenuItems = _container.Resolve<ICollection<NavMenuItem>>("optionMenuItems");
            OptionMenuItems.AddRange(optionMenuItems);
        }
    }

    public class NavMenuItem : HamburgerMenuIconItem
    {
        public Type? NavigationType { get; internal set; }
        public string? NavigationPath => NavigationType?.Name;
    }
}
