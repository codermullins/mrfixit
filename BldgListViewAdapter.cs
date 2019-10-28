using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using Java.Lang;
using mrfixit.Resources.Model;

namespace mrfixit
{
    //class BldgListViewAdapter : BaseAdapter
    //{
        //private List<Building> myItems;
        //private Context mContext;

        //public BldgListViewAdapter(Context context, List<Building> items)
        //{
        //    myItems = items;
        //    mContext = context;
        //}
        //public override int Count
        //{
        //    get { return myItems.Count; }
        //}

        //public override long GetItemId(int position)
        //{
        //    return position;
        //}

        //public override Building this[int position]
        //{
        //    get
        //    {
        //        return myItems[position];
        //    }
        //}

        //public override View GetView(int position, View convertView, ViewGroup parent)
        //{
        //    View row = convertView;

        //    if (row == null)
        //    {
        //        row = LayoutInflater.From(mContext).Inflate(Resource.Layout.empRow, null, false);
        //    }

        //    TextView textBldgNum = row.FindViewById<TextView>(Resource.Id.textBldgNum);
        //    textBldgNum.Text = myItems[position];

        //    return row;
        //}


    //}
}