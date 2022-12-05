
namespace WebAPI_Core_Client_Malkin.Forms.Archives
{
    partial class Archive
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbDbList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(297, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Создать копию";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbDbList
            // 
            this.cbDbList.FormattingEnabled = true;
            this.cbDbList.Location = new System.Drawing.Point(12, 12);
            this.cbDbList.Name = "cbDbList";
            this.cbDbList.Size = new System.Drawing.Size(279, 21);
            this.cbDbList.TabIndex = 2;
            this.cbDbList.SelectedIndexChanged += new System.EventHandler(this.cbDbList_SelectedIndexChanged);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 234);
            this.Controls.Add(this.cbDbList);
            this.Controls.Add(this.btnCreate);
            this.Name = "Archive";
            this.Text = "Archive";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbDbList;
    }
}