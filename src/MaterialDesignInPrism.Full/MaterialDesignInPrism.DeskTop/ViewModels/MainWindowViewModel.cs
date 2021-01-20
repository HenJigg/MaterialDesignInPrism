using MaterialDesignInPrism.Core.Service;
using MaterialDesignInPrism.DeskTop.Views.Dialogs;
using MaterialDesignThemes.Wpf;
using Prism.Commands;
using Prism.Mvvm;
using System;
using MaterialDesignInPrism.Core.Extensions;

namespace MaterialDesignInPrism.DeskTop.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IDialogHostService dialog;

        public MainWindowViewModel(IDialogHostService dialog)
        {
            HomeCommand = new DelegateCommand(GoHome);
            this.dialog = dialog;
        }

        public DelegateCommand HomeCommand { get; private set; }


        private async void GoHome()
        {
            var result = await dialog.ShowDialog("ShowView");
        }
    }
}
