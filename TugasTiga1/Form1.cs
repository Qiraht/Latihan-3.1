using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class TugasTiga1 : Form
    {
        public TugasTiga1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            lblNim.Text = "NIM \t: 18.11.2350";
            lblNama.Text = "Nama \t: Thariq Aulia Akbar";
            lblKelas.Text = "Kelas \t: 18-S1IF-08 ";
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            lblNim.Text = "NIM \t: ";
            lblNama.Text = "Nama \t: ";
            lblKelas.Text = "Kelas \t: ";
        }
    }
}
