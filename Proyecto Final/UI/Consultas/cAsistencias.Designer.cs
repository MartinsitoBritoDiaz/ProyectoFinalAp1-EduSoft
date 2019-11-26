namespace Proyecto_Final.UI.Consultas
{
    partial class cAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cAsistencias));
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.ImprimirReporteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.AllowUserToAddRows = false;
            this.ConsultaDataGridView.AllowUserToDeleteRows = false;
            this.ConsultaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(26, 95);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.ReadOnly = true;
            this.ConsultaDataGridView.RowHeadersWidth = 51;
            this.ConsultaDataGridView.RowTemplate.Height = 24;
            this.ConsultaDataGridView.Size = new System.Drawing.Size(948, 413);
            this.ConsultaDataGridView.TabIndex = 41;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CriterioTextBox.Location = new System.Drawing.Point(512, 55);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(130, 22);
            this.CriterioTextBox.TabIndex = 39;
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioLabel.Location = new System.Drawing.Point(509, 23);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(56, 18);
            this.CriterioLabel.TabIndex = 38;
            this.CriterioLabel.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Profesor",
            "Cantidad total de estudiantes"});
            this.FiltroComboBox.Location = new System.Drawing.Point(358, 55);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(126, 24);
            this.FiltroComboBox.TabIndex = 37;
            this.FiltroComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltroComboBox_SelectedIndexChanged);
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLabel.Location = new System.Drawing.Point(355, 23);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(41, 18);
            this.FiltroLabel.TabIndex = 36;
            this.FiltroLabel.Text = "Filtro";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(178, 55);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(129, 24);
            this.HastaDateTimePicker.TabIndex = 35;
            // 
            // HastaLabel
            // 
            this.HastaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaLabel.Location = new System.Drawing.Point(175, 23);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(47, 18);
            this.HastaLabel.TabIndex = 34;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(22, 55);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(129, 24);
            this.DesdeDateTimePicker.TabIndex = 33;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeLabel.Location = new System.Drawing.Point(19, 23);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(51, 18);
            this.DesdeLabel.TabIndex = 32;
            this.DesdeLabel.Text = "Desde";
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultarButton.Image = global::Proyecto_Final.Properties.Resources.imgBuscar;
            this.ConsultarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarButton.Location = new System.Drawing.Point(680, 44);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(102, 35);
            this.ConsultarButton.TabIndex = 40;
            this.ConsultarButton.Text = "Consultar";
            this.ConsultarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // ImprimirReporteButton
            // 
            this.ImprimirReporteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImprimirReporteButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirReporteButton.Image")));
            this.ImprimirReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImprimirReporteButton.Location = new System.Drawing.Point(826, 40);
            this.ImprimirReporteButton.Name = "ImprimirReporteButton";
            this.ImprimirReporteButton.Size = new System.Drawing.Size(148, 37);
            this.ImprimirReporteButton.TabIndex = 47;
            this.ImprimirReporteButton.Text = "Imprimir reporte";
            this.ImprimirReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImprimirReporteButton.UseVisualStyleBackColor = true;
            this.ImprimirReporteButton.Click += new System.EventHandler(this.ImprimirReporteButton_Click);
            // 
            // cAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 520);
            this.Controls.Add(this.ImprimirReporteButton);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroLabel);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.HastaLabel);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.DesdeLabel);
            this.Name = "cAsistencias";
            this.Text = "Consulta asistencias";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.Button ImprimirReporteButton;
    }
}