namespace Belirtecler
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(47, 205);
            button1.Name = "button1";
            button1.Size = new Size(150, 56);
            button1.TabIndex = 0;
            button1.Text = "Ürün Bilgisi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(258, 205);
            button2.Name = "button2";
            button2.Size = new Size(125, 56);
            button2.TabIndex = 1;
            button2.Text = "Kategoriyi Değiştir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(435, 205);
            button3.Name = "button3";
            button3.Size = new Size(127, 56);
            button3.TabIndex = 2;
            button3.Text = "Fiyatı Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(616, 205);
            button4.Name = "button4";
            button4.Size = new Size(135, 56);
            button4.TabIndex = 3;
            button4.Text = "Stok Miktarını Güncelle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 104);
            label1.Name = "label1";
            label1.Size = new Size(18, 18);
            label1.TabIndex = 5;
            label1.Text = "*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(851, 405);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Belirteçler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}
