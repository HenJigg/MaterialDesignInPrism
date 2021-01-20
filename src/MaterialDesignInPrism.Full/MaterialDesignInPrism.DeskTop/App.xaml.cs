using MaterialDesignInPrism.Core.Service;
using MaterialDesignInPrism.DeskTop.Views;
using MaterialDesignInPrism.DeskTop.Views.Dialogs;
using MaterialDesignThemes.Wpf;
using Prism.Ioc;
using System.Windows;

namespace MaterialDesignInPrism.DeskTop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<ShowView>();
            containerRegistry.Register<IDialogHostService, DialogHostService>();
        }
    }
}
