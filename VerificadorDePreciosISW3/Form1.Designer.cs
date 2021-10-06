namespace VerificadorDePreciosISW3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelMainInstruction = new System.Windows.Forms.Label();
            this.labelSecondaryInstruction = new System.Windows.Forms.Label();
            this.labelBottomInstruction = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.pbServicio = new System.Windows.Forms.PictureBox();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbScanAtBottom = new System.Windows.Forms.PictureBox();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.timerToStartState = new System.Windows.Forms.Timer(this.components);
            this.labelProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanAtBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMainInstruction
            // 
            this.labelMainInstruction.AutoSize = true;
            this.labelMainInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainInstruction.Location = new System.Drawing.Point(278, 90);
            this.labelMainInstruction.Name = "labelMainInstruction";
            this.labelMainInstruction.Size = new System.Drawing.Size(267, 46);
            this.labelMainInstruction.TabIndex = 2;
            this.labelMainInstruction.Text = "1st instruction";
            this.labelMainInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondaryInstruction
            // 
            this.labelSecondaryInstruction.AutoSize = true;
            this.labelSecondaryInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondaryInstruction.Location = new System.Drawing.Point(217, 311);
            this.labelSecondaryInstruction.Name = "labelSecondaryInstruction";
            this.labelSecondaryInstruction.Size = new System.Drawing.Size(281, 46);
            this.labelSecondaryInstruction.TabIndex = 3;
            this.labelSecondaryInstruction.Text = "2nd Instruction";
            this.labelSecondaryInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBottomInstruction
            // 
            this.labelBottomInstruction.AutoSize = true;
            this.labelBottomInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBottomInstruction.Location = new System.Drawing.Point(174, 364);
            this.labelBottomInstruction.Name = "labelBottomInstruction";
            this.labelBottomInstruction.Size = new System.Drawing.Size(747, 74);
            this.labelBottomInstruction.TabIndex = 4;
            this.labelBottomInstruction.Text = "Puede colocar el código de barras de otro producto\r\nfrente al lector en cualquier" +
    " momento.";
            this.labelBottomInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.Location = new System.Drawing.Point(217, 217);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(256, 44);
            this.labelContent.TabIndex = 8;
            this.labelContent.Text = "Content Label";
            this.labelContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbServicio
            // 
            this.pbServicio.Image = global::VerificadorDePreciosISW3.Properties.Resources.clerk_2;
            this.pbServicio.Location = new System.Drawing.Point(613, 311);
            this.pbServicio.Name = "pbServicio";
            this.pbServicio.Size = new System.Drawing.Size(175, 172);
            this.pbServicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbServicio.TabIndex = 9;
            this.pbServicio.TabStop = false;
            // 
            // pbLoading
            // 
            this.pbLoading.Image = global::VerificadorDePreciosISW3.Properties.Resources.LoadingGif1;
            this.pbLoading.Location = new System.Drawing.Point(620, 149);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(151, 143);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 7;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // pbScanAtBottom
            // 
            this.pbScanAtBottom.Image = global::VerificadorDePreciosISW3.Properties.Resources.cropped_scangif_2;
            this.pbScanAtBottom.Location = new System.Drawing.Point(12, 333);
            this.pbScanAtBottom.Name = "pbScanAtBottom";
            this.pbScanAtBottom.Size = new System.Drawing.Size(156, 105);
            this.pbScanAtBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScanAtBottom.TabIndex = 6;
            this.pbScanAtBottom.TabStop = false;
            this.pbScanAtBottom.Visible = false;
            // 
            // pbResult
            // 
            this.pbResult.Location = new System.Drawing.Point(30, 139);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(150, 153);
            this.pbResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResult.TabIndex = 5;
            this.pbResult.TabStop = false;
            this.pbResult.Visible = false;
            // 
            // pbScan
            // 
            this.pbScan.Image = global::VerificadorDePreciosISW3.Properties.Resources.cropped_scangif_2;
            this.pbScan.Location = new System.Drawing.Point(334, 139);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(188, 153);
            this.pbScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScan.TabIndex = 1;
            this.pbScan.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::VerificadorDePreciosISW3.Properties.Resources.placeholder_logo2;
            this.pbLogo.Location = new System.Drawing.Point(578, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(210, 61);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // timerToStartState
            // 
            this.timerToStartState.Interval = 1000;
            this.timerToStartState.Tick += new System.EventHandler(this.timerToStartState_Tick);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(12, 46);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(295, 44);
            this.labelProductName.TabIndex = 10;
            this.labelProductName.Text = "ProdNameLabel";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.pbServicio);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.pbScanAtBottom);
            this.Controls.Add(this.pbResult);
            this.Controls.Add(this.labelBottomInstruction);
            this.Controls.Add(this.labelSecondaryInstruction);
            this.Controls.Add(this.labelMainInstruction);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanAtBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Windows.Forms.Label labelMainInstruction;
        private System.Windows.Forms.Label labelSecondaryInstruction;
        private System.Windows.Forms.Label labelBottomInstruction;
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.PictureBox pbScanAtBottom;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.PictureBox pbServicio;
        private System.Windows.Forms.Timer timerToStartState;
        private System.Windows.Forms.Label labelProductName;
    }
}

