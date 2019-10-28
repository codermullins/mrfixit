using SQLite;

namespace mrfixit.Resources.Model
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string EmpID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }

        public Employee (string empID, string fName, string lName, string password)
        {
            EmpID = empID;
            FName = fName;
            LName = lName;
            Password = password;
        }

        public Employee()
        {

        }
       
    }


}