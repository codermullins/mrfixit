using System;
using System.IO;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using mrfixit.Resources.Model;
using SQLite;
using mrfixit.Resources.DataHelper;

namespace mrfixit
{
    [Activity(Label = "DisplayEmployees")]
    public class DisplayEmployees : Activity
    {
        //path for database
        DAL db;

        //private List<string> empItems;
        private ListView empListView;
        private List<Employee> mListView;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            db = new DAL();
            mListView = db.GetEmployee();
            SetContentView(Resource.Layout.employeeList);
            empListView = FindViewById<ListView>(Resource.Id.myListView);

            //ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.employeeList, db.GetEmployee());
            EmpListViewAdapter adapter = new EmpListViewAdapter(this, mListView);

            empListView.Adapter = adapter;
        }

    }
}