namespace Proyecto_Final.UI.Registros
{
    partial class rInscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rInscripciones));
            this.InscripcionIdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EstudianteGroupBox = new System.Windows.Forms.GroupBox();
            this.SeleccionarEstudiantesbutton = new System.Windows.Forms.Button();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EstudianteIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EstudianteLabel = new System.Windows.Forms.Label();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AgregarEstudiantesButton = new System.Windows.Forms.Button();
            this.EstudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.MatriculaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadEstudiantesLabel = new System.Windows.Forms.Label();
            this.InscripcionIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SemestreIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AsignaturasLabel = new System.Windows.Forms.Label();
            this.AsignaturasComboBox = new System.Windows.Forms.ComboBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EstudianteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemestreIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // InscripcionIdLabel
            // 
            this.InscripcionIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InscripcionIdLabel.AutoSize = true;
            this.InscripcionIdLabel.Location = new System.Drawing.Point(34, 36);
            this.InscripcionIdLabel.Name = "InscripcionIdLabel";
            this.InscripcionIdLabel.Size = new System.Drawing.Size(90, 17);
            this.InscripcionIdLabel.TabIndex = 0;
            this.InscripcionIdLabel.Text = "Inscripción Id";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad estudiantes";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Semestre";
            // 
            // EstudianteGroupBox
            // 
            this.EstudianteGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EstudianteGroupBox.Controls.Add(this.SeleccionarEstudiantesbutton);
            this.EstudianteGroupBox.Controls.Add(this.NombreTextBox);
            this.EstudianteGroupBox.Controls.Add(this.EstudianteIdMaskedTextBox);
            this.EstudianteGroupBox.Controls.Add(this.label4);
            this.EstudianteGroupBox.Controls.Add(this.EstudianteLabel);
            this.EstudianteGroupBox.Controls.Add(this.RemoverButton);
            this.EstudianteGroupBox.Controls.Add(this.AgregarEstudiantesButton);
            this.EstudianteGroupBox.Controls.Add(this.EstudiantesDataGridView);
            this.EstudianteGroupBox.Controls.Add(this.CantidadEstudiantesLabel);
            this.EstudianteGroupBox.Controls.Add(this.label2);
            this.EstudianteGroupBox.Location = new System.Drawing.Point(37, 211);
            this.EstudianteGroupBox.Name = "EstudianteGroupBox";
            this.EstudianteGroupBox.Size = new System.Drawing.Size(442, 389);
            this.EstudianteGroupBox.TabIndex = 9;
            this.EstudianteGroupBox.TabStop = false;
            this.EstudianteGroupBox.Text = "Estudiante";
            // 
            // SeleccionarEstudiantesbutton
            // 
            this.SeleccionarEstudiantesbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SeleccionarEstudiantesbutton.Image = global::Proyecto_Final.Properties.Resources.imgBuscar;
            this.SeleccionarEstudiantesbutton.Location = new System.Drawing.Point(315, 69);
            this.SeleccionarEstudiantesbutton.Name = "SeleccionarEstudiantesbutton";
            this.SeleccionarEstudiantesbutton.Size = new System.Drawing.Size(32, 31);
            this.SeleccionarEstudiantesbutton.TabIndex = 79;
            this.SeleccionarEstudiantesbutton.UseVisualStyleBackColor = true;
            this.SeleccionarEstudiantesbutton.Click += new System.EventHandler(this.SeleccionarEstudiantesbutton_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NombreTextBox.Location = new System.Drawing.Point(129, 76);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.ReadOnly = true;
            this.NombreTextBox.Size = new System.Drawing.Size(180, 22);
            this.NombreTextBox.TabIndex = 78;
            // 
            // EstudianteIdMaskedTextBox
            // 
            this.EstudianteIdMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EstudianteIdMaskedTextBox.Location = new System.Drawing.Point(129, 28);
            this.EstudianteIdMaskedTextBox.Mask = "00000000";
            this.EstudianteIdMaskedTextBox.Name = "EstudianteIdMaskedTextBox";
            this.EstudianteIdMaskedTextBox.Size = new System.Drawing.Size(61, 22);
            this.EstudianteIdMaskedTextBox.TabIndex = 77;
            this.EstudianteIdMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MatriculaMaskedTextBox_MaskInputRejected);
            this.EstudianteIdMaskedTextBox.TextChanged += new System.EventHandler(this.MatriculaMaskedTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Estudiante Id";
            // 
            // EstudianteLabel
            // 
            this.EstudianteLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EstudianteLabel.AutoSize = true;
            this.EstudianteLabel.Location = new System.Drawing.Point(20, 76);
            this.EstudianteLabel.Name = "EstudianteLabel";
            this.EstudianteLabel.Size = new System.Drawing.Size(58, 17);
            this.EstudianteLabel.TabIndex = 75;
            this.EstudianteLabel.Text = "Nombre";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(284, 342);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(120, 30);
            this.RemoverButton.TabIndex = 74;
            this.RemoverButton.Text = "Remover fila";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // AgregarEstudiantesButton
            // 
            this.AgregarEstudiantesButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AgregarEstudiantesButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarEstudiantesButton.Image")));
            this.AgregarEstudiantesButton.Location = new System.Drawing.Point(372, 69);
            this.AgregarEstudiantesButton.Name = "AgregarEstudiantesButton";
            this.AgregarEstudiantesButton.Size = new System.Drawing.Size(32, 31);
            this.AgregarEstudiantesButton.TabIndex = 16;
            this.AgregarEstudiantesButton.UseVisualStyleBackColor = true;
            this.AgregarEstudiantesButton.Click += new System.EventHandler(this.AgregarEstudiantesButton_Click);
            // 
            // EstudiantesDataGridView
            // 
            this.EstudiantesDataGridView.AllowUserToAddRows = false;
            this.EstudiantesDataGridView.AllowUserToDeleteRows = false;
            this.EstudiantesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatriculaColumn,
            this.NombreColumn});
            this.EstudiantesDataGridView.Location = new System.Drawing.Point(23, 123);
            this.EstudiantesDataGridView.Name = "EstudiantesDataGridView";
            this.EstudiantesDataGridView.ReadOnly = true;
            this.EstudiantesDataGridView.RowHeadersWidth = 10;
            this.EstudiantesDataGridView.RowTemplate.Height = 24;
            this.EstudiantesDataGridView.Size = new System.Drawing.Size(381, 213);
            this.EstudiantesDataGridView.TabIndex = 15;
            // 
            // MatriculaColumn
            // 
            this.MatriculaColumn.FillWeight = 10F;
            this.MatriculaColumn.HeaderText = "Matricula";
            this.MatriculaColumn.MinimumWidth = 6;
            this.MatriculaColumn.Name = "MatriculaColumn";
            this.MatriculaColumn.ReadOnly = true;
            this.MatriculaColumn.Width = 125;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.MinimumWidth = 6;
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            this.NombreColumn.Width = 125;
            // 
            // CantidadEstudiantesLabel
            // 
            this.CantidadEstudiantesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CantidadEstudiantesLabel.AutoSize = true;
            this.CantidadEstudiantesLabel.Location = new System.Drawing.Point(200, 352);
            this.CantidadEstudiantesLabel.Name = "CantidadEstudiantesLabel";
            this.CantidadEstudiantesLabel.Size = new System.Drawing.Size(16, 17);
            this.CantidadEstudiantesLabel.TabIndex = 6;
            this.CantidadEstudiantesLabel.Text = "0";
            this.CantidadEstudiantesLabel.Click += new System.EventHandler(this.CantidadEstudiantesLabel_Click);
            // 
            // InscripcionIdNumericUpDown
            // 
            this.InscripcionIdNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.InscripcionIdNumericUpDown.Location = new System.Drawing.Point(139, 34);
            this.InscripcionIdNumericUpDown.Name = "InscripcionIdNumericUpDown";
            this.InscripcionIdNumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.InscripcionIdNumericUpDown.TabIndex = 10;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(296, 38);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(117, 22);
            this.FechaDateTimePicker.TabIndex = 11;
            // 
            // SemestreIdNumericUpDown
            // 
            this.SemestreIdNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SemestreIdNumericUpDown.Location = new System.Drawing.Point(139, 78);
            this.SemestreIdNumericUpDown.Name = "SemestreIdNumericUpDown";
            this.SemestreIdNumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.SemestreIdNumericUpDown.TabIndex = 13;
            this.SemestreIdNumericUpDown.ValueChanged += new System.EventHandler(this.SemestreIdNumericUpDown_ValueChanged);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // AsignaturasLabel
            // 
            this.AsignaturasLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AsignaturasLabel.AutoSize = true;
            this.AsignaturasLabel.Location = new System.Drawing.Point(34, 142);
            this.AsignaturasLabel.Name = "AsignaturasLabel";
            this.AsignaturasLabel.Size = new System.Drawing.Size(83, 17);
            this.AsignaturasLabel.TabIndex = 44;
            this.AsignaturasLabel.Text = "Asignaturas";
            // 
            // AsignaturasComboBox
            // 
            this.AsignaturasComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AsignaturasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AsignaturasComboBox.FormattingEnabled = true;
            this.AsignaturasComboBox.Location = new System.Drawing.Point(140, 139);
            this.AsignaturasComboBox.Name = "AsignaturasComboBox";
            this.AsignaturasComboBox.Size = new System.Drawing.Size(339, 24);
            this.AsignaturasComboBox.TabIndex = 45;
            this.AsignaturasComboBox.SelectedIndexChanged += new System.EventHandler(this.AsignaturasComboBox_SelectedIndexChanged);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioTextBox.Location = new System.Drawing.Point(182, 628);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(164, 22);
            this.UsuarioTextBox.TabIndex = 53;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(92, 628);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLabel.TabIndex = 52;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // BorrarButton
            // 
            this.BorrarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.Image = global::Proyecto_Final.Properties.Resources.imgEliminar;
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButton.Location = new System.Drawing.Point(376, 683);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(103, 36);
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
            this.GuardarButton.Location = new System.Drawing.Point(209, 683);
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
            this.NuevoButton.Location = new System.Drawing.Point(37, 683);
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
            this.BuscarButton.Image = global::Proyecto_Final.Properties.Resources.imgBuscar;
            this.BuscarButton.Location = new System.Drawing.Point(447, 36);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(32, 31);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // rInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 747);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.AsignaturasLabel);
            this.Controls.Add(this.AsignaturasComboBox);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.SemestreIdNumericUpDown);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.InscripcionIdNumericUpDown);
            this.Controls.Add(this.EstudianteGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InscripcionIdLabel);
            this.Name = "rInscripciones";
            this.Text = "Registro de inscripciones";
            this.Load += new System.EventHandler(this.RInscripcion_Load);
            this.EstudianteGroupBox.ResumeLayout(false);
            this.EstudianteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SemestreIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InscripcionIdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox EstudianteGroupBox;
        private System.Windows.Forms.Label CantidadEstudiantesLabel;
        private System.Windows.Forms.DataGridView EstudiantesDataGridView;
        private System.Windows.Forms.NumericUpDown InscripcionIdNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown SemestreIdNumericUpDown;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button AgregarEstudiantesButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label EstudianteLabel;
        private System.Windows.Forms.Button SeleccionarEstudiantesbutton;
        private System.Windows.Forms.MaskedTextBox EstudianteIdMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label AsignaturasLabel;
        private System.Windows.Forms.ComboBox AsignaturasComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatriculaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label UsuarioLabel;
    }
}