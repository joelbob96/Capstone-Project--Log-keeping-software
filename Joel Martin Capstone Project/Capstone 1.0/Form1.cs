using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capstone_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CheckForDirectory("C:\\DispatchFiles");

            DateTime today = DateTime.Now;
            date.Text = today.ToString("d");
            startTime.Text = today.ToString("t");
            LoadOfficers();
        }

        //Ensures Dispatch files and LogEntries folder exists in C drive, along with the officers folder
        private void CheckForDirectory(String path)
        {
            if (!System.IO.Directory.Exists(@path))
            {
                System.IO.Directory.CreateDirectory(@path);
                String path2 = path + "\\LogEntries";
                System.IO.Directory.CreateDirectory(@path2);
                
            }
            String OffFile = path + "\\Officers.csv";
            if (!System.IO.File.Exists(@OffFile)) { 
            using (StreamWriter writer = new StreamWriter(OffFile))
                {
                    //writer.Write("Joel Martin 1");
                }
            }
        }

        //fills end time box with current time on click
        private void endTime_setTime(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            endTime.Text = today.ToString("t");
        }

        //saves data entered into boxes and officers added to the call, saves as a csv file in the LogEntries directory
        private void SaveLog(object sender, MouseEventArgs e)
        {
            List<Officer> officers = new List<Officer>();
            //Officer o1 = new Officer(firstName.Text, lastName.Text, System.Convert.ToInt32(badgeNumber.Text));
            //officers.Add(o1);
            foreach(FlowLayoutPanel flow in CallOfficers.Controls)
            {
                foreach (Control c in flow.Controls)
                    if (c.GetType() == typeof(Label))
                    {
                        string[] off = c.Text.Split(' ');
                        Officer o1 = new Officer(off[0], off[1], System.Convert.ToInt32(off[2]));
                        officers.Add(o1);
                    }
 
            }
            string date1 = date.Text.Replace('/', '.');
            string stime = startTime.Text.Replace(':', '.');
            string etime = endTime.Text.Replace(':', '.');
            LogEntry l1 = new LogEntry(date1, stime, etime, location.Text, incidentType.Text, description.Text, officers);
            l1.SaveLog();
        }

        //Load selected csv file into the form, filling the text boxes and adding the officers. Only called from Form2
        public void LoadLogToForm(String fileName)
        {
            LogEntry l1 = new LogEntry();
            l1.LoadLog(fileName);
            date.Text = l1.getDate().Replace('.', '/');
            endTime.Text = l1.getEndTime().Replace('.', ':');
            startTime.Text = l1.getStartTime().Replace('.', ':');
            location.Text = l1.getLocation();
            incidentType.Text = l1.getIncidentType();
            description.Text = l1.getDescription();
            List<Officer> officers = l1.getOfficers();

            
            for (int i = 0; i < officers.Count; i++)
            {
                string o1 = officers[i].getFName() + ' ' + officers[i].getLName() + ' ' + officers[i].getBadge().ToString();
                AddOfficerToPanel(o1);
            }
        }

        //Loads officer list from "Officers.csv" and instantiates a button for each officer into the officer box
        private void LoadOfficers()
        {
            OfficerBox.Controls.Clear();
            string loadedData;
            string fileName = "C:\\DispatchFiles\\Officers.csv";
            if (File.Exists(fileName))
            {
                using (StreamReader readtext = new StreamReader(fileName))
                {
                    if ((loadedData = readtext.ReadLine()) != null)
                    {
                        string[] data = loadedData.Split(',');
                        for(int i = 0; i < data.Length; i++)
                        {
                            Button btn = new Button();
                            btn.Size = new Size(150, 30);
                            btn.Text = data[i];
                            btn.Click += AddOfficer;
                            OfficerBox.Controls.Add(btn);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File " + fileName + " could not be found");
            }
        }

        //add selected officer from OfficerBox panel to the CallOfficer panel
        void AddOfficer(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            //string [] officer = s.Split(' ');

            AddOfficerToPanel(s);
        }

        //Called from AddOfficer function adds the officer from the OfficerBox to the CallOfficer panel 
        private void AddOfficerToPanel(String s)
        {
            Label l1 = new Label();
            l1.Text = s;
            l1.Size = new Size(150, 20);

            Button btn = new Button();
            btn.Text = "Remove";
            btn.Size = new Size(150, 20);
            btn.Click += DeleteParent;

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Size = new Size(320, 25);
            flow.Controls.Add(l1);
            flow.Controls.Add(btn);

            CallOfficers.Controls.Add(flow);
        }

        //opens form2 to load calls from the C:/DispatchFiles/LogEntries directory
        private void ChangeCall_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            //frm.FormClosing += delegate { this.Show(); };
            frm.ShowDialog();
            //this.Hide();
        }

        //launches form3 to make changes to the availible officers box
        private void AddOff_Click(object sender, EventArgs e)
        {
            var frm = new Form3();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed); ;

            //this.Hide();
            frm.ShowDialog();
            
        }

        //re-loads the officer box after changes have been made in form3
        private void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            LoadOfficers();
        }

        //Deletes the parent of the button, used to remove an officer from the CallOfficer box
        private void DeleteParent(object sender, EventArgs e)
        {
            //(sender as Button).Parent.Controls.Clear();
            CallOfficers.Controls.Remove((sender as Button).Parent);
        }

        //Cleans up extra hidden pannels or re-launch of form1
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            if(openForms[0].Visible == true)
            openForms[0].Hide();
                

            if(openForms.Count > 3)
                openForms[1].Close();
        }

        //Ensures all open forms are closed when the button is pressed
        private void CloseAll(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                    f.Close();
            }
        }

        //Clears and resets the contents of the text boxes and CallOfficers panel
        private void NewCall_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            date.Text = today.ToString("d");
            startTime.Text = today.ToString("t");
            endTime.Text = "";
            location.Text = "";
            incidentType.Text = "";
            description.Text = "";
            CallOfficers.Controls.Clear();

        }
    }
}
