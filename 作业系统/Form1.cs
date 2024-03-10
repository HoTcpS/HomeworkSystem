using System.Diagnostics;

namespace 作业系统
{
    public partial class Form1 : Form
    {
        public int Init()
        {
            try
            {
                if (!Directory.Exists(@"ZYX_HomeworkSystem"))
                {
                    Directory.CreateDirectory(@"ZYX_HomeworkSystem");
                    File.CreateText(@"ZYX_HomeworkSystem\eula.txt");
                    File.WriteAllText(@"ZYX_HomeworkSystem\eula.txt", "false");
                }
                thisClass.Text = new Form2().Thisclassname;
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {
            if(Init() < 0) {
                MessageBox.Show("发生错误（错误代码："+ Init().ToString()+"）");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}