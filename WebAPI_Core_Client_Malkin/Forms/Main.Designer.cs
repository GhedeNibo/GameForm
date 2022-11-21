
namespace WebAPI_Core_Client_Malkin
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
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuAccaunt = new System.Windows.Forms.ToolStripMenuItem();
            this.logOuttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTables = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageOwner = new System.Windows.Forms.TabPage();
            this.dgvOwner = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddOwner = new System.Windows.Forms.Button();
            this.btnDeleteOwner = new System.Windows.Forms.Button();
            this.btnUpdateOwner = new System.Windows.Forms.Button();
            this.btnReloadOwner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tabPageOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwner)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(16, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(130, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Обновить";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(6, 6);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(740, 384);
            this.dgvTable.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAccaunt,
            this.toolStripMenuItemTables});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuAccaunt
            // 
            this.toolStripMenuAccaunt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOuttoolStripMenuItem});
            this.toolStripMenuAccaunt.Name = "toolStripMenuAccaunt";
            this.toolStripMenuAccaunt.Size = new System.Drawing.Size(103, 20);
            this.toolStripMenuAccaunt.Text = "Учетная запись";
            // 
            // logOuttoolStripMenuItem
            // 
            this.logOuttoolStripMenuItem.Name = "logOuttoolStripMenuItem";
            this.logOuttoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOuttoolStripMenuItem.Text = "Выйти";
            this.logOuttoolStripMenuItem.Click += new System.EventHandler(this.logOuttoolStripMenuItem_Click);
            // 
            // toolStripMenuItemTables
            // 
            this.toolStripMenuItemTables.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.userTypesToolStripMenuItem});
            this.toolStripMenuItemTables.Name = "toolStripMenuItemTables";
            this.toolStripMenuItemTables.Size = new System.Drawing.Size(68, 20);
            this.toolStripMenuItemTables.Text = "Таблицы";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // userTypesToolStripMenuItem
            // 
            this.userTypesToolStripMenuItem.Name = "userTypesToolStripMenuItem";
            this.userTypesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userTypesToolStripMenuItem.Text = "UserTypes";
            this.userTypesToolStripMenuItem.Click += new System.EventHandler(this.userTypesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Location = new System.Drawing.Point(752, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 384);
            this.panel1.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_ClickAsync);
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(784, 9);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(0, 13);
            this.lbLogin.TabIndex = 9;
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabPageMain);
            this.tcMain.Controls.Add(this.tabPageOwner);
            this.tcMain.Location = new System.Drawing.Point(0, 27);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(927, 422);
            this.tcMain.TabIndex = 10;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.dgvTable);
            this.tabPageMain.Controls.Add(this.panel1);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(919, 396);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Главная";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPageOwner
            // 
            this.tabPageOwner.Controls.Add(this.dgvOwner);
            this.tabPageOwner.Controls.Add(this.panel2);
            this.tabPageOwner.Location = new System.Drawing.Point(4, 22);
            this.tabPageOwner.Name = "tabPageOwner";
            this.tabPageOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOwner.Size = new System.Drawing.Size(919, 396);
            this.tabPageOwner.TabIndex = 1;
            this.tabPageOwner.Text = "Ваши записи";
            this.tabPageOwner.UseVisualStyleBackColor = true;
            // 
            // dgvOwner
            // 
            this.dgvOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOwner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwner.Location = new System.Drawing.Point(7, 6);
            this.dgvOwner.Name = "dgvOwner";
            this.dgvOwner.Size = new System.Drawing.Size(740, 384);
            this.dgvOwner.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnAddOwner);
            this.panel2.Controls.Add(this.btnDeleteOwner);
            this.panel2.Controls.Add(this.btnUpdateOwner);
            this.panel2.Controls.Add(this.btnReloadOwner);
            this.panel2.Location = new System.Drawing.Point(753, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 384);
            this.panel2.TabIndex = 10;
            // 
            // btnAddOwner
            // 
            this.btnAddOwner.Location = new System.Drawing.Point(16, 32);
            this.btnAddOwner.Name = "btnAddOwner";
            this.btnAddOwner.Size = new System.Drawing.Size(130, 23);
            this.btnAddOwner.TabIndex = 5;
            this.btnAddOwner.Text = "Добавить";
            this.btnAddOwner.UseVisualStyleBackColor = true;
            this.btnAddOwner.Click += new System.EventHandler(this.btnAddOwner_Click);
            // 
            // btnDeleteOwner
            // 
            this.btnDeleteOwner.Location = new System.Drawing.Point(16, 91);
            this.btnDeleteOwner.Name = "btnDeleteOwner";
            this.btnDeleteOwner.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteOwner.TabIndex = 4;
            this.btnDeleteOwner.Text = "Удалить";
            this.btnDeleteOwner.UseVisualStyleBackColor = true;
            this.btnDeleteOwner.Click += new System.EventHandler(this.btnDeleteOwner_ClickAsync);
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Location = new System.Drawing.Point(16, 62);
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.Size = new System.Drawing.Size(130, 23);
            this.btnUpdateOwner.TabIndex = 3;
            this.btnUpdateOwner.Text = "Изменить";
            this.btnUpdateOwner.UseVisualStyleBackColor = true;
            this.btnUpdateOwner.Click += new System.EventHandler(this.btnUpdateOwner_ClickAsync);
            // 
            // btnReloadOwner
            // 
            this.btnReloadOwner.Location = new System.Drawing.Point(16, 3);
            this.btnReloadOwner.Name = "btnReloadOwner";
            this.btnReloadOwner.Size = new System.Drawing.Size(130, 23);
            this.btnReloadOwner.TabIndex = 2;
            this.btnReloadOwner.Text = "Обновить";
            this.btnReloadOwner.UseVisualStyleBackColor = true;
            this.btnReloadOwner.Click += new System.EventHandler(this.btnReloadOwner_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 449);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "GamsShop Client";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageOwner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwner)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAccaunt;
        private System.Windows.Forms.ToolStripMenuItem logOuttoolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTables;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userTypesToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageOwner;
        private System.Windows.Forms.DataGridView dgvOwner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddOwner;
        private System.Windows.Forms.Button btnDeleteOwner;
        private System.Windows.Forms.Button btnUpdateOwner;
        private System.Windows.Forms.Button btnReloadOwner;
    }
}

