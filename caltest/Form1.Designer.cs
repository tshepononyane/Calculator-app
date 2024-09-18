namespace caltest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtTotal = new TextBox();
            btn1 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btnClear = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.White;
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(22, 47);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(560, 71);
            txtTotal.TabIndex = 0;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // btn1
            // 
            btn1.BackgroundImage = Calculator.Properties.Resources.pretty_cool;
            btn1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(22, 335);
            btn1.Name = "btn1";
            btn1.Size = new Size(92, 68);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            btn4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(261, 256);
            btn4.Name = "btn4";
            btn4.Size = new Size(91, 68);
            btn4.TabIndex = 2;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            btn3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(260, 335);
            btn3.Name = "btn3";
            btn3.Size = new Size(92, 68);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackgroundImage = Calculator.Properties.Resources.pretty_cool;
            btn2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(139, 335);
            btn2.Name = "btn2";
            btn2.Size = new Size(92, 68);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191414;
            btn5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(139, 256);
            btn5.Name = "btn5";
            btn5.Size = new Size(92, 68);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.BackgroundImage = Calculator.Properties.Resources.pretty_cool;
            btn0.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(22, 409);
            btn0.Name = "btn0";
            btn0.Size = new Size(209, 42);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Black;
            btn7.BackgroundImage = Calculator.Properties.Resources.pretty_cool;
            btn7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(22, 172);
            btn7.Name = "btn7";
            btn7.Size = new Size(92, 68);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackgroundImage = (Image)resources.GetObject("btn8.BackgroundImage");
            btn8.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(139, 172);
            btn8.Name = "btn8";
            btn8.Size = new Size(92, 68);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            btn9.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(261, 172);
            btn9.Name = "btn9";
            btn9.Size = new Size(92, 68);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackgroundImage = Calculator.Properties.Resources.pretty_cool;
            btn6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(22, 256);
            btn6.Name = "btn6";
            btn6.Size = new Size(92, 68);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnClear
            // 
            btnClear.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            btnClear.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(490, 172);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(92, 68);
            btnClear.TabIndex = 15;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            btnMinus.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(378, 256);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(92, 68);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            btnMultiply.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiply.Location = new Point(378, 335);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(92, 68);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            btnDivide.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(378, 406);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(92, 45);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "\\";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            btnPlus.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(378, 172);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(91, 68);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191414;
            btnEqual.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEqual.Location = new Point(490, 335);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(92, 116);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(261, 409);
            button1.Name = "button1";
            button1.Size = new Size(91, 42);
            button1.TabIndex = 17;
            button1.Text = ".";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackgroundImage = Calculator.Properties.Resources.Screenshot_2023_05_22_191341;
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(490, 256);
            button2.Name = "button2";
            button2.Size = new Size(92, 68);
            button2.TabIndex = 18;
            button2.Text = "C";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Calculator.Properties.Resources.pretty_cool;
            ClientSize = new Size(600, 463);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnEqual);
            Controls.Add(btnClear);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "𝐂𝐀𝐋𝐂𝐔𝐋𝐀𝐓𝐎𝐑";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn5;
        private Button btn0;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btnClear;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnPlus;
        private Button btnEqual;
        private Button button1;
        private Button button2;
    }
}