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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\\DispatchFiles\\LogEntries\\");
            FileInfo[] LogFiles = dirinfo.GetFiles("*.csv");
            foreach (FileInfo fi in LogFiles)
            {
                //ticketBox.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
                Button btn = new Button();
                btn.Name = Path.GetFileNameWithoutExtension(fi.Name);
                btn.Text = Path.GetFileNameWithoutExtension(fi.Name);
                btn.Size = new Size(300, 20);
                btn.Click += LoadLog1;
                LoadedLogs.Controls.Add(btn);
            }
        }

        private void LoadLog1(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            string s = (sender as Button).Name + ".csv";
            frm.LoadLogToForm(s);
            frm.Show();
            
            this.Close();
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            
            frm.Show();
            this.Close();
        }
    }
}
