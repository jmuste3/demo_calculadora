namespace demo_calculadora
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
            txtAmount = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label1 = new Label();
            button6 = new Button();
            label2 = new Label();
            button7 = new Button();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtAmount.Location = new Point(111, 37);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(121, 36);
            txtAmount.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button2.Location = new Point(99, 87);
            button2.Name = "button2";
            button2.Size = new Size(72, 56);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button3.Location = new Point(177, 87);
            button3.Name = "button3";
            button3.Size = new Size(72, 56);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button1.Location = new Point(12, 87);
            button1.Name = "button1";
            button1.Size = new Size(72, 56);
            button1.TabIndex = 4;
            button1.Text = "9";
            button1.UseVisualStyleBackColor = true;
            //button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button4.Location = new Point(12, 165);
            button4.Name = "button4";
            button4.Size = new Size(72, 56);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += teclat_Click;
            // 
            // button5
            // 
            button5.Location = new Point(287, 120);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(201, 198);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(80, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.TextChanged += comboBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(187, 257);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(249, 58);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "ERROR";
            label1.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(300, 198);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "Convert";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(192, 180);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 11;
            label2.Text = "selecciona divisa:";
            label2.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(43, 275);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 12;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 381);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtAmount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmount;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label1;
        private Button button6;
        private Label label2;
        private Button button7;
    }
}