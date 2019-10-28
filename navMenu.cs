using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;


namespace mrfixit
{
    [Activity(Label = "navMenu")]
    public class navMenu : Activity
    {
        private List<string> menuItems;
        private ListView menuListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.selectionMap);

            menuListView = FindViewById<ListView>(Resource.Id.menuList);


            menuItems = new List<string>();
            menuItems.Add("Building");
            menuItems.Add("Inventory");
            menuItems.Add("Employee");
            menuItems.Add("Workorders");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, menuItems);

            menuListView.Adapter = adapter;
            menuListView.ItemClick += ListViewClick;

        }
        void ListViewClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            switch (menuItems[e.Position])
            {
                case "Building":
                    StartActivity(typeof(DisplayBuilding));
                    break;
                case "Inventory":
                    StartActivity(typeof(Inventory));
                    break;
                case "Employee":
                    StartActivity(typeof(DisplayEmployees));
                    break;
                case "Workorders":
                    StartActivity(typeof(Workorders));
                    break;
            }
        }
    }
}