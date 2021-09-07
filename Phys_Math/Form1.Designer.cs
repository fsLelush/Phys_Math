namespace Phys_Math
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
            this.Length_L = new System.Windows.Forms.Label();
            this.Width_L = new System.Windows.Forms.Label();
            this.Height_L = new System.Windows.Forms.Label();
            this.Area_L = new System.Windows.Forms.Label();
            this.Volume_L = new System.Windows.Forms.Label();
            this.Length_TB = new System.Windows.Forms.TextBox();
            this.Width_TB = new System.Windows.Forms.TextBox();
            this.Height_TB = new System.Windows.Forms.TextBox();
            this.Area_TB = new System.Windows.Forms.TextBox();
            this.Volume_TB = new System.Windows.Forms.TextBox();
            this.Res_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Length_L
            // 
            this.Length_L.AutoSize = true;
            this.Length_L.Location = new System.Drawing.Point(41, 30);
            this.Length_L.Name = "Length_L";
            this.Length_L.Size = new System.Drawing.Size(40, 13);
            this.Length_L.TabIndex = 0;
            this.Length_L.Text = "Длина";
            // 
            // Width_L
            // 
            this.Width_L.AutoSize = true;
            this.Width_L.Location = new System.Drawing.Point(153, 30);
            this.Width_L.Name = "Width_L";
            this.Width_L.Size = new System.Drawing.Size(46, 13);
            this.Width_L.TabIndex = 1;
            this.Width_L.Text = "Ширина";
            // 
            // Height_L
            // 
            this.Height_L.AutoSize = true;
            this.Height_L.Location = new System.Drawing.Point(275, 30);
            this.Height_L.Name = "Height_L";
            this.Height_L.Size = new System.Drawing.Size(45, 13);
            this.Height_L.TabIndex = 2;
            this.Height_L.Text = "Высота";
            // 
            // Area_L
            // 
            this.Area_L.AutoSize = true;
            this.Area_L.Location = new System.Drawing.Point(78, 167);
            this.Area_L.Name = "Area_L";
            this.Area_L.Size = new System.Drawing.Size(54, 13);
            this.Area_L.TabIndex = 3;
            this.Area_L.Text = "Площадь";
            // 
            // Volume_L
            // 
            this.Volume_L.AutoSize = true;
            this.Volume_L.Location = new System.Drawing.Point(214, 167);
            this.Volume_L.Name = "Volume_L";
            this.Volume_L.Size = new System.Drawing.Size(42, 13);
            this.Volume_L.TabIndex = 4;
            this.Volume_L.Text = "Объём";
            // 
            // Length_TB
            // 
            this.Length_TB.Location = new System.Drawing.Point(12, 60);
            this.Length_TB.Name = "Length_TB";
            this.Length_TB.Size = new System.Drawing.Size(100, 20);
            this.Length_TB.TabIndex = 5;
            // 
            // Width_TB
            // 
            this.Width_TB.Location = new System.Drawing.Point(123, 60);
            this.Width_TB.Name = "Width_TB";
            this.Width_TB.Size = new System.Drawing.Size(100, 20);
            this.Width_TB.TabIndex = 6;
            // 
            // Height_TB
            // 
            this.Height_TB.Location = new System.Drawing.Point(245, 60);
            this.Height_TB.Name = "Height_TB";
            this.Height_TB.Size = new System.Drawing.Size(100, 20);
            this.Height_TB.TabIndex = 7;
            // 
            // Area_TB
            // 
            this.Area_TB.Location = new System.Drawing.Point(56, 198);
            this.Area_TB.Name = "Area_TB";
            this.Area_TB.Size = new System.Drawing.Size(100, 20);
            this.Area_TB.TabIndex = 8;
            // 
            // Volume_TB
            // 
            this.Volume_TB.Location = new System.Drawing.Point(187, 198);
            this.Volume_TB.Name = "Volume_TB";
            this.Volume_TB.Size = new System.Drawing.Size(100, 20);
            this.Volume_TB.TabIndex = 9;
            // 
            // Res_B
            // 
            this.Res_B.Location = new System.Drawing.Point(134, 125);
            this.Res_B.Name = "Res_B";
            this.Res_B.Size = new System.Drawing.Size(75, 23);
            this.Res_B.TabIndex = 10;
            this.Res_B.Text = "Посчитать";
            this.Res_B.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 308);
            this.Controls.Add(this.Res_B);
            this.Controls.Add(this.Volume_TB);
            this.Controls.Add(this.Area_TB);
            this.Controls.Add(this.Height_TB);
            this.Controls.Add(this.Width_TB);
            this.Controls.Add(this.Length_TB);
            this.Controls.Add(this.Volume_L);
            this.Controls.Add(this.Area_L);
            this.Controls.Add(this.Height_L);
            this.Controls.Add(this.Width_L);
            this.Controls.Add(this.Length_L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Length_L;
        private System.Windows.Forms.Label Width_L;
        private System.Windows.Forms.Label Height_L;
        private System.Windows.Forms.Label Area_L;
        private System.Windows.Forms.Label Volume_L;
        private System.Windows.Forms.TextBox Length_TB;
        private System.Windows.Forms.TextBox Width_TB;
        private System.Windows.Forms.TextBox Height_TB;
        private System.Windows.Forms.TextBox Area_TB;
        private System.Windows.Forms.TextBox Volume_TB;
        private System.Windows.Forms.Button Res_B;
    }
}

