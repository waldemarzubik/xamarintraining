using Android.App;
using Android.OS;
using Android.Widget;
using GalaSoft.MvvmLight.Helpers;
using xamarintraining.ViewModels.Interfaces;

namespace xamarintraining.Droid
{
    [Activity(Label = "xamarin training", MainLauncher = true, Icon = "@mipmap/icon", Exported = true)]
    public class MainActivity : ActivityBase<IMainViewModel>
    {
        private Button _button;
        private TextView _text;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            _button = FindViewById<Button>(Resource.Id.searchButton);
            _text = FindViewById<TextView>(Resource.Id.searchEditText);
        }

        protected override void OnCreateBindings()
        {
            this.SetBinding(() => ViewModel.SearchCriteria, () => _text.Text, BindingMode.TwoWay);
            _button.SetCommand(ViewModel.ClickCommand);

            base.OnCreateBindings();
        }
    }
}

