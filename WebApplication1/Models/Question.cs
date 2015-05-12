using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinahProject.Models
{
    public class Question
    {
        private List<Theme> themeListValue;
        private Subject subjectValue;
        private List<ExtraPerson> extraPersonListValue;
        private AnswerSet answerSetValue;
        private String audioLocationValue;
        private String videoLocationValue;
        private String imageLocationValue;
        private String questionTextValue;

        public String QuestionText
        {
            get { return questionTextValue; }
            set { questionTextValue = value; }
        }
        

        public String ImageLocation
        {
            get { return imageLocationValue; }
            set { imageLocationValue = value; }
        }
        

        public String AudioLocation
        {
            get { return audioLocationValue; }
            set { audioLocationValue = value; }
        }

       

        public String VideoLocation
        {
            get { return videoLocationValue; }
            set { videoLocationValue = value; }
        }
        

        public AnswerSet AnswerSet
        {
            get { return answerSetValue; }
            set { answerSetValue = value; }
        }
        

        public List<ExtraPerson> ExtraPersonList
        {
            get { return extraPersonListValue; }
            set { extraPersonListValue = value; }
        }
        
        
        
        

        public List<Theme> ThemeList
        {
            get { return themeListValue; }
            set { themeListValue = value; }
        }

        public Subject Subject
        {
            get { return subjectValue; }
            set { subjectValue = value; }
        }
        
    }
}