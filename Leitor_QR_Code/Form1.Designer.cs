
namespace Leitor_QR_Code {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(30, 401);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(585, 20);
            this.txtResult.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 332);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(100, 133);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(121, 21);
            this.cboCamera.TabIndex = 3;
            this.cboCamera.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 363);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(585, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Conectar Dispositivo";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

