using BL;
using System;
using System.Windows.Forms;

namespace UrunYonetimiStokTakibi
{
    public partial class MarkaYonetimiFrm : Form
    {
        public MarkaYonetimiFrm()
        {
            InitializeComponent();
        }
        MarkaManager markaManager = new MarkaManager();

        void Yukle()
        {
            dgvMarkalar.DataSource = markaManager.GetAll();
        }
        private void MarkaYonetimiFrm_Load(object sender, EventArgs e)
        {
            Yukle();
        }
    }
}
