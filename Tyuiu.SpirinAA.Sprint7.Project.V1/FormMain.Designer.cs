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
            this.NumberOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDone_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrder_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_SSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMovesOrders_SAA = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch_SAA = new System.Windows.Forms.TextBox();
            this.buttonOpenOrder_SAA = new System.Windows.Forms.Button();
            this.buttonSearch_SAA = new System.Windows.Forms.Button();
            this.buttonRemoveRows_SAA = new System.Windows.Forms.Button();
            this.buttonAddOrders_SAA = new System.Windows.Forms.Button();
            this.buttonDownloadOrders_SAA = new System.Windows.Forms.Button();
            this.tabControl_SAA = new System.Windows.Forms.TabControl();
            this.menuStrip_SAA.SuspendLayout();
            this.tabPageOrderData_SAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SAA)).BeginInit();
            this.groupBoxMovesOrders_SAA.SuspendLayout();
            this.tabControl_SAA.SuspendLayout();
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
            this.menuStrip_SAA.Size = new System.Drawing.Size(921, 24);
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
            this.toolStripMenuItemAdd_SAA.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemAdd_SAA.Text = "Добавить";
            this.toolStripMenuItemAdd_SAA.Click += new System.EventHandler(this.buttonAdd_SAA_Click);
            // 
            // toolStripMenuItemOpen_SAA
            // 
            this.toolStripMenuItemOpen_SAA.Name = "toolStripMenuItemOpen_SAA";
            this.toolStripMenuItemOpen_SAA.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemOpen_SAA.Text = "Открыть";
            this.toolStripMenuItemOpen_SAA.Click += new System.EventHandler(this.buttonOpen_SAA_Click);
            // 
            // toolStripMenuItemSave_SAA
            // 
            this.toolStripMenuItemSave_SAA.Name = "toolStripMenuItemSave_SAA";
            this.toolStripMenuItemSave_SAA.Size = new System.Drawing.Size(133, 22);
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
            this.tabPageStats_SAA.Location = new System.Drawing.Point(4, 22);
            this.tabPageStats_SAA.Name = "tabPageStats_SAA";
            this.tabPageStats_SAA.Size = new System.Drawing.Size(913, 357);
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
            this.tabPageOrderData_SAA.Size = new System.Drawing.Size(913, 357);
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
            this.NumberOrder_SSV,
            this.DateDone_SSV,
            this.PriceOrder_SSV,
            this.NameOrder_SSV,
            this.Price_SSV,
            this.Quantity_SSV});
            this.dataGridViewTableOrders_SAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTableOrders_SAA.Location = new System.Drawing.Point(183, 3);
            this.dataGridViewTableOrders_SAA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTableOrders_SAA.Name = "dataGridViewTableOrders_SAA";
            this.dataGridViewTableOrders_SAA.RowHeadersWidth = 51;
            this.dataGridViewTableOrders_SAA.RowTemplate.Height = 24;
            this.dataGridViewTableOrders_SAA.Size = new System.Drawing.Size(727, 351);
            this.dataGridViewTableOrders_SAA.TabIndex = 1;
            this.dataGridViewTableOrders_SAA.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTable_SAA_RowPrePaint);
            // 
            // NumberDock_SAA
            // 
            this.NumberOrder_SSV.HeaderText = "Номер Водительских прав ";
            this.NumberOrder_SSV.MinimumWidth = 6;
            this.NumberOrder_SSV.Name = "NumberOrder_SAA";
            // 
            // NameFIO_SAA
            // 
            this.DateDone_SSV.HeaderText = "ФИО";
            this.DateDone_SSV.MinimumWidth = 6;
            this.DateDone_SSV.Name = "DateDone_SAA";
            this.DateDone_SSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NumberPhone_SAA
            // 
            this.PriceOrder_SSV.HeaderText = "Номер телефона владельца автомобиля";
            this.PriceOrder_SSV.MinimumWidth = 6;
            this.PriceOrder_SSV.Name = "PriceOrder_SAA";
            // 
            // CarMake_SAA
            // 
            this.NameOrder_SSV.HeaderText = "Марка";
            this.NameOrder_SSV.MinimumWidth = 6;
            this.NameOrder_SSV.Name = "NameOrder_SAA";
            this.NameOrder_SSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameOrder_SSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EnergyCar_SAA
            // 
            this.Price_SSV.HeaderText = "Мощность автомобиля";
            this.Price_SSV.Name = "Price_SAA";
            // 
            // ColorCar_SAA
            // 
            this.Quantity_SSV.HeaderText = "Цвет автомобиля";
            this.Quantity_SSV.Name = "Quantity_SAA";
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
            this.groupBoxMovesOrders_SAA.Size = new System.Drawing.Size(180, 351);
            this.groupBoxMovesOrders_SAA.TabIndex = 4;
            this.groupBoxMovesOrders_SAA.TabStop = false;
            this.groupBoxMovesOrders_SAA.Text = "Действия";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите объект для поиска\r\n";
            // 
            // textBoxSearch_SAA
            // 
            this.textBoxSearch_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch_SAA.Location = new System.Drawing.Point(4, 202);
            this.textBoxSearch_SAA.Name = "textBoxSearch_SAA";
            this.textBoxSearch_SAA.Size = new System.Drawing.Size(169, 20);
            this.textBoxSearch_SAA.TabIndex = 1;
            this.textBoxSearch_SAA.TextChanged += new System.EventHandler(this.textBoxSearch_SAA_TextChanged);
            // 
            // buttonOpenOrder_SAA
            // 
            this.buttonOpenOrder_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonSearch_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch_SAA.Location = new System.Drawing.Point(3, 227);
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
            this.buttonRemoveRows_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonAddOrders_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonDownloadOrders_SAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tabControl_SAA.Size = new System.Drawing.Size(921, 383);
            this.tabControl_SAA.TabIndex = 3;
            // 
            // FormMain_SAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 407);
            this.Controls.Add(this.tabControl_SAA);
            this.Controls.Add(this.menuStrip_SAA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain_SAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторемонтная Мастерская";
            this.menuStrip_SAA.ResumeLayout(false);
            this.menuStrip_SAA.PerformLayout();
            this.tabPageOrderData_SAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_SAA)).EndInit();
            this.groupBoxMovesOrders_SAA.ResumeLayout(false);
            this.groupBoxMovesOrders_SAA.PerformLayout();
            this.tabControl_SAA.ResumeLayout(false);
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
    }
}

