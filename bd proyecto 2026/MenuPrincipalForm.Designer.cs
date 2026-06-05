namespace bd_proyecto_2026
{
    partial class frmMenuPrincipal
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
            pnlMenuLateral = new Panel();
            pnlMenuInferior = new Panel();
            btnInicio = new Button();
            pnlSeleccion = new Panel();
            pnlMenuLateralSuperior = new Panel();
            btnMenuLateral = new Button();
            picLogoUAEMEX = new PictureBox();
            btnEmpleado = new Button();
            btnVuelo = new Button();
            pnlPantalla = new Panel();
            pnlMenuLateral.SuspendLayout();
            pnlMenuInferior.SuspendLayout();
            pnlMenuLateralSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoUAEMEX).BeginInit();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.BackColor = Color.DimGray;
            pnlMenuLateral.Controls.Add(pnlMenuInferior);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMenuLateral.Location = new Point(0, 0);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(250, 664);
            pnlMenuLateral.TabIndex = 0;
            // 
            // pnlMenuInferior
            // 
            pnlMenuInferior.BackColor = Color.Transparent;
            pnlMenuInferior.Controls.Add(btnInicio);
            pnlMenuInferior.Controls.Add(pnlSeleccion);
            pnlMenuInferior.Controls.Add(pnlMenuLateralSuperior);
            pnlMenuInferior.Controls.Add(btnEmpleado);
            pnlMenuInferior.Controls.Add(btnVuelo);
            pnlMenuInferior.Dock = DockStyle.Left;
            pnlMenuInferior.ForeColor = Color.Black;
            pnlMenuInferior.Location = new Point(0, 0);
            pnlMenuInferior.Name = "pnlMenuInferior";
            pnlMenuInferior.Size = new Size(250, 664);
            pnlMenuInferior.TabIndex = 3;
            // 
            // btnInicio
            // 
            btnInicio.BackgroundImage = Properties.Resources.icono_casa_azul_32;
            btnInicio.BackgroundImageLayout = ImageLayout.None;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Myanmar Text", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.White;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(27, 161);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(223, 34);
            btnInicio.TabIndex = 3;
            btnInicio.Tag = "Inicio";
            btnInicio.Text = "Inicio";
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlSeleccion
            // 
            pnlSeleccion.BackColor = Color.White;
            pnlSeleccion.Location = new Point(0, 161);
            pnlSeleccion.Name = "pnlSeleccion";
            pnlSeleccion.Size = new Size(10, 34);
            pnlSeleccion.TabIndex = 0;
            // 
            // pnlMenuLateralSuperior
            // 
            pnlMenuLateralSuperior.Controls.Add(btnMenuLateral);
            pnlMenuLateralSuperior.Controls.Add(picLogoUAEMEX);
            pnlMenuLateralSuperior.Dock = DockStyle.Top;
            pnlMenuLateralSuperior.Location = new Point(0, 0);
            pnlMenuLateralSuperior.Name = "pnlMenuLateralSuperior";
            pnlMenuLateralSuperior.Size = new Size(250, 122);
            pnlMenuLateralSuperior.TabIndex = 2;
            // 
            // btnMenuLateral
            // 
            btnMenuLateral.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMenuLateral.BackgroundImageLayout = ImageLayout.Zoom;
            btnMenuLateral.FlatAppearance.BorderSize = 0;
            btnMenuLateral.FlatStyle = FlatStyle.Flat;
            btnMenuLateral.Image = Properties.Resources.icono_menu_azul_321;
            btnMenuLateral.Location = new Point(146, 0);
            btnMenuLateral.Name = "btnMenuLateral";
            btnMenuLateral.Size = new Size(104, 119);
            btnMenuLateral.TabIndex = 1;
            btnMenuLateral.UseVisualStyleBackColor = false;
            btnMenuLateral.Click += btnMenuLateral_Click;
            // 
            // picLogoUAEMEX
            // 
            picLogoUAEMEX.BackgroundImageLayout = ImageLayout.Zoom;
            picLogoUAEMEX.Image = Properties.Resources.aereopuerto_logo_azul;
            picLogoUAEMEX.Location = new Point(17, 0);
            picLogoUAEMEX.Name = "picLogoUAEMEX";
            picLogoUAEMEX.Size = new Size(123, 122);
            picLogoUAEMEX.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoUAEMEX.TabIndex = 0;
            picLogoUAEMEX.TabStop = false;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackgroundImage = Properties.Resources.icono_empleado_azul_32;
            btnEmpleado.BackgroundImageLayout = ImageLayout.None;
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Myanmar Text", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleado.ForeColor = Color.White;
            btnEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.Location = new Point(27, 339);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(223, 34);
            btnEmpleado.TabIndex = 1;
            btnEmpleado.Tag = "  Empleado";
            btnEmpleado.Text = "     Empleado";
            btnEmpleado.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnVuelo
            // 
            btnVuelo.BackgroundImage = Properties.Resources.icono_avion_azul_32;
            btnVuelo.BackgroundImageLayout = ImageLayout.None;
            btnVuelo.FlatAppearance.BorderSize = 0;
            btnVuelo.FlatStyle = FlatStyle.Flat;
            btnVuelo.Font = new Font("Myanmar Text", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVuelo.ForeColor = Color.White;
            btnVuelo.ImageAlign = ContentAlignment.MiddleLeft;
            btnVuelo.Location = new Point(27, 252);
            btnVuelo.Name = "btnVuelo";
            btnVuelo.Size = new Size(223, 34);
            btnVuelo.TabIndex = 0;
            btnVuelo.Tag = "Vuelo";
            btnVuelo.Text = "Vuelo";
            btnVuelo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVuelo.UseVisualStyleBackColor = true;
            btnVuelo.Click += btnVuelo_Click;
            // 
            // pnlPantalla
            // 
            pnlPantalla.BackColor = Color.Black;
            pnlPantalla.Dock = DockStyle.Fill;
            pnlPantalla.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlPantalla.Location = new Point(250, 0);
            pnlPantalla.Name = "pnlPantalla";
            pnlPantalla.Size = new Size(1200, 664);
            pnlPantalla.TabIndex = 1;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1450, 664);
            Controls.Add(pnlPantalla);
            Controls.Add(pnlMenuLateral);
            Name = "frmMenuPrincipal";
            Text = "Menu Principal";
            pnlMenuLateral.ResumeLayout(false);
            pnlMenuInferior.ResumeLayout(false);
            pnlMenuLateralSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoUAEMEX).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuLateral;
        private Panel pnlPantalla;
        private Panel pnlMenuInferior;
        private Panel pnlSeleccion;
        private Panel pnlMenuLateralSuperior;
        private Button btnMenuLateral;
        private PictureBox picLogoUAEMEX;
        private Button btnEmpleado;
        private Button btnVuelo;
        private Button btnInicio;
    }
}
