using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace OS_lab_1
{
    public partial class Threadscs : Form
    {
        public Threadscs()
        {
            InitializeComponent();
        }
        public Threadscs(Process proc)
        {
            InitializeComponent();
            ShowThreads(proc);
        }
        private void ShowThreads (Process proc)
        {
            lblID.Text = "ID процесса: " + proc.Id.ToString();
            lblName.Text = "Имя процесса: " + proc.ProcessName;
            foreach (ProcessThread thread in proc.Threads)
            {
                dgvThreads.Rows.Add(thread.Id, thread.CurrentPriority);
            } 
        }
    }
}
