using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Control
    {
        public static List<Avion>aviones { get; set; }
        public static List<Vuelo> ListaVuelos { get; set; }

        public Control()
        {
            if(aviones==null)
            {
                aviones = new List<Avion>();
            }
            if(ListaVuelos==null)
            {
                ListaVuelos = new List<Vuelo>();
            }
        }
        public void Registrar_Avion(Avion obj)
        {
            if(Existe_Avion(obj.CODIGOAVION)==false)
            {
                aviones.Add(obj);
            }
            
        }
        public bool Existe_Avion(string codigo)
        {
            return aviones.Exists(delegate (Avion x) { return x.CODIGOAVION == codigo; });
        }
        public List<Avion> Listar_Aviones(string TipoAvion)
        {

            //  List<Avion> LisatAux = aviones.FindAll(delegate(Avion x) { return x.TIPOAVION == TipoAvion; });
            List<Avion> ListaAux = aviones.FindAll(i => i.TIPOAVION == TipoAvion);
            return ListaAux;

        }
        public void Registrar_Vuelo(Vuelo objvuelo,Avion objavion)
        {

            Avion auxiliar = aviones.Find(delegate (Avion x) { return x.CODIGOAVION == objavion.CODIGOAVION; });
            auxiliar.VUELOS.Add(objvuelo);

        }
        public List<Avion> ListarAvionesDestino(string ciudadD)
        {
            List<Avion> avionesAux = new List<Avion>();

            // aviones.FindAll(i => i.VUELOS[i].CIUDAD_D == ciudadD);
            foreach (Avion Aux in aviones)
            {

                foreach (Vuelo aux2 in Aux.VUELOS)
                {
                    if (aux2.CIUDAD_D == ciudadD)
                    {
                        avionesAux.Add(Aux);
                    }
                }
            }

            return avionesAux;
        }




    }
}
