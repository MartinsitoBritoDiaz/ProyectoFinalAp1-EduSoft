namespace Proyecto_Final.UI.Registros
{
    partial class rProfesores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProfesores));
            this.ProfesorIdLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.DirecciónLabel = new System.Windows.Forms.Label();
            this.ImagenLabel = new System.Windows.Forms.Label();
            this.ProfesorIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.InsertarImagenButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.CelularLabel = new System.Windows.Forms.Label();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.SexoLabel = new System.Windows.Forms.Label();
            this.GeneroComboBox = new System.Windows.Forms.ComboBox();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfesorIdLabel
            // 
            this.ProfesorIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfesorIdLabel.AutoSize = true;
            this.ProfesorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesorIdLabel.Location = new System.Drawing.Point(24, 37);
            this.ProfesorIdLabel.Name = "ProfesorIdLabel";
            this.ProfesorIdLabel.Size = new System.Drawing.Size(91, 20);
            this.ProfesorIdLabel.TabIndex = 0;
            this.ProfesorIdLabel.Text = "Profesor Id";
            // 
            // NombreLabel
            // 
            this.NombreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(24, 98);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(68, 20);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre";
            // 
            // DirecciónLabel
            // 
            this.DirecciónLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DirecciónLabel.AutoSize = true;
            this.DirecciónLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirecciónLabel.Location = new System.Drawing.Point(24, 312);
            this.DirecciónLabel.Name = "DirecciónLabel";
            this.DirecciónLabel.Size = new System.Drawing.Size(81, 20);
            this.DirecciónLabel.TabIndex = 5;
            this.DirecciónLabel.Text = "Dirección";
            // 
            // ImagenLabel
            // 
            this.ImagenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImagenLabel.AutoSize = true;
            this.ImagenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagenLabel.Location = new System.Drawing.Point(560, 37);
            this.ImagenLabel.Name = "ImagenLabel";
            this.ImagenLabel.Size = new System.Drawing.Size(125, 20);
            this.ImagenLabel.TabIndex = 6;
            this.ImagenLabel.Text = "Foto de usuario";
            // 
            // ProfesorIdNumericUpDown
            // 
            this.ProfesorIdNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfesorIdNumericUpDown.Location = new System.Drawing.Point(126, 38);
            this.ProfesorIdNumericUpDown.Name = "ProfesorIdNumericUpDown";
            this.ProfesorIdNumericUpDown.Size = new System.Drawing.Size(79, 22);
            this.ProfesorIdNumericUpDown.TabIndex = 8;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NombreTextBox.Location = new System.Drawing.Point(126, 98);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(297, 22);
            this.NombreTextBox.TabIndex = 10;
            this.NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextBox_KeyPress);
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DireccionTextBox.Location = new System.Drawing.Point(126, 312);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(297, 22);
            this.DireccionTextBox.TabIndex = 11;
            // 
            // InsertarImagenButton
            // 
            this.InsertarImagenButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InsertarImagenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertarImagenButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertarImagenButton.Image")));
            this.InsertarImagenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertarImagenButton.Location = new System.Drawing.Point(504, 305);
            this.InsertarImagenButton.Name = "InsertarImagenButton";
            this.InsertarImagenButton.Size = new System.Drawing.Size(237, 36);
            this.InsertarImagenButton.TabIndex = 20;
            this.InsertarImagenButton.Text = "Insertar imagen";
            this.InsertarImagenButton.UseVisualStyleBackColor = true;
            this.InsertarImagenButton.Click += new System.EventHandler(this.InsertarImagenButton_Click);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.Image = global::Proyecto_Final.Properties.Resources.imgEliminar;
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButton.Location = new System.Drawing.Point(652, 437);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(89, 36);
            this.BorrarButton.TabIndex = 19;
            this.BorrarButton.Text = "Borrar";
            this.BorrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BorrarButton.UseVisualStyleBackColor = true;
            this.BorrarButton.Click += new System.EventHandler(this.BorrarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarButton.Image = global::Proyecto_Final.Properties.Resources.imgGuardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(325, 437);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(98, 36);
            this.GuardarButton.TabIndex = 18;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NuevoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NuevoButton.Image = global::Proyecto_Final.Properties.Resources.imgNuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(28, 437);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(89, 36);
            this.NuevoButton.TabIndex = 17;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BuscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButton.Image = global::Proyecto_Final.Properties.Resources.imgBuscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(334, 30);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(89, 36);
            this.BuscarButton.TabIndex = 16;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImagenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ImagenPictureBox.Image")));
            this.ImagenPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("ImagenPictureBox.InitialImage")));
            this.ImagenPictureBox.Location = new System.Drawing.Point(504, 75);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(237, 215);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenPictureBox.TabIndex = 7;
            this.ImagenPictureBox.TabStop = false;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailTextBox.Location = new System.Drawing.Point(126, 270);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(297, 22);
            this.EmailTextBox.TabIndex = 45;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(24, 270);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.EmailLabel.TabIndex = 44;
            this.EmailLabel.Text = "Email";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("MyErrorProvider.Icon")));
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(19, 156);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(73, 20);
            this.TelefonoLabel.TabIndex = 2;
            this.TelefonoLabel.Text = "Telefono";
            // 
            // CelularLabel
            // 
            this.CelularLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CelularLabel.AutoSize = true;
            this.CelularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularLabel.Location = new System.Drawing.Point(248, 156);
            this.CelularLabel.Name = "CelularLabel";
            this.CelularLabel.Size = new System.Drawing.Size(62, 20);
            this.CelularLabel.TabIndex = 3;
            this.CelularLabel.Text = "Celular";
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.Location = new System.Drawing.Point(24, 220);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(61, 20);
            this.CedulaLabel.TabIndex = 4;
            this.CedulaLabel.Text = "Cedula";
            // 
            // SexoLabel
            // 
            this.SexoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SexoLabel.AutoSize = true;
            this.SexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexoLabel.Location = new System.Drawing.Point(246, 220);
            this.SexoLabel.Name = "SexoLabel";
            this.SexoLabel.Size = new System.Drawing.Size(64, 20);
            this.SexoLabel.TabIndex = 9;
            this.SexoLabel.Text = "Genero";
            // 
            // GeneroComboBox
            // 
            this.GeneroComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GeneroComboBox.FormattingEnabled = true;
            this.GeneroComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.GeneroComboBox.Location = new System.Drawing.Point(325, 220);
            this.GeneroComboBox.Name = "GeneroComboBox";
            this.GeneroComboBox.Size = new System.Drawing.Size(98, 24);
            this.GeneroComboBox.TabIndex = 12;
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(126, 156);
            this.TelefonoMaskedTextBox.Mask = "000-000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(107, 22);
            this.TelefonoMaskedTextBox.TabIndex = 13;
            // 
            // CelularMaskedTextBox
            // 
            this.CelularMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CelularMaskedTextBox.Location = new System.Drawing.Point(325, 156);
            this.CelularMaskedTextBox.Mask = "000-000-0000";
            this.CelularMaskedTextBox.Name = "CelularMaskedTextBox";
            this.CelularMaskedTextBox.Size = new System.Drawing.Size(98, 22);
            this.CelularMaskedTextBox.TabIndex = 14;
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(126, 220);
            this.CedulaMaskedTextBox.Mask = "000-0000000-0";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(107, 22);
            this.CedulaMaskedTextBox.TabIndex = 15;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioTextBox.Location = new System.Drawing.Point(337, 384);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(173, 22);
            this.UsuarioTextBox.TabIndex = 51;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(265, 384);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLabel.TabIndex = 50;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // rProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 496);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.InsertarImagenButton);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.CelularMaskedTextBox);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.GeneroComboBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.SexoLabel);
            this.Controls.Add(this.ProfesorIdNumericUpDown);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.ImagenLabel);
            this.Controls.Add(this.DirecciónLabel);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.CelularLabel);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.ProfesorIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rProfesores";
            this.Text = "Registro de profesores";
            this.Load += new System.EventHandler(this.RProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfesorIdLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label DirecciónLabel;
        private System.Windows.Forms.Label ImagenLabel;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.NumericUpDown ProfesorIdNumericUpDown;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button InsertarImagenButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CelularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.ComboBox GeneroComboBox;
        private System.Windows.Forms.Label SexoLabel;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label CelularLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label UsuarioLabel;
    }
}