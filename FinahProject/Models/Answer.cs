using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinahProject.Models
{
    public class Answer
    {
        private String nameValue;
        private Question extraQuestionValue;

        public Question ExtraQuestion
        {
            get { return extraQuestionValue; }
            set { extraQuestionValue = value; }
        }
        

        public String Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }
        
    }
}
