
namespace Capstone_1._0
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ChangeCall = new System.Windows.Forms.Button();
            this.endTime = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.incidentType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CallOfficers = new System.Windows.Forms.FlowLayoutPanel();
            this.OfficerBox = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddOff = new System.Windows.Forms.Button();
            this.NewCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ChangeCall
            // 
            this.ChangeCall.Location = new System.Drawing.Point(16, 12);
            this.ChangeCall.Name = "ChangeCall";
            this.ChangeCall.Size = new System.Drawing.Size(75, 43);
            this.ChangeCall.TabIndex = 29;
            this.ChangeCall.Text = "Load Call";
            this.ChangeCall.UseVisualStyleBackColor = true;
            this.ChangeCall.Click += new System.EventHandler(this.ChangeCall_Click);
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(400, 112);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(207, 20);
            this.endTime.TabIndex = 3;
            this.endTime.Click += new System.EventHandler(this.endTime_setTime);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(120, 85);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(204, 20);
            this.date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date:";
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(400, 85);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(207, 20);
            this.startTime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Time";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(122, 205);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(485, 83);
            this.description.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Time";
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(122, 138);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(485, 20);
            this.location.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Location";
            // 
            // incidentType
            // 
            this.incidentType.Location = new System.Drawing.Point(122, 164);
            this.incidentType.Name = "incidentType";
            this.incidentType.Size = new System.Drawing.Size(485, 20);
            this.incidentType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Incident Type";
            // 
            // CallOfficers
            // 
            this.CallOfficers.AutoScroll = true;
            this.CallOfficers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CallOfficers.Location = new System.Drawing.Point(122, 329);
            this.CallOfficers.Name = "CallOfficers";
            this.CallOfficers.Size = new System.Drawing.Size(485, 157);
            this.CallOfficers.TabIndex = 27;
            // 
            // OfficerBox
            // 
            this.OfficerBox.BackColor = System.Drawing.Color.Bisque;
            this.OfficerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OfficerBox.Location = new System.Drawing.Point(661, 85);
            this.OfficerBox.Name = "OfficerBox";
            this.OfficerBox.Size = new System.Drawing.Size(162, 479);
            this.OfficerBox.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveLog);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(718, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(105, 38);
            this.Close.TabIndex = 30;
            this.Close.Text = "Close Application";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.CloseAll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Available Officers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Officers Dispatched";
            // 
            // AddOff
            // 
            this.AddOff.Location = new System.Drawing.Point(664, 581);
            this.AddOff.Name = "AddOff";
            this.AddOff.Size = new System.Drawing.Size(159, 29);
            this.AddOff.TabIndex = 33;
            this.AddOff.Text = "Add/Remove Officers";
            this.AddOff.UseVisualStyleBackColor = true;
            this.AddOff.Click += new System.EventHandler(this.AddOff_Click);
            // 
            // NewCall
            // 
            this.NewCall.Location = new System.Drawing.Point(177, 12);
            this.NewCall.Name = "NewCall";
            this.NewCall.Size = new System.Drawing.Size(74, 43);
            this.NewCall.TabIndex = 34;
            this.NewCall.Text = "New Call";
            this.NewCall.UseVisualStyleBackColor = true;
            this.NewCall.Click += new System.EventHandler(this.NewCall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(865, 630);
            this.Controls.Add(this.NewCall);
            this.Controls.Add(this.AddOff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.incidentType);
            this.Controls.Add(this.ChangeCall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CallOfficers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OfficerBox);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dispatching Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ChangeCall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel OfficerBox;
        private System.Windows.Forms.FlowLayoutPanel CallOfficers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox incidentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox endTime;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddOff;
        private System.Windows.Forms.Button NewCall;
    }
}

