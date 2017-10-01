using System;
using GalaSoft.MvvmLight.Views;

namespace xamarintraining.Droid
{
    public class AndroidLocator : Locator
    {
        protected override INavigationService Configure()
        {
            var navigationService = new NavigationService();
            navigationService.Configure(PageKeys.SECOND_VIEW, typeof(SecondActivity));

            return navigationService;
        }
    }
}
