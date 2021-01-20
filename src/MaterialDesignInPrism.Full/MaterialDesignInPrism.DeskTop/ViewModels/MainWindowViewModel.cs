using MaterialDesignInPrism.Core.Service;
using MaterialDesignInPrism.DeskTop.Views.Dialogs;
using MaterialDesignThemes.Wpf;
using Prism.Commands;
using Prism.Mvvm;
using System;
using MaterialDesignInPrism.Core.Extensions;
using System.Windows.Media;
using Prism.Regions;

namespace MaterialDesignInPrism.DeskTop.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;
        private readonly IDialogHostService dialog;

        public MainWindowViewModel(IRegionManager regionManager, IDialogHostService dialog)
        {
            this.regionManager = regionManager;
            this.dialog = dialog;
            HomeCommand = new DelegateCommand(GoHome);
        }


        public DelegateCommand HomeCommand { get; private set; }

        private void GoHome()
        {
            regionManager.Regions["ContentRegion"].RequestNavigate("SkinView");
            //var result = await dialog.ShowDialog("ShowView");
        }
    }
}
