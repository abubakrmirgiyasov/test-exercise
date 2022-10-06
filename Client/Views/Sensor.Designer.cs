namespace Client.Views
{
    partial class Sensor
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SensorName_T = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SensorDescription_T = new System.Windows.Forms.TextBox();
            this.DeviceName_C = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Save_B = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.59218F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.40782F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SensorName_T, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SensorDescription_T, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DeviceName_C, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Save_B, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 193);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя датчика ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SensorName_T
            // 
            this.SensorName_T.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SensorName_T.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SensorName_T.Location = new System.Drawing.Point(136, 60);
            this.SensorName_T.Margin = new System.Windows.Forms.Padding(5);
            this.SensorName_T.Name = "SensorName_T";
            this.SensorName_T.Size = new System.Drawing.Size(217, 22);
            this.SensorName_T.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавить датчик";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Описание";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SensorDescription_T
            // 
            this.SensorDescription_T.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SensorDescription_T.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SensorDescription_T.Location = new System.Drawing.Point(136, 124);
            this.SensorDescription_T.Margin = new System.Windows.Forms.Padding(5);
            this.SensorDescription_T.Name = "SensorDescription_T";
            this.SensorDescription_T.Size = new System.Drawing.Size(217, 22);
            this.SensorDescription_T.TabIndex = 4;
            // 
            // DeviceName_C
            // 
            this.DeviceName_C.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeviceName_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeviceName_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceName_C.FormattingEnabled = true;
            this.DeviceName_C.Location = new System.Drawing.Point(136, 92);
            this.DeviceName_C.Margin = new System.Windows.Forms.Padding(5);
            this.DeviceName_C.Name = "DeviceName_C";
            this.DeviceName_C.Size = new System.Drawing.Size(217, 22);
            this.DeviceName_C.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(5, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя устройства";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Save_B
            // 
            this.Save_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.Save_B, 2);
            this.Save_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Save_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_B.ForeColor = System.Drawing.Color.White;
            this.Save_B.Location = new System.Drawing.Point(5, 156);
            this.Save_B.Margin = new System.Windows.Forms.Padding(5);
            this.Save_B.Name = "Save_B";
            this.Save_B.Size = new System.Drawing.Size(348, 30);
            this.Save_B.TabIndex = 5;
            this.Save_B.Text = "Сохранить";
            this.Save_B.UseVisualStyleBackColor = false;
            // 
            // Sensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 193);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sensor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Датчик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sensor_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_B;
        public System.Windows.Forms.ComboBox DeviceName_C;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox SensorName_T;
        public System.Windows.Forms.TextBox SensorDescription_T;
    }
}