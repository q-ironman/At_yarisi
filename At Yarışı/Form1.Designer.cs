
namespace At_Yarışı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.horseNum = new System.Windows.Forms.NumericUpDown();
            this.horse1 = new System.Windows.Forms.PictureBox();
            this.horse3 = new System.Windows.Forms.PictureBox();
            this.horse4 = new System.Windows.Forms.PictureBox();
            this.horse5 = new System.Windows.Forms.PictureBox();
            this.horse2 = new System.Windows.Forms.PictureBox();
            this.finishLine = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.scoreBoard = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.horseNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine)).BeginInit();
            this.SuspendLayout();
            // 
            // horseNum
            // 
            this.horseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.horseNum.Location = new System.Drawing.Point(357, 33);
            this.horseNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.horseNum.Name = "horseNum";
            this.horseNum.Size = new System.Drawing.Size(53, 30);
            this.horseNum.TabIndex = 0;
            this.horseNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.horseNum.ValueChanged += new System.EventHandler(this.horseNum_ValueChanged);
            // 
            // horse1
            // 
            this.horse1.Image = ((System.Drawing.Image)(resources.GetObject("horse1.Image")));
            this.horse1.Location = new System.Drawing.Point(60, 119);
            this.horse1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(135, 62);
            this.horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse1.TabIndex = 1;
            this.horse1.TabStop = false;
            this.horse1.Visible = false;
            // 
            // horse3
            // 
            this.horse3.Image = ((System.Drawing.Image)(resources.GetObject("horse3.Image")));
            this.horse3.Location = new System.Drawing.Point(60, 257);
            this.horse3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(133, 62);
            this.horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse3.TabIndex = 2;
            this.horse3.TabStop = false;
            this.horse3.Visible = false;
            // 
            // horse4
            // 
            this.horse4.Image = ((System.Drawing.Image)(resources.GetObject("horse4.Image")));
            this.horse4.Location = new System.Drawing.Point(60, 326);
            this.horse4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.horse4.Name = "horse4";
            this.horse4.Size = new System.Drawing.Size(133, 62);
            this.horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse4.TabIndex = 3;
            this.horse4.TabStop = false;
            this.horse4.Visible = false;
            // 
            // horse5
            // 
            this.horse5.Image = ((System.Drawing.Image)(resources.GetObject("horse5.Image")));
            this.horse5.Location = new System.Drawing.Point(60, 395);
            this.horse5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.horse5.Name = "horse5";
            this.horse5.Size = new System.Drawing.Size(133, 62);
            this.horse5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse5.TabIndex = 4;
            this.horse5.TabStop = false;
            this.horse5.Visible = false;
            // 
            // horse2
            // 
            this.horse2.Image = ((System.Drawing.Image)(resources.GetObject("horse2.Image")));
            this.horse2.Location = new System.Drawing.Point(60, 188);
            this.horse2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(133, 62);
            this.horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.horse2.TabIndex = 5;
            this.horse2.TabStop = false;
            this.horse2.Visible = false;
            // 
            // finishLine
            // 
            this.finishLine.Image = ((System.Drawing.Image)(resources.GetObject("finishLine.Image")));
            this.finishLine.Location = new System.Drawing.Point(896, 119);
            this.finishLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finishLine.Name = "finishLine";
            this.finishLine.Size = new System.Drawing.Size(89, 337);
            this.finishLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finishLine.TabIndex = 6;
            this.finishLine.TabStop = false;
            this.finishLine.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 66);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sıfırla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // scoreBoard
            // 
            this.scoreBoard.Location = new System.Drawing.Point(1012, 15);
            this.scoreBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scoreBoard.Multiline = true;
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(257, 186);
            this.scoreBoard.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 554);
            this.Controls.Add(this.scoreBoard);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finishLine);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.horse5);
            this.Controls.Add(this.horse4);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.horseNum);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horseNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown horseNum;
        private System.Windows.Forms.PictureBox horse1;
        private System.Windows.Forms.PictureBox horse3;
        private System.Windows.Forms.PictureBox horse4;
        private System.Windows.Forms.PictureBox horse5;
        private System.Windows.Forms.PictureBox horse2;
        private System.Windows.Forms.PictureBox finishLine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox scoreBoard;
        private System.Windows.Forms.Timer timer1;
    }
}

