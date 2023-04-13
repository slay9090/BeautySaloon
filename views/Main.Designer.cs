﻿namespace BeautySaloon.view
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
            this.buttonFilteredItems = new System.Windows.Forms.Button();
            this.textBoxFiltered = new System.Windows.Forms.TextBox();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonChangeEmployee = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.tabPageCares = new System.Windows.Forms.TabPage();
            this.buttonCareSearch = new System.Windows.Forms.Button();
            this.textBoxCareSearch = new System.Windows.Forms.TextBox();
            this.buttonCareDeleteItem = new System.Windows.Forms.Button();
            this.buttonCareEditItem = new System.Windows.Forms.Button();
            this.dataGridViewCares = new System.Windows.Forms.DataGridView();
            this.buttonCareAddItem = new System.Windows.Forms.Button();
            this.tabPageSkills = new System.Windows.Forms.TabPage();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.btnGenerateBDData = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.tabPageCares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCares)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEmployee);
            this.tabControlMain.Controls.Add(this.tabPageCares);
            this.tabControlMain.Controls.Add(this.tabPageSkills);
            this.tabControlMain.Controls.Add(this.tabPageClients);
            this.tabControlMain.Controls.Add(this.tabPageOrders);
            this.tabControlMain.Location = new System.Drawing.Point(12, 50);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(807, 452);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.buttonFilteredItems);
            this.tabPageEmployee.Controls.Add(this.textBoxFiltered);
            this.tabPageEmployee.Controls.Add(this.buttonDeleteEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonChangeEmployee);
            this.tabPageEmployee.Controls.Add(this.dataGridViewEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonAddEmployee);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(799, 419);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Сотрудники";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonFilteredItems
            // 
            this.buttonFilteredItems.Location = new System.Drawing.Point(237, 6);
            this.buttonFilteredItems.Name = "buttonFilteredItems";
            this.buttonFilteredItems.Size = new System.Drawing.Size(100, 35);
            this.buttonFilteredItems.TabIndex = 6;
            this.buttonFilteredItems.Text = "Найти";
            this.buttonFilteredItems.UseVisualStyleBackColor = true;
            this.buttonFilteredItems.Click += new System.EventHandler(this.buttonFilteredItems_Click);
            this.buttonFilteredItems.Layout += new System.Windows.Forms.LayoutEventHandler(this.buttonFilteredItems_Layout);
            // 
            // textBoxFiltered
            // 
            this.textBoxFiltered.Location = new System.Drawing.Point(6, 10);
            this.textBoxFiltered.Name = "textBoxFiltered";
            this.textBoxFiltered.Size = new System.Drawing.Size(225, 26);
            this.textBoxFiltered.TabIndex = 5;
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(481, 6);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(100, 35);
            this.buttonDeleteEmployee.TabIndex = 4;
            this.buttonDeleteEmployee.Text = "Удалить";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonChangeEmployee
            // 
            this.buttonChangeEmployee.Location = new System.Drawing.Point(587, 6);
            this.buttonChangeEmployee.Name = "buttonChangeEmployee";
            this.buttonChangeEmployee.Size = new System.Drawing.Size(100, 35);
            this.buttonChangeEmployee.TabIndex = 3;
            this.buttonChangeEmployee.Text = "Изменить";
            this.buttonChangeEmployee.UseVisualStyleBackColor = true;
            this.buttonChangeEmployee.Click += new System.EventHandler(this.buttonChangeEmployee_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(6, 47);
            this.dataGridViewEmployee.MultiSelect = false;
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 62;
            this.dataGridViewEmployee.RowTemplate.Height = 28;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(787, 359);
            this.dataGridViewEmployee.TabIndex = 1;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(693, 6);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(100, 35);
            this.buttonAddEmployee.TabIndex = 0;
            this.buttonAddEmployee.Text = "Добавить";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageCares
            // 
            this.tabPageCares.Controls.Add(this.buttonCareSearch);
            this.tabPageCares.Controls.Add(this.textBoxCareSearch);
            this.tabPageCares.Controls.Add(this.buttonCareDeleteItem);
            this.tabPageCares.Controls.Add(this.buttonCareEditItem);
            this.tabPageCares.Controls.Add(this.dataGridViewCares);
            this.tabPageCares.Controls.Add(this.buttonCareAddItem);
            this.tabPageCares.Location = new System.Drawing.Point(4, 29);
            this.tabPageCares.Name = "tabPageCares";
            this.tabPageCares.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCares.Size = new System.Drawing.Size(799, 419);
            this.tabPageCares.TabIndex = 1;
            this.tabPageCares.Text = "Услуги";
            this.tabPageCares.UseVisualStyleBackColor = true;
            // 
            // buttonCareSearch
            // 
            this.buttonCareSearch.Location = new System.Drawing.Point(237, 6);
            this.buttonCareSearch.Name = "buttonCareSearch";
            this.buttonCareSearch.Size = new System.Drawing.Size(100, 35);
            this.buttonCareSearch.TabIndex = 12;
            this.buttonCareSearch.Text = "Найти";
            this.buttonCareSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxCareSearch
            // 
            this.textBoxCareSearch.Location = new System.Drawing.Point(6, 10);
            this.textBoxCareSearch.Name = "textBoxCareSearch";
            this.textBoxCareSearch.Size = new System.Drawing.Size(225, 26);
            this.textBoxCareSearch.TabIndex = 11;
            // 
            // buttonCareDeleteItem
            // 
            this.buttonCareDeleteItem.Location = new System.Drawing.Point(481, 6);
            this.buttonCareDeleteItem.Name = "buttonCareDeleteItem";
            this.buttonCareDeleteItem.Size = new System.Drawing.Size(100, 35);
            this.buttonCareDeleteItem.TabIndex = 10;
            this.buttonCareDeleteItem.Text = "Удалить";
            this.buttonCareDeleteItem.UseVisualStyleBackColor = true;
            // 
            // buttonCareEditItem
            // 
            this.buttonCareEditItem.Location = new System.Drawing.Point(587, 6);
            this.buttonCareEditItem.Name = "buttonCareEditItem";
            this.buttonCareEditItem.Size = new System.Drawing.Size(100, 35);
            this.buttonCareEditItem.TabIndex = 9;
            this.buttonCareEditItem.Text = "Изменить";
            this.buttonCareEditItem.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCares
            // 
            this.dataGridViewCares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCares.Location = new System.Drawing.Point(6, 47);
            this.dataGridViewCares.MultiSelect = false;
            this.dataGridViewCares.Name = "dataGridViewCares";
            this.dataGridViewCares.ReadOnly = true;
            this.dataGridViewCares.RowHeadersWidth = 62;
            this.dataGridViewCares.RowTemplate.Height = 28;
            this.dataGridViewCares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCares.Size = new System.Drawing.Size(787, 359);
            this.dataGridViewCares.TabIndex = 8;
            // 
            // buttonCareAddItem
            // 
            this.buttonCareAddItem.Location = new System.Drawing.Point(693, 6);
            this.buttonCareAddItem.Name = "buttonCareAddItem";
            this.buttonCareAddItem.Size = new System.Drawing.Size(100, 35);
            this.buttonCareAddItem.TabIndex = 7;
            this.buttonCareAddItem.Text = "Добавить";
            this.buttonCareAddItem.UseVisualStyleBackColor = true;
            // 
            // tabPageSkills
            // 
            this.tabPageSkills.Location = new System.Drawing.Point(4, 29);
            this.tabPageSkills.Name = "tabPageSkills";
            this.tabPageSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSkills.Size = new System.Drawing.Size(799, 419);
            this.tabPageSkills.TabIndex = 2;
            this.tabPageSkills.Text = "Навыки";
            this.tabPageSkills.UseVisualStyleBackColor = true;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Location = new System.Drawing.Point(4, 29);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(799, 419);
            this.tabPageClients.TabIndex = 3;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(799, 419);
            this.tabPageOrders.TabIndex = 4;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 514);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnGenerateBDData);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Салон красоты";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.tabPageCares.ResumeLayout(false);
            this.tabPageCares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCares)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonChangeEmployee;
        private System.Windows.Forms.Button buttonFilteredItems;
        private System.Windows.Forms.TextBox textBoxFiltered;
        private System.Windows.Forms.Button buttonCareSearch;
        private System.Windows.Forms.TextBox textBoxCareSearch;
        private System.Windows.Forms.Button buttonCareDeleteItem;
        private System.Windows.Forms.Button buttonCareEditItem;
        private System.Windows.Forms.DataGridView dataGridViewCares;
        private System.Windows.Forms.Button buttonCareAddItem;
        private System.Windows.Forms.TabPage tabPageOrders;
    }
}