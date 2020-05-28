using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA_Project
{
    class HorAlunoProf
    {
        //aluno
        private String _Nome;
        private String _NMEC;
        private String _Email;
        private String _ID_Horario;

        //prof
        private String _NomeProf;
        private String _TNMEC;
        private String _EmailProf;


        public String Nome
        {
            get { return _Nome; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome necessário!");
                }
                _Nome = value;
            }
        }
        public String ID_Horario
        {
            get { return _ID_Horario; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome necessário!");
                }
                _ID_Horario = value;
            }
        }

        public String NomeProf
        {
            get { return _NomeProf; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("Nome Profesosr necessário!");
                }
                _NomeProf = value;
            }
        }

        public String NMEC
        {
            get { return _NMEC; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("NMEC necessario!");
                }
                _NMEC = value;
            }
        }

        public String TNMEC
        {
            get { return _TNMEC; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("TNMEC necessario!");
                }
                _TNMEC = value;
            }
        }
        public String Email
        {
            get { return _Email; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("Email necessário");
                }
                _Email = value;
            }
        }
        public String EmailProf
        {
            get { return _EmailProf; }
            set
            {
                if (value == null | String.IsNullOrEmpty(value))
                {
                    throw new Exception("Email do professor necessário");
                }
                _EmailProf = value;
            }
        }
      
        public override String ToString()
        {
            String s = String.Format("{0,-15}  {1,-10}", _NMEC, Nome);
            return s;
        }

    }
}
