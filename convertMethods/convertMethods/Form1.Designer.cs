namespace convertMethods
{
    partial class Form1
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
            this.num2 = new System.Windows.Forms.Label();
            this.numBox1 = new System.Windows.Forms.TextBox();
            this.numBox2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.resultNum = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(77, 163);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(50, 13);
            this.num2.TabIndex = 1;
            this.num2.Text = "Number2";
            // 
            // numBox1
            // 
            this.numBox1.Location = new System.Drawing.Point(169, 116);
            this.numBox1.Name = "numBox1";
            this.numBox1.Size = new System.Drawing.Size(100, 20);
            this.numBox1.TabIndex = 2;
            // 
            // numBox2
            // 
            this.numBox2.Location = new System.Drawing.Point(169, 156);
            this.numBox2.Name = "numBox2";
            this.numBox2.Size = new System.Drawing.Size(100, 20);
            this.numBox2.TabIndex = 3;
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(77, 123);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(50, 13);
            this.num1.TabIndex = 0;
            this.num1.Text = "Number1";
            this.num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(316, 123);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(40, 13);
            this.resultText.TabIndex = 4;
            this.resultText.Text = "Result:";
            this.resultText.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // resultNum
            // 
            this.resultNum.AutoSize = true;
            this.resultNum.Location = new System.Drawing.Point(365, 123);
            this.resultNum.Name = "resultNum";
            this.resultNum.Size = new System.Drawing.Size(19, 13);
            this.resultNum.TabIndex = 5;
            this.resultNum.Text = "00";
            this.resultNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(169, 255);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "calulate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.resultNum);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.numBox2);
            this.Controls.Add(this.numBox1);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox numBox1;
        private System.Windows.Forms.TextBox numBox2;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Label resultNum;
        private System.Windows.Forms.Button btnCalc;
    }
}

