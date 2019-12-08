using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GUI_Optica_app_net_framework.model;

namespace GUI_Optica_app_net_framework
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Login_Load(object sender, EventArgs e)
        {
            textbox_pass.Text = "Contraseña";
            textBox_user.Text = "Usuario";
            textbox_pass.ForeColor = Color.Gray;
            textBox_user.ForeColor = Color.Gray;
        }

        private void textBox_user_Leave(object sender, EventArgs e)
        {
            if (textBox_user.Text == "")
            {
                textBox_user.Text = "Usuario";
                textBox_user.ForeColor = Color.Gray;
            }
        }

        private void textbox_pass_Leave(object sender, EventArgs e)
        {
            textbox_pass.Text = "Contraseña";
            textbox_pass.ForeColor = Color.Gray;
            textbox_pass.UseSystemPasswordChar = false;
        }

        private void textBox_user_Enter(object sender, EventArgs e)
        {
            if (textBox_user.Text == "Usuario")
            {
                textBox_user.Text = "";
            }
            textBox_user.ForeColor = Color.Black;
        }

        private void textbox_pass_Enter(object sender, EventArgs e)
        {
            textbox_pass.Text = "";
            textbox_pass.ForeColor = Color.Black;
            textbox_pass.UseSystemPasswordChar = true;
        }

        private void button1_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textbox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                ///programar entrada condicional por controller component
                new Main_view(new User(null, null, 0), this).Show();
                this.Hide();
            }
        }
    }
}
