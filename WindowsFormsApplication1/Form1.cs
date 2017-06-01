using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NextLevelStuff;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainClass mClass = new mainClass();

            label1.Text = mClass.testME1("", "", 233);
            textBox1.Text = mClass.testME2("23", "22", 1);
            label2.Text = mClass.testME3("A", "B", 3).ToString();
            radioButton1.Checked = mClass.testME4("", "BB", 2);
        }
    }
}
