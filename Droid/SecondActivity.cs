using System.Linq;
using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Views;
using GalaSoft.MvvmLight.Helpers;
using xamarintraining.ViewModels.Interfaces;

namespace xamarintraining.Droid
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : ActivityBase<ISecondViewModel>
    {
        private string _text;
        private RecyclerView _recyclerView;
        private ObservableRecyclerAdapter<User, RecyclerView.ViewHolder> _adapter;
        private object _parameter;
        //private ListView _listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Second);

            _recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            _recyclerView.SetLayoutManager(new LinearLayoutManager
                                           (this, LinearLayoutManager.Vertical, false));

            //reading parameter from first page (this should be done in mvvm on view model side)
            //_parameter = ((NavigationService)SimpleIoc.Default.GetService(typeof(INavigationService))).GetAndRemoveParameter(Intent);


            //_listView = FindViewById<ListView>(Resource.Id.listView);
            //_listView.Adapter = new ListAdapter(GetItems());
        }

        protected override void OnStart()
        {
            base.OnStart();
            ViewModel.PropertyChanged += ViewModel_PropertyChanged;

            ViewModel.LoadDataCommand.Execute(_parameter);
        }

        protected override void OnStop()
        {
            ViewModel.PropertyChanged -= ViewModel_PropertyChanged;
            base.OnStop();
        }

        protected override void OnCreateBindings()
        {
            base.OnCreateBindings();
        }

        void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (nameof(ViewModel.Items).Equals(e.PropertyName) && ViewModel.Items != null)
            {
                _adapter = ViewModel.Items.ToList().GetRecyclerAdapter(BindViewHolder, CreateView, null);
                _recyclerView.SetAdapter(_adapter);
            }
        }

        private RecyclerView.ViewHolder CreateView(ViewGroup parent, int type)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var rawView = inflater.Inflate(Resource.Layout.ListItem, parent, false);
            return new RecyclerViewHolder(rawView);
        }

        private void BindViewHolder(RecyclerView.ViewHolder holder,
                                    User taskModel,
                                    int position)
        {
            var viewHolder = (RecyclerViewHolder)holder;

            var item = ViewModel.Items.ToList()[position];
            viewHolder.Name.Text = item.Login;
            viewHolder.Detail.Text = item.Type;
        }
    }
}
