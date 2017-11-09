using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personinformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var email = textBox2.Text;
            var phoneno = textBox3.Text.ToString();
            var dateofdate = int.Parse(dateTimePicker1.Value.ToString("yyyyMMdd"));
            var todaydaydate =int.Parse( DateTime.Today.ToString("yyyyMMdd"));
            var age = ((todaydaydate-dateofdate) / 10000).ToString();
            richTextBox1.Text = name + Environment.NewLine + email + Environment.NewLine + phoneno + Environment.NewLine + age;
            saveFileDialog1.ShowDialog();
            
            File.WriteAllLines(saveFileDialog1.FileName, richTextBox1.Lines);
           
        }
    }
}
