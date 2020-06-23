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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            ShowClient();
        }

        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientSet clientSet in Program.BD.ClientSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                  {
                    Convert.ToString(clientSet.Id_client),
                   clientSet.Name,
                    clientSet.Last_Name,
                    Convert.ToString(clientSet.Phone)
                  });
                item.Tag = clientSet;
                listViewClient.Items.Add(item);

            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {          
                ClientSet clientSet = new ClientSet();
                clientSet.Name = textBoxName.Text;
                clientSet.Last_Name = textBoxLastName.Text;
                clientSet.Phone = Convert.ToInt32(textBoxPhone.Text);
                Program.BD.ClientSet.Add(clientSet);
                Program.BD.SaveChanges();
                ShowClient();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
           
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                ClientSet clientSet = listViewClient.SelectedItems[0].Tag as ClientSet;
                textBoxName.Text=clientSet.Name;
                textBoxLastName.Text=clientSet.Last_Name;
                textBoxPhone.Text= Convert.ToString(clientSet.Phone);


            }
            else
            {
                textBoxName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";


            }
        }
    }
}
