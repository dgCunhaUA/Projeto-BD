﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAA_Project
{
    class UC
    {
        private int _ID_UC;
        private string _AnoFormacao;
        private int _ID_Horario;
        private int _ID_Aval;

        public int ID_UC
        {
            get { return _ID_UC; }
            set
            {
                _ID_UC = value;
            }
        }

        public string AnoFormacao
        {
            get { return _AnoFormacao; }
            set
            {
                _AnoFormacao = value;
            }
        }

        public int ID_Horario
        {
            get { return _ID_Horario; }
            set
            {
                _ID_Horario = value;
            }
        }

        public int ID_Aval
        {
            get { return _ID_Aval; }
            set
            {
                _ID_Aval = value;
            }
        }

        public override String ToString()
        {
            String s = String.Format("{0,-10}  {1,-5}", _ID_UC, _AnoFormacao);
            return s;
        }
    }
}
