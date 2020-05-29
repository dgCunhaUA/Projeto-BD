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

namespace SAA_Project
{
    public partial class FormRegistos : Form
    {
        private int currentAluno;
        private int currentRegisto;

        public FormRegistos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void FormRegistos_Load(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM SAA.Aluno", BDconnection.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            listAlunos.Items.Clear();

            while (reader.Read())
            {

                Aluno A = new Aluno();
                A.Nome = reader["Nome"].ToString();
                A.NMEC = reader["NMEC"].ToString();
                A.Email = reader["Email"].ToString();
                A.RegimeEstudo = reader["RegimeEstudo"].ToString();
                A.ID_Horario = reader["ID_Horario"].ToString();
                A.ID_Biblioteca = reader["ID_Biblioteca"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC_Tutor = reader["NMEC_Tutor"].ToString();
                A.Idade = reader["Idade"].ToString();

                listAlunos.Items.Add(A);
            }
            BDconnection.getConnection().Close();

            currentAluno = 0;
            ShowAluno();
        }
        public void ShowAluno()
        {
            if (listAlunos.Items.Count == 0 | currentAluno < 0)
                return;
            Aluno aluno = new Aluno();
            aluno = (Aluno)listAlunos.Items[currentAluno];
            nomeAluno.Text = aluno.Nome.ToString();
            nmecAluno.Text = aluno.NMEC;
            emailAluno.Text = aluno.Email;
            idHorarioAluno.Text = aluno.ID_Horario;
            idCursoAluno.Text = aluno.ID_Curso;

            n_Alunos.Text = listAlunos.Items.Count.ToString();
        }

        private void listAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAlunos.SelectedIndex >= 0)
            {
                currentAluno = listAlunos.SelectedIndex;
                ShowAluno();
                ListarRegistos();
            }
        }

        private void ListarRegistos()
        {
            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BDconnection.getConnection();

            cmd.CommandText = "SELECT * FROM SAA.REGISTOS_DO_NMEC ( @NMEC )";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NMEC", nmecAluno.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            listRegistos.Items.Clear();

            while (reader.Read())
            {

                Registo R = new Registo();
                R.ID_Registo = reader["ID_Registo"].ToString();
                R.NMEC = reader["NMEC"].ToString();
                R.ID_UC = reader["ID_UC"].ToString();
                R.ID_Aval = reader["ID_Aval"].ToString();

                listRegistos.Items.Add(R);
            }
            BDconnection.getConnection().Close();

            currentRegisto = 0;

            ShowRegisto();
        }

        private void ShowRegisto()
        {
            if (listRegistos.Items.Count == 0 | currentRegisto < 0)
                return;
            Registo R = new Registo();
            R = (Registo)listRegistos.Items[currentRegisto];
            id_registo.Text = R.ID_Registo.ToString();
            nmecRegisto.Text = R.NMEC;
            id_uc_Registo.Text = R.ID_UC;
            id_Aval_Registo.Text = R.ID_Aval;
        }

        private void listRegistos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listRegistos.SelectedIndex >= 0)
            {
                currentRegisto = listRegistos.SelectedIndex;
                ShowRegisto();
                ShowTipoRegisto();
            }
        }

        private void ShowTipoRegisto()
        {
            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BDconnection.getConnection();

            cmd.CommandText = "EXEC ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NMEC", nmecAluno.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            listRegistos.Items.Clear();

            while (reader.Read())
            {

                Registo R = new Registo();
                R.ID_Registo = reader["ID_Registo"].ToString();
                R.NMEC = reader["NMEC"].ToString();
                R.ID_UC = reader["ID_UC"].ToString();
                R.ID_Aval = reader["ID_Aval"].ToString();

                listRegistos.Items.Add(R);
            }
            BDconnection.getConnection().Close();

            currentRegisto = 0;

            ShowRegisto();
        }
    }
}
