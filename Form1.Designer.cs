namespace Assignment_GUI_Fractional_calculator
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
            First = new Label();
            label2 = new Label();
            numerator1 = new TextBox();
            denominator1 = new TextBox();
            radio_add = new RadioButton();
            radio_sub = new RadioButton();
            radio_mul = new RadioButton();
            radio_div = new RadioButton();
            second = new Label();
            label3 = new Label();
            numerator2 = new TextBox();
            denominator2 = new TextBox();
            equal = new Label();
            result = new Label();
            label6 = new Label();
            label4 = new Label();
            result_num = new TextBox();
            result_den = new TextBox();
            Per_operation = new Button();
            SuspendLayout();
            // 
            // First
            // 
            First.AllowDrop = true;
            First.AutoSize = true;
            First.Location = new Point(12, 95);
            First.Name = "First";
            First.Size = new Size(36, 20);
            First.TabIndex = 0;
            First.Text = "First";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 136);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 1;
            label2.Text = "/";
            // 
            // numerator1
            // 
            numerator1.Location = new Point(12, 133);
            numerator1.Name = "numerator1";
            numerator1.Size = new Size(29, 27);
            numerator1.TabIndex = 2;
            numerator1.TextChanged += numerator1_TextChanged;
            // 
            // denominator1
            // 
            denominator1.Location = new Point(84, 136);
            denominator1.Name = "denominator1";
            denominator1.Size = new Size(28, 27);
            denominator1.TabIndex = 3;
            denominator1.TextChanged += denominator1_TextChanged;
            // 
            // radio_add
            // 
            radio_add.AutoSize = true;
            radio_add.Location = new Point(183, 95);
            radio_add.Name = "radio_add";
            radio_add.Size = new Size(40, 24);
            radio_add.TabIndex = 4;
            radio_add.TabStop = true;
            radio_add.Text = "+";
            radio_add.UseVisualStyleBackColor = true;
            radio_add.CheckedChanged += radio_add_CheckedChanged;
            // 
            // radio_sub
            // 
            radio_sub.AutoSize = true;
            radio_sub.Location = new Point(183, 139);
            radio_sub.Name = "radio_sub";
            radio_sub.Size = new Size(36, 24);
            radio_sub.TabIndex = 5;
            radio_sub.TabStop = true;
            radio_sub.Text = "-";
            radio_sub.UseVisualStyleBackColor = true;
            radio_sub.CheckedChanged += radio_sub_CheckedChanged;
            // 
            // radio_mul
            // 
            radio_mul.AutoSize = true;
            radio_mul.Location = new Point(183, 189);
            radio_mul.Name = "radio_mul";
            radio_mul.Size = new Size(36, 24);
            radio_mul.TabIndex = 6;
            radio_mul.TabStop = true;
            radio_mul.Text = "*";
            radio_mul.UseVisualStyleBackColor = true;
            radio_mul.CheckedChanged += radio_mul_CheckedChanged;
            // 
            // radio_div
            // 
            radio_div.AutoSize = true;
            radio_div.Location = new Point(183, 239);
            radio_div.Name = "radio_div";
            radio_div.Size = new Size(36, 24);
            radio_div.TabIndex = 7;
            radio_div.TabStop = true;
            radio_div.Text = "/";
            radio_div.UseVisualStyleBackColor = true;
            radio_div.CheckedChanged += radio_div_CheckedChanged;
            // 
            // second
            // 
            second.AutoSize = true;
            second.Location = new Point(300, 99);
            second.Name = "second";
            second.Size = new Size(58, 20);
            second.TabIndex = 8;
            second.Text = "Second";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 140);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 9;
            label3.Text = "/";
            // 
            // numerator2
            // 
            numerator2.BorderStyle = BorderStyle.None;
            numerator2.Location = new Point(282, 133);
            numerator2.Multiline = true;
            numerator2.Name = "numerator2";
            numerator2.Size = new Size(38, 34);
            numerator2.TabIndex = 10;
            numerator2.TextChanged += numerator2_TextChanged;
            // 
            // denominator2
            // 
            denominator2.Location = new Point(375, 140);
            denominator2.Name = "denominator2";
            denominator2.Size = new Size(43, 27);
            denominator2.TabIndex = 11;
            denominator2.TextChanged += denominator2_TextChanged;
            // 
            // equal
            // 
            equal.AutoSize = true;
            equal.Location = new Point(444, 147);
            equal.Name = "equal";
            equal.Size = new Size(19, 20);
            equal.TabIndex = 12;
            equal.Text = "=";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(508, 99);
            result.Name = "result";
            result.Size = new Size(49, 20);
            result.TabIndex = 13;
            result.Text = "Result";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(554, 150);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 14;
            label6.Text = "/";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 212);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 15;
            // 
            // result_num
            // 
            result_num.Location = new Point(497, 147);
            result_num.Name = "result_num";
            result_num.Size = new Size(32, 27);
            result_num.TabIndex = 16;
            result_num.TextChanged += result_num_TextChanged;
            // 
            // result_den
            // 
            result_den.Location = new Point(584, 147);
            result_den.Name = "result_den";
            result_den.Size = new Size(37, 27);
            result_den.TabIndex = 17;
            result_den.TextChanged += result_den_TextChanged;
            // 
            // Per_operation
            // 
            Per_operation.Location = new Point(218, 337);
            Per_operation.Name = "Per_operation";
            Per_operation.Size = new Size(256, 29);
            Per_operation.TabIndex = 18;
            Per_operation.Text = "Perform Operation";
            Per_operation.UseVisualStyleBackColor = true;
            Per_operation.Click += Per_operation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Per_operation);
            Controls.Add(result_den);
            Controls.Add(result_num);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(result);
            Controls.Add(equal);
            Controls.Add(denominator2);
            Controls.Add(numerator2);
            Controls.Add(label3);
            Controls.Add(second);
            Controls.Add(radio_div);
            Controls.Add(radio_mul);
            Controls.Add(radio_sub);
            Controls.Add(radio_add);
            Controls.Add(denominator1);
            Controls.Add(numerator1);
            Controls.Add(label2);
            Controls.Add(First);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label First;
        private Label label2;
        private TextBox numerator1;
        private TextBox denominator1;
        private RadioButton radio_add;
        private RadioButton radio_sub;
        private RadioButton radio_mul;
        private RadioButton radio_div;
        private Label second;
        private Label label3;
        private TextBox numerator2;
        private TextBox denominator2;
        private Label equal;
        private Label result;
        private Label label6;
        private Label label4;
        private TextBox result_num;
        private TextBox result_den;
        private Button Per_operation;
    }
}
