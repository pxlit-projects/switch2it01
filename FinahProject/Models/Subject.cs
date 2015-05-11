using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinahProject.Models
{
    public class Subject
    {
        private String nameValue;
        private String descriptionValue;

        public String Description
        {
            get { return descriptionValue; }
            set { descriptionValue = value; }
        }
        

        public String Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }
        
    }
}
