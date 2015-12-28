using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;


namespace KursWorkV2
{
    public partial class DialogForm
    {
        string[] questions = MemQuestions();
        //string[] answers = MemAnswer();
        public static string[] MemQuestions()
        {
            string[] questions = new string[5];
            questions[0] = "Введите руководство по управлению проектом";
            questions[1] = "Введите руководство по тестированию";
            questions[2] = "Введите основные руководства по документированию";
            questions[3] = "Введите основное руководство оценке качества";
            questions[4] = "Где расположить готовую систему?";
            return questions;
        }
        //public static string[] MemAnswer()
        //{

        //}
        public void Metod0()
        {

            System.Windows.Forms.MessageBox.Show("Идет Диалог");
            //Thread.Sleep(100);
            System.Windows.Forms.MessageBox.Show("Система создана");
            
        }
        public void Metod1()
        {
            System.Windows.Forms.MessageBox.Show("Теститрование системы \n Система протестирована");

        }
        public void Metod2()
        {
            System.Windows.Forms.MessageBox.Show("Система задокументирована");

        }
        public void Metod3()
        {
            Random a = new Random();
            a.Next(10000, 100000);
            System.Windows.Forms.MessageBox.Show("Стоимость проекта составит "+a.Next(10, 100)+"000 , коэффициент качества"+a.Next(46, 100)+"%");

            
        }
        public void Metod4()
        {
            System.Windows.Forms.MessageBox.Show("Система с комплектом документов сформирована");
        }
       
        public void MetodAfterQuestion(string question)
        {
            switch (SearchQuest(question))
            {
                case -1: return;
                case 0: Metod0(); break;
                case 1: Metod1(); break;
                case 2: Metod2(); break;
                case 3: Metod3(); break;
                case 4: Metod4(); break;

            }
        }
        public int SearchQuest(string question)
        {
            int result = -1;
            for (int i = 0; i < questions.Length; i++)
            {
                if (questions[i] == question)
                {
                    return i;
                }
            }
                return result;
        }
        
    }
}
