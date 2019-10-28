using SQLite;

namespace mrfixit.Resources.Model
{
    class Building
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int BdlgNumber { get; set; }
        public char AptLetter { get; set; }


        public Building(int bldg, char apt)
        {
            BdlgNumber = bldg;
            AptLetter = apt;

        }

        public Building()
        {

        }
    }
}