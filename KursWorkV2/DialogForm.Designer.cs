namespace KursWorkV2
{
    partial class DialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HowCreateQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HowWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.qaTable = new System.Windows.Forms.DataGridView();
            this.errBox = new System.Windows.Forms.RichTextBox();
            this.questBox = new System.Windows.Forms.RichTextBox();
            this.ansBox = new System.Windows.Forms.RichTextBox();
            this.ansText = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.answerСomboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(406, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDialog,
            this.OpenDialogToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // newDialog
            // 
            this.newDialog.Name = "newDialog";
            this.newDialog.Size = new System.Drawing.Size(162, 22);
            this.newDialog.Text = "Новый диалог";
            this.newDialog.Click += new System.EventHandler(this.NewDialog);
            // 
            // OpenDialogToolStripMenuItem
            // 
            this.OpenDialogToolStripMenuItem.Name = "OpenDialogToolStripMenuItem";
            this.OpenDialogToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.OpenDialogToolStripMenuItem.Text = "Открыть диалог";
            this.OpenDialogToolStripMenuItem.Click += new System.EventHandler(this.OpenDialog);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowCreateQuestionsToolStripMenuItem,
            this.DocToolStripMenuItem,
            this.HowWorkToolStripMenuItem,
            this.AboutProgToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aboutToolStripMenuItem.Text = "Справка";
            // 
            // HowCreateQuestionsToolStripMenuItem
            // 
            this.HowCreateQuestionsToolStripMenuItem.Name = "HowCreateQuestionsToolStripMenuItem";
            this.HowCreateQuestionsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.HowCreateQuestionsToolStripMenuItem.Text = "Как строить дилог";
            this.HowCreateQuestionsToolStripMenuItem.Click += new System.EventHandler(this.HowCreateDialog);
            // 
            // DocToolStripMenuItem
            // 
            this.DocToolStripMenuItem.Name = "DocToolStripMenuItem";
            this.DocToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.DocToolStripMenuItem.Text = "Документация";
            this.DocToolStripMenuItem.Click += new System.EventHandler(this.Docume);
            // 
            // HowWorkToolStripMenuItem
            // 
            this.HowWorkToolStripMenuItem.Name = "HowWorkToolStripMenuItem";
            this.HowWorkToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.HowWorkToolStripMenuItem.Text = "Как работать";
            this.HowWorkToolStripMenuItem.Click += new System.EventHandler(this.HowWork);
            // 
            // AboutProgToolStripMenuItem
            // 
            this.AboutProgToolStripMenuItem.Name = "AboutProgToolStripMenuItem";
            this.AboutProgToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.AboutProgToolStripMenuItem.Text = "О программе";
            this.AboutProgToolStripMenuItem.Click += new System.EventHandler(this.AboutProg);
            // 
            // qaTable
            // 
            this.qaTable.AllowUserToAddRows = false;
            this.qaTable.AllowUserToDeleteRows = false;
            this.qaTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.qaTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.qaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qaTable.Location = new System.Drawing.Point(12, 171);
            this.qaTable.Name = "qaTable";
            this.qaTable.ReadOnly = true;
            this.qaTable.Size = new System.Drawing.Size(382, 123);
            this.qaTable.TabIndex = 1;
            // 
            // errBox
            // 
            this.errBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.errBox.Location = new System.Drawing.Point(11, 300);
            this.errBox.Name = "errBox";
            this.errBox.Size = new System.Drawing.Size(383, 20);
            this.errBox.TabIndex = 2;
            this.errBox.Text = "";
            // 
            // questBox
            // 
            this.questBox.Location = new System.Drawing.Point(12, 43);
            this.questBox.Name = "questBox";
            this.questBox.ReadOnly = true;
            this.questBox.Size = new System.Drawing.Size(188, 61);
            this.questBox.TabIndex = 3;
            this.questBox.Text = "";
            // 
            // ansBox
            // 
            this.ansBox.Location = new System.Drawing.Point(206, 43);
            this.ansBox.Name = "ansBox";
            this.ansBox.ReadOnly = true;
            this.ansBox.Size = new System.Drawing.Size(188, 61);
            this.ansBox.TabIndex = 4;
            this.ansBox.Text = "";
            // 
            // ansText
            // 
            this.ansText.Location = new System.Drawing.Point(12, 110);
            this.ansText.Name = "ansText";
            this.ansText.Size = new System.Drawing.Size(296, 20);
            this.ansText.TabIndex = 5;
            this.ansText.Text = "Введите ответ";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(314, 110);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(80, 20);
            this.ok.TabIndex = 6;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // answerСomboBox
            // 
            this.answerСomboBox.FormattingEnabled = true;
            this.answerСomboBox.Location = new System.Drawing.Point(11, 142);
            this.answerСomboBox.Name = "answerСomboBox";
            this.answerСomboBox.Size = new System.Drawing.Size(382, 21);
            this.answerСomboBox.TabIndex = 7;
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 332);
            this.Controls.Add(this.answerСomboBox);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.ansText);
            this.Controls.Add(this.ansBox);
            this.Controls.Add(this.questBox);
            this.Controls.Add(this.errBox);
            this.Controls.Add(this.qaTable);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qaTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.DataGridView qaTable;
        private System.Windows.Forms.RichTextBox errBox;
        private System.Windows.Forms.RichTextBox questBox;
        private System.Windows.Forms.RichTextBox ansBox;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDialog;
        private System.Windows.Forms.ToolStripMenuItem OpenDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HowCreateQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HowWorkToolStripMenuItem;
        private System.Windows.Forms.TextBox ansText;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.ToolStripMenuItem AboutProgToolStripMenuItem;
        private System.Windows.Forms.ComboBox answerСomboBox;
    }
}