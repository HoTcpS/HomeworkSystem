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

namespace 作业系统
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (File.ReadAllText(@"ZYX_HomeworkSystem\eula.txt") == "true")
            {
                if (!Directory.Exists(@"ZYX_HomeworkSystem\classes"))
                {
                    Directory.CreateDirectory(@"ZYX_HomeworkSystem\classes");
                    for (int i = 1; i <= 5; i++)
                    {
                        File.CreateText(@"ZYX_HomeworkSystem\classes\class" + i.ToString() + ".cl");
                    }
                    File.CreateText(@"ZYX_HomeworkSystem\classes\now.cl");
                }
            }
            File.WriteAllText(@"ZYX_HomeworkSystem\classes\class1.cl", "25");
            string classname = File.ReadAllText(@"ZYX_HomeworkSystem\classes\class1.cl");
            label1.Text = classname;
            classname = File.ReadAllText(@"ZYX_HomeworkSystem\classes\class2.cl");
            label2.Text = classname;
            classname = File.ReadAllText(@"ZYX_HomeworkSystem\classes\class3.cl");
            label3.Text = classname;
            classname = File.ReadAllText(@"ZYX_HomeworkSystem\classes\class4.cl");
            label4.Text = classname;
            classname = File.ReadAllText(@"ZYX_HomeworkSystem\classes\class5.cl");
            label5.Text = classname;
            File.WriteAllText(@"ZYX_HomeworkSystem\classes\now.cl", File.ReadAllText(@"ZYX_HomeworkSystem\classes\class1.cl"));
        }
        public string Thisclassname { get; private set; }

        private void class1_Click(object sender, EventArgs e)
        {
            Thisclassname = label1.Text;
            new Form1().Init();
            Close();
        }

        private void class2_Click(object sender, EventArgs e)
        {
            Thisclassname = label2.Text;
            new Form1().Show();
            Close();
        }

        private void class3_Click(object sender, EventArgs e)
        {
            Thisclassname = label3.Text;
            new Form1().Show();
            Close();
        }

        private void class4_Click(object sender, EventArgs e)
        {
            Thisclassname = label4.Text;
            new Form1().Show();
            Close();
        }

        private void class5_Click(object sender, EventArgs e)
        {
            Thisclassname = label5.Text;
            new Form1().Show();
            Close();
        }
    }
}
