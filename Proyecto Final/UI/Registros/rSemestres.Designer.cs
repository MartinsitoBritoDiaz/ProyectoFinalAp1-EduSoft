namespace Proyecto_Final.UI.Registros
{
    partial class rSemestres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rSemestres));
            this.SemestreIdLabel = new System.Windows.Forms.Label();
            this.FechaInicioLabel = new System.Windows.Forms.Label();
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaFinalLabel = new System.Windows.Forms.Label();
            this.FechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaFinalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SemestreIdLabel
            // 
            this.SemestreIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SemestreIdLabel.AutoSize = true;
            this.SemestreIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemestreIdLabel.Location = new System.Drawing.Point(27, 18);
            this.SemestreIdLabel.Name = "SemestreIdLabel";
            this.SemestreIdLabel.Size = new System.Drawing.Size(99, 20);
            this.SemestreIdLabel.TabIndex = 0;
            this.SemestreIdLabel.Text = "Semestre Id";
            // 
            // FechaInicioLabel
            // 
            this.FechaInicioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FechaInicioLabel.AutoSize = true;
            this.FechaInicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicioLabel.Location = new System.Drawing.Point(27, 76);
            this.FechaInicioLabel.Name = "FechaInicioLabel";
            this.FechaInicioLabel.Size = new System.Drawing.Size(99, 20);
            this.FechaInicioLabel.TabIndex = 1;
            this.FechaInicioLabel.Text = "Fecha inicio";
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActivoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivoCheckBox.Location = new System.Drawing.Point(31, 188);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(66, 22);
            this.ActivoCheckBox.TabIndex = 2;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            this.ActivoCheckBox.CheckedChanged += new System.EventHandler(this.ActivoCheckBox_CheckedChanged);
            // 
            // FechaFinalLabel
            // 
            this.FechaFinalLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FechaFinalLabel.AutoSize = true;
            this.FechaFinalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFinalLabel.Location = new System.Drawing.Point(27, 126);
            this.FechaFinalLabel.Name = "FechaFinalLabel";
            this.FechaFinalLabel.Size = new System.Drawing.Size(91, 20);
            this.FechaFinalLabel.TabIndex = 3;
            this.FechaFinalLabel.Text = "Fecha final";
            // 
            // FechaInicioDateTimePicker
            // 
            this.FechaInicioDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FechaInicioDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaInicioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicioDateTimePicker.Location = new System.Drawing.Point(155, 74);
            this.FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker";
            this.FechaInicioDateTimePicker.Size = new System.Drawing.Size(163, 22);
            this.FechaInicioDateTimePicker.TabIndex = 6;
            this.FechaInicioDateTimePicker.ValueChanged += new System.EventHandler(this.FechaInicioDateTimePicker_ValueChanged);
            // 
            // FechaFinalDateTimePicker
            // 
            this.FechaFinalDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FechaFinalDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaFinalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinalDateTimePicker.Location = new System.Drawing.Point(155, 124);
            this.FechaFinalDateTimePicker.Name = "FechaFinalDateTimePicker";
            this.FechaFinalDateTimePicker.Size = new System.Drawing.Size(163, 22);
            this.FechaFinalDateTimePicker.TabIndex = 7;
            this.FechaFinalDateTimePicker.ValueChanged += new System.EventHandler(this.FechaFinalDateTimePicker_ValueChanged);
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IdNumericUpDown.Location = new System.Drawing.Point(155, 18);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(64, 22);
            this.IdNumericUpDown.TabIndex = 8;
            // 
            // BorrarButton
            // 
            this.BorrarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.Image = global::Proyecto_Final.Properties.Resources.imgEliminar;
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButton.Location = new System.Drawing.Point(246, 296);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(77, 36);
            this.BorrarButton.TabIndex = 20;
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
            this.GuardarButton.Location = new System.Drawing.Point(133, 296);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(94, 36);
            this.GuardarButton.TabIndex = 21;
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
            this.NuevoButton.Location = new System.Drawing.Point(31, 296);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(83, 36);
            this.NuevoButton.TabIndex = 22;
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
            this.BuscarButton.Location = new System.Drawing.Point(285, 11);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(33, 36);
            this.BuscarButton.TabIndex = 23;
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UsuarioTextBox.Location = new System.Drawing.Point(155, 236);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(163, 22);
            this.UsuarioTextBox.TabIndex = 53;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(28, 236);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLabel.TabIndex = 52;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // rSemestres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 363);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.FechaFinalDateTimePicker);
            this.Controls.Add(this.FechaInicioDateTimePicker);
            this.Controls.Add(this.FechaFinalLabel);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.FechaInicioLabel);
            this.Controls.Add(this.SemestreIdLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rSemestres";
            this.Text = "Registro de semestres";
            this.Load += new System.EventHandler(this.RSemestre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SemestreIdLabel;
        private System.Windows.Forms.Label FechaInicioLabel;
        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.Label FechaFinalLabel;
        private System.Windows.Forms.DateTimePicker FechaInicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaFinalDateTimePicker;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label UsuarioLabel;
    }
}