﻿using System;
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
    public partial class Assortment : Form
    {
        public Assortment()
        {
            //comboBoxType.SelectedIndex = 0;
            InitializeComponent();
            ShowAssort();
            ShowProvider();
        }
        void ShowProvider()
        {
           
            
                //очистка
                comboBoxProvider.Items.Clear();
                foreach (ProviderSet providerSet in Program.BD.ProviderSet)
                {
                    string[] item =
                    {
                    providerSet.Name_of_company
                };
                comboBoxProvider.Items.Add(string.Join(" ", item));

                }
        }
        void ShowAssort()
        {
            listViewBook.Items.Clear();
            listViewFigurka.Items.Clear();
            listViewMaska.Items.Clear();
            foreach( AssortmentSet assortment in Program.BD.AssortmentSet)
            {
                if( assortment.Type==0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        assortment.Name_product,
                        Convert.ToString(assortment.Quantity),
                        Convert.ToString(assortment.price)

                    });
                    item.Tag = assortment;
                    listViewBook.Items.Add(item);
                }
                else if (assortment.Type==1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                   {
                        assortment.Name_product,
                        Convert.ToString(assortment.Quantity),
                        Convert.ToString(assortment.price),
                        Convert.ToString(assortment.razmer_V),
                        Convert.ToString( assortment.razmer_H)

                   });
                    item.Tag = assortment;
                    listViewFigurka.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                   {
                        assortment.Name_product,
                        Convert.ToString(assortment.Quantity),
                        Convert.ToString(assortment.price),
                        assortment.color

                   });
                    item.Tag = assortment;
                    listViewMaska.Items.Add(item);
                }
            }
            listViewBook.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewFigurka.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewMaska.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
         
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AssortmentSet assortment = new AssortmentSet();
            assortment.Name_product = textBoxName.Text;
            assortment.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            assortment.price = Convert.ToInt32(textBoxPrice.Text);
           
            if(comboBoxType.SelectedIndex==1)
            {
                assortment.Type = 1;
                assortment.razmer_H = Convert.ToInt32(textBoxRazmerH.Text);
                assortment.razmer_V = Convert.ToInt32(textBoxRazmerV.Text);


            }
            
            else
            {
                assortment.Type = 2;
                assortment.color = textBoxCloor.Text;
            }
            Program.BD.AssortmentSet.Add(assortment);
            Program.BD.SaveChanges();
            ShowAssort();
            ShowProvider();

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedIndex==0)
            {
                listViewBook.Visible = true;
                listViewFigurka.Visible = false;
                listViewMaska.Visible = false;
                textBoxName.Visible = true;
                labelName.Visible = true;
                textBoxQuantity.Visible = true;
                labelQuantity.Visible = true;
                textBoxPrice.Visible = true;
                labelprice.Visible = true;
                textBoxRazmerH.Visible = false;
                labelrazmerH.Visible = false;
                textBoxRazmerV.Visible = false;
                labelrazmerV.Visible = false;
                textBoxCloor.Visible = false;
                labelCloor.Visible = false;
            }
            else if(comboBoxType.SelectedIndex==1)
            {
                listViewBook.Visible = false;
                listViewFigurka.Visible = true;
                listViewMaska.Visible = false;
                textBoxName.Visible = true;
                labelName.Visible = true;
                textBoxQuantity.Visible = true;
                labelQuantity.Visible = true;
                textBoxPrice.Visible = true;
                labelprice.Visible = true;
                textBoxRazmerH.Visible = true;
                labelrazmerH.Visible = true;
                textBoxRazmerV.Visible = true;
                labelrazmerV.Visible = true;
                textBoxCloor.Visible = false;
                labelCloor.Visible = false;
            }
            else if(comboBoxType.SelectedIndex==2)
            {
                listViewBook.Visible = false;
                listViewFigurka.Visible = false;
                listViewMaska.Visible = true;
                textBoxName.Visible = true;
                labelName.Visible = true;
                textBoxQuantity.Visible = true;
                labelQuantity.Visible = true;
                textBoxPrice.Visible = true;
                labelprice.Visible = true;
                textBoxRazmerH.Visible = false;
                labelrazmerH.Visible = false;
                textBoxRazmerV.Visible = false;
                labelrazmerV.Visible = false;
                textBoxCloor.Visible = true;
                labelCloor.Visible = true;
            }
        }
    }
}