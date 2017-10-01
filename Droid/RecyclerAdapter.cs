using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace xamarintraining.Droid
{
    public class RecyclerAdapter : RecyclerView.Adapter
    {
        private IList<Item> _items;

        public RecyclerAdapter(IList<Item> items)
        {
            _items = items;
        }

        public override int ItemCount => _items.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = (RecyclerViewHolder)holder;

            var item = _items[position];

            viewHolder.Name.Text = item.Name;
            viewHolder.Detail.Text = item.DetailedText;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var inflater = LayoutInflater.From(parent.Context);

            var rawView = inflater.Inflate(Resource.Layout.ListItem, parent, false);

            return new RecyclerViewHolder(rawView);
        }
    }

    public class RecyclerViewHolder : RecyclerView.ViewHolder
    {
        public TextView Name { get; }

        public TextView Detail { get; }

        public RecyclerViewHolder(View view) : base(view)
        {
            Name = view.FindViewById<TextView>(Resource.Id.name);
            Detail = view.FindViewById<TextView>(Resource.Id.detail);
        }
    }
}
