using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marjetaUredi.Data.DataModels
{
    public class Workshop_User
    {
        public int RelationID { get; set; }
        public int UserID { get; set; }
        public int WorkshopID { get; set; }
        public DateTime DateStamp { get; set; }

        public Workshop_User(int RelationID_, int UserID_, int WorkshopID_, DateTime DateStamp_)
        {
            this.RelationID = RelationID_;
            this.UserID = UserID_;
            this.WorkshopID = WorkshopID_;
            this.DateStamp = DateStamp_;
        }
    }
}
