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
using SQLite;

namespace mrfixit.Resources.Model
{
    public class Workorder
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int BldgNumber { get; set; }
        public char AptLetter { get; set; }
        public string Description { get; set; }
        public string EmpID { get; set; }

        public Workorder(int bldgNumber, Char aptLetter, String Desc, String empID)
        {
            BldgNumber = bldgNumber;
            AptLetter = aptLetter;
            Description = Desc;
            EmpID = empID;
        }

        public Workorder()
        {

        }


            
    }

}