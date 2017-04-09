using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Xamarin_ListView
{
    class ListViewAdapter: BaseAdapter<string>
    {
        private List<string> _items;
        private Context _context;

        public ListViewAdapter(Context context, List<string> items)
        {
            _context = context;
            _items = items;
        }

        public override long GetItemId (int position)
        {
            return position;
        }

        public override View GetView (int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From (_context).Inflate (Resource.Layout.listview_row, null, false);
            }

            TextView txtName = row.FindViewById<TextView> (Resource.Id.txtName);

            txtName.Text = _items[position];

            return row;
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override string this [int position]
        {
            get { return _items[position]; }
        }
    }
}