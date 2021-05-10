
namespace KonferenciaProjekt
{
    partial class FormEloadasok
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
            this.pictureBoxIro = new System.Windows.Forms.PictureBox();
            this.buttonMent = new System.Windows.Forms.Button();
            this.buttonJobb = new System.Windows.Forms.Button();
            this.buttonBal = new System.Windows.Forms.Button();
            this.panelErtekeles = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIro)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIro
            // 
            this.pictureBoxIro.Location = new System.Drawing.Point(122, 50);
            this.pictureBoxIro.Name = "pictureBoxIro";
            this.pictureBoxIro.Size = new System.Drawing.Size(158, 175);
            this.pictureBoxIro.TabIndex = 0;
            this.pictureBoxIro.TabStop = false;
            // 
            // buttonMent
            // 
            this.buttonMent.Location = new System.Drawing.Point(162, 243);
            this.buttonMent.Name = "buttonMent";
            this.buttonMent.Size = new System.Drawing.Size(78, 72);
            this.buttonMent.TabIndex = 1;
            this.buttonMent.UseVisualStyleBackColor = true;
            this.buttonMent.Click += new System.EventHandler(this.buttonMent_Click);
            // 
            // buttonJobb
            // 
            this.buttonJobb.Location = new System.Drawing.Point(312, 102);
            this.buttonJobb.Name = "buttonJobb";
            this.buttonJobb.Size = new System.Drawing.Size(78, 72);
            this.buttonJobb.TabIndex = 2;
            this.buttonJobb.UseVisualStyleBackColor = true;
            this.buttonJobb.Click += new System.EventHandler(this.buttonJobb_Click);
            // 
            // buttonBal
            // 
            this.buttonBal.Location = new System.Drawing.Point(12, 102);
            this.buttonBal.Name = "buttonBal";
            this.buttonBal.Size = new System.Drawing.Size(78, 72);
            this.buttonBal.TabIndex = 3;
            this.buttonBal.UseVisualStyleBackColor = true;
            this.buttonBal.Click += new System.EventHandler(this.buttonBal_Click);
            // 
            // panelErtekeles
            // 
            this.panelErtekeles.Location = new System.Drawing.Point(444, 50);
            this.panelErtekeles.Name = "panelErtekeles";
            this.panelErtekeles.Size = new System.Drawing.Size(505, 251);
            this.panelErtekeles.TabIndex = 4;
            // 
            // FormEloadasok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 373);
            this.Controls.Add(this.panelErtekeles);
            this.Controls.Add(this.buttonBal);
            this.Controls.Add(this.buttonJobb);
            this.Controls.Add(this.buttonMent);
            this.Controls.Add(this.pictureBoxIro);
            this.Name = "FormEloadasok";
            this.Load += new System.EventHandler(this.FormEloadasok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIro;
        private System.Windows.Forms.Button buttonMent;
        private System.Windows.Forms.Button buttonJobb;
        private System.Windows.Forms.Button buttonBal;
        private System.Windows.Forms.Panel panelErtekeles;
    }
}

