namespace PictureSearcher
{
    partial class PictureSearcherUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SizeCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SizeCheckBox
            // 
            this.SizeCheckBox.AutoSize = true;
            this.SizeCheckBox.Location = new System.Drawing.Point(3, 13);
            this.SizeCheckBox.Name = "SizeCheckBox";
            this.SizeCheckBox.Size = new System.Drawing.Size(119, 17);
            this.SizeCheckBox.TabIndex = 1;
            this.SizeCheckBox.Text = "Поиск по размеру";
            this.SizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Высота";
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Location = new System.Drawing.Point(66, 49);
            this.WidthNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.WidthNumericUpDown.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Location = new System.Drawing.Point(66, 79);
            this.HeightNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.HeightNumericUpDown.TabIndex = 8;
            // 
            // PictureSearcherUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeCheckBox);
            this.Name = "PictureSearcherUserControl";
            this.Size = new System.Drawing.Size(186, 115);
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox SizeCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
    }
}
