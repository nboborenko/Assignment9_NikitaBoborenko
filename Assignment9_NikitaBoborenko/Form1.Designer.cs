namespace Individual_Assignment_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.input_btn = new System.Windows.Forms.Button();
            this.output_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(148, 182);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(210, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // input_btn
            // 
            this.input_btn.Location = new System.Drawing.Point(362, 182);
            this.input_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input_btn.Name = "input_btn";
            this.input_btn.Size = new System.Drawing.Size(56, 19);
            this.input_btn.TabIndex = 1;
            this.input_btn.Text = "Input";
            this.input_btn.UseVisualStyleBackColor = true;
            this.input_btn.Click += new System.EventHandler(this.input_btn_Click);
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Location = new System.Drawing.Point(145, 229);
            this.output_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(120, 13);
            this.output_label.TabIndex = 2;
            this.output_label.Text = "Most frequent character";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.input_btn);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button input_btn;
        private System.Windows.Forms.Label output_label;
    }
}

