namespace FORMS
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.Contra_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Mostrar_button = new System.Windows.Forms.Button();
            this.Cancelar_Button = new System.Windows.Forms.Button();
            this.Ingresar_button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Location = new System.Drawing.Point(111, 42);
            this.Usuario_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(234, 26);
            this.Usuario_textBox.TabIndex = 1;
            // 
            // Contra_textBox
            // 
            this.Contra_textBox.Location = new System.Drawing.Point(111, 115);
            this.Contra_textBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Contra_textBox.Name = "Contra_textBox";
            this.Contra_textBox.Size = new System.Drawing.Size(234, 26);
            this.Contra_textBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // Mostrar_button
            // 
            this.Mostrar_button.Image = global::FORMS.Properties.Resources.ver;
            this.Mostrar_button.Location = new System.Drawing.Point(353, 113);
            this.Mostrar_button.Margin = new System.Windows.Forms.Padding(4);
            this.Mostrar_button.Name = "Mostrar_button";
            this.Mostrar_button.Size = new System.Drawing.Size(39, 28);
            this.Mostrar_button.TabIndex = 6;
            this.Mostrar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Mostrar_button.UseVisualStyleBackColor = true;
            this.Mostrar_button.Click += new System.EventHandler(this.Mostrar_button_Click);
            // 
            // Cancelar_Button
            // 
            this.Cancelar_Button.Image = global::FORMS.Properties.Resources.boton_x;
            this.Cancelar_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar_Button.Location = new System.Drawing.Point(43, 168);
            this.Cancelar_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar_Button.Name = "Cancelar_Button";
            this.Cancelar_Button.Size = new System.Drawing.Size(144, 51);
            this.Cancelar_Button.TabIndex = 5;
            this.Cancelar_Button.Text = "CANCELAR";
            this.Cancelar_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancelar_Button.UseVisualStyleBackColor = true;
            // 
            // Ingresar_button
            // 
            this.Ingresar_button.Image = global::FORMS.Properties.Resources.cheque;
            this.Ingresar_button.Location = new System.Drawing.Point(274, 166);
            this.Ingresar_button.Margin = new System.Windows.Forms.Padding(4);
            this.Ingresar_button.Name = "Ingresar_button";
            this.Ingresar_button.Size = new System.Drawing.Size(144, 51);
            this.Ingresar_button.TabIndex = 2;
            this.Ingresar_button.Text = "INGRESAR";
            this.Ingresar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ingresar_button.UseVisualStyleBackColor = true;
            this.Ingresar_button.Click += new System.EventHandler(this.Ingresar_button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 230);
            this.Controls.Add(this.Mostrar_button);
            this.Controls.Add(this.Cancelar_Button);
            this.Controls.Add(this.Contra_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ingresar_button);
            this.Controls.Add(this.Usuario_textBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.Button Ingresar_button;
        private System.Windows.Forms.TextBox Contra_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancelar_Button;
        private System.Windows.Forms.Button Mostrar_button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

