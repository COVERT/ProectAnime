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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (user.users.type == "agent") buttonAgent.Enabled = false ;
        }

        private void buttonAgent_Click(object sender, EventArgs e)
        {
            Form FormAgent = new Agent();
            FormAgent.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Form FormClient = new Client();
            FormClient.Show();
        }

        private void buttonProvader_Click(object sender, EventArgs e)
        {
            Form FormProvider = new Provider();
            FormProvider.Show();
        }

        private void buttonAssortiment_Click(object sender, EventArgs e)
        {
            Form FormSdelka = new Sdelka();
            FormSdelka.Show();
        }
    }
}
