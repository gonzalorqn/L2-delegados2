using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace TestWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (TipoManejador item in Enum.GetValues(typeof (TipoManejador)))
            {
                this.cboManejador.Items.Add(item);
            }
            this.cboManejador.SelectedItem = TipoManejador.Ambos;
        }

        public void EmpleadoMejorado_LimiteSueldo(EmpleadoMejorado emp,EmpleadoSueldoArgs sueldo)
        {
            MessageBox.Show("El empleado " + emp.Nombre + " se le quiso asignar el sueldo de " + sueldo.Sueldo);
        }

        public void EmpleadoMejorado_Log_LimiteSueldo(EmpleadoMejorado emp, EmpleadoSueldoArgs sueldo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\incidentesWF.log");
                sw.WriteLine("Fecha: " + DateTime.Now.ToString());
                sw.WriteLine("Nombre: " + emp.Nombre);
                sw.WriteLine("Legajo: " + emp.Legajo);
                sw.WriteLine("Sueldo a asignar: " + sueldo.Sueldo);
                sw.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadoMejorado empleado = new EmpleadoMejorado();
            switch ((TipoManejador)this.cboManejador.SelectedItem)
            {
                case TipoManejador.LimiteSueldo:
                    empleado._limiteSueldo += new DelSueldo(this.EmpleadoMejorado_LimiteSueldo);
                    break;
                case TipoManejador.Log:
                    empleado._limiteSueldo += new DelSueldo(this.EmpleadoMejorado_Log_LimiteSueldo);
                    break;
                case TipoManejador.Ambos:
                    empleado._limiteSueldo += new DelSueldo(this.EmpleadoMejorado_LimiteSueldo);
                    empleado._limiteSueldo += new DelSueldo(this.EmpleadoMejorado_Log_LimiteSueldo);
                    break;
                default:
                    break;
            }
            empleado.Nombre = this.txtNombre.Text;
            empleado.Legajo = int.Parse(this.txtLegajo.Text);
            empleado.Sueldo = float.Parse(this.txtSueldo.Text);
        }
    }
}
