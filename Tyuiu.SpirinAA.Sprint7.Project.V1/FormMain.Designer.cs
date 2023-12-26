namespace Tyuiu.SpirinAA.Sprint7.Project.V1
{
    partial class FormMain_SAA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SAA));
            this.saveFileDialogTable_SAA = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_SAA = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip_SAA = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile_SAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdd_SAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen_SAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave_SAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInfo_SAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInstruction_SAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout_SAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit_SAA = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageStats_SAA = new System.Windows.Forms.TabPage();
            this.tabPageOrderData_SAA = new System.Windows.Forms.TabPage();
            this.dataGridViewTableOrders_SAA = new System.Windows.Forms.DataGridView();
            this.NumberOrder_SAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDone_SAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOrder_SAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrder_SAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_SAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_SAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMovesOrders_SAA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch_SAA = new System.Windows.Forms.TextBox();
            this.buttonOpenOrder_SAA = new System.Windows.Forms.Button();
            this.buttonSearch_SAA = new System.Windows.Forms.Button();
            this.buttonRemoveRows_SAA = new System.Windows.Forms.Button();
            this.buttonAddOrders_SAA = new System.Windows.Forms.Button();
            this.buttonDownloadOrders_SAA = new System.Windows.Forms.Button();
            this.tabControl_SAA = new System.Windows.Forms.TabControl();
            this.buttonMax_SAA = new System.Windows.Forms.Button();
            this.buttonSumm_SAA = new System.Windows.Forms.Button();
            this.buttonMin_SAA = new System.Windows.Forms.Button();
            this.buttonMediana_SAA = new System.Windows.Forms.Button();
            this.buttonCount_SAA = new System.Windows.Forms.Button();
            this.textBoxResult_SAA = new System.Windows.Forms.TextBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonFunction_SAA = new System.Windows.Forms.Button();
            this.menuStrip_SAA.SuspendLayout();
            this.tabPageStats_SAA.SuspendLayout();
            this.tabPageOrderData_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SAA)).BeginInit();
            this.groupBoxMovesOrders_SAA.SuspendLayout();
            this.tabControl_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogTable_SAA
            // 
            this.openFileDialogTable_SAA.FileName = "openFileDialog1";
            // 
            // menuStrip_SAA
            // 
            this.menuStrip_SAA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile_SAA,
            this.toolStripMenuItemInfo_SAA,
            this.toolStripMenuItemExit_SAA});
            this.menuStrip_SAA.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_SAA.Name = "menuStrip_SAA";
            this.menuStrip_SAA.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip_SAA.TabIndex = 4;
            this.menuStrip_SAA.Text = "menuStrip1";
            // 
            // toolStripMenuFile_SAA
            // 
            this.toolStripMenuFile_SAA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd_SAA,
            this.toolStripMenuItemOpen_SAA,
            this.toolStripMenuItemSave_SAA});
            this.toolStripMenuFile_SAA.Name = "toolStripMenuFile_SAA";
            this.toolStripMenuFile_SAA.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuFile_SAA.Text = "Файл";
            // 
            // toolStripMenuItemAdd_SAA
            // 
            this.toolStripMenuItemAdd_SAA.Name = "toolStripMenuItemAdd_SAA";
            this.toolStripMenuItemAdd_SAA.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAdd_SAA.Text = "Добавить";
            this.toolStripMenuItemAdd_SAA.Click += new System.EventHandler(this.buttonAdd_SAA_Click);
            // 
            // toolStripMenuItemOpen_SAA
            // 
            this.toolStripMenuItemOpen_SAA.Name = "toolStripMenuItemOpen_SAA";
            this.toolStripMenuItemOpen_SAA.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemOpen_SAA.Text = "Открыть";
            this.toolStripMenuItemOpen_SAA.Click += new System.EventHandler(this.buttonOpen_SAA_Click);
            // 
            // toolStripMenuItemSave_SAA
            // 
            this.toolStripMenuItemSave_SAA.Name = "toolStripMenuItemSave_SAA";
            this.toolStripMenuItemSave_SAA.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemSave_SAA.Text = "Сохранить";
            this.toolStripMenuItemSave_SAA.Click += new System.EventHandler(this.buttonDownload_SAA_Click);
            // 
            // toolStripMenuItemInfo_SAA
            // 
            this.toolStripMenuItemInfo_SAA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInstruction_SAA,
            this.toolStripMenuItemAbout_SAA});
            this.toolStripMenuItemInfo_SAA.Name = "toolStripMenuItemInfo_SAA";
            this.toolStripMenuItemInfo_SAA.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItemInfo_SAA.Text = "Справка";
            // 
            // toolStripMenuItemInstruction_SAA
            // 
            this.toolStripMenuItemInstruction_SAA.Name = "toolStripMenuItemInstruction_SAA";
            this.toolStripMenuItemInstruction_SAA.Size = new System.Drawing.Size(317, 22);
            this.toolStripMenuItemInstruction_SAA.Text = "Инструкция по использованию программы";
            this.toolStripMenuItemInstruction_SAA.Click += new System.EventHandler(this.toolStripMenuItemInstruction_SAA_Click);
            // 
            // toolStripMenuItemAbout_SAA
            // 
            this.toolStripMenuItemAbout_SAA.Name = "toolStripMenuItemAbout_SAA";
            this.toolStripMenuItemAbout_SAA.Size = new System.Drawing.Size(317, 22);
            this.toolStripMenuItemAbout_SAA.Text = "О программе ";
            this.toolStripMenuItemAbout_SAA.Click += new System.EventHandler(this.buttonInfo_SAA_Click);
            // 
            // toolStripMenuItemExit_SAA
            // 
            this.toolStripMenuItemExit_SAA.Name = "toolStripMenuItemExit_SAA";
            this.toolStripMenuItemExit_SAA.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemExit_SAA.Text = "Выход";
            this.toolStripMenuItemExit_SAA.Click += new System.EventHandler(this.toolStripMenuItemExit_SAA_Click);
            // 
            // tabPageStats_SAA
            // 
            this.tabPageStats_SAA.Controls.Add(this.buttonFunction_SAA);
            this.tabPageStats_SAA.Controls.Add(this.chartFunction);
            this.tabPageStats_SAA.Controls.Add(this.textBoxResult_SAA);
            this.tabPageStats_SAA.Controls.Add(this.buttonCount_SAA);
            this.tabPageStats_SAA.Controls.Add(this.buttonMediana_SAA);
            this.tabPageStats_SAA.Controls.Add(this.buttonMin_SAA);
            this.tabPageStats_SAA.Controls.Add(this.buttonSumm_SAA);
            this.tabPageStats_SAA.Controls.Add(this.buttonMax_SAA);
            this.tabPageStats_SAA.Location = new System.Drawing.Point(4, 22);
            this.tabPageStats_SAA.Name = "tabPageStats_SAA";
            this.tabPageStats_SAA.Size = new System.Drawing.Size(986, 444);
            this.tabPageStats_SAA.TabIndex = 2;
            this.tabPageStats_SAA.Text = "Статистика";
            this.tabPageStats_SAA.UseVisualStyleBackColor = true;
            // 
            // tabPageOrderData_SAA
            // 
            this.tabPageOrderData_SAA.Controls.Add(this.dataGridViewTableOrders_SAA);
            this.tabPageOrderData_SAA.Controls.Add(this.groupBoxMovesOrders_SAA);
            this.tabPageOrderData_SAA.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderData_SAA.Name = "tabPageOrderData_SAA";
            this.tabPageOrderData_SAA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderData_SAA.Size = new System.Drawing.Size(1024, 452);
            this.tabPageOrderData_SAA.TabIndex = 1;
            this.tabPageOrderData_SAA.Text = "База данных по заказам";
            this.tabPageOrderData_SAA.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTableOrders_SAA
            // 
            this.dataGridViewTableOrders_SAA.AllowUserToAddRows = false;
            this.dataGridViewTableOrders_SAA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTableOrders_SAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableOrders_SAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOrder_SAA,
            this.DateDone_SAA,
            this.PriceOrder_SAA,
            this.NameOrder_SAA,
            this.Price_SAA,
            this.Quantity_SAA});
            this.dataGridViewTableOrders_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTableOrders_SAA.Location = new System.Drawing.Point(183, 3);
            this.dataGridViewTableOrders_SAA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTableOrders_SAA.Name = "dataGridViewTableOrders_SAA";
            this.dataGridViewTableOrders_SAA.RowHeadersWidth = 51;
            this.dataGridViewTableOrders_SAA.RowTemplate.Height = 24;
            this.dataGridViewTableOrders_SAA.Size = new System.Drawing.Size(838, 446);
            this.dataGridViewTableOrders_SAA.TabIndex = 1;
            this.dataGridViewTableOrders_SAA.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTable_SAA_RowPrePaint);
            // 
            // NumberOrder_SAA
            // 
            this.NumberOrder_SAA.HeaderText = "Номер Водительских прав ";
            this.NumberOrder_SAA.MinimumWidth = 6;
            this.NumberOrder_SAA.Name = "NumberOrder_SAA";
            // 
            // DateDone_SAA
            // 
            this.DateDone_SAA.HeaderText = "ФИО";
            this.DateDone_SAA.MinimumWidth = 6;
            this.DateDone_SAA.Name = "DateDone_SAA";
            this.DateDone_SAA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PriceOrder_SAA
            // 
            this.PriceOrder_SAA.HeaderText = "Номер телефона владельца автомобиля";
            this.PriceOrder_SAA.MinimumWidth = 6;
            this.PriceOrder_SAA.Name = "PriceOrder_SAA";
            // 
            // NameOrder_SAA
            // 
            this.NameOrder_SAA.HeaderText = "Марка";
            this.NameOrder_SAA.MinimumWidth = 6;
            this.NameOrder_SAA.Name = "NameOrder_SAA";
            this.NameOrder_SAA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameOrder_SAA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price_SAA
            // 
            this.Price_SAA.HeaderText = "Мощность автомобиля";
            this.Price_SAA.Name = "Price_SAA";
            // 
            // Quantity_SAA
            // 
            this.Quantity_SAA.HeaderText = "Цвет автомобиля";
            this.Quantity_SAA.Name = "Quantity_SAA";
            // 
            // groupBoxMovesOrders_SAA
            // 
            this.groupBoxMovesOrders_SAA.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMovesOrders_SAA.Controls.Add(this.label1);
            this.groupBoxMovesOrders_SAA.Controls.Add(this.textBoxSearch_SAA);
            this.groupBoxMovesOrders_SAA.Controls.Add(this.buttonOpenOrder_SAA);
            this.groupBoxMovesOrders_SAA.Controls.Add(this.buttonSearch_SAA);
            this.groupBoxMovesOrders_SAA.Controls.Add(this.buttonRemoveRows_SAA);
            this.groupBoxMovesOrders_SAA.Controls.Add(this.buttonAddOrders_SAA);
            this.groupBoxMovesOrders_SAA.Controls.Add(this.buttonDownloadOrders_SAA);
            this.groupBoxMovesOrders_SAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxMovesOrders_SAA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMovesOrders_SAA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesOrders_SAA.Name = "groupBoxMovesOrders_SAA";
            this.groupBoxMovesOrders_SAA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesOrders_SAA.Size = new System.Drawing.Size(180, 446);
            this.groupBoxMovesOrders_SAA.TabIndex = 4;
            this.groupBoxMovesOrders_SAA.TabStop = false;
            this.groupBoxMovesOrders_SAA.Text = "Действия";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите объект для поиска\r\n";
            // 
            // textBoxSearch_SAA
            // 
            this.textBoxSearch_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch_SAA.Location = new System.Drawing.Point(4, 203);
            this.textBoxSearch_SAA.Name = "textBoxSearch_SAA";
            this.textBoxSearch_SAA.Size = new System.Drawing.Size(169, 20);
            this.textBoxSearch_SAA.TabIndex = 1;
            this.textBoxSearch_SAA.TextChanged += new System.EventHandler(this.textBoxSearch_SAA_TextChanged);
            // 
            // buttonOpenOrder_SAA
            // 
            this.buttonOpenOrder_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenOrder_SAA.Location = new System.Drawing.Point(4, 17);
            this.buttonOpenOrder_SAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenOrder_SAA.Name = "buttonOpenOrder_SAA";
            this.buttonOpenOrder_SAA.Size = new System.Drawing.Size(170, 39);
            this.buttonOpenOrder_SAA.TabIndex = 0;
            this.buttonOpenOrder_SAA.Text = "Открыть базу данных по заказам";
            this.buttonOpenOrder_SAA.UseVisualStyleBackColor = true;
            this.buttonOpenOrder_SAA.Click += new System.EventHandler(this.buttonOpen_SAA_Click);
            // 
            // buttonSearch_SAA
            // 
            this.buttonSearch_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch_SAA.Location = new System.Drawing.Point(3, 228);
            this.buttonSearch_SAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch_SAA.Name = "buttonSearch_SAA";
            this.buttonSearch_SAA.Size = new System.Drawing.Size(170, 39);
            this.buttonSearch_SAA.TabIndex = 0;
            this.buttonSearch_SAA.Text = "Найти";
            this.buttonSearch_SAA.UseVisualStyleBackColor = true;
            this.buttonSearch_SAA.Click += new System.EventHandler(this.buttonSearch_SAA_Click);
            // 
            // buttonRemoveRows_SAA
            // 
            this.buttonRemoveRows_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveRows_SAA.Location = new System.Drawing.Point(4, 146);
            this.buttonRemoveRows_SAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemoveRows_SAA.Name = "buttonRemoveRows_SAA";
            this.buttonRemoveRows_SAA.Size = new System.Drawing.Size(170, 39);
            this.buttonRemoveRows_SAA.TabIndex = 0;
            this.buttonRemoveRows_SAA.Text = "Удалить заказ";
            this.buttonRemoveRows_SAA.UseVisualStyleBackColor = true;
            this.buttonRemoveRows_SAA.Click += new System.EventHandler(this.buttonRemoveRows_SAA_Click);
            // 
            // buttonAddOrders_SAA
            // 
            this.buttonAddOrders_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOrders_SAA.Location = new System.Drawing.Point(4, 103);
            this.buttonAddOrders_SAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddOrders_SAA.Name = "buttonAddOrders_SAA";
            this.buttonAddOrders_SAA.Size = new System.Drawing.Size(170, 39);
            this.buttonAddOrders_SAA.TabIndex = 0;
            this.buttonAddOrders_SAA.Text = "Добавить заказ";
            this.buttonAddOrders_SAA.UseVisualStyleBackColor = true;
            this.buttonAddOrders_SAA.Click += new System.EventHandler(this.buttonAdd_SAA_Click);
            // 
            // buttonDownloadOrders_SAA
            // 
            this.buttonDownloadOrders_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadOrders_SAA.Location = new System.Drawing.Point(4, 60);
            this.buttonDownloadOrders_SAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownloadOrders_SAA.Name = "buttonDownloadOrders_SAA";
            this.buttonDownloadOrders_SAA.Size = new System.Drawing.Size(170, 39);
            this.buttonDownloadOrders_SAA.TabIndex = 0;
            this.buttonDownloadOrders_SAA.Text = "Сохранить базу данных по заказам";
            this.buttonDownloadOrders_SAA.UseVisualStyleBackColor = true;
            this.buttonDownloadOrders_SAA.Click += new System.EventHandler(this.buttonDownload_SAA_Click);
            // 
            // tabControl_SAA
            // 
            this.tabControl_SAA.Controls.Add(this.tabPageOrderData_SAA);
            this.tabControl_SAA.Controls.Add(this.tabPageStats_SAA);
            this.tabControl_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_SAA.Location = new System.Drawing.Point(0, 24);
            this.tabControl_SAA.Name = "tabControl_SAA";
            this.tabControl_SAA.SelectedIndex = 0;
            this.tabControl_SAA.Size = new System.Drawing.Size(1032, 478);
            this.tabControl_SAA.TabIndex = 3;
            // 
            // buttonMax_SAA
            // 
            this.buttonMax_SAA.Location = new System.Drawing.Point(8, 19);
            this.buttonMax_SAA.Name = "buttonMax_SAA";
            this.buttonMax_SAA.Size = new System.Drawing.Size(204, 49);
            this.buttonMax_SAA.TabIndex = 0;
            this.buttonMax_SAA.Text = "Max";
            this.buttonMax_SAA.UseVisualStyleBackColor = true;
            this.buttonMax_SAA.Click += new System.EventHandler(this.buttonMax_SAA_Click);
            // 
            // buttonSumm_SAA
            // 
            this.buttonSumm_SAA.Location = new System.Drawing.Point(8, 129);
            this.buttonSumm_SAA.Name = "buttonSumm_SAA";
            this.buttonSumm_SAA.Size = new System.Drawing.Size(204, 49);
            this.buttonSumm_SAA.TabIndex = 0;
            this.buttonSumm_SAA.Text = "Summ";
            this.buttonSumm_SAA.UseVisualStyleBackColor = true;
            this.buttonSumm_SAA.Click += new System.EventHandler(this.buttonSumm_SAA_Click);
            // 
            // buttonMin_SAA
            // 
            this.buttonMin_SAA.Location = new System.Drawing.Point(8, 74);
            this.buttonMin_SAA.Name = "buttonMin_SAA";
            this.buttonMin_SAA.Size = new System.Drawing.Size(204, 49);
            this.buttonMin_SAA.TabIndex = 0;
            this.buttonMin_SAA.Text = "Min";
            this.buttonMin_SAA.UseVisualStyleBackColor = true;
            this.buttonMin_SAA.Click += new System.EventHandler(this.buttonMin_SAA_Click);
            // 
            // buttonMediana_SAA
            // 
            this.buttonMediana_SAA.Location = new System.Drawing.Point(8, 184);
            this.buttonMediana_SAA.Name = "buttonMediana_SAA";
            this.buttonMediana_SAA.Size = new System.Drawing.Size(204, 49);
            this.buttonMediana_SAA.TabIndex = 0;
            this.buttonMediana_SAA.Text = "Srednee";
            this.buttonMediana_SAA.UseVisualStyleBackColor = true;
            this.buttonMediana_SAA.Click += new System.EventHandler(this.buttonMediana_SAA_Click);
            // 
            // buttonCount_SAA
            // 
            this.buttonCount_SAA.Location = new System.Drawing.Point(8, 239);
            this.buttonCount_SAA.Name = "buttonCount_SAA";
            this.buttonCount_SAA.Size = new System.Drawing.Size(204, 49);
            this.buttonCount_SAA.TabIndex = 0;
            this.buttonCount_SAA.Text = "Collichestvo";
            this.buttonCount_SAA.UseVisualStyleBackColor = true;
            this.buttonCount_SAA.Click += new System.EventHandler(this.buttonCount_SAA_Click);
            // 
            // textBoxResult_SAA
            // 
            this.textBoxResult_SAA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_SAA.Location = new System.Drawing.Point(8, 294);
            this.textBoxResult_SAA.Multiline = true;
            this.textBoxResult_SAA.Name = "textBoxResult_SAA";
            this.textBoxResult_SAA.Size = new System.Drawing.Size(204, 23);
            this.textBoxResult_SAA.TabIndex = 1;
            // 
            // chartFunction
            // 
            this.chartFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction.Legends.Add(legend1);
            this.chartFunction.Location = new System.Drawing.Point(218, 3);
            this.chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction.Series.Add(series1);
            this.chartFunction.Size = new System.Drawing.Size(760, 433);
            this.chartFunction.TabIndex = 2;
            this.chartFunction.Text = "chart1";
            // 
            // buttonFunction_SAA
            // 
            this.buttonFunction_SAA.Location = new System.Drawing.Point(3, 383);
            this.buttonFunction_SAA.Name = "buttonFunction_SAA";
            this.buttonFunction_SAA.Size = new System.Drawing.Size(209, 53);
            this.buttonFunction_SAA.TabIndex = 3;
            this.buttonFunction_SAA.Text = "Построить Круговую Диаграмму";
            this.buttonFunction_SAA.UseVisualStyleBackColor = true;
            this.buttonFunction_SAA.Click += new System.EventHandler(this.buttonFunction_SAA_Click);
            // 
            // FormMain_SAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 502);
            this.Controls.Add(this.tabControl_SAA);
            this.Controls.Add(this.menuStrip_SAA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain_SAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторемонтная Мастерская";
            this.menuStrip_SAA.ResumeLayout(false);
            this.menuStrip_SAA.PerformLayout();
            this.tabPageStats_SAA.ResumeLayout(false);
            this.tabPageStats_SAA.PerformLayout();
            this.tabPageOrderData_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SAA)).EndInit();
            this.groupBoxMovesOrders_SAA.ResumeLayout(false);
            this.groupBoxMovesOrders_SAA.PerformLayout();
            this.tabControl_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_SAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_SAA;
        private System.Windows.Forms.MenuStrip menuStrip_SAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile_SAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_SAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_SAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd_SAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_SAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_SAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_SAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_SAA;
        private System.Windows.Forms.TabPage tabPageStats_SAA;
        private System.Windows.Forms.TabPage tabPageOrderData_SAA;
        private System.Windows.Forms.DataGridView dataGridViewTableOrders_SAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOrder_SAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDone_SAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOrder_SAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrder_SAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_SAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_SAA;
        private System.Windows.Forms.GroupBox groupBoxMovesOrders_SAA;
        private System.Windows.Forms.Button buttonOpenOrder_SAA;
        private System.Windows.Forms.Button buttonAddOrders_SAA;
        private System.Windows.Forms.Button buttonDownloadOrders_SAA;
        private System.Windows.Forms.TabControl tabControl_SAA;
        private System.Windows.Forms.Button buttonRemoveRows_SAA;
        private System.Windows.Forms.TextBox textBoxSearch_SAA;
        private System.Windows.Forms.Button buttonSearch_SAA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOrder_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDone_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOrder_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrder_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_SSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_SSV;
        private System.Windows.Forms.TextBox textBoxResult_SAA;
        private System.Windows.Forms.Button buttonCount_SAA;
        private System.Windows.Forms.Button buttonMediana_SAA;
        private System.Windows.Forms.Button buttonMin_SAA;
        private System.Windows.Forms.Button buttonSumm_SAA;
        private System.Windows.Forms.Button buttonMax_SAA;
        private System.Windows.Forms.Button buttonFunction_SAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}

