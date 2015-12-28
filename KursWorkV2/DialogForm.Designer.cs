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
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.qaTable = new System.Windows.Forms.DataGridView();
            this.errBox = new System.Windows.Forms.RichTextBox();
            this.questBox = new System.Windows.Forms.RichTextBox();
            this.ansBox = new System.Windows.Forms.RichTextBox();
            this.ansText = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.фийлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйДиалог = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьДиалогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьДиалогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какВводитьВопросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.документацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какРаботатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фийлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(398, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // qaTable
            // 
            this.qaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qaTable.Location = new System.Drawing.Point(12, 307);
            this.qaTable.Name = "qaTable";
            this.qaTable.Size = new System.Drawing.Size(374, 138);
            this.qaTable.TabIndex = 1;
            // 
            // errBox
            // 
            this.errBox.Location = new System.Drawing.Point(12, 267);
            this.errBox.Name = "errBox";
            this.errBox.Size = new System.Drawing.Size(374, 24);
            this.errBox.TabIndex = 2;
            this.errBox.Text = "";
            // 
            // questBox
            // 
            this.questBox.Location = new System.Drawing.Point(12, 43);
            this.questBox.Name = "questBox";
            this.questBox.Size = new System.Drawing.Size(189, 61);
            this.questBox.TabIndex = 3;
            this.questBox.Text = "";
            // 
            // ansBox
            // 
            this.ansBox.Location = new System.Drawing.Point(12, 126);
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(188, 135);
            this.ansBox.TabIndex = 4;
            this.ansBox.Text = "";
            // 
            // ansText
            // 
            this.ansText.Location = new System.Drawing.Point(215, 138);
            this.ansText.Name = "ansText";
            this.ansText.Size = new System.Drawing.Size(170, 20);
            this.ansText.TabIndex = 5;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(219, 186);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(80, 33);
            this.ok.TabIndex = 6;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // фийлToolStripMenuItem
            // 
            this.фийлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйДиалог,
            this.сохранитьДиалогToolStripMenuItem,
            this.открытьДиалогToolStripMenuItem});
            this.фийлToolStripMenuItem.Name = "фийлToolStripMenuItem";
            this.фийлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.фийлToolStripMenuItem.Text = "Файл";
            // 
            // новыйДиалог
            // 
            this.новыйДиалог.Name = "новыйДиалог";
            this.новыйДиалог.Size = new System.Drawing.Size(171, 22);
            this.новыйДиалог.Text = "Новый диалог";
            this.новыйДиалог.Click += new System.EventHandler(this.новыйДиалогToolStripMenuItem_Click_1);
            // 
            // сохранитьДиалогToolStripMenuItem
            // 
            this.сохранитьДиалогToolStripMenuItem.Name = "сохранитьДиалогToolStripMenuItem";
            this.сохранитьДиалогToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.сохранитьДиалогToolStripMenuItem.Text = "Сохранить диалог";
            this.сохранитьДиалогToolStripMenuItem.Click += new System.EventHandler(this.сохранитьДиалогToolStripMenuItem_Click);
            // 
            // открытьДиалогToolStripMenuItem
            // 
            this.открытьДиалогToolStripMenuItem.Name = "открытьДиалогToolStripMenuItem";
            this.открытьДиалогToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.открытьДиалогToolStripMenuItem.Text = "Открыть диалог";
            this.открытьДиалогToolStripMenuItem.Click += new System.EventHandler(this.новыйДиалогToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какВводитьВопросыToolStripMenuItem,
            this.документацияToolStripMenuItem,
            this.какРаботатьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // какВводитьВопросыToolStripMenuItem
            // 
            this.какВводитьВопросыToolStripMenuItem.Name = "какВводитьВопросыToolStripMenuItem";
            this.какВводитьВопросыToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.какВводитьВопросыToolStripMenuItem.Text = "Как строить дилог";
            this.какВводитьВопросыToolStripMenuItem.Click += new System.EventHandler(this.какВводитьВопросыToolStripMenuItem_Click);
            // 
            // документацияToolStripMenuItem
            // 
            this.документацияToolStripMenuItem.Name = "документацияToolStripMenuItem";
            this.документацияToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.документацияToolStripMenuItem.Text = "Документация";
            // 
            // какРаботатьToolStripMenuItem
            // 
            this.какРаботатьToolStripMenuItem.Name = "какРаботатьToolStripMenuItem";
            this.какРаботатьToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.какРаботатьToolStripMenuItem.Text = "Как работать";
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 457);
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
        private System.Windows.Forms.ToolStripMenuItem фийлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйДиалог;
        private System.Windows.Forms.ToolStripMenuItem сохранитьДиалогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьДиалогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какВводитьВопросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какРаботатьToolStripMenuItem;
        private System.Windows.Forms.TextBox ansText;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}