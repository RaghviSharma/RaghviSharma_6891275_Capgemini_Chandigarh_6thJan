namespace WinFormsAppDemo2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            IDtb = new TextBox();
            nameTB = new TextBox();
            designTB = new TextBox();
            dojTB = new TextBox();
            salaryTB = new TextBox();
            deptnoTB = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
            label1.Location = new Point(98, 45);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Emp Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 76);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter EmpName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 106);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter Designation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 138);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Enter DOJ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 167);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Enter Salary";
            // 
            // IDtb
            // 
            IDtb.Location = new Point(252, 42);
            IDtb.Name = "IDtb";
            IDtb.Size = new Size(100, 23);
            IDtb.TabIndex = 5;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(252, 71);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(100, 23);
            nameTB.TabIndex = 6;
            // 
            // designTB
            // 
            designTB.Location = new Point(252, 100);
            designTB.Name = "designTB";
            designTB.Size = new Size(100, 23);
            designTB.TabIndex = 7;
            // 
            // dojTB
            // 
            dojTB.Location = new Point(252, 135);
            dojTB.Name = "dojTB";
            dojTB.Size = new Size(100, 23);
            dojTB.TabIndex = 8;
            // 
            // salaryTB
            // 
            salaryTB.Location = new Point(252, 164);
            salaryTB.Name = "salaryTB";
            salaryTB.Size = new Size(100, 23);
            salaryTB.TabIndex = 9;
            // 
            // deptnoTB
            // 
            deptnoTB.Location = new Point(252, 193);
            deptnoTB.Name = "deptnoTB";
            deptnoTB.Size = new Size(100, 23);
            deptnoTB.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 196);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 11;
            label6.Text = " Enter DeptNo";
            // 
            // button1
            // 
            button1.Location = new Point(91, 227);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(184, 227);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Find";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(277, 227);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(91, 256);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(184, 256);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 16;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(277, 256);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 17;
            button6.Text = "Close";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(390, 256);
            button7.Name = "button7";
            button7.Size = new Size(161, 23);
            button7.TabIndex = 18;
            button7.Text = "Update Into Database";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(409, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(deptnoTB);
            Controls.Add(salaryTB);
            Controls.Add(dojTB);
            Controls.Add(designTB);
            Controls.Add(nameTB);
            Controls.Add(IDtb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox IDtb;
        private TextBox nameTB;
        private TextBox designTB;
        private TextBox dojTB;
    
        private TextBox salaryTB;
        private TextBox deptnoTB;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private DataGridView dataGridView1;
    }
}
