namespace Task1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary
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
            this.subfolderCheckBox = new System.Windows.Forms.CheckBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resultList = new System.Windows.Forms.ListBox();
            this.numericUpFrom = new System.Windows.Forms.NumericUpDown();
            this.numericUpTo = new System.Windows.Forms.NumericUpDown();
            this.currentFile = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.folder = new System.Windows.Forms.Label();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.readOnlycheckBox = new System.Windows.Forms.CheckBox();
            this.hiddencheckBox = new System.Windows.Forms.CheckBox();
            this.attr = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpTo)).BeginInit();
            this.SuspendLayout();
            // 
            // subfolderCheckBox
            // 
            this.subfolderCheckBox.AutoSize = true;
            this.subfolderCheckBox.Location = new System.Drawing.Point(379, 131);
            this.subfolderCheckBox.Name = "subfolderCheckBox";
            this.subfolderCheckBox.Size = new System.Drawing.Size(139, 17);
            this.subfolderCheckBox.TabIndex = 0;
            this.subfolderCheckBox.Text = "Поиск в подкаталогах";
            this.subfolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(12, 403);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(219, 403);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 5;
            this.stop_btn.Text = "Остановить";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Выбрать папку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Настройки поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Размер (КБ)";
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Location = new System.Drawing.Point(452, 196);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(110, 20);
            this.datePickerFrom.TabIndex = 12;
            // 
            // datePickerTo
            // 
            this.datePickerTo.Location = new System.Drawing.Point(598, 196);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(127, 20);
            this.datePickerTo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ограничения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "от";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "до";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "с";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "по";
            // 
            // resultList
            // 
            this.resultList.FormattingEnabled = true;
            this.resultList.Location = new System.Drawing.Point(12, 98);
            this.resultList.Name = "resultList";
            this.resultList.Size = new System.Drawing.Size(282, 277);
            this.resultList.TabIndex = 23;
            // 
            // numericUpFrom
            // 
            this.numericUpFrom.Location = new System.Drawing.Point(482, 227);
            this.numericUpFrom.Name = "numericUpFrom";
            this.numericUpFrom.Size = new System.Drawing.Size(80, 20);
            this.numericUpFrom.TabIndex = 24;
            // 
            // numericUpTo
            // 
            this.numericUpTo.Location = new System.Drawing.Point(598, 227);
            this.numericUpTo.Name = "numericUpTo";
            this.numericUpTo.Size = new System.Drawing.Size(80, 20);
            this.numericUpTo.TabIndex = 26;
            // 
            // currentFile
            // 
            this.currentFile.Location = new System.Drawing.Point(0, 0);
            this.currentFile.Name = "currentFile";
            this.currentFile.Size = new System.Drawing.Size(100, 23);
            this.currentFile.TabIndex = 30;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(379, 358);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 1;
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(0, 0);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(100, 23);
            this.folder.TabIndex = 0;
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(216, 51);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(0, 13);
            this.folderPathLabel.TabIndex = 31;
            // 
            // readOnlycheckBox
            // 
            this.readOnlycheckBox.AutoSize = true;
            this.readOnlycheckBox.Location = new System.Drawing.Point(379, 295);
            this.readOnlycheckBox.Name = "readOnlycheckBox";
            this.readOnlycheckBox.Size = new System.Drawing.Size(74, 17);
            this.readOnlycheckBox.TabIndex = 33;
            this.readOnlycheckBox.Text = "Read only";
            this.readOnlycheckBox.UseVisualStyleBackColor = true;
            // 
            // hiddencheckBox
            // 
            this.hiddencheckBox.AutoSize = true;
            this.hiddencheckBox.Location = new System.Drawing.Point(379, 319);
            this.hiddencheckBox.Name = "hiddencheckBox";
            this.hiddencheckBox.Size = new System.Drawing.Size(60, 17);
            this.hiddencheckBox.TabIndex = 34;
            this.hiddencheckBox.Text = "Hidden";
            this.hiddencheckBox.UseVisualStyleBackColor = true;
            // 
            // attr
            // 
            this.attr.AutoSize = true;
            this.attr.Location = new System.Drawing.Point(376, 268);
            this.attr.Name = "attr";
            this.attr.Size = new System.Drawing.Size(55, 13);
            this.attr.TabIndex = 35;
            this.attr.Text = "Атрибуты";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(379, 381);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(754, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.attr);
            this.Controls.Add(this.hiddencheckBox);
            this.Controls.Add(this.readOnlycheckBox);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.currentFile);
            this.Controls.Add(this.numericUpTo);
            this.Controls.Add(this.numericUpFrom);
            this.Controls.Add(this.resultList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePickerTo);
            this.Controls.Add(this.datePickerFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.subfolderCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox subfolderCheckBox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox resultList;
        private System.Windows.Forms.NumericUpDown numericUpFrom;
        private System.Windows.Forms.NumericUpDown numericUpTo;
        private System.Windows.Forms.Label currentFile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label folder;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.CheckBox readOnlycheckBox;
        private System.Windows.Forms.CheckBox hiddencheckBox;
        private System.Windows.Forms.Label attr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

