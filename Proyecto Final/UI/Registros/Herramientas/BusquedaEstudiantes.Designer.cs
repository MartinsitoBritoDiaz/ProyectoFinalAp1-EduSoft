namespace Proyecto_Final.UI.Registros.Herramientas
{
    partial class hBusquedaEstudiantes
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
            this.EstudiantesDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgregarColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MatriculaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EstudiantesDataGridView
            // 
            this.EstudiantesDataGridView.AllowUserToAddRows = false;
            this.EstudiantesDataGridView.AllowUserToDeleteRows = false;
            this.EstudiantesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgregarColumn,
            this.MatriculaColumn,
            this.NombreColumn});
            this.EstudiantesDataGridView.Location = new System.Drawing.Point(1, 1);
            this.EstudiantesDataGridView.Name = "EstudiantesDataGridView";
            this.EstudiantesDataGridView.RowHeadersWidth = 10;
            this.EstudiantesDataGridView.RowTemplate.Height = 24;
            this.EstudiantesDataGridView.Size = new System.Drawing.Size(552, 525);
            this.EstudiantesDataGridView.TabIndex = 0;
            this.EstudiantesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstudiantesDataGridView_CellContentClick);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AgregarButton.Location = new System.Drawing.Point(238, 542);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(86, 37);
            this.AgregarButton.TabIndex = 1;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // AgregarColumn
            // 
            this.AgregarColumn.HeaderText = "Agregar";
            this.AgregarColumn.MinimumWidth = 6;
            this.AgregarColumn.Name = "AgregarColumn";
            this.AgregarColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AgregarColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AgregarColumn.Width = 125;
            // 
            // MatriculaColumn
            // 
            this.MatriculaColumn.HeaderText = "Id";
            this.MatriculaColumn.MinimumWidth = 6;
            this.MatriculaColumn.Name = "MatriculaColumn";
            this.MatriculaColumn.Width = 125;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.MinimumWidth = 6;
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.Width = 125;
            // 
            // hBusquedaEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 591);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.EstudiantesDataGridView);
            this.Name = "hBusquedaEstudiantes";
            this.Text = "Busqueda Estudiantes";
            this.Load += new System.EventHandler(this.BusquedaEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EstudiantesDataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AgregarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatriculaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
    }
}