using Android.App;
using Android.OS;
using Android.Widget;
using System.IO;
using System;
using mrfixit.Resources.Model;
using System.Linq;
using mrfixit.Resources.DataHelper;

namespace mrfixit
{
    [Activity( Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //path for database
        DAL db = new DAL();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            db.CreateEmpTable();

            base.OnCreate(savedInstanceState);
            // Set view from main layout
            SetContentView(Resource.Layout.employeeLogin);
            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Click += delegate
            {

                string empId = FindViewById<EditText>(Resource.Id.editEmpID).Text;
                string psw = FindViewById<EditText>(Resource.Id.editPassword).Text;

                
                if (db.Valid(empId, psw))
                {
                    Toast.MakeText(this, "Login Successful", ToastLength.Short).Show();
                    StartActivity(typeof(navMenu));
                }
                else
                {
                    Toast.MakeText(this, "Invalid Employee ID or password!!", ToastLength.Long).Show();
                }
            };
        }

    }
}