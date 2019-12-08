namespace GUI_Optica_app_net_framework
{
    partial class Login
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
            this.button1_exit = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textbox_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_exit
            // 
            this.button1_exit.FlatAppearance.BorderSize = 0;
            this.button1_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_exit.ForeColor = System.Drawing.Color.Gray;
            this.button1_exit.Location = new System.Drawing.Point(277, 4);
            this.button1_exit.Name = "button1_exit";
            this.button1_exit.Size = new System.Drawing.Size(45, 45);
            this.button1_exit.TabIndex = 0;
            this.button1_exit.Text = "X";
            this.button1_exit.UseVisualStyleBackColor = true;
            this.button1_exit.Click += new System.EventHandler(this.button1_exit_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.Gray;
            this.button_minimize.Location = new System.Drawing.Point(226, 4);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(45, 45);
            this.button_minimize.TabIndex = 1;
            this.button_minimize.Text = "-";
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.BackColor = System.Drawing.Color.White;
            this.textBox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(61, 286);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(208, 24);
            this.textBox_user.TabIndex = 2;
            this.textBox_user.Enter += new System.EventHandler(this.textBox_user_Enter);
            this.textBox_user.Leave += new System.EventHandler(this.textBox_user_Leave);
            // 
            // textbox_pass
            // 
            this.textbox_pass.BackColor = System.Drawing.Color.White;
            this.textbox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_pass.Location = new System.Drawing.Point(61, 343);
            this.textbox_pass.Name = "textbox_pass";
            this.textbox_pass.Size = new System.Drawing.Size(208, 24);
            this.textbox_pass.TabIndex = 3;
            this.textbox_pass.Enter += new System.EventHandler(this.textbox_pass_Enter);
            this.textbox_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_pass_KeyPress);
            this.textbox_pass.Leave += new System.EventHandler(this.textbox_pass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(59, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "_____________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(59, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "_____________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(49, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 64);
            this.label4.TabIndex = 7;
            this.label4.Text = " Nombre Optica \r\n******************";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_pass);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button1_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_exit;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textbox_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

