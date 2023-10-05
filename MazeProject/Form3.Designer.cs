
namespace MazeProject
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Uzunluk = new System.Windows.Forms.NumericUpDown();
            this.Genislik = new System.Windows.Forms.NumericUpDown();
            this.picMaze = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Uzunluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genislik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(539, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Olustur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Location = new System.Drawing.Point(539, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Çöz";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Location = new System.Drawing.Point(540, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sonuç";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.Location = new System.Drawing.Point(539, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Genislik";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox2.Location = new System.Drawing.Point(539, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Uzunluk";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Uzunluk
            // 
            this.Uzunluk.Location = new System.Drawing.Point(621, 274);
            this.Uzunluk.Name = "Uzunluk";
            this.Uzunluk.Size = new System.Drawing.Size(49, 20);
            this.Uzunluk.TabIndex = 10;
            this.Uzunluk.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Genislik
            // 
            this.Genislik.Location = new System.Drawing.Point(621, 312);
            this.Genislik.Name = "Genislik";
            this.Genislik.Size = new System.Drawing.Size(49, 20);
            this.Genislik.TabIndex = 11;
            this.Genislik.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // picMaze
            // 
            this.picMaze.BackColor = System.Drawing.Color.PaleGreen;
            this.picMaze.Location = new System.Drawing.Point(12, 12);
            this.picMaze.Name = "picMaze";
            this.picMaze.Size = new System.Drawing.Size(500, 500);
            this.picMaze.TabIndex = 14;
            this.picMaze.TabStop = false;
            this.picMaze.Click += new System.EventHandler(this.picMaze_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 531);
            this.Controls.Add(this.picMaze);
            this.Controls.Add(this.Genislik);
            this.Controls.Add(this.Uzunluk);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.Uzunluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Genislik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown Uzunluk;
        private System.Windows.Forms.NumericUpDown Genislik;
        private System.Windows.Forms.PictureBox picMaze;
    }
}