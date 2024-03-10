namespace 作业系统
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            label1 = new Label();
            thisClass = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(234, 298);
            button1.Name = "button1";
            button1.Size = new Size(130, 89); 
            button1.TabIndex = 0;
            button1.Text = "选择班级";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 256);
            label1.Name = "label1";
            label1.Size = new Size(167, 39);
            label1.TabIndex = 1;
            label1.Text = "当前班级：";
            // 
            // thisClass
            // 
            thisClass.AutoSize = true;
            thisClass.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            thisClass.Location = new Point(311, 263);
            thisClass.Name = "thisClass";
            thisClass.Size = new Size(0, 31);
            thisClass.TabIndex = 2;
            thisClass.Text = @"ZYX_HomeworkSystem/classes/now.cl";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 648);
            Controls.Add(thisClass);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "   ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        public Label thisClass;
    }
}