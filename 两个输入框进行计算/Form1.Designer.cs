namespace 两个输入框进行计算
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputNumber1 = new System.Windows.Forms.TextBox();
            this.inputNumber2 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(12, 42);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(100, 21);
            this.inputNumber1.TabIndex = 0;
            // 
            // inputNumber2
            // 
            this.inputNumber2.Location = new System.Drawing.Point(154, 42);
            this.inputNumber2.Name = "inputNumber2";
            this.inputNumber2.Size = new System.Drawing.Size(100, 21);
            this.inputNumber2.TabIndex = 0;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(13, 217);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "计算";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(168, 217);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "清除";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Location = new System.Drawing.Point(13, 13);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(65, 12);
            this.number1.TabIndex = 2;
            this.number1.Text = "第一个数字";
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Location = new System.Drawing.Point(152, 13);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(65, 12);
            this.number2.TabIndex = 2;
            this.number2.Text = "第二个数字";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(12, 80);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 12);
            this.result.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.result);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.inputNumber2);
            this.Controls.Add(this.inputNumber1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "两个输入框进行计算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNumber1;
        private System.Windows.Forms.TextBox inputNumber2;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.Label result;
    }
}

