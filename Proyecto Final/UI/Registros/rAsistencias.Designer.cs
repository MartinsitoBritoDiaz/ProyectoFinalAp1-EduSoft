namespace Proyecto_Final.UI.Registros
{
    partial class rAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rAsistencias));
            this.FechaLabel = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SemestreIdLabel = new System.Windows.Forms.Label();
            this.SemestreIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AsistenciaIdLabel = new System.Windows.Forms.Label();
            this.AsistenciaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProfesorLabel = new System.Windows.Forms.Label();
            this.ListaGroupBox = new System.Windows.Forms.GroupBox();
            this.ExcusasLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgregarEstudiantesButton = new System.Windows.Forms.Button();
            this.Ausenteslabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Presenteslabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AsignaturasComboBox = new System.Windows.Forms.ComboBox();
            this.AsignaturaLabel = new System.Windows.Forms.Label();
            this.EstudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresenteColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AusentesColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExcusasColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProfesorComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.BorrarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SemestreIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdNumericUpDown)).BeginInit();
            this.ListaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaLabel
            // 
            this.FechaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaLabel.Location = new System.Drawing.Point(325, 80);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(55, 20);
            this.FechaLabel.TabIndex = 55;
            this.FechaLabel.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(389, 78);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(104, 22);
            this.FechaDateTimePicker.TabIndex = 54;
            // 
            // SemestreIdLabel
            // 
            this.SemestreIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SemestreIdLabel.AutoSize = true;
            this.SemestreIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemestreIdLabel.Location = new System.Drawing.Point(24, 78);
            this.SemestreIdLabel.Name = "SemestreIdLabel";
            this.SemestreIdLabel.Size = new System.Drawing.Size(99, 20);
            this.SemestreIdLabel.TabIndex = 51;
            this.SemestreIdLabel.Text = "Semestre Id";
            // 
            // SemestreIdNumericUpDown
            // 
            this.SemestreIdNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SemestreIdNumericUpDown.Location = new System.Drawing.Point(143, 78);
            this.SemestreIdNumericUpDown.Name = "SemestreIdNumericUpDown";
            this.SemestreIdNumericUpDown.Size = new System.Drawing.Size(129, 22);
            this.SemestreIdNumericUpDown.TabIndex = 50;
            this.SemestreIdNumericUpDown.ValueChanged += new System.EventHandler(this.SemestreIdNumericUpDown_ValueChanged);
            // 
            // AsistenciaIdLabel
            // 
            this.AsistenciaIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AsistenciaIdLabel.AutoSize = true;
            this.AsistenciaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsistenciaIdLabel.Location = new System.Drawing.Point(24, 25);
            this.AsistenciaIdLabel.Name = "AsistenciaIdLabel";
            this.AsistenciaIdLabel.Size = new System.Drawing.Size(105, 20);
            this.AsistenciaIdLabel.TabIndex = 49;
            this.AsistenciaIdLabel.Text = "Asistencia Id";
            // 
            // AsistenciaIdNumericUpDown
            // 
            this.AsistenciaIdNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AsistenciaIdNumericUpDown.Location = new System.Drawing.Point(144, 23);
            this.AsistenciaIdNumericUpDown.Name = "AsistenciaIdNumericUpDown";
            this.AsistenciaIdNumericUpDown.Size = new System.Drawing.Size(127, 22);
            this.AsistenciaIdNumericUpDown.TabIndex = 48;
            // 
            // ProfesorLabel
            // 
            this.ProfesorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfesorLabel.AutoSize = true;
            this.ProfesorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfesorLabel.Location = new System.Drawing.Point(24, 140);
            this.ProfesorLabel.Name = "ProfesorLabel";
            this.ProfesorLabel.Size = new System.Drawing.Size(73, 20);
            this.ProfesorLabel.TabIndex = 72;
            this.ProfesorLabel.Text = "Profesor";
            // 
            // ListaGroupBox
            // 
            this.ListaGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaGroupBox.Controls.Add(this.ExcusasLabel);
            this.ListaGroupBox.Controls.Add(this.label1);
            this.ListaGroupBox.Controls.Add(this.AgregarEstudiantesButton);
            this.ListaGroupBox.Controls.Add(this.Ausenteslabel);
            this.ListaGroupBox.Controls.Add(this.label10);
            this.ListaGroupBox.Controls.Add(this.Presenteslabel);
            this.ListaGroupBox.Controls.Add(this.label8);
            this.ListaGroupBox.Controls.Add(this.TotalLabel);
            this.ListaGroupBox.Controls.Add(this.label6);
            this.ListaGroupBox.Controls.Add(this.AsignaturasComboBox);
            this.ListaGroupBox.Controls.Add(this.AsignaturaLabel);
            this.ListaGroupBox.Controls.Add(this.EstudiantesDataGridView);
            this.ListaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaGroupBox.Location = new System.Drawing.Point(28, 193);
            this.ListaGroupBox.Name = "ListaGroupBox";
            this.ListaGroupBox.Size = new System.Drawing.Size(490, 425);
            this.ListaGroupBox.TabIndex = 74;
            this.ListaGroupBox.TabStop = false;
            this.ListaGroupBox.Text = "Lista";
            this.ListaGroupBox.TextChanged += new System.EventHandler(this.ListaGroupBox_TextChanged);
            // 
            // ExcusasLabel
            // 
            this.ExcusasLabel.AutoSize = true;
            this.ExcusasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcusasLabel.Location = new System.Drawing.Point(160, 383);
            this.ExcusasLabel.Name = "ExcusasLabel";
            this.ExcusasLabel.Size = new System.Drawing.Size(18, 20);
            this.ExcusasLabel.TabIndex = 84;
            this.ExcusasLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Excusas";
            // 
            // AgregarEstudiantesButton
            // 
            this.AgregarEstudiantesButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AgregarEstudiantesButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarEstudiantesButton.Image")));
            this.AgregarEstudiantesButton.Location = new System.Drawing.Point(433, 21);
            this.AgregarEstudiantesButton.Name = "AgregarEstudiantesButton";
            this.AgregarEstudiantesButton.Size = new System.Drawing.Size(32, 31);
            this.AgregarEstudiantesButton.TabIndex = 82;
            this.AgregarEstudiantesButton.UseVisualStyleBackColor = true;
            this.AgregarEstudiantesButton.Click += new System.EventHandler(this.AgregarEstudiantesButton_Click);
            // 
            // Ausenteslabel
            // 
            this.Ausenteslabel.AutoSize = true;
            this.Ausenteslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ausenteslabel.Location = new System.Drawing.Point(449, 345);
            this.Ausenteslabel.Name = "Ausenteslabel";
            this.Ausenteslabel.Size = new System.Drawing.Size(18, 20);
            this.Ausenteslabel.TabIndex = 79;
            this.Ausenteslabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(297, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 78;
            this.label10.Text = "Ausentes";
            // 
            // Presenteslabel
            // 
            this.Presenteslabel.AutoSize = true;
            this.Presenteslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presenteslabel.Location = new System.Drawing.Point(160, 345);
            this.Presenteslabel.Name = "Presenteslabel";
            this.Presenteslabel.Size = new System.Drawing.Size(18, 20);
            this.Presenteslabel.TabIndex = 77;
            this.Presenteslabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 76;
            this.label8.Text = "Presentes";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(447, 383);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(18, 20);
            this.TotalLabel.TabIndex = 75;
            this.TotalLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 74;
            this.label6.Text = "Total";
            // 
            // AsignaturasComboBox
            // 
            this.AsignaturasComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AsignaturasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AsignaturasComboBox.FormattingEnabled = true;
            this.AsignaturasComboBox.Location = new System.Drawing.Point(116, 29);
            this.AsignaturasComboBox.Name = "AsignaturasComboBox";
            this.AsignaturasComboBox.Size = new System.Drawing.Size(128, 24);
            this.AsignaturasComboBox.TabIndex = 72;
            // 
            // AsignaturaLabel
            // 
            this.AsignaturaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AsignaturaLabel.AutoSize = true;
            this.AsignaturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsignaturaLabel.Location = new System.Drawing.Point(6, 33);
            this.AsignaturaLabel.Name = "AsignaturaLabel";
            this.AsignaturaLabel.Size = new System.Drawing.Size(89, 20);
            this.AsignaturaLabel.TabIndex = 71;
            this.AsignaturaLabel.Text = "Asignatura";
            // 
            // EstudiantesDataGridView
            // 
            this.EstudiantesDataGridView.AllowUserToAddRows = false;
            this.EstudiantesDataGridView.AllowUserToDeleteRows = false;
            this.EstudiantesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.PresenteColumn,
            this.AusentesColumn,
            this.ExcusasColumn});
            this.EstudiantesDataGridView.Location = new System.Drawing.Point(10, 67);
            this.EstudiantesDataGridView.Name = "EstudiantesDataGridView";
            this.EstudiantesDataGridView.RowHeadersWidth = 10;
            this.EstudiantesDataGridView.RowTemplate.Height = 24;
            this.EstudiantesDataGridView.Size = new System.Drawing.Size(457, 256);
            this.EstudiantesDataGridView.TabIndex = 70;
            this.EstudiantesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstudiantesDataGridView_CellClick);
            this.EstudiantesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstudiantesDataGridView_CellContentClick);
            this.EstudiantesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EstudiantesDataGridView_CellMouseClick);
            this.EstudiantesDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstudiantesDataGridView_CellValueChanged);
            this.EstudiantesDataGridView.Click += new System.EventHandler(this.EstudiantesDataGridView_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estudiantes";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 110;
            // 
            // PresenteColumn
            // 
            this.PresenteColumn.HeaderText = "Presencia";
            this.PresenteColumn.MinimumWidth = 6;
            this.PresenteColumn.Name = "PresenteColumn";
            this.PresenteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PresenteColumn.Width = 75;
            // 
            // AusentesColumn
            // 
            this.AusentesColumn.HeaderText = "Ausentes";
            this.AusentesColumn.MinimumWidth = 6;
            this.AusentesColumn.Name = "AusentesColumn";
            this.AusentesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AusentesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AusentesColumn.Width = 75;
            // 
            // ExcusasColumn
            // 
            this.ExcusasColumn.HeaderText = "Excusas";
            this.ExcusasColumn.MinimumWidth = 6;
            this.ExcusasColumn.Name = "ExcusasColumn";
            this.ExcusasColumn.Width = 75;
            // 
            // ProfesorComboBox
            // 
            this.ProfesorComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProfesorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProfesorComboBox.FormattingEnabled = true;
            this.ProfesorComboBox.Location = new System.Drawing.Point(136, 140);
            this.ProfesorComboBox.Name = "ProfesorComboBox";
            this.ProfesorComboBox.Size = new System.Drawing.Size(359, 24);
            this.ProfesorComboBox.TabIndex = 79;
            this.ProfesorComboBox.SelectedIndexChanged += new System.EventHandler(this.ProfesorComboBox_SelectedIndexChanged);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BuscarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarButton.Image = global::Proyecto_Final.Properties.Resources.imgBuscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(404, 18);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(89, 36);
            this.BuscarButton.TabIndex = 78;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // BorrarButton
            // 
            this.BorrarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BorrarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrarButton.Image = global::Proyecto_Final.Properties.Resources.imgEliminar;
            this.BorrarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrarButton.Location = new System.Drawing.Point(429, 686);
            this.BorrarButton.Name = "BorrarButton";
            this.BorrarButton.Size = new System.Drawing.Size(89, 36);
            this.BorrarButton.TabIndex = 77;
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
            this.GuardarButton.Location = new System.Drawing.Point(228, 686);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(98, 36);
            this.GuardarButton.TabIndex = 76;
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
            this.NuevoButton.Location = new System.Drawing.Point(28, 686);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(89, 36);
            this.NuevoButton.TabIndex = 75;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            this.MyErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("MyErrorProvider.Icon")));
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioTextBox.Location = new System.Drawing.Point(207, 642);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(173, 22);
            this.UsuarioTextBox.TabIndex = 81;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(135, 642);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLabel.TabIndex = 80;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // rAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 746);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.ProfesorComboBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.BorrarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.ListaGroupBox);
            this.Controls.Add(this.ProfesorLabel);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.SemestreIdLabel);
            this.Controls.Add(this.SemestreIdNumericUpDown);
            this.Controls.Add(this.AsistenciaIdLabel);
            this.Controls.Add(this.AsistenciaIdNumericUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rAsistencias";
            this.Text = "Registro de asistencias";
            this.Load += new System.EventHandler(this.RAsistencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SemestreIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistenciaIdNumericUpDown)).EndInit();
            this.ListaGroupBox.ResumeLayout(false);
            this.ListaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label SemestreIdLabel;
        private System.Windows.Forms.NumericUpDown SemestreIdNumericUpDown;
        private System.Windows.Forms.Label AsistenciaIdLabel;
        private System.Windows.Forms.NumericUpDown AsistenciaIdNumericUpDown;
        private System.Windows.Forms.Label ProfesorLabel;
        private System.Windows.Forms.GroupBox ListaGroupBox;
        private System.Windows.Forms.Label Ausenteslabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Presenteslabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AsignaturasComboBox;
        private System.Windows.Forms.Label AsignaturaLabel;
        private System.Windows.Forms.DataGridView EstudiantesDataGridView;
        private System.Windows.Forms.Button BorrarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ComboBox ProfesorComboBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button AgregarEstudiantesButton;
        private System.Windows.Forms.Label ExcusasLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PresenteColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AusentesColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExcusasColumn;
    }
}