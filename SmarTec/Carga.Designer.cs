namespace SmarTec
{
    partial class Carga
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
            this.imgcarga = new System.Windows.Forms.PictureBox();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Barraprogress1 = new System.Windows.Forms.ProgressBar();
            this.TextBienvenida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgcarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgcarga
            // 
            this.imgcarga.Image = global::SmarTec.Properties.Resources.image_processing20210427_19682_1d12g5z_preview_rev_13;
            this.imgcarga.Location = new System.Drawing.Point(447, 145);
            this.imgcarga.Name = "imgcarga";
            this.imgcarga.Size = new System.Drawing.Size(500, 500);
            this.imgcarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgcarga.TabIndex = 1;
            this.imgcarga.TabStop = false;
            // 
            // fondo
            // 
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Image = global::SmarTec.Properties.Resources.Colorful_Confetti_PNG_Transparent_Image1;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(1354, 763);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fondo.TabIndex = 0;
            this.fondo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Barraprogress1
            // 
            this.Barraprogress1.BackColor = System.Drawing.Color.White;
            this.Barraprogress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(113)))), ((int)(((byte)(214)))));
            this.Barraprogress1.Location = new System.Drawing.Point(58, 711);
            this.Barraprogress1.Name = "Barraprogress1";
            this.Barraprogress1.Size = new System.Drawing.Size(1232, 23);
            this.Barraprogress1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Barraprogress1.TabIndex = 2;
            this.Barraprogress1.Click += new System.EventHandler(this.Barraprogress1_Click);
            // 
            // TextBienvenida
            // 
            this.TextBienvenida.AutoSize = true;
            this.TextBienvenida.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBienvenida.Location = new System.Drawing.Point(337, 28);
            this.TextBienvenida.Name = "TextBienvenida";
            this.TextBienvenida.Size = new System.Drawing.Size(664, 72);
            this.TextBienvenida.TabIndex = 3;
            this.TextBienvenida.Text = "¡BIENVENID@ AL TEST!";
            // 
            // Carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 763);
            this.Controls.Add(this.TextBienvenida);
            this.Controls.Add(this.Barraprogress1);
            this.Controls.Add(this.imgcarga);
            this.Controls.Add(this.fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga";
            this.Load += new System.EventHandler(this.Carga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgcarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.PictureBox imgcarga;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar Barraprogress1;
        private System.Windows.Forms.Label TextBienvenida;
    }
}