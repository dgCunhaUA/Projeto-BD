using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA_Project
{
    class Registo
    {
        private String _ID_Registo;
        private String _NMEC;
        private String _ID_UC;
        private String _ID_Aval;

        public String ID_Registo
        {
            get { return _ID_Registo; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("ID registo necessário!");
                }
                _ID_Registo = value;
            }
        }

        public String NMEC
        {
            get { return _NMEC; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("NMEC necessário!");
                }
                _NMEC = value;
            }
        }

        public String ID_UC
        {
            get { return _ID_UC; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("ID UC necessário!");
                }
                _ID_UC = value;
            }
        }

        public String ID_Aval
        {
            get { return _ID_Aval; }
            set { _ID_Aval = value; }
        }


        public override String ToString()
        {
            String s = String.Format("{0,-15}  {1,-5}", ID_Registo, ID_UC);
            return s;
        }

    }
}
