
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
            this.tbH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.btnSavePolicy = new System.Windows.Forms.Button();
            this.tbCopy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(53, 27);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(24, 20);
            this.tbH.TabIndex = 3;
            this.tbH.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ч";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "м";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(101, 27);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(24, 20);
            this.tbM.TabIndex = 5;
            this.tbM.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "д";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(5, 27);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(24, 20);
            this.tbD.TabIndex = 7;
            this.tbD.Text = "30";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "с";
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(149, 27);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(24, 20);
            this.tbS.TabIndex = 9;
            this.tbS.Text = "0";
            // 
            // btnSavePolicy
            // 
            this.btnSavePolicy.Location = new System.Drawing.Point(284, 140);
            this.btnSavePolicy.Name = "btnSavePolicy";
            this.btnSavePolicy.Size = new System.Drawing.Size(75, 23);
            this.btnSavePolicy.TabIndex = 11;
            this.btnSavePolicy.Text = "Сохранить";
            this.btnSavePolicy.UseVisualStyleBackColor = true;
            this.btnSavePolicy.Click += new System.EventHandler(this.btnSavePolicy_Click);
            // 
            // tbCopy
            // 
            this.tbCopy.Location = new System.Drawing.Point(7, 90);
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(24, 20);
            this.tbCopy.TabIndex = 12;
            this.tbCopy.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Количество хранимых резервных копий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Назначить периодическое времия создания копий";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbCopy);
            this.panel1.Controls.Add(this.tbM);
            this.panel1.Controls.Add(this.btnSavePolicy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbD);
            this.panel1.Controls.Add(this.tbS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 177);
            this.panel1.TabIndex = 15;
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 234);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbDbList);
            this.Controls.Add(this.btnCreate);
            this.Name = "Archive";
            this.Text = "Archive";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbDbList;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Button btnSavePolicy;
        private System.Windows.Forms.TextBox tbCopy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}