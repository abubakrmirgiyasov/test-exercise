namespace Client
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
            this.GetList_B = new System.Windows.Forms.Button();
            this.Add_B = new System.Windows.Forms.Button();
            this.Start_B = new System.Windows.Forms.Button();
            this.Stop_B = new System.Windows.Forms.Button();
            this.Search_B = new System.Windows.Forms.Button();
            this.List_D = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_D)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.19547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.80453F));
            this.tableLayoutPanel1.Controls.Add(this.GetList_B, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Add_B, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Start_B, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Stop_B, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Search_B, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.List_D, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(706, 403);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GetList_B
            // 
            this.GetList_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetList_B.Location = new System.Drawing.Point(548, 3);
            this.GetList_B.Name = "GetList_B";
            this.GetList_B.Size = new System.Drawing.Size(155, 34);
            this.GetList_B.TabIndex = 0;
            this.GetList_B.Text = "Получить список";
            this.GetList_B.UseVisualStyleBackColor = true;
            this.GetList_B.Click += new System.EventHandler(this.GetList_B_Click);
            // 
            // Add_B
            // 
            this.Add_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_B.Location = new System.Drawing.Point(548, 43);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(155, 34);
            this.Add_B.TabIndex = 1;
            this.Add_B.Text = "Добавить устройство";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.AddDevice_B_Click);
            // 
            // Start_B
            // 
            this.Start_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start_B.Location = new System.Drawing.Point(548, 123);
            this.Start_B.Name = "Start_B";
            this.Start_B.Size = new System.Drawing.Size(155, 34);
            this.Start_B.TabIndex = 2;
            this.Start_B.Text = "Start";
            this.Start_B.UseVisualStyleBackColor = true;
            this.Start_B.Click += new System.EventHandler(this.Start_B_Click);
            // 
            // Stop_B
            // 
            this.Stop_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stop_B.Enabled = false;
            this.Stop_B.Location = new System.Drawing.Point(548, 163);
            this.Stop_B.Name = "Stop_B";
            this.Stop_B.Size = new System.Drawing.Size(155, 34);
            this.Stop_B.TabIndex = 3;
            this.Stop_B.Text = "Stop";
            this.Stop_B.UseVisualStyleBackColor = true;
            this.Stop_B.Click += new System.EventHandler(this.Stop_B_Click);
            // 
            // Search_B
            // 
            this.Search_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Search_B.Location = new System.Drawing.Point(548, 203);
            this.Search_B.Name = "Search_B";
            this.Search_B.Size = new System.Drawing.Size(155, 34);
            this.Search_B.TabIndex = 4;
            this.Search_B.Text = "Поиск";
            this.Search_B.UseVisualStyleBackColor = true;
            this.Search_B.Click += new System.EventHandler(this.Search_B_Click);
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
            this.List_D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_D.Location = new System.Drawing.Point(3, 3);
            this.List_D.Name = "List_D";
            this.List_D.ReadOnly = true;
            this.List_D.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.List_D, 7);
            this.List_D.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_D.Size = new System.Drawing.Size(539, 397);
            this.List_D.TabIndex = 5;
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
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(548, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить датчик";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddSensor_B_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 403);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List_D)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GetList_B;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Start_B;
        private System.Windows.Forms.Button Stop_B;
        private System.Windows.Forms.Button Search_B;
        private System.Windows.Forms.DataGridView List_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
    }
}

