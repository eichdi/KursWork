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
            JumpTo_Reac.Add("DIALOG:START", null);
            JumpTo_Reac.Add("FUNC:Start()", Start);
            JumpTo_Reac.Add("FUNC:Test()", Test);
            JumpTo_Reac.Add("FUNC:SysDoc()", SysDoc);
            JumpTo_Reac.Add("FUNC:Quality()", Quality);
            JumpTo_Reac.Add("FUNC:End()", End);
            JumpTo_Reac.Add("FUNC:Show();DIALOG:END", Show);
            JumpTo_Reac.Add("DIALOG:END", Show);
        }

        //реакция на вопросы
        public string Rection(string jumpTo)
        {
            this.JumpTo_Reac[jumpTo]();
            if (jumpTo.StartsWith("DIALOG:"))
            {
                int i=7;
                while (i < jumpTo.Length && jumpTo != ";")
                {
                    i++;
                }
                return jumpTo.Substring(8, i);
            }
            else return null;
        }
    }
}
