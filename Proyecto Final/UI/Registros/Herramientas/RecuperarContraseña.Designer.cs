namespace Proyecto_Final.UI.Registros.Herramientas
{
    partial class RecuperarContraseña
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
            this.RecuperarButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecuperarButton
            // 
            this.RecuperarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RecuperarButton.Location = new System.Drawing.Point(163, 264);
            this.RecuperarButton.Name = "RecuperarButton";
            this.RecuperarButton.Size = new System.Drawing.Size(96, 37);
            this.RecuperarButton.TabIndex = 13;
            this.RecuperarButton.Text = "Recuperar";
            this.RecuperarButton.UseVisualStyleBackColor = true;
            this.RecuperarButton.Click += new System.EventHandler(this.RecuperarButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EmailTextBox.Location = new System.Drawing.Point(143, 122);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(249, 22);
            this.EmailTextBox.TabIndex = 11;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(67, 36);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(289, 32);
            this.LoginLabel.TabIndex = 10;
            this.LoginLabel.Text = "Recuperar la cuenta";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(42, 124);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.EmailLabel.TabIndex = 8;
            this.EmailLabel.Text = "Email";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 60);
            this.label1.TabIndex = 14;
            this.label1.Text = "Introduzca el correo electronico de \r\nsu cuenta y se le enviara un correo \r\ncon s" +
    "u usuario y su contraseña.";
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecuperarButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.EmailLabel);
            this.Name = "RecuperarContraseña";
            this.Text = "Recuperar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RecuperarButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label1;
    }
}