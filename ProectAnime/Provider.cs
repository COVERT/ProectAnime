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
    public partial class Provider : Form
    {
        public Provider()
        {
            InitializeComponent();
            ShowProvider();
        }
        void ShowProvider()
        {
            listViewProvider.Items.Clear();
            foreach (ProviderSet providerSet in Program.BD.ProviderSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                  {
                    Convert.ToString(providerSet.ID_provider),
                    providerSet.Name_of_company,
                    providerSet.Address,
                    Convert.ToString(providerSet.Score),
                    providerSet.Phone,
                    providerSet.Email
                  }) ;
                item.Tag = providerSet;
                listViewProvider.Items.Add(item);

            }
            listViewProvider.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
            
            private void buttonAdd_Click(object sender, EventArgs e)
            {
            ProviderSet providerSet = new ProviderSet();
            providerSet.Name_of_company= textBoxNamecompany.Text;
            providerSet.Address= textBoxAdress.Text;
            providerSet.Score = Convert.ToInt32(textBoxScore.Text);
            providerSet.Phone= textBoxPhone.Text;
            providerSet.Email= textBoxEmail.Text;
            Program.BD.ProviderSet.Add(providerSet);
            Program.BD.SaveChanges();
            ShowProvider();

            }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                ProviderSet providerSet = listViewProvider.SelectedItems[0].Tag as ProviderSet;
                providerSet.Name_of_company = textBoxNamecompany.Text;
                providerSet.Address = textBoxAdress.Text;
                providerSet.Score = Convert.ToInt32(textBoxScore.Text);
                providerSet.Phone = textBoxPhone.Text;
                providerSet.Email = textBoxEmail.Text;
                Program.BD.SaveChanges();
                ShowProvider();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {


                if (listViewProvider.SelectedItems.Count == 1)
                {
                    ProviderSet providerSet = listViewProvider.SelectedItems[0].Tag as ProviderSet;
                    Program.BD.ProviderSet.Remove(providerSet);
                    Program.BD.SaveChanges();
                    ShowProvider();
                }
                 textBoxNamecompany.Text ="";
                 textBoxAdress.Text= "";
                 textBoxScore.Text= "";
                 textBoxPhone.Text= "";
                 textBoxEmail.Text="";
            }
            catch
            {
                MessageBox.Show("не возможно удалить эту запись, эта запись используется!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProvider.SelectedItems.Count == 1)
            {
                ProviderSet providerSet = listViewProvider.SelectedItems[0].Tag as ProviderSet;
                textBoxNamecompany.Text = providerSet.Name_of_company;
                textBoxAdress.Text =  providerSet.Address;
                textBoxScore.Text = Convert.ToString(providerSet.Score);
                textBoxPhone.Text = Convert.ToString(providerSet.Phone);
                textBoxEmail.Text = providerSet.Email;


            }
            else
            {
                textBoxNamecompany.Text =" ";
                textBoxAdress.Text = " ";
                textBoxScore.Text = " ";
                textBoxPhone.Text = " ";
                textBoxEmail.Text = " ";


            }
        }
    }
}
