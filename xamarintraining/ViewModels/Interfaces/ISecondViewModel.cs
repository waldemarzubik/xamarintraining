using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace xamarintraining.ViewModels.Interfaces
{
    public interface ISecondViewModel : INotifyPropertyChanged
    {
        IEnumerable<User> Items { get; }

        ICommand LoadDataCommand { get; }
    }
}
