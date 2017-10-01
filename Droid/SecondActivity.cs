using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.Widget;

namespace xamarintraining.Droid
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        private string _text;
        private RecyclerView _recyclerView;
        //private ListView _listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Second);
            _recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            _recyclerView.SetLayoutManager(new LinearLayoutManager
                                           (this, LinearLayoutManager.Vertical, false));
            //_recyclerView.SetAdapter(new RecyclerAdapter(GetItems()));

            //_listView = FindViewById<ListView>(Resource.Id.listView);
            //_listView.Adapter = new ListAdapter(GetItems());
        }
    }
}
