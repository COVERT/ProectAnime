using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProectAnime
{
    public partial class user : Form
    {
        public struct User
        {
            public string login;
            public string password;
            public string type;
        }
        public static User users = new User();
        public user()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == " " && textBoxPassword.Text == " ")
            {
                MessageBox.Show("введите данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                bool key = false;
                foreach (Users user in Program.BD.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Pssword)
                    {
                        key = true;
                        user.Login = user.Login;
                        user.Pssword = user.Pssword;
                        user.Type = user.Type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("проверьте данные", "пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = " ";
                    textBoxPassword.Text = " ";
                }
                else
                {

                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();

                }
            }
        }
    }
}
