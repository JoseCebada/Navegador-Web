namespace Navegador_Web
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.linkCalc = new System.Windows.Forms.LinkLabel();
            this.linkUcol = new System.Windows.Forms.LinkLabel();
            this.linkDiscoC = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(747, 172);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // picImagen
            // 
            this.picImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picImagen.Location = new System.Drawing.Point(12, 12);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(670, 444);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 2;
            this.picImagen.TabStop = false;
            // 
            // linkCalc
            // 
            this.linkCalc.AutoSize = true;
            this.linkCalc.Location = new System.Drawing.Point(741, 261);
            this.linkCalc.Name = "linkCalc";
            this.linkCalc.Size = new System.Drawing.Size(86, 13);
            this.linkCalc.TabIndex = 3;
            this.linkCalc.TabStop = true;
            this.linkCalc.Text = "Abrir calculadora";
            this.linkCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCalc_LinkClicked);
            // 
            // linkUcol
            // 
            this.linkUcol.AutoSize = true;
            this.linkUcol.Location = new System.Drawing.Point(742, 334);
            this.linkUcol.Name = "linkUcol";
            this.linkUcol.Size = new System.Drawing.Size(70, 13);
            this.linkUcol.TabIndex = 4;
            this.linkUcol.TabStop = true;
            this.linkUcol.Text = "www.ucol.mx";
            this.linkUcol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUcol_LinkClicked);
            // 
            // linkDiscoC
            // 
            this.linkDiscoC.AutoSize = true;
            this.linkDiscoC.Location = new System.Drawing.Point(742, 414);
            this.linkDiscoC.Name = "linkDiscoC";
            this.linkDiscoC.Size = new System.Drawing.Size(85, 13);
            this.linkDiscoC.TabIndex = 5;
            this.linkDiscoC.TabStop = true;
            this.linkDiscoC.Text = "Explorar Disco C";
            this.linkDiscoC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkDiscoC_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 467);
            this.Controls.Add(this.linkDiscoC);
            this.Controls.Add(this.linkUcol);
            this.Controls.Add(this.linkCalc);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.LinkLabel linkCalc;
        private System.Windows.Forms.LinkLabel linkUcol;
        private System.Windows.Forms.LinkLabel linkDiscoC;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

