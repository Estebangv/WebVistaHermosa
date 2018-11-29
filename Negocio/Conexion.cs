using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALC;
using Oracle.ManagedDataAccess;

namespace Negocio
{
    public class Conexion
    {
        public static Entidades _entidades;
        public static Entidades Entidades
        {
            get
            {
                if (_entidades == null)
                {
                    _entidades = new DALC.Entidades();
                }

                return _entidades;
            }


        }

        public Conexion()
        {


        }


    }
}
