using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oprosik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SurveyAnser> survey = new List<SurveyAnser>();
            survey.Add(new SurveyAnser("Вопрос 1", true, 1));
            survey.Add(new SurveyAnser("Вопрос 2", false, 2));
            survey.Add(new SurveyAnser("Вопрос 3", false, 3));
            int ch = 0;
            foreach (var item in survey)
            {
                if (item.answer == true)
                {
                    ch++;
                }
                Console.WriteLine($"ответ = {item.answer}");
                
            }
            Console.WriteLine($"количество положительных= {ch}");
            Console.ReadLine();
        }
    }
}
