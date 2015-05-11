using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinahProject.Models
{
    public class AnswerSet
    {
        private String nameValue;
        private List<Answer> answerListValue;

        public List<Answer> AnswerList
        {
            get { return answerListValue; }
            set { answerListValue = value; }
        }
        

        public String Name
        {
            get { return nameValue; }
            set { nameValue = value; }
        }
        
    }
}
