using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SAA_Project
{
    public partial class FormAluno : Form
    {
        private SqlConnection cn;
        private int currentAluno;

        public FormAluno()
        {
            InitializeComponent();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM SAA.Aluno", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            listAluno.Items.Clear();

            while (reader.Read())
            {
                
                Aluno A = new Aluno();
                A.Nome = reader["Nome"].ToString();
                A.NMEC = reader["NMEC"].ToString();
                A.Email = reader["Email"].ToString();
                A.RegimeEstudo = reader["RegimeEstudo"].ToString();
                A.ID_Horario = reader["ID_Horario"].ToString();
                A.ID_Biblioteca = reader["ID_Biblioteca"].ToString();
                //A.ID_Secretaria = reader["ID_Secretaria"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC_Tutor = reader["NMEC_Tutor"].ToString();
                A.Idade = reader["Idade"].ToString();

                listAluno.Items.Add(A);
            }
            cn.Close();

            currentAluno = 0;
            ShowAluno();

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

        private void listAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAluno.SelectedIndex >= 0)
            {
                currentAluno = listAluno.SelectedIndex;
                ShowAluno();
            }
        }


        public void ShowAluno()
        {
            if (listAluno.Items.Count == 0 | currentAluno < 0)
                return;
            Aluno aluno = new Aluno();
            aluno = (Aluno)listAluno.Items[currentAluno];
            nomeAluno.Text = aluno.Nome;
            nmecAluno.Text = aluno.NMEC;
            emailAluno.Text = aluno.Email;
            regimeEstudoAluno.Text = aluno.RegimeEstudo;
            idHorarioAluno.Text = aluno.ID_Horario;
            idBibliotecaAluno.Text = aluno.ID_Biblioteca;
            idSecretariaAluno.Text = aluno.ID_Secretaria;
            idCursoAluno.Text = aluno.ID_Curso;
            nmecTutorAluno.Text = aluno.NMEC_Tutor;
            idadeAluno.Text = aluno.Idade;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu fMenu = new FormMenu();
            fMenu.ShowDialog();
        }
    }
}
