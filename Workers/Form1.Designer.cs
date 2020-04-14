namespace Workers
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экпортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.cmTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedWorkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.cmTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWorkerToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.экпортToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addWorkerToolStripMenuItem
            // 
            this.addWorkerToolStripMenuItem.Name = "addWorkerToolStripMenuItem";
            this.addWorkerToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.addWorkerToolStripMenuItem.Text = "Добавить работника";
            this.addWorkerToolStripMenuItem.Click += new System.EventHandler(this.addWorkerToolStripMenuItem_Click);
            // 
            // экпортToolStripMenuItem
            // 
            this.экпортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtFileToolStripMenuItem});
            this.экпортToolStripMenuItem.Name = "экпортToolStripMenuItem";
            this.экпортToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.экпортToolStripMenuItem.Text = "Экпорт";
            // 
            // txtFileToolStripMenuItem
            // 
            this.txtFileToolStripMenuItem.Name = "txtFileToolStripMenuItem";
            this.txtFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.txtFileToolStripMenuItem.Text = ".txt Файл";
            this.txtFileToolStripMenuItem.Click += new System.EventHandler(this.txtFileToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Поиск";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.showAllToolStripMenuItem.Text = "Показать всех";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.ContextMenuStrip = this.cmTable;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(12, 27);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(1190, 411);
            this.dataGrid.TabIndex = 1;
            // 
            // cmTable
            // 
            this.cmTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedWorkerToolStripMenuItem,
            this.editSelectedWorkerToolStripMenuItem});
            this.cmTable.Name = "cmTable";
            this.cmTable.Size = new System.Drawing.Size(292, 48);
            // 
            // deleteSelectedWorkerToolStripMenuItem
            // 
            this.deleteSelectedWorkerToolStripMenuItem.Name = "deleteSelectedWorkerToolStripMenuItem";
            this.deleteSelectedWorkerToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.deleteSelectedWorkerToolStripMenuItem.Text = "Удалить выделенного работника";
            this.deleteSelectedWorkerToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedWorkerToolStripMenuItem_Click);
            // 
            // editSelectedWorkerToolStripMenuItem
            // 
            this.editSelectedWorkerToolStripMenuItem.Name = "editSelectedWorkerToolStripMenuItem";
            this.editSelectedWorkerToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.editSelectedWorkerToolStripMenuItem.Text = "Редактировать выделенного работника";
            this.editSelectedWorkerToolStripMenuItem.Click += new System.EventHandler(this.editSelectedWorkerToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата отсчета:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(623, 5);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(78, 13);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "Дата отсчета:";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.openFileToolStripMenuItem.Text = "Восстановить данные из файла";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 450);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о работниках";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.cmTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экпортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtFileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ContextMenuStrip cmTable;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedWorkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
    }
}

