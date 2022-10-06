namespace Client.Views
{
    partial class Filter
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
            this.List_D = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TopDate_T = new System.Windows.Forms.TextBox();
            this.BottomDate_T = new System.Windows.Forms.TextBox();
            this.Device_T = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_D)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.73759F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.26241F));
            this.tableLayoutPanel1.Controls.Add(this.List_D, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TopDate_T, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BottomDate_T, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Device_T, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // List_D
            // 
            this.List_D.AllowUserToAddRows = false;
            this.List_D.AllowUserToDeleteRows = false;
            this.List_D.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.List_D.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.List_D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_D.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tableLayoutPanel1.SetColumnSpan(this.List_D, 2);
            this.List_D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_D.Location = new System.Drawing.Point(3, 3);
            this.List_D.Name = "List_D";
            this.List_D.ReadOnly = true;
            this.List_D.RowHeadersVisible = false;
            this.List_D.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_D.Size = new System.Drawing.Size(558, 294);
            this.List_D.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Device";
            this.Column1.HeaderText = "Устройство";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Sensor";
            this.Column2.HeaderText = "Датчик";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date";
            this.Column3.HeaderText = "Время";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Value";
            this.Column4.HeaderText = "Значение";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первая дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 333);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вторая дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(5, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Название устройства";
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(558, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search_B_Click);
            // 
            // TopDate_T
            // 
            this.TopDate_T.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TopDate_T.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopDate_T.Location = new System.Drawing.Point(182, 303);
            this.TopDate_T.Name = "TopDate_T";
            this.TopDate_T.Size = new System.Drawing.Size(379, 22);
            this.TopDate_T.TabIndex = 11;
            // 
            // BottomDate_T
            // 
            this.BottomDate_T.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BottomDate_T.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomDate_T.Location = new System.Drawing.Point(182, 331);
            this.BottomDate_T.Name = "BottomDate_T";
            this.BottomDate_T.Size = new System.Drawing.Size(379, 22);
            this.BottomDate_T.TabIndex = 12;
            // 
            // Device_T
            // 
            this.Device_T.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Device_T.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Device_T.Location = new System.Drawing.Point(182, 359);
            this.Device_T.Name = "Device_T";
            this.Device_T.Size = new System.Drawing.Size(379, 22);
            this.Device_T.TabIndex = 13;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView List_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TopDate_T;
        private System.Windows.Forms.TextBox BottomDate_T;
        private System.Windows.Forms.TextBox Device_T;
    }
}