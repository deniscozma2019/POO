namespace ex_04._12._2020
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
            this.reset = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.Button();
            this.Clear_all = new System.Windows.Forms.Button();
            this.Indicate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(71, 82);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(58, 42);
            this.reset.TabIndex = 0;
            this.reset.Text = "X";
            this.reset.UseVisualStyleBackColor = true;
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(413, 186);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(75, 45);
            this.Random.TabIndex = 1;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            // 
            // Clear_all
            // 
            this.Clear_all.Location = new System.Drawing.Point(154, 186);
            this.Clear_all.Name = "Clear_all";
            this.Clear_all.Size = new System.Drawing.Size(75, 42);
            this.Clear_all.TabIndex = 2;
            this.Clear_all.Text = "Clear All";
            this.Clear_all.UseVisualStyleBackColor = true;
            // 
            // Indicate
            // 
            this.Indicate.Location = new System.Drawing.Point(277, 186);
            this.Indicate.Name = "Indicate";
            this.Indicate.Size = new System.Drawing.Size(75, 45);
            this.Indicate.TabIndex = 3;
            this.Indicate.Text = "Indicate";
            this.Indicate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Indicate);
            this.Controls.Add(this.Clear_all);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.reset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Clear_all;
        private System.Windows.Forms.Button Indicate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

