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
using GUI_Optica_app_net_framework.view.sales;

namespace GUI_Optica_app_net_framework
{
    public partial class Main_view : Form
    {
        public Main_view(User loged_user, Login login_form)
        {
            InitializeComponent();
            this.loged_user = loged_user;
            this.login_form = login_form;
            this.generic_form = new Form();

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        ///variable's declaration

        /// <summary>
        /// loged_user, extracted from database, it contains the credentials of loged_user for 
        /// internal software process this object is sent to all called windows
        /// </summary>
        private User loged_user;

        /// <summary>
        /// the form before this one, it is used for invocation of return of unloggin
        /// </summary>
        private Form login_form;

        /// <summary>
        /// generic form for casting diferent views
        /// </summary>
        private Form generic_form;

        /// function's declaration

        /// <summary>
        /// return the loged_user
        /// </summary>  
        public User get_loged_user() {
            return this.loged_user;
        }



        /// <summary>
        /// function for cating generic form to a specific form,
        /// set some atributtes, encapsulate in <from panel_container> and show it
        /// </summary>
        /// <param name="form_to_cast"></param>
        private void cast_form(Form form_to_cast) {
            generic_form?.Close();
            generic_form = form_to_cast;
            generic_form.Dock = DockStyle.Fill;
            generic_form.FormBorderStyle = FormBorderStyle.None;
            generic_form.TopLevel = false;
            panel_container.Controls.Add(generic_form);
            generic_form.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        private void refresh_all() { 

        }

        ///Automtic generated functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_left_menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox_management_Click(object sender, EventArgs e)
        {
            cast_form(new Sales());
        }
    }
}
