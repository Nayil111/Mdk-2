using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace OS_lab_1
{
    public partial class Form1 : Form
    {
        private object lblCount;
        private object Text;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowProcesses();
        }
        private void ShowProcesses()
        {
            foreach (Process process in Process.GetProcesses())
            {
                AddProcess(process);
            }
            lblCount.Text = "Количество процессов: " + dgvProcess.Rows.Count.ToString();
        }
        private void AddProcess(Process process)
        {
            String[] array = new String[6];
            array[0] = process.Id.ToString();
            array[1] = process.ProcessName;
            array[2] = process.VirtualMemorySize64.ToString();
            array[3] = GetProcessUser(process);
            array[4] = process.BasePriority.ToString();
            array[5] = process.Threads.Count.ToString();
            dgvProcess.Rows.Add(array);
        }
        private void dgvProcess_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvProcess.Rows[index];
            Process p = Process.GetProcessById(Convert.ToInt32(row.Cells[0].Value));
            if (p.Threads.Count <= 0)
            {
                MessageBox.Show("У данного процесса нет потоков");
                return;
            }
            lblCount.Text = p.ToString();
            Threadscs form = new Threadscs(p);
            form.Show();
        }
        private static string GetProcessUser(Process process)
        {
            IntPtr processHandle = IntPtr.Zero;
            try
            {
                OpenProcessToken(process.Handle, 8, out processHandle);
                WindowsIdentity wi = new WindowsIdentity(processHandle);
                string user = wi.Name;
                return user.Contains(@"\") ? user.Substring(user.IndexOf(@"\", StringComparison.Ordinal) + 1) : user;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (processHandle != IntPtr.Zero)
                {
                    CloseHandle(processHandle);
                }
            }
        }
        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr processHandle, uint desiredAccess, out IntPtr tokenHandle);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvProcess.Rows.Clear();
            ShowProcesses();
        }

        private void dgvProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
