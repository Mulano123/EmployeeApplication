namespace EmployeeApplication
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
            txtbox1 = new TextBox();
            txtbox2 = new TextBox();
            txtbox3 = new TextBox();
            txtbox4 = new TextBox();
            btn1 = new Button();
            label6 = new Label();
            dataGW = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGW).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(133, 22);
            label1.TabIndex = 0;
            label1.Text = "Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 75);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 1;
            label2.Text = "Employee ID *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 147);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 2;
            label3.Text = "First Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 215);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 3;
            label4.Text = "Last Name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(31, 289);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 4;
            label5.Text = "Position *";
            // 
            // txtbox1
            // 
            txtbox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox1.Location = new Point(37, 99);
            txtbox1.Name = "txtbox1";
            txtbox1.Size = new Size(145, 26);
            txtbox1.TabIndex = 5;
            // 
            // txtbox2
            // 
            txtbox2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox2.Location = new Point(37, 171);
            txtbox2.Name = "txtbox2";
            txtbox2.Size = new Size(145, 26);
            txtbox2.TabIndex = 6;
            // 
            // txtbox3
            // 
            txtbox3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox3.Location = new Point(37, 239);
            txtbox3.Name = "txtbox3";
            txtbox3.Size = new Size(145, 26);
            txtbox3.TabIndex = 7;
            // 
            // txtbox4
            // 
            txtbox4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox4.Location = new Point(37, 322);
            txtbox4.Name = "txtbox4";
            txtbox4.Size = new Size(145, 26);
            txtbox4.TabIndex = 8;
            // 
            // btn1
            // 
            btn1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(67, 369);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 27);
            btn1.TabIndex = 9;
            btn1.Text = "Submit";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(333, 36);
            label6.Name = "label6";
            label6.Size = new Size(131, 22);
            label6.TabIndex = 11;
            label6.Text = "Employee List:";
            // 
            // dataGW
            // 
            dataGW.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGW.Location = new Point(324, 75);
            dataGW.Name = "dataGW";
            dataGW.RowTemplate.Height = 25;
            dataGW.Size = new Size(449, 265);
            dataGW.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGW);
            Controls.Add(label6);
            Controls.Add(btn1);
            Controls.Add(txtbox4);
            Controls.Add(txtbox3);
            Controls.Add(txtbox2);
            Controls.Add(txtbox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Employee Database";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtbox1;
        private TextBox txtbox2;
        private TextBox txtbox3;
        private TextBox txtbox4;
        private Button btn1;
        private Label label6;
        private DataGridView dataGW;
    }
}