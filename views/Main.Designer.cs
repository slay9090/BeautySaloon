namespace BeautySaloon.view
{
    partial class Main
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.tabPageCares = new System.Windows.Forms.TabPage();
            this.tabPageSkills = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.btnGenerateBDData = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.buttonChangeEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEmployee);
            this.tabControlMain.Controls.Add(this.tabPageCares);
            this.tabControlMain.Controls.Add(this.tabPageSkills);
            this.tabControlMain.Controls.Add(this.tabPageOrders);
            this.tabControlMain.Location = new System.Drawing.Point(12, 50);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 397);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.buttonDeleteEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonChangeEmployee);
            this.tabPageEmployee.Controls.Add(this.dataGridViewEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonAddEmployee);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(768, 364);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Сотрудники";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(6, 106);
            this.dataGridViewEmployee.MultiSelect = false;
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 62;
            this.dataGridViewEmployee.RowTemplate.Height = 28;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(756, 252);
            this.dataGridViewEmployee.TabIndex = 1;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(662, 6);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(100, 35);
            this.buttonAddEmployee.TabIndex = 0;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageCares
            // 
            this.tabPageCares.Location = new System.Drawing.Point(4, 29);
            this.tabPageCares.Name = "tabPageCares";
            this.tabPageCares.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCares.Size = new System.Drawing.Size(768, 364);
            this.tabPageCares.TabIndex = 1;
            this.tabPageCares.Text = "Услуги";
            this.tabPageCares.UseVisualStyleBackColor = true;
            // 
            // tabPageSkills
            // 
            this.tabPageSkills.Location = new System.Drawing.Point(4, 29);
            this.tabPageSkills.Name = "tabPageSkills";
            this.tabPageSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSkills.Size = new System.Drawing.Size(768, 364);
            this.tabPageSkills.TabIndex = 2;
            this.tabPageSkills.Text = "Навыки";
            this.tabPageSkills.UseVisualStyleBackColor = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(768, 364);
            this.tabPageOrders.TabIndex = 3;
            this.tabPageOrders.Text = "Заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // btnGenerateBDData
            // 
            this.btnGenerateBDData.Location = new System.Drawing.Point(196, 12);
            this.btnGenerateBDData.Name = "btnGenerateBDData";
            this.btnGenerateBDData.Size = new System.Drawing.Size(174, 32);
            this.btnGenerateBDData.TabIndex = 1;
            this.btnGenerateBDData.Text = "Сгененировать БД";
            this.btnGenerateBDData.UseVisualStyleBackColor = true;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(16, 12);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(174, 32);
            this.btnGetData.TabIndex = 2;
            this.btnGetData.Text = "Обновить";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // buttonChangeEmployee
            // 
            this.buttonChangeEmployee.Location = new System.Drawing.Point(556, 6);
            this.buttonChangeEmployee.Name = "buttonChangeEmployee";
            this.buttonChangeEmployee.Size = new System.Drawing.Size(100, 35);
            this.buttonChangeEmployee.TabIndex = 3;
            this.buttonChangeEmployee.Text = "Изменить";
            this.buttonChangeEmployee.UseVisualStyleBackColor = true;
            this.buttonChangeEmployee.Click += new System.EventHandler(this.buttonChangeEmployee_Click);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(450, 6);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(100, 35);
            this.buttonDeleteEmployee.TabIndex = 4;
            this.buttonDeleteEmployee.Text = "Удалить";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnGenerateBDData);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Салон красоты";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.TabPage tabPageCares;
        private System.Windows.Forms.Button btnGenerateBDData;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.TabPage tabPageSkills;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonChangeEmployee;
    }
}