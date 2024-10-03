using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_jj
{
    public class Gerente : Empleado
    {

        public Gerente(string nombre, decimal salario) : base(nombre, salario)
        {    
        }

        public override decimal CalcularBono()
        {
            return salario * 0.20m;
        }
        public override string MostrarInf()
        {
            return base.MostrarInf()+"      Rol: Gerente"+"      salario: "+salario+"      bono: "+CalcularBono();   
        }
    }
}
