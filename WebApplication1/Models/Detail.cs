using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinahProject.Models
{
    public class Detail
    {
        private String textValue;
        private Boolean isTitleValue;
        private Boolean isQuestionValue;
        private Boolean isOptionValue;
        private TextBox textBoxValue;
        private int rowValue;
        private int columnValue;

        public int Column
        {
            get { return columnValue; }
            set { columnValue = value; }
        }
        

        public int Row
        {
            get { return rowValue; }
            set { rowValue = value; }
        }
        

        public TextBox TextBox
        {
            get { return textBoxValue; }
            set { textBoxValue = value; }
        }
        

        public Boolean IsOption
        {
            get { return isOptionValue; }
            set { isOptionValue = value; }
        }
        

        public Boolean IsQuestion
        {
            get { return isQuestionValue; }
            set { isQuestionValue = value; }
        }
        

        public Boolean IsTitle
        {
            get { return isTitleValue; }
            set { isTitleValue = value; }
        }
        

        public String Text
        {
            get { return textValue; }
            set { textValue = value; }
        }
        
    }
}
