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
    public partial class PrevisionForm : Form
    {
        public PrevisionForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string forecastName = textBox1.Text;
            string forecastPercent = textBox2.Text;

            if( forecastName == "" || forecastPercent == "")
            {
                MessageBox.Show("Los campos no deben estar vacios", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            } else
            {
                float percentForecast = float.Parse(forecastPercent);
                Prevision insertarPrevision = new Prevision(forecastName, percentForecast);
                int filas = insertarPrevision.AgregarIsapre();

                if (filas == 1)
                {
                    MessageBox.Show("Registro ingresado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Error al insertar registro", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dataGridRefresh();
            }
        }

        private void dataGridViewIsapre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void PrevisionForm_Load(object sender, EventArgs e)
        {
            dataGridRefresh();
        }

        private void dataGridRefresh()
        {
            dataGridViewIsapre.DataSource = Prevision.MostrarTodasIsapres();
        }

        private void dataGridViewIsapre_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridViewIsapre.CurrentRow.Cells[1].Value);
            textBox2.Text = Convert.ToString(dataGridViewIsapre.CurrentRow.Cells[2].Value);
        }
    }
}
