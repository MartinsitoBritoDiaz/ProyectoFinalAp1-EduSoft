namespace Proyecto_Final.UI.Registros
{
    partial class rAsignaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAsignaturas));
            this.AsignaturaIdLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CreditosLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.AsignaturaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CreditosMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ProfesorLabel = new System.Windows.Forms.Label();
            this.ProfesorIdLabel = new System.Windows.Forms.Label();
            this.ProfesorIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProfesorTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AsignaturaIdLabel
            // 
            this.AsignaturaIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AsignaturaIdLabel.AutoSize = true;
            this.AsignaturaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsignaturaIdLabel.Location = new System.Drawing.Point(26, 36);
            this.AsignaturaIdLabel.Name = "AsignaturaIdLabel";
            this.AsignaturaIdLabel.Size = new System.Drawing.Size(107, 20);
            this.AsignaturaIdLabel.TabIndex = 0;
            this.AsignaturaIdLabel.Text = "Asignatura Id";
            // 
            // NombreLabel
            // 
            this.NombreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(26, 174);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(68, 20);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre";
            // 
            // CreditosLabel
            // 
            this.CreditosLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreditosLabel.AutoSize = true;
            this.CreditosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditosLabel.Location = new System.Drawing.Point(26, 235);
            this.CreditosLabel.Name = "CreditosLabel";
            this.CreditosLabel.Size = new System.Drawing.Size(72, 20);
            this.CreditosLabel.TabIndex = 2;
            this.CreditosLabel.Text = "Creditos";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.Location = new System.Drawing.Point(26, 296);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(99, 20);
            this.DescripcionLabel.TabIndex = 3;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // AsignaturaIdNumericUpDown
            // 
            this.AsignaturaIdNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AsignaturaIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsignaturaIdNumericUpDown.Location = new System.Drawing.Point(179, 36);
            this.AsignaturaIdNumericUpDown.Name = "AsignaturaIdNumericUpDown";
            this.AsignaturaIdNumericUpDown.Size = new System.Drawing.Size(55, 24);
            this.AsignaturaIdNumericUpDown.TabIndex = 4;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NombreTextBox.Location = new System.Drawing.Point(179, 174);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(312, 22);
            this.NombreTextBox.TabIndex = 5;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            this.NombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTextBox_KeyPress);
            // 
            // DescripcionRichTextBox
            // 
            this.DescripcionRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescripcionRichTextBox.Location = new System.Drawing.Point(179, 296);
            this.DescripcionRichTextBox.Name = "DescripcionRichTextBox";
            this.DescripcionRichTextBox.Size = new System.Drawing.Size(307, 116);
            this.DescripcionRichTextBox.TabIndex = 7;
            this.DescripcionRichTextBox.Text = "";
            this.DescripcionRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionRichTextBox_KeyPress);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.Image = global::Proyecto_Final.Properties.Resources.imgEliminar;
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButton.Location = new System.Drawing.Point(402, 495);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(89, 36);
            this.BorrarButton.TabIndex = 43;
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
            this.GuardarButton.Location = new System.Drawing.Point(218, 495);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(98, 36);
            this.GuardarButton.TabIndex = 42;
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
            this.NuevoButton.Location = new System.Drawing.Point(44, 495);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(89, 36);
            this.NuevoButton.TabIndex = 41;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BuscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButton.Image = global::Proyecto_Final.Properties.Resources.imgBuscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(402, 29);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(89, 36);
            this.BuscarButton.TabIndex = 44;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("MyErrorProvider.Icon")));
            // 
            // CreditosMaskedTextBox
            // 
            this.CreditosMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CreditosMaskedTextBox.Location = new System.Drawing.Point(179, 233);
            this.CreditosMaskedTextBox.Mask = "00";
            this.CreditosMaskedTextBox.Name = "CreditosMaskedTextBox";
            this.CreditosMaskedTextBox.Size = new System.Drawing.Size(312, 22);
            this.CreditosMaskedTextBox.TabIndex = 49;
            // 
            // ProfesorLabel
            // 
            this.ProfesorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProfesorLabel.AutoSize = true;
            this.ProfesorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesorLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ProfesorLabel.Location = new System.Drawing.Point(243, 108);
            this.ProfesorLabel.Name = "ProfesorLabel";
            this.ProfesorLabel.Size = new System.Drawing.Size(73, 20);
            this.ProfesorLabel.TabIndex = 50;
            this.ProfesorLabel.Text = "Profesor";
            // 
            // ProfesorIdLabel
            // 
            this.ProfesorIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfesorIdLabel.AutoSize = true;
            this.ProfesorIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesorIdLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ProfesorIdLabel.Location = new System.Drawing.Point(26, 105);
            this.ProfesorIdLabel.Name = "ProfesorIdLabel";
            this.ProfesorIdLabel.Size = new System.Drawing.Size(91, 20);
            this.ProfesorIdLabel.TabIndex = 52;
            this.ProfesorIdLabel.Text = "Profesor Id";
            // 
            // ProfesorIdNumericUpDown
            // 
            this.ProfesorIdNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfesorIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesorIdNumericUpDown.Location = new System.Drawing.Point(179, 104);
            this.ProfesorIdNumericUpDown.Name = "ProfesorIdNumericUpDown";
            this.ProfesorIdNumericUpDown.Size = new System.Drawing.Size(55, 24);
            this.ProfesorIdNumericUpDown.TabIndex = 53;
            this.ProfesorIdNumericUpDown.ValueChanged += new System.EventHandler(this.ProfesorIdNumericUpDown_ValueChanged);
            // 
            // ProfesorTextBox
            // 
            this.ProfesorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProfesorTextBox.Location = new System.Drawing.Point(342, 108);
            this.ProfesorTextBox.Name = "ProfesorTextBox";
            this.ProfesorTextBox.ReadOnly = true;
            this.ProfesorTextBox.Size = new System.Drawing.Size(149, 22);
            this.ProfesorTextBox.TabIndex = 54;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioTextBox.Location = new System.Drawing.Point(195, 437);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(173, 22);
            this.UsuarioTextBox.TabIndex = 56;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(123, 437);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLabel.TabIndex = 55;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // rAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 567);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.ProfesorTextBox);
            this.Controls.Add(this.ProfesorIdNumericUpDown);
            this.Controls.Add(this.ProfesorIdLabel);
            this.Controls.Add(this.ProfesorLabel);
            this.Controls.Add(this.CreditosMaskedTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.DescripcionRichTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.AsignaturaIdNumericUpDown);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.CreditosLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.AsignaturaIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rAsignaturas";
            this.Text = "Registro de asignaturas";
            this.Load += new System.EventHandler(this.RAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesorIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AsignaturaIdLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label CreditosLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.NumericUpDown AsignaturaIdNumericUpDown;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.RichTextBox DescripcionRichTextBox;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.MaskedTextBox CreditosMaskedTextBox;
        private System.Windows.Forms.TextBox ProfesorTextBox;
        private System.Windows.Forms.NumericUpDown ProfesorIdNumericUpDown;
        private System.Windows.Forms.Label ProfesorIdLabel;
        private System.Windows.Forms.Label ProfesorLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label UsuarioLabel;
    }
}