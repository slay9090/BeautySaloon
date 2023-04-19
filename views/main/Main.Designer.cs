namespace BeautySaloon.views
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
            this.buttonSaveSkills = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewSkills = new System.Windows.Forms.DataGridView();
            this.checkedListBoxSkills = new System.Windows.Forms.CheckedListBox();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.buttonFilterClients = new System.Windows.Forms.Button();
            this.textBoxFilterClients = new System.Windows.Forms.TextBox();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonChangeClient = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.buttonSetStatusCanceled = new System.Windows.Forms.Button();
            this.buttonSetStatusComplited = new System.Windows.Forms.Button();
            this.buttonFilterOrders = new System.Windows.Forms.Button();
            this.textBoxOrdersFilter = new System.Windows.Forms.TextBox();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.btnGenerateBDData = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.tabPageCares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCares)).BeginInit();
            this.tabPageSkills.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).BeginInit();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
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
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(6, 47);
            this.dataGridViewEmployee.MultiSelect = false;
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 25;
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
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
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
            this.buttonCareSearch.Click += new System.EventHandler(this.buttonCareSearch_Click);
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
            this.buttonCareDeleteItem.Click += new System.EventHandler(this.buttonCareDeleteItem_Click);
            // 
            // buttonCareEditItem
            // 
            this.buttonCareEditItem.Location = new System.Drawing.Point(587, 6);
            this.buttonCareEditItem.Name = "buttonCareEditItem";
            this.buttonCareEditItem.Size = new System.Drawing.Size(100, 35);
            this.buttonCareEditItem.TabIndex = 9;
            this.buttonCareEditItem.Text = "Изменить";
            this.buttonCareEditItem.UseVisualStyleBackColor = true;
            this.buttonCareEditItem.Click += new System.EventHandler(this.buttonCareEditItem_Click);
            // 
            // dataGridViewCares
            // 
            this.dataGridViewCares.AllowUserToAddRows = false;
            this.dataGridViewCares.AllowUserToDeleteRows = false;
            this.dataGridViewCares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCares.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCares.Location = new System.Drawing.Point(6, 47);
            this.dataGridViewCares.MultiSelect = false;
            this.dataGridViewCares.Name = "dataGridViewCares";
            this.dataGridViewCares.ReadOnly = true;
            this.dataGridViewCares.RowHeadersWidth = 25;
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
            this.buttonCareAddItem.Click += new System.EventHandler(this.buttonCareAddItem_Click);
            // 
            // tabPageSkills
            // 
            this.tabPageSkills.Controls.Add(this.buttonSaveSkills);
            this.tabPageSkills.Controls.Add(this.label2);
            this.tabPageSkills.Controls.Add(this.label1);
            this.tabPageSkills.Controls.Add(this.tableLayoutPanel1);
            this.tabPageSkills.Location = new System.Drawing.Point(4, 29);
            this.tabPageSkills.Name = "tabPageSkills";
            this.tabPageSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSkills.Size = new System.Drawing.Size(799, 419);
            this.tabPageSkills.TabIndex = 2;
            this.tabPageSkills.Text = "Навыки";
            this.tabPageSkills.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSkills
            // 
            this.buttonSaveSkills.Location = new System.Drawing.Point(679, 7);
            this.buttonSaveSkills.Name = "buttonSaveSkills";
            this.buttonSaveSkills.Size = new System.Drawing.Size(110, 31);
            this.buttonSaveSkills.TabIndex = 4;
            this.buttonSaveSkills.Text = "Сохранить";
            this.buttonSaveSkills.UseVisualStyleBackColor = true;
            this.buttonSaveSkills.Click += new System.EventHandler(this.buttonSaveSkills_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Навыки:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудники:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewSkills, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBoxSkills, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 356);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewSkills
            // 
            this.dataGridViewSkills.AllowUserToAddRows = false;
            this.dataGridViewSkills.AllowUserToDeleteRows = false;
            this.dataGridViewSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSkills.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkills.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSkills.MultiSelect = false;
            this.dataGridViewSkills.Name = "dataGridViewSkills";
            this.dataGridViewSkills.ReadOnly = true;
            this.dataGridViewSkills.RowHeadersVisible = false;
            this.dataGridViewSkills.RowHeadersWidth = 25;
            this.dataGridViewSkills.RowTemplate.Height = 28;
            this.dataGridViewSkills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSkills.Size = new System.Drawing.Size(377, 328);
            this.dataGridViewSkills.TabIndex = 11;
            this.dataGridViewSkills.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSkills_CellMouseClick);
            // 
            // checkedListBoxSkills
            // 
            this.checkedListBoxSkills.FormattingEnabled = true;
            this.checkedListBoxSkills.Location = new System.Drawing.Point(396, 3);
            this.checkedListBoxSkills.Name = "checkedListBoxSkills";
            this.checkedListBoxSkills.Size = new System.Drawing.Size(388, 349);
            this.checkedListBoxSkills.TabIndex = 10;
            // 
            // tabPageClients
            // 
            this.tabPageClients.Controls.Add(this.buttonFilterClients);
            this.tabPageClients.Controls.Add(this.textBoxFilterClients);
            this.tabPageClients.Controls.Add(this.buttonDeleteClient);
            this.tabPageClients.Controls.Add(this.buttonChangeClient);
            this.tabPageClients.Controls.Add(this.dataGridViewClients);
            this.tabPageClients.Controls.Add(this.buttonAddClient);
            this.tabPageClients.Location = new System.Drawing.Point(4, 29);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClients.Size = new System.Drawing.Size(799, 419);
            this.tabPageClients.TabIndex = 3;
            this.tabPageClients.Text = "Клиенты";
            this.tabPageClients.UseVisualStyleBackColor = true;
            // 
            // buttonFilterClients
            // 
            this.buttonFilterClients.Location = new System.Drawing.Point(237, 9);
            this.buttonFilterClients.Name = "buttonFilterClients";
            this.buttonFilterClients.Size = new System.Drawing.Size(100, 35);
            this.buttonFilterClients.TabIndex = 12;
            this.buttonFilterClients.Text = "Найти";
            this.buttonFilterClients.UseVisualStyleBackColor = true;
            this.buttonFilterClients.Click += new System.EventHandler(this.buttonFilterClients_Click);
            // 
            // textBoxFilterClients
            // 
            this.textBoxFilterClients.Location = new System.Drawing.Point(6, 13);
            this.textBoxFilterClients.Name = "textBoxFilterClients";
            this.textBoxFilterClients.Size = new System.Drawing.Size(225, 26);
            this.textBoxFilterClients.TabIndex = 11;
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(481, 9);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(100, 35);
            this.buttonDeleteClient.TabIndex = 10;
            this.buttonDeleteClient.Text = "Удалить";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonChangeClient
            // 
            this.buttonChangeClient.Location = new System.Drawing.Point(587, 9);
            this.buttonChangeClient.Name = "buttonChangeClient";
            this.buttonChangeClient.Size = new System.Drawing.Size(100, 35);
            this.buttonChangeClient.TabIndex = 9;
            this.buttonChangeClient.Text = "Изменить";
            this.buttonChangeClient.UseVisualStyleBackColor = true;
            this.buttonChangeClient.Click += new System.EventHandler(this.buttonChangeClient_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(6, 50);
            this.dataGridViewClients.MultiSelect = false;
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersWidth = 25;
            this.dataGridViewClients.RowTemplate.Height = 28;
            this.dataGridViewClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients.Size = new System.Drawing.Size(787, 359);
            this.dataGridViewClients.TabIndex = 8;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(693, 9);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(100, 35);
            this.buttonAddClient.TabIndex = 7;
            this.buttonAddClient.Text = "Добавить";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.buttonSetStatusCanceled);
            this.tabPageOrders.Controls.Add(this.buttonSetStatusComplited);
            this.tabPageOrders.Controls.Add(this.buttonFilterOrders);
            this.tabPageOrders.Controls.Add(this.textBoxOrdersFilter);
            this.tabPageOrders.Controls.Add(this.dataGridViewOrders);
            this.tabPageOrders.Controls.Add(this.buttonCreateOrder);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(799, 419);
            this.tabPageOrders.TabIndex = 4;
            this.tabPageOrders.Text = "Заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // buttonSetStatusCanceled
            // 
            this.buttonSetStatusCanceled.Location = new System.Drawing.Point(481, 9);
            this.buttonSetStatusCanceled.Name = "buttonSetStatusCanceled";
            this.buttonSetStatusCanceled.Size = new System.Drawing.Size(100, 35);
            this.buttonSetStatusCanceled.TabIndex = 14;
            this.buttonSetStatusCanceled.Text = "Отменён";
            this.buttonSetStatusCanceled.UseVisualStyleBackColor = true;
            this.buttonSetStatusCanceled.Click += new System.EventHandler(this.buttonSetStatusCanceled_Click);
            // 
            // buttonSetStatusComplited
            // 
            this.buttonSetStatusComplited.Location = new System.Drawing.Point(587, 9);
            this.buttonSetStatusComplited.Name = "buttonSetStatusComplited";
            this.buttonSetStatusComplited.Size = new System.Drawing.Size(100, 35);
            this.buttonSetStatusComplited.TabIndex = 17;
            this.buttonSetStatusComplited.Text = "Исполнен";
            this.buttonSetStatusComplited.UseVisualStyleBackColor = true;
            this.buttonSetStatusComplited.Click += new System.EventHandler(this.buttonSetStatusComplited_Click);
            // 
            // buttonFilterOrders
            // 
            this.buttonFilterOrders.Location = new System.Drawing.Point(237, 9);
            this.buttonFilterOrders.Name = "buttonFilterOrders";
            this.buttonFilterOrders.Size = new System.Drawing.Size(100, 35);
            this.buttonFilterOrders.TabIndex = 16;
            this.buttonFilterOrders.Text = "Найти";
            this.buttonFilterOrders.UseVisualStyleBackColor = true;
            this.buttonFilterOrders.Click += new System.EventHandler(this.buttonFilterOrders_Click);
            // 
            // textBoxOrdersFilter
            // 
            this.textBoxOrdersFilter.Location = new System.Drawing.Point(6, 13);
            this.textBoxOrdersFilter.Name = "textBoxOrdersFilter";
            this.textBoxOrdersFilter.Size = new System.Drawing.Size(225, 26);
            this.textBoxOrdersFilter.TabIndex = 15;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(6, 50);
            this.dataGridViewOrders.MultiSelect = false;
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 25;
            this.dataGridViewOrders.RowTemplate.Height = 28;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(787, 359);
            this.dataGridViewOrders.TabIndex = 14;
            this.dataGridViewOrders.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewOrders_RowPostPaint);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(693, 9);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(100, 35);
            this.buttonCreateOrder.TabIndex = 13;
            this.buttonCreateOrder.Text = "Добавить";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Салон красоты";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.tabPageCares.ResumeLayout(false);
            this.tabPageCares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCares)).EndInit();
            this.tabPageSkills.ResumeLayout(false);
            this.tabPageSkills.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkills)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            this.tabPageClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckedListBox checkedListBoxSkills;
        private System.Windows.Forms.DataGridView dataGridViewSkills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveSkills;
        private System.Windows.Forms.Button buttonFilterClients;
        private System.Windows.Forms.TextBox textBoxFilterClients;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonChangeClient;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonSetStatusCanceled;
        private System.Windows.Forms.Button buttonSetStatusComplited;
        private System.Windows.Forms.Button buttonFilterOrders;
        private System.Windows.Forms.TextBox textBoxOrdersFilter;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonCreateOrder;
    }
}