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
    public partial class afpForm : Form
    {
        public afpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void afpForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            RefreshGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameAfp = textBox1.Text;
            string percentStr = textBox2.Text;

            if (nameAfp == "" || percentStr == "") {
                MessageBox.Show("Todos los campos deben ser ingresados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                float percentAfp = float.Parse(percentStr);
                Afp insertAfp = new Afp(nameAfp, percentAfp);
                int filas = insertAfp.AgregarAfp();

                if(filas == 1)
                {
                    MessageBox.Show("AFP ingresada con éxito", "Ingreso de AFP", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                }
                RefreshGrid();
            }
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = Afp.MostrarTodasAfp();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
