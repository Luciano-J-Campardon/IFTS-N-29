namespace PrimerEjercicioWinForms
{
    partial class fmrPrincipal
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
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.Button();
            lblApellido = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            btnLimpiar = new System.Windows.Forms.Button();
            lblDocumento = new System.Windows.Forms.Label();
            txtDocumento = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(26, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(194, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(172, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(486, 50);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(75, 23);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(26, 115);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(194, 112);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(172, 23);
            txtApellido.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(486, 112);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new System.Drawing.Point(26, 179);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new System.Drawing.Size(70, 15);
            lblDocumento.TabIndex = 6;
            lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(194, 176);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(172, 23);
            txtDocumento.TabIndex = 7;
            // 
            // fmrPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 255, 192);
            ClientSize = new System.Drawing.Size(844, 437);
            Controls.Add(txtDocumento);
            Controls.Add(lblDocumento);
            Controls.Add(btnLimpiar);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnIngresar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "fmrPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PRIMER PROYECTO";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
    }
}
