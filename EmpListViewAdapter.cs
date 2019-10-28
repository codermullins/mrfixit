using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using mrfixit.Resources.Model;

namespace mrfixit
{
    public class EmpListViewAdapter : BaseAdapter<Employee>
    {
        private List<Employee> myItems;
        private Context mContext;

        public EmpListViewAdapter(Context context, List<Employee> items)
        {
            myItems = items;
            mContext = context;
        }
        public override int Count
        {
            get { return myItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Employee this[int position]
        {
            get { return myItems[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.empRow, null, false);
            }

            TextView textFName = row.FindViewById<TextView>(Resource.Id.textFName);
            textFName.Text = myItems[position].FName;

            TextView textLName = row.FindViewById<TextView>(Resource.Id.textLName);
            textLName.Text = myItems[position].LName;

            TextView textEmpID = row.FindViewById<TextView>(Resource.Id.textEmpID);
            textEmpID.Text = myItems[position].EmpID;

            return row;
        }
    }
}