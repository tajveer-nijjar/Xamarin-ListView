using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace Xamarin_ListView
{
    [Activity(Label = "Xamarin_ListView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Person> items;
        private ListView listView;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);

            items = new List<Person>
            {
                new Person () {FirstName = "Bob", LastName = "Marshal"},
                new Person() { FirstName = "Sarah", LastName = "Marshal" }
            };

            listView = FindViewById<ListView> (Resource.Id.myListView);

            ListViewAdapter adapter = new ListViewAdapter (this, items);

            listView.Adapter = adapter;

            listView.ItemClick += ListViewOnItemClick;

            listView.LongClick += ListViewOnLongClick;
        }

        private void ListViewOnLongClick (object sender, View.LongClickEventArgs longClickEventArgs)
        {
            Console.WriteLine("Long clicked");
        }

        private void ListViewOnItemClick (object sender, AdapterView.ItemClickEventArgs itemClickEventArgs)
        {
            Console.WriteLine("Single clicked");

        }
    }
}

