using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectSeptica
{
    public partial class Septica : Form
    {
        GameEnvironment playground;
        public Septica()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
             playground = new GameEnvironment();
            playground.Show();
        }
    }
}
