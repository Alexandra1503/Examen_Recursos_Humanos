using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{

    // : PERSONA (PARA HEREDAR)

   public class CLIENTE : PERSONA
    {

        private string CATEGORIA;
        private string CODIGODEPEDIDO;

        public string CATEGORIA1
        {
            get
            {
                return CATEGORIA;
            }

            set
            {
                CATEGORIA = value;
            }
        }

        public string CODIGODEPEDIDO1
        {
            get
            {
                return CODIGODEPEDIDO;
            }

            set
            {
                CODIGODEPEDIDO = value;
            }
        }

        //MÉTODOS

        public void GENERARCODIGODEPEDIDO()

        {
            this.CODIGODEPEDIDO1 = "C" + this.APPATERNO1.Substring(0,3);

            // Substring(0,3) EXTRAE LA CADENA Y TOMA 3 VALORES 
        }

    }
}
