using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using xamarintraining.ViewModels.Interfaces;

namespace xamarintraining.ViewModels
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private string _searchCriteria;
        private readonly INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService ??
                throw new ArgumentException($"Missing {nameof(INavigationService)}");

            SearchCriteria = "default";
            ClickCommand = new RelayCommand(ClickAction);
        }

        public string SearchCriteria
        {
            get { return _searchCriteria; }
            set
            {
                _searchCriteria = value;
                RaisePropertyChanged();
            }
        }

        public ICommand ClickCommand { get; private set; }

        private void ClickAction()
        {
            _navigationService.NavigateTo(PageKeys.SECOND_VIEW, SearchCriteria);
        }

    }
}
