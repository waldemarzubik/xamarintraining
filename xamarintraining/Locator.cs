using System;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using xamarintraining.Interfaces;
using xamarintraining.Services;
using xamarintraining.ViewModels;
using xamarintraining.ViewModels.Interfaces;

namespace xamarintraining
{
    public abstract class Locator
    {
        protected Locator()
        {
            SimpleIoc.Default.Register<IMainViewModel, MainViewModel>();
            SimpleIoc.Default.Register<ISecondViewModel, SecondViewModel>();
            SimpleIoc.Default.Register<IDataService, DataService>();
            SimpleIoc.Default.Register(Configure);
        }

        protected abstract INavigationService Configure();
    }
}
