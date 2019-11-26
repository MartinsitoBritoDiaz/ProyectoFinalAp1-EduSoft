namespace Proyecto_Final.UI.Consultas
{
    partial class cProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cProfesores));
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
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
            this.ConsultaDataGridView.Location = new System.Drawing.Point(19, 81);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.ReadOnly = true;
            this.ConsultaDataGridView.RowHeadersWidth = 51;
            this.ConsultaDataGridView.RowTemplate.Height = 24;
            this.ConsultaDataGridView.Size = new System.Drawing.Size(755, 384);
            this.ConsultaDataGridView.TabIndex = 31;
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConsultarButton.Image = global::Proyecto_Final.Properties.Resources.imgBuscar;
            this.ConsultarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarButton.Location = new System.Drawing.Point(462, 28);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(102, 35);
            this.ConsultarButton.TabIndex = 30;
            this.ConsultarButton.Text = "Consultar";
            this.ConsultarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CriterioTextBox.Location = new System.Drawing.Point(191, 41);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(130, 22);
            this.CriterioTextBox.TabIndex = 29;
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioLabel.Location = new System.Drawing.Point(188, 9);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(56, 18);
            this.CriterioLabel.TabIndex = 28;
            this.CriterioLabel.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Nombre",
            "Genero"});
            this.FiltroComboBox.Location = new System.Drawing.Point(19, 41);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(126, 24);
            this.FiltroComboBox.TabIndex = 27;
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLabel.Location = new System.Drawing.Point(16, 9);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(41, 18);
            this.FiltroLabel.TabIndex = 26;
            this.FiltroLabel.Text = "Filtro";
            // 
            // ImprimirReporteButton
            // 
            this.ImprimirReporteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ImprimirReporteButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirReporteButton.Image")));
            this.ImprimirReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImprimirReporteButton.Location = new System.Drawing.Point(626, 26);
            this.ImprimirReporteButton.Name = "ImprimirReporteButton";
            this.ImprimirReporteButton.Size = new System.Drawing.Size(148, 37);
            this.ImprimirReporteButton.TabIndex = 48;
            this.ImprimirReporteButton.Text = "Imprimir reporte";
            this.ImprimirReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImprimirReporteButton.UseVisualStyleBackColor = true;
            this.ImprimirReporteButton.Click += new System.EventHandler(this.ImprimirReporteButton_Click);
            // 
            // cProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.ImprimirReporteButton);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.FiltroLabel);
            this.Name = "cProfesores";
            this.Text = "Consulta profesores";
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
        private System.Windows.Forms.Button ImprimirReporteButton;
    }
}