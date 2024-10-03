using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_jj
{
    public partial class Form1 : Form
    {
        private Empleado empleado;
       
        public Form1()
        {
            InitializeComponent();
            tpEmpleado.Items.Add("Gerente");
            tpEmpleado.Items.Add("Progrmador");
            tpEmpleado.SelectedIndex = -1;

            tpEmpleado.SelectedIndexChanged += tpEmpleado_SelectedIndexChanged;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salario;
                decimal.TryParse(Salario.Text, out salario);
                if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Salario.Text) || tpEmpleado.SelectedItem == null)
                {
                    MessageBox.Show("Completa todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else if (tpEmpleado.SelectedItem.ToString()== "Gerente") {

                    empleado = new Gerente(Nombre.Text,salario);
                }
                else if (tpEmpleado.SelectedItem.ToString() == "Gerente")
                {

                    empleado = new Programador(Nombre.Text, salario);
                }

                decimal bono = empleado.CalcularBono();
                MessageBox.Show("Bono de "+empleado.nombre+ " es: "+bono);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de salario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
                throw;
            }
        }

        private void tpEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            Nombre.Clear();
            Salario.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (empleado==null) {

                MessageBox.Show("Primero calcule el Bono del empleado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }

            MessageBox.Show(empleado.MostrarInf(), "Informacion del empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
