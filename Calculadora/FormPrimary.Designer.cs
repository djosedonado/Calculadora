namespace Calculadora
{
    partial class FormPrimary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrimary));
            this.panelPrimary = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCompuesto = new System.Windows.Forms.Button();
            this.buttonSimple = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrimary.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrimary
            // 
            this.panelPrimary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelPrimary.Controls.Add(this.panelContainer);
            this.panelPrimary.Controls.Add(this.panelMenu);
            this.panelPrimary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrimary.Location = new System.Drawing.Point(0, 0);
            this.panelPrimary.Name = "panelPrimary";
            this.panelPrimary.Size = new System.Drawing.Size(1092, 607);
            this.panelPrimary.TabIndex = 0;
            this.panelPrimary.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrimary_Paint);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(200, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(892, 607);
            this.panelContainer.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.panelButton);
            this.panelMenu.Controls.Add(this.panelImage);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 607);
            this.panelMenu.TabIndex = 0;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.button3);
            this.panelButton.Controls.Add(this.button2);
            this.panelButton.Controls.Add(this.buttonCompuesto);
            this.panelButton.Controls.Add(this.buttonSimple);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButton.Location = new System.Drawing.Point(0, 100);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(200, 507);
            this.panelButton.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonCompuesto
            // 
            this.buttonCompuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCompuesto.Location = new System.Drawing.Point(0, 42);
            this.buttonCompuesto.Name = "buttonCompuesto";
            this.buttonCompuesto.Size = new System.Drawing.Size(200, 42);
            this.buttonCompuesto.TabIndex = 1;
            this.buttonCompuesto.Text = "Interes Compuesto";
            this.buttonCompuesto.UseVisualStyleBackColor = true;
            this.buttonCompuesto.Click += new System.EventHandler(this.buttonCompuesto_Click);
            // 
            // buttonSimple
            // 
            this.buttonSimple.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSimple.Location = new System.Drawing.Point(0, 0);
            this.buttonSimple.Name = "buttonSimple";
            this.buttonSimple.Size = new System.Drawing.Size(200, 42);
            this.buttonSimple.TabIndex = 0;
            this.buttonSimple.Text = "Interes Simple";
            this.buttonSimple.UseVisualStyleBackColor = true;
            this.buttonSimple.Click += new System.EventHandler(this.buttonSimple_Click);
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pictureBox1);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(200, 100);
            this.panelImage.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrimary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 607);
            this.Controls.Add(this.panelPrimary);
            this.Name = "FormPrimary";
            this.Text = "Form1";
            this.panelPrimary.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrimary;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonCompuesto;
        private System.Windows.Forms.Button buttonSimple;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContainer;
    }
}

