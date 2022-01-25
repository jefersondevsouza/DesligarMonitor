using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Desligar_Monitor
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MONITORPOWER = 0xF170;
        const int HWND_BROADCAST = 0xFFFF;

        public Form1()
        {
            InitializeComponent();
            this.Desligar();
            //Thread t = new Thread(Desligar);
            //t.Start();
            //Thread.Sleep(3000);
            //t.Suspend();
            this.Close();
        }

        private void Desligar()
        {
            SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, 2);
            //SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, 1);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Desligar();
            this.Close();
        }

    }
}
