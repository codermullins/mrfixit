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
using mrfixit.Resources.Model;

namespace mrfixit
{
    class EmpAdapter : BaseAdapter<Employee>
    {
        Employee[] emp;
        Activity context;

        public EmpAdapter(Activity context, Employee[] employee)
        {
            this.emp = employee;
            this.context = context;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Employee this[int position]
        {
            get
            {
                return emp[position];
            }
        }

        public override int Count
        {
            get
            {
                return emp.Length;
            }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if(view == null)
            {
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
                
            }

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = emp[position].ToString();
            return view;
        }
    }
}