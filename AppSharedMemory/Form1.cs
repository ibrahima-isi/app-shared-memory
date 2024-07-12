using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSharedMemory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            service1Client = new ServiceMetier.Service1Client();
        }
        ServiceMetier.Service1Client service1Client;
        private void Form1_Load(object sender, EventArgs e)
        {
            service1Client.GetData(1); 
        }
    }
}
