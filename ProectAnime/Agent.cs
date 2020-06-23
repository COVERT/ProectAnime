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
    public partial class Agent : Form
    {
        public Agent()
        {
            InitializeComponent();
            ShowAgent();
        }

        void ShowAgent()
        {
            listViewAgent.Items.Clear();
            foreach (AgentSet agentSet in Program.BD.AgentSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                  {
                    agentSet.Id_agent.ToString(),
                    agentSet.Name,
                    agentSet.mesto,
                    agentSet.Napravlenie ,
                    agentSet.time, 

            }) ;
                item.Tag = agentSet;
                listViewAgent.Items.Add(item);
                
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgentSet agentsSet = new AgentSet();
            agentsSet.Name = textBoxName.Text;
            agentsSet.mesto = textBoxmesto.Text;
            agentsSet.Napravlenie = textBoxNapravlenie.Text;
            agentsSet.time = textBoxtime.Text;
            Program.BD.AgentSet.Add(agentsSet);
            Program.BD.SaveChanges();
            ShowAgent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                agentSet.Name= textBoxName.Text;
                agentSet.mesto = textBoxmesto.Text;
                agentSet.Napravlenie = textBoxNapravlenie.Text;
                agentSet.time = textBoxtime.Text;
                Program.BD.SaveChanges();
                ShowAgent();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {


                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                    Program.BD.AgentSet.Remove(agentSet);
                    Program.BD.SaveChanges();
                    ShowAgent();
                }
                textBoxName.Text = "";
                textBoxNapravlenie.Text = "";
                textBoxmesto.Text = "";
                textBoxtime.Text = "";
            }
            catch
            {
                MessageBox.Show("не возможно удалить эту запись, эта запись используется!", "ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                textBoxName.Text = agentSet.Name;
                textBoxmesto.Text = agentSet.mesto;
                textBoxNapravlenie.Text = agentSet.Napravlenie;
                textBoxtime.Text = agentSet.time; 


            }
            else
            {
                textBoxName.Text = "";
                textBoxNapravlenie.Text = "";
                textBoxmesto.Text = "";
                textBoxtime.Text = "";


            }
        }
    }
}
