namespace KursWorkV2
{
    partial class CreateDialog
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созадтьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какСозаватьДиалогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LableText = new System.Windows.Forms.RichTextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DarkGray;
            this.add.Location = new System.Drawing.Point(12, 355);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 33);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = false;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DarkGray;
            this.edit.Location = new System.Drawing.Point(112, 355);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(94, 33);
            this.edit.TabIndex = 5;
            this.edit.Text = "Редактировать";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Visible = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.DarkGray;
            this.enter.Location = new System.Drawing.Point(310, 355);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(94, 33);
            this.enter.TabIndex = 6;
            this.enter.Text = "Ок";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Visible = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkGray;
            this.back.Location = new System.Drawing.Point(410, 355);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(94, 33);
            this.back.TabIndex = 7;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = false;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox.Location = new System.Drawing.Point(112, 310);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(292, 20);
            this.textBox.TabIndex = 8;
            this.textBox.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(517, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созадтьToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // созадтьToolStripMenuItem
            // 
            this.созадтьToolStripMenuItem.Name = "созадтьToolStripMenuItem";
            this.созадтьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.созадтьToolStripMenuItem.Text = "Созадть";
            this.созадтьToolStripMenuItem.Click += new System.EventHandler(this.созадтьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.добавитьToolStripMenuItem.Text = "Открыть";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какСозаватьДиалогToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // какСозаватьДиалогToolStripMenuItem
            // 
            this.какСозаватьДиалогToolStripMenuItem.Name = "какСозаватьДиалогToolStripMenuItem";
            this.какСозаватьДиалогToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.какСозаватьДиалогToolStripMenuItem.Text = "Как создать диалог";
            this.какСозаватьДиалогToolStripMenuItem.Click += new System.EventHandler(this.какСозаватьДиалогToolStripMenuItem_Click);
            // 
            // LableText
            // 
            this.LableText.BackColor = System.Drawing.Color.Gainsboro;
            this.LableText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LableText.Location = new System.Drawing.Point(112, 245);
            this.LableText.Name = "LableText";
            this.LableText.Size = new System.Drawing.Size(292, 34);
            this.LableText.TabIndex = 10;
            this.LableText.Text = "";
            this.LableText.Visible = false;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(112, 27);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.ShowEditingIcon = false;
            this.Grid.Size = new System.Drawing.Size(292, 212);
            this.Grid.TabIndex = 13;
            this.Grid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_RowEnter);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkGray;
            this.delete.Location = new System.Drawing.Point(210, 355);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 33);
            this.delete.TabIndex = 14;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // CreateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(517, 438);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.LableText);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "CreateDialog";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созадтьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какСозаватьДиалогToolStripMenuItem;
        private System.Windows.Forms.RichTextBox LableText;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button delete;

    }
}

