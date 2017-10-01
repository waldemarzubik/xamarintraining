using System;
using System.Collections.Generic;
using Android.Views;
using Android.Widget;

namespace xamarintraining.Droid
{
    public class ListAdapter : BaseAdapter<Item>
    {
        private IList<Item> _items;

        public ListAdapter(IList<Item> items)
        {
            _items = items;
        }

        public override Item this[int position] => _items[position];

        public override int Count => _items.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ViewHolder holder = null;
            var rawView = convertView;

            if (rawView == null)
            {
                var inflater = LayoutInflater.From(parent.Context);

                //creating a view
                var view = inflater.Inflate(Resource.Layout.ListItem, parent, false);

                holder = new ViewHolder(view);
                view.Tag = holder;
            }
            else
            {
                holder = (ViewHolder)rawView.Tag;
            }

            //biding a view 
            var item = this[position];
            holder.Name.Text = item.Name;
            holder.Detail.Text = item.DetailedText;

            return rawView;
        }
    }

    public class ViewHolder : Java.Lang.Object
    {
        public TextView Name { get; }

        public TextView Detail { get; }

        public ViewHolder(View view)
        {
            Name = view.FindViewById<TextView>(Resource.Id.name);
            Detail = view.FindViewById<TextView>(Resource.Id.detail);
        }
    }
}
