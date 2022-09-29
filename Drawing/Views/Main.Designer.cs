namespace Drawing
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Paint_PB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.X_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Y_TB = new System.Windows.Forms.TextBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Data_LB = new System.Windows.Forms.ListBox();
            this.SensorValue_TB = new System.Windows.Forms.TextBox();
            this.Size_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Upload_Btn = new System.Windows.Forms.Button();
            this.Save_D = new System.Windows.Forms.SaveFileDialog();
            this.Open_D = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paint_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Paint_PB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.X_TB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Y_TB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Add_Btn, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Delete_Btn, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.Data_LB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SensorValue_TB, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Size_TB, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Save_Btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Upload_Btn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1172, 510);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Paint_PB
            // 
            this.Paint_PB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Paint_PB, 5);
            this.Paint_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paint_PB.Location = new System.Drawing.Point(175, 5);
            this.Paint_PB.Margin = new System.Windows.Forms.Padding(5);
            this.Paint_PB.Name = "Paint_PB";
            this.Paint_PB.Padding = new System.Windows.Forms.Padding(5);
            this.Paint_PB.Size = new System.Drawing.Size(990, 432);
            this.Paint_PB.TabIndex = 0;
            this.Paint_PB.TabStop = false;
            this.Paint_PB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Paint_PB_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(175, 447);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // X_TB
            // 
            this.X_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.X_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.X_TB.Location = new System.Drawing.Point(175, 480);
            this.X_TB.Margin = new System.Windows.Forms.Padding(5);
            this.X_TB.Name = "X_TB";
            this.X_TB.Size = new System.Drawing.Size(190, 22);
            this.X_TB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(375, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Y_TB
            // 
            this.Y_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Y_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Y_TB.Location = new System.Drawing.Point(375, 480);
            this.Y_TB.Margin = new System.Windows.Forms.Padding(5);
            this.Y_TB.Name = "Y_TB";
            this.Y_TB.Size = new System.Drawing.Size(190, 22);
            this.Y_TB.TabIndex = 4;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_Btn.Location = new System.Drawing.Point(972, 444);
            this.Add_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(196, 29);
            this.Add_Btn.TabIndex = 5;
            this.Add_Btn.Text = "Добавить";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_Btn.Location = new System.Drawing.Point(972, 477);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(196, 29);
            this.Delete_Btn.TabIndex = 6;
            this.Delete_Btn.Text = "Удалить";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Data_LB
            // 
            this.Data_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_LB.FormattingEnabled = true;
            this.Data_LB.ItemHeight = 14;
            this.Data_LB.Location = new System.Drawing.Point(5, 5);
            this.Data_LB.Margin = new System.Windows.Forms.Padding(5);
            this.Data_LB.Name = "Data_LB";
            this.Data_LB.Size = new System.Drawing.Size(160, 432);
            this.Data_LB.TabIndex = 7;
            this.Data_LB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Data_LB_MouseDoubleClick);
            // 
            // SensorValue_TB
            // 
            this.SensorValue_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SensorValue_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SensorValue_TB.Location = new System.Drawing.Point(575, 480);
            this.SensorValue_TB.Margin = new System.Windows.Forms.Padding(5);
            this.SensorValue_TB.Name = "SensorValue_TB";
            this.SensorValue_TB.Size = new System.Drawing.Size(190, 22);
            this.SensorValue_TB.TabIndex = 8;
            // 
            // Size_TB
            // 
            this.Size_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Size_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Size_TB.Location = new System.Drawing.Point(775, 480);
            this.Size_TB.Margin = new System.Windows.Forms.Padding(5);
            this.Size_TB.Name = "Size_TB";
            this.Size_TB.Size = new System.Drawing.Size(190, 22);
            this.Size_TB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(775, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Размер:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(575, 447);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Числовое Значение:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save_Btn
            // 
            this.Save_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_Btn.Location = new System.Drawing.Point(5, 447);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(160, 23);
            this.Save_Btn.TabIndex = 12;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Upload_Btn
            // 
            this.Upload_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Upload_Btn.Location = new System.Drawing.Point(5, 480);
            this.Upload_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.Upload_Btn.Name = "Upload_Btn";
            this.Upload_Btn.Size = new System.Drawing.Size(160, 23);
            this.Upload_Btn.TabIndex = 13;
            this.Upload_Btn.Text = "Load";
            this.Upload_Btn.UseVisualStyleBackColor = true;
            this.Upload_Btn.Click += new System.EventHandler(this.Upload_Btn_Click);
            // 
            // Open_D
            // 
            this.Open_D.FileName = "Open";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 510);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paint_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox Paint_PB;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox X_TB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Y_TB;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.ListBox Data_LB;
        private System.Windows.Forms.TextBox SensorValue_TB;
        private System.Windows.Forms.TextBox Size_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Upload_Btn;
        private System.Windows.Forms.SaveFileDialog Save_D;
        private System.Windows.Forms.OpenFileDialog Open_D;
    }
}

