using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.OS;
using Android.Widget;
using mrfixit.Resources.Model;
using SQLite;

namespace mrfixit.Resources.DataHelper
{
    class DAL
    {
        //path for database
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "EmployeeDB.sqlite");
        

        public List<Employee> GetEmployee()
        {
            //get list of employee from the database
            List<Employee> employee = new List<Employee>();

            //connnect to the DB
            var db = new SQLiteConnection(dbPath);
            
            //get everything from the Employee table
            TableQuery<Employee> empTable = db.Table<Employee>();

            //get the names into the list
            foreach (Employee emp in empTable)
            {
                employee.Add(emp);
            }
            return employee;
        }

        public void CreateEmpTable()
        {
            //setup connection to database
            var db = new SQLite.SQLiteConnection(dbPath);
            //create table
            db.CreateTable<Employee>();


            //create employee
            Employee emp1 = new Employee("9326", "Sam", "Samson", "P@ssword");
            Employee emp2 = new Employee("1203", "Bob", "Smith", "madness");


            ////store the object
            db.Insert(emp1);
            db.Insert(emp2);
        }

        public bool Valid(String empId, string psw)
        {

            //setup connection to database
            var db = new SQLite.SQLiteConnection(dbPath);
            var results = db.Table<Employee>().Where(x => x.EmpID == empId && x.Password == psw).ToList();
            if (results.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void CreateBldgTable()
        {
            //setup connection to database
            var db = new SQLite.SQLiteConnection(dbPath);
            //create table
            db.CreateTable<Building>();


            //create employee
            Building bldg1 = new Building(2564, 'A');
            Building bldg2 = new Building(8004, 'F');


            ////store the object
            db.Insert(bldg1);
            db.Insert(bldg2);
        }

        public List<string> GetBuilding()
        {

            //get list of employee from the database
            List<string> building = new List<string>();

            //connnect to the DB
            var db = new SQLiteConnection(dbPath);

            //get everything from the Employee table
            TableQuery<Building> bldgTable = db.Table<Building>();

            //get the names into the list
            foreach (Building bldg in bldgTable)
            {
                building.Add(Convert.ToString(bldg.BdlgNumber));
            }
            return building;
        }

        public void CreateWOTable()
        {
            //setup connection to database
            var db = new SQLite.SQLiteConnection(dbPath);
            //create table
            db.CreateTable<Workorder>();


            //create employee
            Workorder wo1 = new Workorder(2564, 'A', "Dishwasher Not draining", null);
            Workorder wo2 = new Workorder(8004, 'F', "AC unit not blowing cold air", "9326");


            ////store the object
            db.Insert(wo1);
            db.Insert(wo2);
        }

        public List<string> GetWorkorder()
        {

            //get list of employee from the database
            List<string> workOrder = new List<string>();

            //connnect to the DB
            var db = new SQLiteConnection(dbPath);

            //get everything from the Employee table
            TableQuery<Workorder> woTable = db.Table<Workorder>();

            //get the names into the list
            foreach (Workorder wOrder in woTable)
            {
                workOrder.Add(Convert.ToString(wOrder.ID));
            }
            return workOrder;
        }
    }
}