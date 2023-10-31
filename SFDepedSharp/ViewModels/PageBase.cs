using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SFDepedSharp.ViewModels
{
    public abstract class PageBase
    {
        public abstract string Title { get; }

        public static Dispatcher UIDispatcher { get; set; } = Dispatcher.CurrentDispatcher;
    }
}
