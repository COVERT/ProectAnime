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
    public partial class Sdelka : Form
    {
        public Sdelka()
        {
            InitializeComponent();
            ShowVis();
            ShowAgent();
            ShowClient();
           
             
        }

        void ShowAgent()
        {
            comboBoxAgent.Items.Clear();
            foreach (AgentSet agentSet in Program.BD.AgentSet)
            {
                string[] item =
                {
                    Convert.ToString(agentSet.Id_agent)
                };
                comboBoxAgent.Items.Add(string.Join(" ", item));

            }
        }
        void ShowClient()
        {
            comboBoxClient.Items.Clear();
            foreach(ClientSet clientSet in Program.BD.ClientSet)
            {
                string[] item =
                {
                    Convert.ToString(clientSet.Id_client)
                };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
       
        void ShowVis()
        {
            listViewSdelka.Items.Clear();
              foreach( sdelkaSet sdelka in Program.BD.sdelkaSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    sdelka.Name_product,
                    Convert.ToString(sdelka.Quantity),
                    Convert.ToString(sdelka.price),
                    sdelka.AgentSet.Name,
                    sdelka.ClientSet.Last_Name,
                    


                });
                item.Tag = sdelka;
                listViewSdelka.Items.Add(item);
            }
        }

        private void Sdelka_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(comboBoxAgent.SelectedItem!=null && comboBoxClient.SelectedItem!= null )
            {
                sdelkaSet sdelka = new sdelkaSet();
                sdelka.Name_product = textBoxNameProduct.Text;
                sdelka.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                sdelka.price = Convert.ToInt32(textBoxprice.Text);
                sdelka.Id__agent= Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                sdelka.Id_client= Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                
                Program.BD.sdelkaSet.Add(sdelka);
                Program.BD.SaveChanges();
                ShowVis();
            }
            else
            {
                 MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if( listViewSdelka.SelectedItems.Count==1)
            {
                sdelkaSet sdelka = listViewSdelka.SelectedItems[0].Tag as sdelkaSet;
                sdelka.Name_product = textBoxNameProduct.Text;
                sdelka.Quantity = Convert.ToInt32(textBoxQuantity.Text); 
                sdelka.price = Convert.ToInt32(textBoxprice.Text);
                sdelka.Id__agent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                sdelka.Id_client = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
               
                Program.BD.SaveChanges();
                ShowVis();
            }
            else
            {
                MessageBox.Show("данные не выбраны", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {


                if (listViewSdelka.SelectedItems.Count == 1)
                {
                    sdelkaSet sdelka = listViewSdelka.SelectedItems[0].Tag as sdelkaSet;
                    Program.BD.sdelkaSet.Remove(sdelka);
                    Program.BD.SaveChanges();
                    ShowVis();
                }
                textBoxNameProduct.Text = "";
                textBoxprice.Text = "";
                textBoxQuantity.Text = "";
                comboBoxAgent.Text = "";
                comboBoxClient.Text = "";
                
            }
            catch
            {
                MessageBox.Show("не возможно удалить эту запись, эта запись используется!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewSdelka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSdelka.SelectedItems.Count == 1)
            {
                sdelkaSet sdelka = listViewSdelka.SelectedItems[0].Tag as sdelkaSet;
                textBoxNameProduct.Text = sdelka.Name_product;
                textBoxprice.Text = Convert.ToString(sdelka.price);
                textBoxQuantity.Text = Convert.ToString(sdelka.Quantity);
                comboBoxAgent.Text = Convert.ToString(sdelka.Id__agent);
                comboBoxClient.Text = Convert.ToString(sdelka.Id_client);
               


            }
            else
            {
                textBoxNameProduct.Text = "";
                textBoxprice.Text = "";
                textBoxQuantity.Text = "";
                comboBoxAgent.Text = "";
                comboBoxClient.Text = "";
               


            }
        }

        private void comboBoxProvider_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
