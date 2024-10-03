using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_jj
{
    public class Programador :Empleado
    {
        public Programador(string nombre, decimal salario) : base(nombre, salario) 
        { }
        public override decimal CalcularBono()
        {
            return salario * 0.10m;
        }
        public override string MostrarInf()
        {
            return base.MostrarInf() + "      Rol: Programador" + "      salario: " + salario + "      bono: " + CalcularBono(); 
        }
    }
}
