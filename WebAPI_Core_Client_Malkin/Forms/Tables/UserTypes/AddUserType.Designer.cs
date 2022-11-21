
namespace WebAPI_Core_Client_Malkin
{
    partial class AddUserType
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
            this.cbRead = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCreate = new System.Windows.Forms.CheckBox();
            this.cbEditAll = new System.Windows.Forms.CheckBox();
            this.cbEdit = new System.Windows.Forms.CheckBox();
            this.cbRezTable = new System.Windows.Forms.CheckBox();
            this.cbDeleteAll = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbUserTable = new System.Windows.Forms.CheckBox();
            this.cbEmergTable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbRead
            // 
            this.cbRead.AutoSize = true;
            this.cbRead.Location = new System.Drawing.Point(31, 70);
            this.cbRead.Name = "cbRead";
            this.cbRead.Size = new System.Drawing.Size(52, 17);
            this.cbRead.TabIndex = 0;
            this.cbRead.Text = "Read";
            this.cbRead.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(91, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbTypeName
            // 
            this.tbTypeName.Location = new System.Drawing.Point(91, 33);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.Size = new System.Drawing.Size(142, 20);
            this.tbTypeName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // cbCreate
            // 
            this.cbCreate.AutoSize = true;
            this.cbCreate.Location = new System.Drawing.Point(31, 93);
            this.cbCreate.Name = "cbCreate";
            this.cbCreate.Size = new System.Drawing.Size(57, 17);
            this.cbCreate.TabIndex = 5;
            this.cbCreate.Text = "Create";
            this.cbCreate.UseVisualStyleBackColor = true;
            // 
            // cbEditAll
            // 
            this.cbEditAll.AutoSize = true;
            this.cbEditAll.Location = new System.Drawing.Point(31, 139);
            this.cbEditAll.Name = "cbEditAll";
            this.cbEditAll.Size = new System.Drawing.Size(55, 17);
            this.cbEditAll.TabIndex = 7;
            this.cbEditAll.Text = "EditAll";
            this.cbEditAll.UseVisualStyleBackColor = true;
            // 
            // cbEdit
            // 
            this.cbEdit.AutoSize = true;
            this.cbEdit.Location = new System.Drawing.Point(31, 116);
            this.cbEdit.Name = "cbEdit";
            this.cbEdit.Size = new System.Drawing.Size(44, 17);
            this.cbEdit.TabIndex = 6;
            this.cbEdit.Text = "Edit";
            this.cbEdit.UseVisualStyleBackColor = true;
            // 
            // cbRezTable
            // 
            this.cbRezTable.AutoSize = true;
            this.cbRezTable.Location = new System.Drawing.Point(31, 206);
            this.cbRezTable.Name = "cbRezTable";
            this.cbRezTable.Size = new System.Drawing.Size(72, 17);
            this.cbRezTable.TabIndex = 10;
            this.cbRezTable.Text = "RezTable";
            this.cbRezTable.UseVisualStyleBackColor = true;
            // 
            // cbDeleteAll
            // 
            this.cbDeleteAll.AutoSize = true;
            this.cbDeleteAll.Location = new System.Drawing.Point(31, 183);
            this.cbDeleteAll.Name = "cbDeleteAll";
            this.cbDeleteAll.Size = new System.Drawing.Size(68, 17);
            this.cbDeleteAll.TabIndex = 9;
            this.cbDeleteAll.Text = "DeleteAll";
            this.cbDeleteAll.UseVisualStyleBackColor = true;
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(31, 160);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(57, 17);
            this.cbDelete.TabIndex = 8;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbUserTable
            // 
            this.cbUserTable.AutoSize = true;
            this.cbUserTable.Location = new System.Drawing.Point(31, 252);
            this.cbUserTable.Name = "cbUserTable";
            this.cbUserTable.Size = new System.Drawing.Size(75, 17);
            this.cbUserTable.TabIndex = 12;
            this.cbUserTable.Text = "UserTable";
            this.cbUserTable.UseVisualStyleBackColor = true;
            // 
            // cbEmergTable
            // 
            this.cbEmergTable.AutoSize = true;
            this.cbEmergTable.Location = new System.Drawing.Point(31, 229);
            this.cbEmergTable.Name = "cbEmergTable";
            this.cbEmergTable.Size = new System.Drawing.Size(83, 17);
            this.cbEmergTable.TabIndex = 11;
            this.cbEmergTable.Text = "EmergTable";
            this.cbEmergTable.UseVisualStyleBackColor = true;
            // 
            // AddUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 307);
            this.Controls.Add(this.cbUserTable);
            this.Controls.Add(this.cbEmergTable);
            this.Controls.Add(this.cbRezTable);
            this.Controls.Add(this.cbDeleteAll);
            this.Controls.Add(this.cbDelete);
            this.Controls.Add(this.cbEditAll);
            this.Controls.Add(this.cbEdit);
            this.Controls.Add(this.cbCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbRead);
            this.Name = "AddUserType";
            this.Text = "AddUserType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbRead;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbCreate;
        private System.Windows.Forms.CheckBox cbEditAll;
        private System.Windows.Forms.CheckBox cbEdit;
        private System.Windows.Forms.CheckBox cbRezTable;
        private System.Windows.Forms.CheckBox cbDeleteAll;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbUserTable;
        private System.Windows.Forms.CheckBox cbEmergTable;
    }
}