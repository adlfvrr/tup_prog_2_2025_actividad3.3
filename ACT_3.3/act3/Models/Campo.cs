using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act3.Models
{
    public class Campo:IComparable
    {
        public string Identificador {  get; set; }
        public double Superficie { get; set; }
        ArrayList parcelas = new ArrayList();
        public Campo(string id, double supe)
        {
            this.Superficie = supe;
            this.Identificador = id;
        }

        public int CompareTo(object otro)
        {
            Campo otroCampo = otro as Campo;
            if (otroCampo != null)
            {
                return Identificador.CompareTo(otroCampo.Identificador);
            }
            return -1;
        }
    }
}
