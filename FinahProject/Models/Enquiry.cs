using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinahProject.Models
{
    public class Enquiry
    {
        private List<Theme> themeListValue;
        private List<Subject> subjectListValue;
        private List<Question> questionListValue;
        private List<ExtraPerson> extraPersonListValue;
        private List<AnswerSet> answerSetListValue;
        private String nameValue;
        private String descriptionValue;
        private List<Detail> detailListValue;
        
        public List<Detail> DetailList
        {
            get { return detailListValue; }
            set { detailListValue = value; }
        }
        

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
        

        public List<AnswerSet> AnswerSetList
        {
            get { return answerSetListValue; }
            set { answerSetListValue = value; }
        }
        

        public List<ExtraPerson> ExtraPersonList
        {
            get { return extraPersonListValue; }
            set { extraPersonListValue = value; }
        }
        

        public List<Question> QuestionList
        {
            get { return questionListValue; }
            set { questionListValue = value; }
        }
        

        public List<Subject> SubjectList
        {
            get { return subjectListValue; }
            set { subjectListValue = value; }
        }
        

        public List<Theme> ThemeList
        {
            get { return themeListValue; }
            set { themeListValue = value; }
        }
        
    }
}