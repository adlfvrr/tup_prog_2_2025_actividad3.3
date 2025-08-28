using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act3.Models
{
    internal class Estancia
    {
        public Casco Casco { get; set; }
        public string Nombre { get; set; }
        ArrayList campos = new ArrayList();
        ArrayList puestos = new ArrayList();
        public Estancia(string nombre, string idCampo, double sup)
        {
            this.Nombre = nombre;
            this.Casco = new Casco();
            this.Casco.Administrador = "Sin asignar";
            puestos.Add(new Puesto());
            ((Puesto)puestos[0]).Responsable = "Sin asignar"; // Es igual a asignar previamente una referencia a un Puesto() -- Puesto puesto = new Puesto(); puestos.Add(puesto); puesto.Responsable = "Sin asignar";
            //
            Campo campo = new Campo(idCampo, sup);           //   <<<---
            campos.Add(campo);
        }
        public Campo AgregarCampo(string idCampo, double superficie)
        {
            Campo nuevo = new Campo(idCampo, superficie);
            campos.Add(nuevo);
            return nuevo;
        }
        public Campo VerCampo(int idx)
        {
            if (campos != null && idx > -1 && idx < campos.Count)
            {
                return campos[idx] as Campo;
            }
            return null;
        }
        public int VerCantidadCampos()
        {
            if(campos!= null)
            { return campos.Count; }
            return 0;
        }
        
    }
}
