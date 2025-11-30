using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oprosik
{
    public class SurveyAnser
    {
        public string question { get; set; }
        public bool answer { get; set; }
        public int respondentId { get; set; }
        public int count { get; set; }
        public SurveyAnser(string question, bool answer, int respondentId)
        {
            this.question = question;
            this.answer = answer;
            this.respondentId = respondentId;
        } 
    }
}