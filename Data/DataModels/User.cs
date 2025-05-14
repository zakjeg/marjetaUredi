using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marjetaUredi.Data.DataModels
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Class { get; set; }
        public int Age { get; set; }
        public byte FotoPermit { get; set; }
        public string AddInfo { get; set; }
        public string RfidUID { get; set; }


        public User(int ID_, string FirstName_, string LastName_, int Class_, int Age_, byte FotoPermit_, string AddInfo_, string RfidUID_)
        {
            this.ID = ID_;
            this.FirstName = FirstName_;
            this.LastName = LastName_;
            this.Class = Class_;
            this.Age = Age_;
            this.FotoPermit = FotoPermit_;
            this.AddInfo = AddInfo_;
            this.RfidUID = RfidUID_;
        }
        //public User()
        //{
        //    this.ID = 0;
        //    this.FirstName = "";
        //    this.LastName = "";
        //    this.Class = 0;
        //    this.Age = 0;
        //    this.FotoPermit = 0;
        //    this.AddInfo = "";
        //    this.RfidUID = "";
        //}
    }
}
