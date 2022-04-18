using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GDI.Forms
{
    public partial class ProcessForm : Form
    {
        
        Process processNotepad;
        Process processOpera;
        TreeNode node = new TreeNode();
        
        

        public ProcessForm()
        {
            
            processNotepad = null;
            InitializeComponent();

        }



        private void buttonNotePadStart_Click(object sender, EventArgs e)
        {

            if (processNotepad == null)
            {
                processNotepad = Process.Start("notepad.exe");

            }
            else
            {
                MessageBox.Show("Процесс уже запущен!");
            }







        }

        private void buttonNotePadStop_Click(object sender, EventArgs e)
        {

            if (processNotepad != null)
            {
                processNotepad.Kill();
                processNotepad.Dispose();
                processNotepad = null;
            }

            else
            {
                MessageBox.Show("Процесс не запущен!");
            }

        }

        

        private void buttonNotePadLog_Click(object sender, EventArgs e)
        {
            if (processNotepad == null)
            {
                processNotepad = Process.Start("notepad.exe", Application.StartupPath + "\\log.txt");
            }
            else
            {
                MessageBox.Show("Процесс уже запущен!");
            }
           
        }

        private void Check()
        {
           

            
        }
        

        private void ProcessForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                processNotepad.Kill();
                processNotepad.Dispose();
            }
            catch
            {
                return;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {


            Refresh();
            
           
        }

       

        private void treeViewProcesses_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (MessageBox.Show("Kill?", e.Node.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ((Process)e.Node.Tag)?.Kill();
                    



                }
            }
        }

       
        private void link_1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            processOpera = Process.Start("opera.exe", link_1.Text);
        }

        private void link_2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            processOpera = Process.Start("opera.exe", link_2.Text);
        }

        private void link_3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            processOpera = Process.Start("opera.exe", link_3.Text);
        }

        private void Refresh()
        {
            Process[] processes = Process.GetProcesses();
            /* foreach (Process process in processes.OrderBy(p => p.ProcessName))
             {
                 TreeNode node = new TreeNode();
                 node.Text = process.ProcessName;
                 treeViewProcesses.Nodes.Add(node);
             }*/
            foreach (var grp in processes.GroupBy(p => p.ProcessName, (n, g) => new { Name = n, Processes = g.ToList() }).OrderBy(grp => grp.Name))
            {
                
                node.Text = grp.Name + " " + grp.Processes.Count;
                foreach (var proc in grp.Processes)
                {
                    TreeNode subNode = new TreeNode();
                    subNode.Text = $"Proc #{proc.Id} ({proc.Threads.Count})";
                    foreach (ProcessThread thread in proc.Threads)
                    {
                        subNode.Nodes.Add(new TreeNode("Thread #" + thread.Id));
                    }
                    subNode.Tag = proc;
                    node.Nodes.Add(subNode);

                }
                treeViewProcesses.Nodes.Add(node);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
