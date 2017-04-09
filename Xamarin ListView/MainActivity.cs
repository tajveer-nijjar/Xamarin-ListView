using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin_ListView
{
    [Activity(Label = "Xamarin_ListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<string> items;
        private ListView listView;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            items = new List<string> ();
            items.Add ("Bob");
            items.Add ("Tom");
            items.Add ("Jim");

            listView = FindViewById<ListView> (Resource.Id.myListView);

            ArrayAdapter<string> adapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1, items);

            listView.Adapter = adapter;

        }
    }
}

