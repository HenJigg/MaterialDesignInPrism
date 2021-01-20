using MaterialDesignInPrism.DeskTop.Views;
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

        }
    }
}
