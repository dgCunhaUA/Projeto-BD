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
    public partial class FormHorario2 : Form
    {
        private int currentHorario;
        private string current_id_horario;
        private int currentAluno;


        public FormHorario2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            this.Close();
            FormHorario fhor = new FormHorario();
            fhor.Show();
        }

        private void FormHorario2_Load(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("EXEC SAA.IDS_HORARIOS", BDconnection.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            listHorarios.Items.Clear();

            while (reader.Read())
            {

                Horario H = new Horario();
                H.ID_Horario = reader["ID_Horario"].ToString();

                listHorarios.Items.Add(H);
            }
            BDconnection.getConnection().Close();

            //currentHorario = currentHorario2;
            currentHorario = 0;
        }

        private void listaUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaAlunos.SelectedIndex >= 0)
            {
                currentAluno = listaAlunos.SelectedIndex;
                ShowAluno();
                ShowProfessor();
            }
        }

        private void listHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listHorarios.SelectedIndex >= 0)
            {
                currentHorario = listHorarios.SelectedIndex;
                current_id_horario = listHorarios.Items[currentHorario].ToString();

                listaAlunos.Visible = true;
                labelnmec2.Visible = true;
                labelnome2.Visible = true;

                if (!BDconnection.verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BDconnection.getConnection();

                //cmd.CommandText = "EXEC SAA.ALUNOS_DO_HORARIO @ID_Horario";
                cmd.CommandText = "Select * from SAA.DADOS_HOR_X2 (@ID_Horario)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Horario", current_id_horario);

                SqlDataReader reader = cmd.ExecuteReader();
                listaAlunos.Items.Clear();

                while (reader.Read())
                {

                    HorAlunoProf A = new HorAlunoProf();
                    //Aluno A = new Aluno();
                    A.Nome = reader["Nome"].ToString();
                    A.NMEC = reader["NMEC"].ToString();
                    A.Email = reader["Email_Aluno"].ToString();
                    A.ID_Horario = reader["ID_Horario"].ToString();

                    //Professor P = new Professor();
                    A.Nome = reader["Nome_Prof"].ToString();
                    A.Email = reader["Email_Prof"].ToString();
                    A.TNMEC = reader["TMEC"].ToString();
                    

                    listaAlunos.Items.Add(A);
                }
                BDconnection.getConnection().Close();

                currentAluno = 0;
                //ShowAluno();
                //ShowAProfesor();
                ShowDados();
            }
        }

        public void ShowAluno()
        {
            if (listaAlunos.Items.Count == 0 | currentAluno < 0)
                return;

            labelNMEC_TUTOR.Text = "NMEC Tutor";
            labelIdade.Text = "Idade";
            labelCurso.Text = "Curso";
            labelNMEC.Text = "NMEC";
            labelEmail.Text = "Email";
            labelnmec2.Text = "NMEC";
            labelnome2.Text = "Nome";
            regimeEstudoAluno.Visible = true;
            idBibliotecaAluno.Visible = true;
            labelRegime.Visible = true;
            labelHorario.Visible = true;
            labelBiblio.Visible = true;
            passAluno.Visible = true;
            idHorarioAluno.Visible = true;
            nomeAluno.Visible = true;
            idCursoAluno.Visible = true;
            labelNome.Visible = true;
            labelCurso.Visible = true;

            Aluno aluno = new Aluno();
            aluno = (Aluno)listaAlunos.Items[currentAluno];
            nomeAluno.Text = aluno.Nome.ToString();
            nmecAluno.Text = aluno.NMEC;
            emailAluno.Text = aluno.Email;
            regimeEstudoAluno.Text = aluno.RegimeEstudo;
            idHorarioAluno.Text = aluno.ID_Horario;
            idBibliotecaAluno.Text = aluno.ID_Biblioteca;
            idCursoAluno.Text = aluno.ID_Curso;
            nmecTutorAluno.Text = aluno.NMEC_Tutor;
            idadeAluno.Text = aluno.Idade;
        }

        public void ShowDados()
        {
            if (listaAlunos.Items.Count == 0 | currentAluno < 0)
                return;

            labelNMEC_TUTOR.Text = "NMEC Tutor";
            labelIdade.Text = "Idade";
            labelCurso.Text = "Curso";
            labelNMEC.Text = "NMEC";
            labelEmail.Text = "Email";
            labelnmec2.Text = "NMEC";
            labelnome2.Text = "Nome";
            regimeEstudoAluno.Visible = true;
            idBibliotecaAluno.Visible = true;
            labelRegime.Visible = true;
            labelHorario.Visible = true;
            labelBiblio.Visible = true;
            passAluno.Visible = true;
            idHorarioAluno.Visible = true;
            nomeAluno.Visible = true;
            idCursoAluno.Visible = true;
            labelNome.Visible = true;
            labelCurso.Visible = true;

            HorAlunoProf aluno = new HorAlunoProf();
            aluno = (HorAlunoProf)listaAlunos.Items[currentAluno];
            nomeAluno.Text = aluno.Nome.ToString();
            nmecAluno.Text = aluno.NMEC;
            emailAluno.Text = aluno.Email;
            //regimeEstudoAluno.Text = aluno.RegimeEstudo;
            idHorarioAluno.Text = aluno.ID_Horario;
            //idBibliotecaAluno.Text = aluno.ID_Biblioteca;
            //idCursoAluno.Text = aluno.ID_Curso;
            //nmecTutorAluno.Text = aluno.NMEC_Tutor;
            //idadeAluno.Text = aluno.Idade;

            //professor
            nomeProf.Text = aluno.Nome.ToString();
            tnmecProf.Text = aluno.TNMEC.ToString();
            emailProf.Text = aluno.Email.ToString();
        }

        public void ShowProfessor()
        {
            if (listaAlunos.Items.Count == 0 | currentAluno < 0)
                return;
            Professor p = new Professor();
            p = (Professor)listaAlunos.Items[currentAluno];
            nomeProf.Text = p.Nome.ToString();
            tnmecProf.Text = p.TNMEC.ToString();
            emailProf.Text = p.Email.ToString();
            // textBox6.Text = p.ID_Dep.ToString();

        }

    }
}
