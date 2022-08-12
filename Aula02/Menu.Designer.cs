namespace Aula02
{
    partial class Menu
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
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.btnMenuImc = new System.Windows.Forms.Button();
            this.btnMenuCalNor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloMenu.Location = new System.Drawing.Point(113, 32);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(420, 103);
            this.lblTituloMenu.TabIndex = 0;
            this.lblTituloMenu.Text = "Calculadoras";
            this.lblTituloMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMenuImc
            // 
            this.btnMenuImc.Location = new System.Drawing.Point(113, 190);
            this.btnMenuImc.Name = "btnMenuImc";
            this.btnMenuImc.Size = new System.Drawing.Size(151, 69);
            this.btnMenuImc.TabIndex = 1;
            this.btnMenuImc.Text = "Calculadora IMC";
            this.btnMenuImc.UseVisualStyleBackColor = true;
            this.btnMenuImc.Click += new System.EventHandler(this.btnMenuImc_Click);
            // 
            // btnMenuCalNor
            // 
            this.btnMenuCalNor.Location = new System.Drawing.Point(382, 190);
            this.btnMenuCalNor.Name = "btnMenuCalNor";
            this.btnMenuCalNor.Size = new System.Drawing.Size(151, 69);
            this.btnMenuCalNor.TabIndex = 2;
            this.btnMenuCalNor.Text = "Calculadora Normal";
            this.btnMenuCalNor.UseVisualStyleBackColor = true;
            this.btnMenuCalNor.Click += new System.EventHandler(this.btnMenuCalNor_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(640, 342);
            this.Controls.Add(this.btnMenuCalNor);
            this.Controls.Add(this.btnMenuImc);
            this.Controls.Add(this.lblTituloMenu);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTituloMenu;
        private Button btnMenuImc;
        private Button btnMenuCalNor;
    }
}