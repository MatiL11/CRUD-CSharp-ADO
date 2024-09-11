namespace TpN3
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
            this.btnMenuPais = new System.Windows.Forms.Button();
            this.btnMenuProvincia = new System.Windows.Forms.Button();
            this.btnMenuSocio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuPais
            // 
            this.btnMenuPais.Location = new System.Drawing.Point(462, 183);
            this.btnMenuPais.Name = "btnMenuPais";
            this.btnMenuPais.Size = new System.Drawing.Size(192, 64);
            this.btnMenuPais.TabIndex = 8;
            this.btnMenuPais.Text = "Menu Pais";
            this.btnMenuPais.UseVisualStyleBackColor = true;
            this.btnMenuPais.Click += new System.EventHandler(this.btnMenuPais_Click);
            // 
            // btnMenuProvincia
            // 
            this.btnMenuProvincia.Location = new System.Drawing.Point(416, 309);
            this.btnMenuProvincia.Name = "btnMenuProvincia";
            this.btnMenuProvincia.Size = new System.Drawing.Size(275, 64);
            this.btnMenuProvincia.TabIndex = 9;
            this.btnMenuProvincia.Text = "Menu Provincia";
            this.btnMenuProvincia.UseVisualStyleBackColor = true;
            this.btnMenuProvincia.Click += new System.EventHandler(this.btnMenuProvincia_Click);
            // 
            // btnMenuSocio
            // 
            this.btnMenuSocio.Location = new System.Drawing.Point(462, 438);
            this.btnMenuSocio.Name = "btnMenuSocio";
            this.btnMenuSocio.Size = new System.Drawing.Size(192, 64);
            this.btnMenuSocio.TabIndex = 10;
            this.btnMenuSocio.Text = "Menu Socio";
            this.btnMenuSocio.UseVisualStyleBackColor = true;
            this.btnMenuSocio.Click += new System.EventHandler(this.btnMenuSocio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 694);
            this.Controls.Add(this.btnMenuSocio);
            this.Controls.Add(this.btnMenuProvincia);
            this.Controls.Add(this.btnMenuPais);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMenuPais;
        private System.Windows.Forms.Button btnMenuProvincia;
        private System.Windows.Forms.Button btnMenuSocio;
    }
}

