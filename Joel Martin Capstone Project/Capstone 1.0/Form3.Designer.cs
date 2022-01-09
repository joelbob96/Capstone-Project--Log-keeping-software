
namespace Capstone_1._0
{
    partial class Form3
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.badgeNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.output1 = new System.Windows.Forms.Label();
            this.OfficerBox = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(12, 51);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(152, 51);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 1;
            // 
            // badgeNumber
            // 
            this.badgeNumber.Location = new System.Drawing.Point(286, 51);
            this.badgeNumber.Name = "badgeNumber";
            this.badgeNumber.Size = new System.Drawing.Size(100, 20);
            this.badgeNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Badge Number";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(442, 51);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // output1
            // 
            this.output1.AutoSize = true;
            this.output1.Location = new System.Drawing.Point(12, 110);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(0, 13);
            this.output1.TabIndex = 7;
            // 
            // OfficerBox
            // 
            this.OfficerBox.AutoScroll = true;
            this.OfficerBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OfficerBox.Location = new System.Drawing.Point(15, 126);
            this.OfficerBox.Name = "OfficerBox";
            this.OfficerBox.Size = new System.Drawing.Size(371, 364);
            this.OfficerBox.TabIndex = 8;
            // 
            // SaveChanges
            // 
            this.SaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChanges.Location = new System.Drawing.Point(15, 509);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(371, 36);
            this.SaveChanges.TabIndex = 9;
            this.SaveChanges.Text = "Save Changes";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 557);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.OfficerBox);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.badgeNumber);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox badgeNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label output1;
        private System.Windows.Forms.FlowLayoutPanel OfficerBox;
        private System.Windows.Forms.Button SaveChanges;
    }
}