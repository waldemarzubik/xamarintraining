using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace xamarintraining.Droid
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        private string _text;
        private ListView _listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Second);

            _text = Intent.GetStringExtra(MainActivity.PARAM);

            _listView = FindViewById<ListView>(Resource.Id.listView);
            _listView.Adapter = new ListAdapter(GetItems());
        }

        private IList<Item> GetItems()
        {
            var list = new List<Item>();
            for (int i = 0; i < 30; i++)
            {
                list.Add(new Item
                {
                    Name = $"Item {i + 1}",
                    DetailedText = $"This is my list item number {i + 1}"
                });
            }
            return list;
        }
    }
}
