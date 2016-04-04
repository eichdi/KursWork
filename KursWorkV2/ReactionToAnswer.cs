using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace React
{
    public delegate void Function();
    class ReactionToAnswer
    {
        //пишем функции для рекции на вопросы
        protected void Show()
        {
            System.Windows.Forms.MessageBox.Show("Хороший денек");
        }
        protected void Start()
        {

            System.Windows.Forms.MessageBox.Show("Идет Диалог");
            //Thread.Sleep(100);
            System.Windows.Forms.MessageBox.Show("Система создана");

        }
        protected void Test()
        {
            System.Windows.Forms.MessageBox.Show("Теститрование системы \n Система протестирована");

        }
        protected void SysDoc()
        {
            System.Windows.Forms.MessageBox.Show("Система задокументирована");

        }
        protected void Quality()
        {
            Random a = new Random();
            a.Next(10000, 100000);
            System.Windows.Forms.MessageBox.Show("Стоимость проекта составит " + a.Next(10, 100) + "000 , коэффициент качества" + a.Next(46, 100) + "%");


        }
        protected void End()
        {
            System.Windows.Forms.MessageBox.Show("Система с комплектом документов сформирована");
        }



        Dictionary<string, Function> JumpTo_Reac = new Dictionary<string, Function>();
        public ReactionToAnswer(Dictionary<string, Function> JumpTo_Reac)
        {
            this.JumpTo_Reac = JumpTo_Reac;
        }
        public ReactionToAnswer()
        {
            //заполнение строго по верхнему регистру 
            JumpTo_Reac.Add("DIALOG:START", null);
            JumpTo_Reac.Add("FUNC:START()", Start);
            JumpTo_Reac.Add("FUNC:TEST()", Test);
            JumpTo_Reac.Add("FUNC:SYSDOC()", SysDoc);
            JumpTo_Reac.Add("FUNC:QUALITY()", Quality);
            JumpTo_Reac.Add("FUNC:END()", End);
            JumpTo_Reac.Add("FUNC:SHOW()", Show);
            JumpTo_Reac.Add("DIALOG:END", Show);
        }

        
        private static string GetBy(string jumpTo, string word)
        {
            word += ":";
            //быдлокод написан на пьяную голову где нужны регулярные выражения а у меня нет интернета
            jumpTo = jumpTo.ToUpper();
            int i;
            for (i = 0; i + 7 < jumpTo.Length; i++)
            {
                if (word == jumpTo.Substring(i, 7))
                {
                    i += 7;
                    int start = i;
                    while (jumpTo[i] != ';' || i < jumpTo.Length)
                    {
                        i++;
                    }
                    return jumpTo.Substring(start, i);
                }
            }
            return null;
        }
        public static string GetDialogName(string jumpTo)
        {
            return GetBy(jumpTo, "Dialog");
        }
        public static string GetFuncName(string jumpTo)
        {
            return GetBy(jumpTo, "FUNC");
        }
        //реакция на вопросы
        public string Rection(string jumpTo)
        {
            this.JumpTo_Reac["FUNC:"+ReactionToAnswer.GetFuncName(jumpTo)]();
            return ReactionToAnswer.GetDialogName(jumpTo);
        }
    }
}
