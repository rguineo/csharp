using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rem2024
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void posicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargos formMenuCargos = new Cargos();
            formMenuCargos.ShowDialog();    
        }

        private void aFPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afpForm formMenu = new afpForm();
            formMenu.ShowDialog();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void previsionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrevisionForm formMenuPrev = new PrevisionForm();
            formMenuPrev.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados formMenuEmpleados = new Empleados();
            formMenuEmpleados.ShowDialog();
        }
    }
}
