using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marjetaUredi.Data.DataModels
{
    public class Workshop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Mentor { get; set; }
        public int AgeLimit { get; set; }
        public int AgeRequirement { get; set; }

        public Workshop(int ID_, string Name_, string About_, string Mentor_, int AgeLimit_, int AgeRequirement_)
        {
            this.ID = ID_;
            this.Name = Name_;
            this.About = About_;
            this.Mentor = Mentor_;
            this.AgeLimit = AgeLimit_;
            this.AgeRequirement = AgeRequirement_;
        }
    }
}
