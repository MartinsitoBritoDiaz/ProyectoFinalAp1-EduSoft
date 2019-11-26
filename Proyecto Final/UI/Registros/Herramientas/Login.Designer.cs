namespace Proyecto_Final.UI.Registros
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.ContraseñaLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VisualizarPictureBox = new System.Windows.Forms.PictureBox();
            this.OlvidoLabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.Location = new System.Drawing.Point(37, 112);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(67, 20);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // ContraseñaLabel
            // 
            this.ContraseñaLabel.AutoSize = true;
            this.ContraseñaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaLabel.Location = new System.Drawing.Point(37, 153);
            this.ContraseñaLabel.Name = "ContraseñaLabel";
            this.ContraseñaLabel.Size = new System.Drawing.Size(95, 20);
            this.ContraseñaLabel.TabIndex = 1;
            this.ContraseñaLabel.Text = "Contraseña";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(151, 39);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(95, 36);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(157, 110);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(249, 22);
            this.UsuarioTextBox.TabIndex = 3;
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContraseñaTextBox.Location = new System.Drawing.Point(157, 153);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(205, 22);
            this.ContraseñaTextBox.TabIndex = 4;
            this.ContraseñaTextBox.UseSystemPasswordChar = true;
            // 
            // IngresarButton
            // 
            this.IngresarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.IngresarButton.Location = new System.Drawing.Point(173, 212);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(96, 37);
            this.IngresarButton.TabIndex = 5;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // VisualizarPictureBox
            // 
            this.VisualizarPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VisualizarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VisualizarPictureBox.Image")));
            this.VisualizarPictureBox.Location = new System.Drawing.Point(368, 138);
            this.VisualizarPictureBox.Name = "VisualizarPictureBox";
            this.VisualizarPictureBox.Size = new System.Drawing.Size(38, 52);
            this.VisualizarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VisualizarPictureBox.TabIndex = 7;
            this.VisualizarPictureBox.TabStop = false;
            this.VisualizarPictureBox.Click += new System.EventHandler(this.VisualizarPictureBox_Click);
            // 
            // OlvidoLabel
            // 
            this.OlvidoLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OlvidoLabel.AutoSize = true;
            this.OlvidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OlvidoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.OlvidoLabel.Location = new System.Drawing.Point(133, 276);
            this.OlvidoLabel.Name = "OlvidoLabel";
            this.OlvidoLabel.Size = new System.Drawing.Size(172, 20);
            this.OlvidoLabel.TabIndex = 8;
            this.OlvidoLabel.Text = "¿Olvidaste tu cuenta?";
            this.OlvidoLabel.Click += new System.EventHandler(this.OlvidoLabel_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 317);
            this.Controls.Add(this.OlvidoLabel);
            this.Controls.Add(this.VisualizarPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.ContraseñaLabel);
            this.Controls.Add(this.UsuarioLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label ContraseñaLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox VisualizarPictureBox;
        private System.Windows.Forms.Label OlvidoLabel;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}