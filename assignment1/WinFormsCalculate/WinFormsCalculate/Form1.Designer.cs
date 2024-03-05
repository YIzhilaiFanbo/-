namespace WinFormsCalculate
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
            num1Box = new TextBox();
            label2 = new Label();
            label3 = new Label();
            num2Box = new TextBox();
            opandBox = new ComboBox();
            label4 = new Label();
            calculate = new Button();
            resultBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(430, 60);
            label1.Name = "label1";
            label1.Size = new Size(256, 96);
            label1.TabIndex = 0;
            label1.Text = "计算器";
            // 
            // num1Box
            // 
            num1Box.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            num1Box.Location = new Point(497, 241);
            num1Box.Name = "num1Box";
            num1Box.Size = new Size(300, 38);
            num1Box.TabIndex = 1;
            num1Box.TextChanged += num1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(253, 247);
            label2.Name = "label2";
            label2.Size = new Size(172, 31);
            label2.TabIndex = 2;
            label2.Text = "请输入运算数1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(253, 345);
            label3.Name = "label3";
            label3.Size = new Size(172, 31);
            label3.TabIndex = 3;
            label3.Text = "请输入运算数2";
            // 
            // num2Box
            // 
            num2Box.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            num2Box.Location = new Point(497, 345);
            num2Box.Name = "num2Box";
            num2Box.Size = new Size(300, 38);
            num2Box.TabIndex = 4;
            // 
            // opandBox
            // 
            opandBox.FormattingEnabled = true;
            opandBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            opandBox.Location = new Point(497, 442);
            opandBox.Name = "opandBox";
            opandBox.Size = new Size(182, 32);
            opandBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(253, 442);
            label4.Name = "label4";
            label4.Size = new Size(158, 31);
            label4.TabIndex = 6;
            label4.Text = "请选择运算符";
            // 
            // calculate
            // 
            calculate.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            calculate.Location = new Point(253, 536);
            calculate.Name = "calculate";
            calculate.Size = new Size(172, 48);
            calculate.TabIndex = 7;
            calculate.Text = "点击输出结果";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += button1_Click;
            // 
            // resultBox
            // 
            resultBox.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            resultBox.Location = new Point(497, 548);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(300, 38);
            resultBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 677);
            Controls.Add(resultBox);
            Controls.Add(calculate);
            Controls.Add(label4);
            Controls.Add(opandBox);
            Controls.Add(num2Box);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(num1Box);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num1Box;
        private Label label2;
        private Label label3;
        private TextBox num2Box;
        private ComboBox opandBox;
        private Label label4;
        private Button calculate;
        private TextBox resultBox;
    }
}
