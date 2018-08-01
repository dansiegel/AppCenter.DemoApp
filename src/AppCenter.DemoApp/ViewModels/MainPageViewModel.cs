using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using AppCenter.DemoApp.Resources;
using Prism.Logging;

namespace AppCenter.DemoApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService,
                                 ILogger logger)
            : base(navigationService, pageDialogService, logger)
        {
            Title = AppResources.MainPageTitle;
        }


        {
        }
    }
}