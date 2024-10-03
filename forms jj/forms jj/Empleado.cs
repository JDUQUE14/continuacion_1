using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_jj
{
    public abstract class  Empleado
    {
        public string nombre { get; set; }
        public decimal salario { get; set; }

        public Empleado(string nom, decimal sal) {
            nombre = nom;
            salario = sal;
        }
        public abstract decimal CalcularBono();
        public virtual string MostrarInf() 
        { 
            return nombre;
        }


    }
}
