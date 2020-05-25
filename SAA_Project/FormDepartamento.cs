using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SAA_Project
{
    public partial class FormDepartamento : Form
    {
        private int currentDepartamento;
        private SqlConnection cn;

        public FormDepartamento()
        {
            InitializeComponent();
        }

        private void FormDepartamento_Load(object sender, EventArgs e)
        {

            cn = getSGBDConnection();
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM SAA.Departamento", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listDepartamento.Items.Clear();

            while (reader.Read())
            {

                Departamento D = new Departamento();
                D.Nome = reader["Nome_Dep"].ToString();
                D.ID_Dep = reader["ID_Dep"].ToString();
                D.localização = reader["Localizaçao_Dep"].ToString();

                listDepartamento.Items.Add(D);
            }
            reader.Close(); 
            //cn.Close();

            currentDepartamento = 0;
            ShowDepartamento();
        }
        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source=tcp:mednat.ieeta.pt\\SQLSERVER,8101; Initial Catalog = p3g6; uid = p3g6; password = 552748589@Bd");
        }
        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        public void ShowDepartamento()
        {
            if (listDepartamento.Items.Count == 0 | currentDepartamento < 0)
                return;
            Departamento dep = new Departamento();
            dep = (Departamento)listDepartamento.Items[currentDepartamento];
            nomeDep.Text = dep.Nome;
            idDep.Text = dep.ID_Dep;
            localizacaoDep.Text = dep.localização;
        }

        private void listDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDepartamento.SelectedIndex >= 0)
            {
                currentDepartamento = listDepartamento.SelectedIndex;
                ShowDepartamento();
            }
        }
    }
}
