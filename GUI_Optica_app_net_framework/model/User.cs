using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Optica_app_net_framework.model
{
    public class User
    {
        private readonly string username;
        private readonly string natural_name;
        private readonly UInt16 id_user;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="username"></param>
        /// <param name="natural_name"></param>
        /// <param name="id_user"></param>
        public User(string username, string natural_name, UInt16 id_user)
        {
            this.username = username;
            this.natural_name = natural_name;
            this.id_user = id_user;
        }

        public string get_username() {
            return this.username;
        }

        public string get_natural_name() {
            return this.natural_name;
        }

        public UInt16 get_id_user() {
            return this.id_user;
        }

        /// <summary>
        /// returns true is this user is an manager or common user
        /// </summary>
        /// <returns></returns>
        public bool is_admin() {
            /// colocar conxion de base de datos para validar que se administrador
            return false;
        }


    }
}
