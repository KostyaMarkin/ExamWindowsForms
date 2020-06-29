using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен.Приветствие
{
    public partial class Приветствие : Form
    {
        public Приветствие()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуй, " + txtEnterName.Text +"!", "Приветсвие", MessageBoxButtons.OK);
        }
    }
}
