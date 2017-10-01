using System;
using System.ComponentModel;
using System.Windows.Input;

namespace xamarintraining.ViewModels.Interfaces
{
    public interface IMainViewModel : INotifyPropertyChanged
    {
        string SearchCriteria { get; set; }

        ICommand ClickCommand { get; }
    }
}
