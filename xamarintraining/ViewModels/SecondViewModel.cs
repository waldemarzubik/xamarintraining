using System;
using System.Collections.Generic;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using xamarintraining.Interfaces;
using xamarintraining.ViewModels.Interfaces;

namespace xamarintraining.ViewModels
{
    public class SecondViewModel : ViewModelBase, ISecondViewModel
    {
        private IDataService _dataService;
        private IEnumerable<User> _items;

        public SecondViewModel(IDataService dataService)
        {
            _dataService = dataService;
            LoadDataCommand = new RelayCommand<string>(LoadDataAction);
        }

        public IEnumerable<User> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                RaisePropertyChanged();
            }
        }

        public ICommand LoadDataCommand { get; private set; }

        public async void LoadDataAction(string searchCriteria)
        {
            Items = await _dataService.GetDataAsync(searchCriteria);
        }
    }
}
