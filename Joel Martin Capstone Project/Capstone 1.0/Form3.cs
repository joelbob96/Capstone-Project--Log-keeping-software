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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadOfficers();
        }

        //function called when Add button is clicked, adds an officer to the officer box based on data entered into the text boxes
        private void Addbtn_Click(object sender, EventArgs e)
        {

            if ((firstName.Text.Length > 0) && (badgeNumber.Text.Length > 0) && (lastName.Text.Length > 0)) {
                String data;
                //if (new FileInfo("C:\\DispatchFiles\\Officers.csv").Length == 0)
                //{
                 data = firstName.Text + " " + lastName.Text + " " + badgeNumber.Text;
                AddOfficer(data);
                firstName.Text = "";
                lastName.Text = "";
                badgeNumber.Text = "";

                /*}
                else
                {
                    data = ',' + firstName.Text + " " + lastName.Text + " " + badgeNumber.Text;
                }
                using (StreamWriter writer = File.AppendText("C:\\DispatchFiles\\Officers.csv"))
                {
                    writer.Write(data);
                    output1.Text = data + " was added to the officers";
                }*/
            }
        }

        //Load officers from Officers.csv file into the OfficerBox as removable objects
        private void LoadOfficers()
        {
            string loadedData;
            string fileName = "C:\\DispatchFiles\\Officers.csv";
            if (File.Exists(fileName))
            {
                using (StreamReader readtext = new StreamReader(fileName))
                {
                    if ((loadedData = readtext.ReadLine()) != null)
                    {
                        string[] data = loadedData.Split(',');
                        for (int i = 0; i < data.Length; i++)
                        {
                            AddOfficer(data[i]);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File " + fileName + " could not be found");
            }
        }

        //remove button deletes its parent flow control panel parent when clicked
        private void RemoveOfficer(object sender, EventArgs e)
        {
                OfficerBox.Controls.Remove((sender as Button).Parent);
        }

        //Saves officers stored in the OfficerBox to the Officers.csv file
        private void SaveChanges_click(object sender, EventArgs e)
        {
            string fileName = "C:\\DispatchFiles\\Officers.csv";
            string output1 = "";
            //output.Add("Hello");
            //int i = 0;


            foreach (FlowLayoutPanel flow in OfficerBox.Controls)
            {
                foreach (Control c in flow.Controls)
                    if (c.GetType() == typeof(Label))
                    {
                        output1 += c.Text + ',';
                        //output.Add(c.Text);
                    }

            }
            string output2 = output1.Remove(output1.Length - 1, 1);
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(output2);
            }
        }

        //Adds the officer string to the OfficerBox as a flowpanel with a label matching the input string, and a button.
        private void AddOfficer(String off)
        {
            FlowLayoutPanel flow = new FlowLayoutPanel();
            Button btn = new Button();
            Label lbl = new Label();
            btn.Size = new Size(150, 20);
            lbl.Size = new Size(150, 20);
            flow.Size = new Size(350, 22);
            lbl.Text = off;
            btn.Text = "Remove Officer";
            btn.Click += RemoveOfficer;
            flow.Controls.Add(lbl);
            flow.Controls.Add(btn);
            OfficerBox.Controls.Add(flow);
        }
    }
}
