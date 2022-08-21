namespace sellingTickets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.agregar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.intEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(77, 104);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(100, 23);
            this.agregar.TabIndex = 0;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(77, 133);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(100, 23);
            this.salir.TabIndex = 2;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // intEdad
            // 
            this.intEdad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.intEdad.Location = new System.Drawing.Point(77, 75);
            this.intEdad.Name = "intEdad";
            this.intEdad.Size = new System.Drawing.Size(100, 23);
            this.intEdad.TabIndex = 3;
            this.intEdad.Text = "Ingrese su edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 248);
            this.Controls.Add(this.intEdad);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.agregar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button agregar;
        private Button salir;
        private TextBox intEdad;
    }
}