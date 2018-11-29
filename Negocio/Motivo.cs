using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALC;


namespace Negocio
{
    public class Motivo
    {
        public static MOTIVO _motivo;
        public static MOTIVO MOTIVO
        {
            get
            {
                if (_motivo == null)
                {
                    _motivo = new DALC.MOTIVO();
                }

                return _motivo;
            }
        }

        public Motivo()
        {
        }
    }
}
