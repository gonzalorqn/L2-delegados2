using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado();
            e1._limiteSueldo += new DelegadoSueldo(Program.LimiteSueldoEmpleado);
            e1._limiteSueldo += new DelegadoSueldo((new Program()).GuardarLog);
            e1.Nombre = "Juan";
            e1.Legajo = 4267;
            e1.Sueldo = 13000;
            Console.WriteLine(e1);
            Console.ReadLine();
        }

        private static void LimiteSueldoEmpleado(Empleado e, float sueldo)
        {
            Console.WriteLine("El empleado " + e.Nombre + " se le quiso asignar el sueldo de " + sueldo);
        }

        public void GuardarLog(Empleado e, float sueldo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\incidentes.log");
                sw.WriteLine("Fecha: " + DateTime.Now.ToString());
                sw.WriteLine("Nombre: " + e.Nombre);
                sw.WriteLine("Legajo: " + e.Legajo);
                sw.WriteLine("Sueldo a asignar: " + sueldo);
                sw.Close();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
