
namespace T5Z2
{
    partial class AddEditEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmploymentDate = new System.Windows.Forms.Label();
            this.lblDismissalDate = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbEmploymentDate = new System.Windows.Forms.TextBox();
            this.tbDismissalDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(127, 27);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(182, 20);
            this.tbId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Imię";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(127, 79);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(182, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwisko";
            // 
            // lblEmploymentDate
            // 
            this.lblEmploymentDate.AutoSize = true;
            this.lblEmploymentDate.Location = new System.Drawing.Point(21, 108);
            this.lblEmploymentDate.Name = "lblEmploymentDate";
            this.lblEmploymentDate.Size = new System.Drawing.Size(90, 13);
            this.lblEmploymentDate.TabIndex = 6;
            this.lblEmploymentDate.Text = "Data zatrudnienia";
            // 
            // lblDismissalDate
            // 
            this.lblDismissalDate.AutoSize = true;
            this.lblDismissalDate.Location = new System.Drawing.Point(21, 134);
            this.lblDismissalDate.Name = "lblDismissalDate";
            this.lblDismissalDate.Size = new System.Drawing.Size(82, 13);
            this.lblDismissalDate.TabIndex = 8;
            this.lblDismissalDate.Text = "Data zwolnienia";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(127, 157);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(182, 20);
            this.tbSalary.TabIndex = 6;
            this.tbSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalary_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wynagrodzenie";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(127, 53);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(182, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Uwagi";
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.Location = new System.Drawing.Point(127, 185);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.Size = new System.Drawing.Size(182, 96);
            this.rtbFeedback.TabIndex = 7;
            this.rtbFeedback.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(87, 293);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbEmploymentDate
            // 
            this.tbEmploymentDate.Location = new System.Drawing.Point(127, 105);
            this.tbEmploymentDate.Name = "tbEmploymentDate";
            this.tbEmploymentDate.Size = new System.Drawing.Size(182, 20);
            this.tbEmploymentDate.TabIndex = 4;
            // 
            // tbDismissalDate
            // 
            this.tbDismissalDate.Location = new System.Drawing.Point(127, 131);
            this.tbDismissalDate.Name = "tbDismissalDate";
            this.tbDismissalDate.Size = new System.Drawing.Size(182, 20);
            this.tbDismissalDate.TabIndex = 5;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(336, 328);
            this.Controls.Add(this.tbDismissalDate);
            this.Controls.Add(this.tbEmploymentDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtbFeedback);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDismissalDate);
            this.Controls.Add(this.lblEmploymentDate);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label1);
            this.Name = "AddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmploymentDate;
        private System.Windows.Forms.Label lblDismissalDate;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbFeedback;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbEmploymentDate;
        private System.Windows.Forms.TextBox tbDismissalDate;
    }
}