﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using DialogModel;

namespace KursWorkV2
{
    public partial class DialogForm : Form
    {
        string _path;
        ProgressDialogController controller;
        
        public DialogForm()
        {
            
            InitializeComponent();
            DataColumn colq = new DataColumn("Вопрос", typeof(String));
            DataColumn cola = new DataColumn("Ответ", typeof(String));
            DataTable dt = new DataTable();
            dt.Columns.Add(colq);
            dt.Columns.Add(cola);
            qaTable.DataSource = dt;
        }


        
        public void ShowToForm(QuestionElem question)
        {
            

        }
        //готовая форма
        public void ClearForm()
        {
            questBox.Text = "";
            errBox.Text= "";
            answerСomboBox.ContextMenu.MenuItems.Clear();
        }
        public AnswerElem GetAnswer()
        {
            return new AnswerElem(answerСomboBox.SelectedText, "");
        }

        public void NextQuestion()
        {
            if(controller.Ready)
            {
                QuestionElem question = controller.Next(GetAnswer());
                if (question != null)
                {

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Dialog is not ready");
            }
            
        }

        public void SaveToTable()
        {
            DataTable dt = (DataTable)qaTable.DataSource;
            DataRow newrow =  dt.NewRow();
            newrow["Вопрос"] = questBox.Text;
            newrow["Ответ"] = ansText.Text;
            dt.Rows.Add(newrow);
            qaTable.DataSource = dt;
        }



		private void ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok_Click");
        }

        private void NewDialog(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            Application.Run(new CreateDialog());
        }

        private void OpenDialog(object sender, EventArgs e)
        {
            FileDialog.ShowDialog();
            controller = new ProgressDialogController(FileDialog.FileName);
        }

        private void HowCreateDialog(object sender, EventArgs e)
        {
            MessageBox.Show("ЗАГЛУШКА");
        }

        private void Docume(object sender, EventArgs e)
        {
            MessageBox.Show("ЗАГЛУШКА");
        }

        private void HowWork(object sender, EventArgs e)
        {
            MessageBox.Show("ЗАГЛУШКА");
        }

        private void AboutProg(object sender, EventArgs e)
        {
            MessageBox.Show("Программа демонстрирует реиляционную модель данных.\n\n" +
				"Программа была создана как практическая часть курсовой работы по дисциплине" + 
				"\"Проектирование человеко-машинного интерфейса\" (ПЧМИ)\nВерсия программы 1.0 \n" +
				"Разработчик: студент КФУ ИВМиИТ 2 курса гр. 09-411 Хайрутдинов С.З.\n" +
				"Проверил: старший преподаватель кафедры технологий программирования" +
				"Георгиев В.О.", "Информация о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
