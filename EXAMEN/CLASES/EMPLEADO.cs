using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class EMPLEADO : PERSONA
    {

        private string TIPO;
        private string TIPOCONTRATO;
        private double SUELDO;

          // MÉTODOS

        public string TIPO1
        {
            get
            {
                return TIPO;
            }

            set
            {
                TIPO = value;
            }
        }

        public string TIPOCONTRATO1
        {
            get
            {
                return TIPOCONTRATO;
            }

            set
            {
                TIPOCONTRATO = value;
            }
        }

        public double SUELDO1
        {
            get
            {
                return SUELDO;
            }

            set
            {
                SUELDO = value;
            }
        }

        //MÉTODOS

        public void CALCULARSUELDO (double SUELDOBASE)

        {
            
            if (this.TIPO1 == "GERENTE")
            {
                if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = 2 * SUELDOBASE + 1500;
                }
            }
            else if (this.TIPO1 == "VENDEDOR")
            {
                if (this.TIPOCONTRATO1 == "NUEVO")
                {
                    SUELDO1 = SUELDOBASE + 500;
                }
                else if (this.TIPOCONTRATO1 == "LONGEVO")
                {
                    SUELDO1 = SUELDOBASE + 1500;
                }

            }else
            {
                this.SUELDO1 = 0;
            }
        }
//.

    }
}
