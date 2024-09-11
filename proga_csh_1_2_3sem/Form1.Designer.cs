namespace proga_csh_1_2_3sem
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
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xlabel = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.radiustextBox = new System.Windows.Forms.TextBox();
            this.angletextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(292, 251);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(154, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Выход из приложения";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите радиус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите угол";
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(305, 202);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(0, 13);
            this.xlabel.TabIndex = 3;
            this.xlabel.Click += new System.EventHandler(this.xlabel_Click);
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(305, 219);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(0, 13);
            this.ylabel.TabIndex = 4;
            this.ylabel.Click += new System.EventHandler(this.ylabel_Click);
            // 
            // radiustextBox
            // 
            this.radiustextBox.Location = new System.Drawing.Point(347, 132);
            this.radiustextBox.Name = "radiustextBox";
            this.radiustextBox.Size = new System.Drawing.Size(100, 20);
            this.radiustextBox.TabIndex = 5;
            this.radiustextBox.Leave += new System.EventHandler(this.radiustextBox_Leave);
            // 
            // angletextBox
            // 
            this.angletextBox.Location = new System.Drawing.Point(346, 158);
            this.angletextBox.Name = "angletextBox";
            this.angletextBox.Size = new System.Drawing.Size(100, 20);
            this.angletextBox.TabIndex = 6;
            this.angletextBox.Leave += new System.EventHandler(this.angletextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "x:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.angletextBox);
            this.Controls.Add(this.radiustextBox);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.TextBox radiustextBox;
        private System.Windows.Forms.TextBox angletextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

