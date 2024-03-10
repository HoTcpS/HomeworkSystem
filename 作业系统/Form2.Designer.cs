namespace 作业系统
{
    partial class Form2
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
            class1 = new Button();
            class5 = new Button();
            class4 = new Button();
            class3 = new Button();
            class2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // class1
            // 
            class1.Location = new Point(14, 20);
            class1.Name = "class1";
            class1.Size = new Size(140, 28);
            class1.TabIndex = 0;
            class1.Text = "选择";
            class1.UseVisualStyleBackColor = true;
            class1.Click += class1_Click;
            // 
            // class5
            // 
            class5.Location = new Point(14, 340);
            class5.Name = "class5";
            class5.Size = new Size(140, 28);
            class5.TabIndex = 2;
            class5.Text = "选择";
            class5.UseVisualStyleBackColor = true;
            class5.Click += class5_Click;
            // 
            // class4
            // 
            class4.Location = new Point(14, 260);
            class4.Name = "class4";
            class4.Size = new Size(140, 28);
            class4.TabIndex = 3;
            class4.Text = "选择";
            class4.UseVisualStyleBackColor = true;
            class4.Click += class4_Click;
            // 
            // class3
            // 
            class3.Location = new Point(14, 180);
            class3.Name = "class3";
            class3.Size = new Size(140, 28);
            class3.TabIndex = 4;
            class3.Text = "选择";
            class3.UseVisualStyleBackColor = true;
            class3.Click += class3_Click;
            // 
            // class2
            // 
            class2.Location = new Point(14, 100);
            class2.Name = "class2";
            class2.Size = new Size(140, 28);
            class2.TabIndex = 5;
            class2.Text = "选择";
            class2.UseVisualStyleBackColor = true;
            class2.Click += class2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 24);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 104);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 184);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 264);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 344);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 407);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(class2);
            Controls.Add(class3);
            Controls.Add(class4);
            Controls.Add(class5);
            Controls.Add(class1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button class1;
        public Button class2;
        public Button class3;
        public Button class4;
        public Button class5;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
    }
}