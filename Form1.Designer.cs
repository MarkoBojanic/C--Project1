namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cevGornja = new System.Windows.Forms.PictureBox();
            this.ptica = new System.Windows.Forms.PictureBox();
            this.donjaCev = new System.Windows.Forms.PictureBox();
            this.trava = new System.Windows.Forms.PictureBox();
            this.rezultat = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cevGornja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donjaCev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trava)).BeginInit();
            this.SuspendLayout();
            // 
            // cevGornja
            // 
            this.cevGornja.Image = ((System.Drawing.Image)(resources.GetObject("cevGornja.Image")));
            this.cevGornja.Location = new System.Drawing.Point(831, -16);
            this.cevGornja.Name = "cevGornja";
            this.cevGornja.Size = new System.Drawing.Size(100, 198);
            this.cevGornja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cevGornja.TabIndex = 0;
            this.cevGornja.TabStop = false;
            // 
            // ptica
            // 
            this.ptica.Image = ((System.Drawing.Image)(resources.GetObject("ptica.Image")));
            this.ptica.Location = new System.Drawing.Point(227, 226);
            this.ptica.Name = "ptica";
            this.ptica.Size = new System.Drawing.Size(93, 67);
            this.ptica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptica.TabIndex = 2;
            this.ptica.TabStop = false;
            // 
            // donjaCev
            // 
            this.donjaCev.Image = ((System.Drawing.Image)(resources.GetObject("donjaCev.Image")));
            this.donjaCev.Location = new System.Drawing.Point(663, 413);
            this.donjaCev.Name = "donjaCev";
            this.donjaCev.Size = new System.Drawing.Size(100, 194);
            this.donjaCev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.donjaCev.TabIndex = 3;
            this.donjaCev.TabStop = false;
            // 
            // trava
            // 
            this.trava.Image = ((System.Drawing.Image)(resources.GetObject("trava.Image")));
            this.trava.Location = new System.Drawing.Point(-11, 590);
            this.trava.Name = "trava";
            this.trava.Size = new System.Drawing.Size(1049, 116);
            this.trava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trava.TabIndex = 4;
            this.trava.TabStop = false;
            // 
            // rezultat
            // 
            this.rezultat.AutoSize = true;
            this.rezultat.BackColor = System.Drawing.Color.Yellow;
            this.rezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultat.Location = new System.Drawing.Point(12, 9);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(131, 33);
            this.rezultat.TabIndex = 5;
            this.rezultat.Text = "Score: 0";
            this.rezultat.Click += new System.EventHandler(this.rezultat_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1035, 699);
            this.Controls.Add(this.ptica);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.trava);
            this.Controls.Add(this.donjaCev);
            this.Controls.Add(this.cevGornja);
            this.Name = "Form1";
            this.Text = "FlappyBridGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.naDole);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.naGore);
            ((System.ComponentModel.ISupportInitialize)(this.cevGornja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donjaCev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cevGornja;
        private System.Windows.Forms.PictureBox ptica;
        private System.Windows.Forms.PictureBox donjaCev;
        private System.Windows.Forms.PictureBox trava;
        private System.Windows.Forms.Label rezultat;
        private System.Windows.Forms.Timer gameTimer;
    }
}

