namespace Practica2
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
            lblDato = new Label();
            lblBuscar = new Label();
            gbInsertar = new GroupBox();
            btnInsertar = new Button();
            txtDato = new TextBox();
            gbBuscar = new GroupBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            gbLista = new GroupBox();
            txtLista = new RichTextBox();
            gbMensaje = new GroupBox();
            txtMensaje = new TextBox();
            gbInsertar.SuspendLayout();
            gbBuscar.SuspendLayout();
            gbLista.SuspendLayout();
            gbMensaje.SuspendLayout();
            SuspendLayout();
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDato.ForeColor = SystemColors.ControlText;
            lblDato.Location = new Point(14, 45);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(35, 15);
            lblDato.TabIndex = 2;
            lblDato.Text = "Dato:";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.ForeColor = SystemColors.ControlText;
            lblBuscar.Location = new Point(8, 43);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(82, 15);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Dato a buscar:";
            // 
            // gbInsertar
            // 
            gbInsertar.Controls.Add(btnInsertar);
            gbInsertar.Controls.Add(txtDato);
            gbInsertar.Controls.Add(lblDato);
            gbInsertar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbInsertar.ForeColor = SystemColors.HotTrack;
            gbInsertar.Location = new Point(47, 53);
            gbInsertar.Name = "gbInsertar";
            gbInsertar.Size = new Size(719, 100);
            gbInsertar.TabIndex = 4;
            gbInsertar.TabStop = false;
            gbInsertar.Text = "Insertar nuevo dato";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(567, 26);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(108, 52);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "INSERTAR";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtDato
            // 
            txtDato.Location = new Point(111, 41);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(261, 25);
            txtDato.TabIndex = 3;
            // 
            // gbBuscar
            // 
            gbBuscar.Controls.Add(btnBuscar);
            gbBuscar.Controls.Add(txtBuscar);
            gbBuscar.Controls.Add(lblBuscar);
            gbBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbBuscar.ForeColor = SystemColors.HotTrack;
            gbBuscar.Location = new Point(47, 180);
            gbBuscar.Name = "gbBuscar";
            gbBuscar.Size = new Size(714, 100);
            gbBuscar.TabIndex = 5;
            gbBuscar.TabStop = false;
            gbBuscar.Text = "Buscar dato";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(561, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 52);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(105, 36);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(261, 25);
            txtBuscar.TabIndex = 4;
            // 
            // gbLista
            // 
            gbLista.Controls.Add(txtLista);
            gbLista.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbLista.ForeColor = SystemColors.HotTrack;
            gbLista.Location = new Point(47, 310);
            gbLista.Name = "gbLista";
            gbLista.Size = new Size(714, 233);
            gbLista.TabIndex = 6;
            gbLista.TabStop = false;
            gbLista.Text = "Lista de datos";
            // 
            // txtLista
            // 
            txtLista.Location = new Point(15, 28);
            txtLista.Name = "txtLista";
            txtLista.Size = new Size(654, 190);
            txtLista.TabIndex = 0;
            txtLista.Text = "";
            // 
            // gbMensaje
            // 
            gbMensaje.Controls.Add(txtMensaje);
            gbMensaje.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbMensaje.ForeColor = SystemColors.HotTrack;
            gbMensaje.Location = new Point(48, 549);
            gbMensaje.Name = "gbMensaje";
            gbMensaje.Size = new Size(713, 73);
            gbMensaje.TabIndex = 7;
            gbMensaje.TabStop = false;
            gbMensaje.Text = "Mensaje";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(18, 29);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(650, 25);
            txtMensaje.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(800, 634);
            Controls.Add(gbMensaje);
            Controls.Add(gbLista);
            Controls.Add(gbBuscar);
            Controls.Add(gbInsertar);
            Name = "Form1";
            Text = "Form1";
            gbInsertar.ResumeLayout(false);
            gbInsertar.PerformLayout();
            gbBuscar.ResumeLayout(false);
            gbBuscar.PerformLayout();
            gbLista.ResumeLayout(false);
            gbMensaje.ResumeLayout(false);
            gbMensaje.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblDato;
        private Label lblBuscar;
        private GroupBox gbInsertar;
        private TextBox txtDato;
        private GroupBox gbBuscar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnInsertar;
        private GroupBox gbLista;
        private GroupBox gbMensaje;
        private RichTextBox txtLista;
        private TextBox txtMensaje;
    }
}
