using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CN_PROYECTO
{
    public class CnPlane
    {
        private int idPlane;
        private int qtyAsiento;
        private String marca;
        public int IdPlane
        {
            get { return idPlane; }
            set { idPlane = value; }
        }

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int QtyAsiento
        {
            get { return qtyAsiento; }
            set { qtyAsiento = value; }
        }

        public List<CD_PROYECTO.CdPlane> ListarAviones()
        {

            CD_PROYECTO.CdPlane pl = new CD_PROYECTO.CdPlane();
            return pl.ListarAvion();
            
        }

    }
}
