
using Android.App;
using Android.OS;
using Android.Widget;
using mrfixit.Resources.DataHelper;
using mrfixit.Resources.Model;

namespace mrfixit
{
    [Activity(Label = "DisplayBuilding")]
    public class DisplayBuilding : Activity
    {
        //path for database
        DAL db;

        //private List<string> empItems;
        //private ListView empListView;
        //private List<Building> mListView;

        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);
        //    db = new DAL();
        //    mListView = db.GetBuilding();
        //    SetContentView(Resource.Layout.buildingList);
        //    empListView = FindViewById<ListView>(Resource.Id.myListView);

        //    //ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.employeeList, db.GetEmployee());
        //    BldgListViewAdapter adapter = new BldgListViewAdapter(this, mListView);

        //    empListView.Adapter = adapter;
        //}
    }
}