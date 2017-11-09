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

namespace UpperCaseTextApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonopen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
           
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var content = File.ReadAllText(openFileDialog1.FileName);
            File.WriteAllText(saveFileDialog1.FileName, content.ToUpper());
            richTextBox2.Text = File.ReadAllText(saveFileDialog1.FileName);
           
        }
    }
}
