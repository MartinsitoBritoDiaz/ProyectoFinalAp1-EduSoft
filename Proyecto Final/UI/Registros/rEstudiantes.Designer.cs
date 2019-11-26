namespace Proyecto_Final.UI.Registros
{
    partial class rEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEstudiantes));
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GeneroComboBox = new System.Windows.Forms.ComboBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.SexoLabel = new System.Windows.Forms.Label();
            this.ImagenLabel = new System.Windows.Forms.Label();
            this.DirecciónLabel = new System.Windows.Forms.Label();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.CelularLabel = new System.Windows.Forms.Label();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.EstudianteIdLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.InsertarImagenButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.MatriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EstudianteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(160, 232);
            this.CedulaMaskedTextBox.Mask = "000-0000000-0";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.CedulaMaskedTextBox.TabIndex = 36;
            // 
            // CelularMaskedTextBox
            // 
            this.CelularMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CelularMaskedTextBox.Location = new System.Drawing.Point(345, 172);
            this.CelularMaskedTextBox.Mask = "000-000-0000";
            this.CelularMaskedTextBox.Name = "CelularMaskedTextBox";
            this.CelularMaskedTextBox.Size = new System.Drawing.Size(98, 22);
            this.CelularMaskedTextBox.TabIndex = 35;
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(160, 172);
            this.TelefonoMaskedTextBox.Mask = "000-000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.TelefonoMaskedTextBox.TabIndex = 34;
            // 
            // GeneroComboBox
            // 
            this.GeneroComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GeneroComboBox.FormattingEnabled = true;
            this.GeneroComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.GeneroComboBox.Location = new System.Drawing.Point(345, 232);
            this.GeneroComboBox.Name = "GeneroComboBox";
            this.GeneroComboBox.Size = new System.Drawing.Size(98, 24);
            this.GeneroComboBox.TabIndex = 33;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DireccionTextBox.Location = new System.Drawing.Point(160, 329);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(283, 22);
            this.DireccionTextBox.TabIndex = 32;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NombreTextBox.Location = new System.Drawing.Point(160, 127);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(283, 22);
            this.NombreTextBox.TabIndex = 31;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            this.NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextBox_KeyPress);
            // 
            // SexoLabel
            // 
            this.SexoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SexoLabel.AutoSize = true;
            this.SexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexoLabel.Location = new System.Drawing.Point(277, 232);
            this.SexoLabel.Name = "SexoLabel";
            this.SexoLabel.Size = new System.Drawing.Size(46, 20);
            this.SexoLabel.TabIndex = 30;
            this.SexoLabel.Text = "Sexo";
            // 
            // ImagenLabel
            // 
            this.ImagenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImagenLabel.AutoSize = true;
            this.ImagenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImagenLabel.Location = new System.Drawing.Point(578, 41);
            this.ImagenLabel.Name = "ImagenLabel";
            this.ImagenLabel.Size = new System.Drawing.Size(125, 20);
            this.ImagenLabel.TabIndex = 27;
            this.ImagenLabel.Text = "Foto de usuario";
            // 
            // DirecciónLabel
            // 
            this.DirecciónLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DirecciónLabel.AutoSize = true;
            this.DirecciónLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirecciónLabel.Location = new System.Drawing.Point(26, 329);
            this.DirecciónLabel.Name = "DirecciónLabel";
            this.DirecciónLabel.Size = new System.Drawing.Size(81, 20);
            this.DirecciónLabel.TabIndex = 26;
            this.DirecciónLabel.Text = "Dirección";
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.Location = new System.Drawing.Point(26, 232);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(61, 20);
            this.CedulaLabel.TabIndex = 25;
            this.CedulaLabel.Text = "Cedula";
            // 
            // CelularLabel
            // 
            this.CelularLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CelularLabel.AutoSize = true;
            this.CelularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularLabel.Location = new System.Drawing.Point(277, 172);
            this.CelularLabel.Name = "CelularLabel";
            this.CelularLabel.Size = new System.Drawing.Size(62, 20);
            this.CelularLabel.TabIndex = 24;
            this.CelularLabel.Text = "Celular";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.Location = new System.Drawing.Point(26, 172);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(73, 20);
            this.TelefonoLabel.TabIndex = 23;
            this.TelefonoLabel.Text = "Telefono";
            // 
            // NombreLabel
            // 
            this.NombreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(26, 127);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(68, 20);
            this.NombreLabel.TabIndex = 22;
            this.NombreLabel.Text = "Nombre";
            // 
            // EstudianteIdLabel
            // 
            this.EstudianteIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EstudianteIdLabel.AutoSize = true;
            this.EstudianteIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteIdLabel.Location = new System.Drawing.Point(26, 75);
            this.EstudianteIdLabel.Name = "EstudianteIdLabel";
            this.EstudianteIdLabel.Size = new System.Drawing.Size(78, 20);
            this.EstudianteIdLabel.TabIndex = 21;
            this.EstudianteIdLabel.Text = "Matricula";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(26, 286);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.EmailLabel.TabIndex = 42;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailTextBox.Location = new System.Drawing.Point(160, 286);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(283, 22);
            this.EmailTextBox.TabIndex = 43;
            // 
            // InsertarImagenButton
            // 
            this.InsertarImagenButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InsertarImagenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertarImagenButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertarImagenButton.Image")));
            this.InsertarImagenButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertarImagenButton.Location = new System.Drawing.Point(517, 310);
            this.InsertarImagenButton.Name = "InsertarImagenButton";
            this.InsertarImagenButton.Size = new System.Drawing.Size(237, 36);
            this.InsertarImagenButton.TabIndex = 41;
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
            this.BorrarButton.Location = new System.Drawing.Point(672, 442);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(89, 36);
            this.BorrarButton.TabIndex = 40;
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
            this.GuardarButton.Location = new System.Drawing.Point(345, 442);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(98, 36);
            this.GuardarButton.TabIndex = 39;
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
            this.NuevoButton.Location = new System.Drawing.Point(30, 442);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(89, 36);
            this.NuevoButton.TabIndex = 38;
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
            this.BuscarButton.Location = new System.Drawing.Point(354, 25);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(89, 36);
            this.BuscarButton.TabIndex = 37;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImagenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ImagenPictureBox.Image")));
            this.ImagenPictureBox.Location = new System.Drawing.Point(517, 79);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(237, 215);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenPictureBox.TabIndex = 28;
            this.ImagenPictureBox.TabStop = false;
            // 
            // MatriculaMaskedTextBox
            // 
            this.MatriculaMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MatriculaMaskedTextBox.Location = new System.Drawing.Point(160, 73);
            this.MatriculaMaskedTextBox.Mask = "0000-0000";
            this.MatriculaMaskedTextBox.Name = "MatriculaMaskedTextBox";
            this.MatriculaMaskedTextBox.Size = new System.Drawing.Size(105, 22);
            this.MatriculaMaskedTextBox.TabIndex = 44;
            this.MatriculaMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MatriculaMaskedTextBox_MaskInputRejected);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("MyErrorProvider.Icon")));
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioTextBox.Location = new System.Drawing.Point(350, 391);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(173, 22);
            this.UsuarioTextBox.TabIndex = 53;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(278, 391);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLabel.TabIndex = 52;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "EstudianteId";
            // 
            // EstudianteIdNumericUpDown
            // 
            this.EstudianteIdNumericUpDown.Location = new System.Drawing.Point(160, 25);
            this.EstudianteIdNumericUpDown.Name = "EstudianteIdNumericUpDown";
            this.EstudianteIdNumericUpDown.Size = new System.Drawing.Size(105, 22);
            this.EstudianteIdNumericUpDown.TabIndex = 55;
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.EstudianteIdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.MatriculaMaskedTextBox);
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
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.ImagenLabel);
            this.Controls.Add(this.DirecciónLabel);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.CelularLabel);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.EstudianteIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rEstudiantes";
            this.Text = "Registro de estudiantes";
            this.Load += new System.EventHandler(this.REstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertarImagenButton;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CelularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.ComboBox GeneroComboBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label SexoLabel;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.Label ImagenLabel;
        private System.Windows.Forms.Label DirecciónLabel;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label CelularLabel;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label EstudianteIdLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.MaskedTextBox MatriculaMaskedTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.NumericUpDown EstudianteIdNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}