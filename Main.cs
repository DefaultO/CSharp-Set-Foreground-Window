using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp_Set_Foreground_Window
{
    public partial class Main : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        // When you don't want the ProcessId, use this overload and pass IntPtr.Zero for the second parameter
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public Main()
        {
            InitializeComponent();
        }

        private void btn_putWindowToForeground_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = FindWindow(null, this.txtbx_windowTitle.Text.ToString());
            // int processID = 0;
            // processID = (int)GetWindowThreadProcessId(hWnd, IntPtr.Zero);
            // Console.WriteLine($"Window with the PID:{processID} has got focus now.");
            SetForegroundWindow(hWnd);
        }
    }
}
