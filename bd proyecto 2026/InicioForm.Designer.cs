namespace bd_proyecto_2026
{
    partial class InicioForm
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
            pnlPantallaInicio = new Panel();
            lblIndicacionInicio = new Label();
            lblBienvenidaInicio = new Label();
            picDestinosPopularesInicio = new PictureBox();
            pnlPantallaInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDestinosPopularesInicio).BeginInit();
            SuspendLayout();
            // 
            // pnlPantallaInicio
            // 
            pnlPantallaInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPantallaInicio.Controls.Add(lblIndicacionInicio);
            pnlPantallaInicio.Controls.Add(lblBienvenidaInicio);
            pnlPantallaInicio.Controls.Add(picDestinosPopularesInicio);
            pnlPantallaInicio.Location = new Point(0, 0);
            pnlPantallaInicio.Name = "pnlPantallaInicio";
            pnlPantallaInicio.Size = new Size(1728, 701);
            pnlPantallaInicio.TabIndex = 0;
            // 
            // lblIndicacionInicio
            // 
            lblIndicacionInicio.AutoSize = true;
            lblIndicacionInicio.BackColor = Color.Transparent;
            lblIndicacionInicio.Font = new Font("Myanmar Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIndicacionInicio.ForeColor = Color.White;
            lblIndicacionInicio.Location = new Point(31, 92);
            lblIndicacionInicio.Name = "lblIndicacionInicio";
            lblIndicacionInicio.Size = new Size(479, 34);
            lblIndicacionInicio.TabIndex = 1;
            lblIndicacionInicio.Text = "Selecciona un módulo del menú lateral para comenzar.";
            lblIndicacionInicio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBienvenidaInicio
            // 
            lblBienvenidaInicio.AutoSize = true;
            lblBienvenidaInicio.BackColor = Color.Transparent;
            lblBienvenidaInicio.Font = new Font("Myanmar Text", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenidaInicio.ForeColor = Color.White;
            lblBienvenidaInicio.Location = new Point(31, 26);
            lblBienvenidaInicio.Name = "lblBienvenidaInicio";
            lblBienvenidaInicio.Size = new Size(406, 66);
            lblBienvenidaInicio.TabIndex = 0;
            lblBienvenidaInicio.Text = "Bienvenido al sistema";
            // 
            // picDestinosPopularesInicio
            // 
            picDestinosPopularesInicio.BackColor = Color.Transparent;
            picDestinosPopularesInicio.Image = Properties.Resources.mapaInicioGrande;
            picDestinosPopularesInicio.Location = new Point(74, 12);
            picDestinosPopularesInicio.Name = "picDestinosPopularesInicio";
            picDestinosPopularesInicio.Size = new Size(1621, 972);
            picDestinosPopularesInicio.TabIndex = 3;
            picDestinosPopularesInicio.TabStop = false;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1719, 700);
            Controls.Add(pnlPantallaInicio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioForm";
            Text = "InicioForm";
            pnlPantallaInicio.ResumeLayout(false);
            pnlPantallaInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDestinosPopularesInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPantallaInicio;
        private Label lblIndicacionInicio;
        private Label lblBienvenidaInicio;
        private PictureBox picDestinosPopularesInicio;
    }
}