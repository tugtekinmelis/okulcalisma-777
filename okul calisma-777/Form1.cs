using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okul_calisma_777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkleForm_Click(object sender, EventArgs e)
        {
            OgrenciEkleForm ogrenciEkleForm = new OgrenciEkleForm();
            ogrenciEkleForm.ShowDialog();
        }

        private void btnOgrenciListeleForm_Click(object sender, EventArgs e)
        {
            TumOgrencilerForm tumOgrencilerForm = new TumOgrencilerForm();
            tumOgrencilerForm.ShowDialog();
        }
    }
}
