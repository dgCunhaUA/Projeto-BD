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
    public partial class FormPerfilAluno : Form
    {

        private int currentAluno;

        public FormPerfilAluno()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            N_TURMAS();
            Nome_Cursos();
            Nome_Dep();
            N_BIBLIOS();
        }

        private void FormPerfilAluno_Load(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM SAA.Aluno", BDconnection.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            listBoxAluno.Items.Clear();

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

                listBoxAluno.Items.Add(A);
            }
            BDconnection.getConnection().Close();

            currentAluno = 0;
            ShowAluno();
        }

        private void listBoxAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAluno.SelectedIndex >= 0)
            {
                clearFields();
                currentAluno = listBoxAluno.SelectedIndex;
                ShowAluno();
            }
        }

        //add nome dos departamentos à combo box
        private void Nome_Dep()
        {
            if (!BDconnection.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("EXEC SAA.NOME_DEPARTAMENTOS", BDconnection.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxDep.Items.Add(reader["Nome_Dep"].ToString());
            }
            BDconnection.getConnection().Close();
        }

        //mostrar alunos de um departamento
        private void comboBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BDconnection.getConnection();

            cmd.CommandText = "EXEC SAA.ALUNO_DE_DEPARTAMENTO @Nome_Dep";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Nome_Dep", (String)comboBoxDep.SelectedItem);


            SqlDataReader reader = cmd.ExecuteReader();
            listBoxAluno.Items.Clear();

            while (reader.Read())
            {

                Aluno A = new Aluno();
                A.Nome = reader["Nome"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC = reader["NMEC"].ToString();
                A.Email = reader["Email"].ToString();
                A.RegimeEstudo = reader["RegimeEstudo"].ToString();
                A.ID_Horario = reader["ID_Horario"].ToString();
                A.ID_Biblioteca = reader["ID_Biblioteca"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC_Tutor = reader["NMEC_Tutor"].ToString();
                A.Idade = reader["Idade"].ToString();

                listBoxAluno.Items.Add(A);
            }
            BDconnection.getConnection().Close();

            currentAluno = 0;
            ShowAluno();

            comboBoxCurso.Text = "";
            comboBoxTurma.Text = "";
            comboBoxBiblio.Text = "";

        }

        //add nome dos cursos a combobox
        private void Nome_Cursos()
        {
            if (!BDconnection.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("EXEC SAA.NOME_CURSOS", BDconnection.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxCurso.Items.Add(reader["Nome_Curso"].ToString());
            }
            BDconnection.getConnection().Close();
        }

        //filtra por nome de curso
        private void comboBoxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BDconnection.getConnection();

            cmd.CommandText = "EXEC SAA.ALUNOS_DO_CURSO @NOME_CURSO";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@NOME_CURSO", (String)comboBoxCurso.SelectedItem);


            SqlDataReader reader = cmd.ExecuteReader();
            listBoxAluno.Items.Clear();

            while (reader.Read())
            {

                Aluno A = new Aluno();
                A.Nome = reader["Nome"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC = reader["NMEC"].ToString();
                A.Email = reader["Email"].ToString();
                A.RegimeEstudo = reader["RegimeEstudo"].ToString();
                A.ID_Horario = reader["ID_Horario"].ToString();
                A.ID_Biblioteca = reader["ID_Biblioteca"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC_Tutor = reader["NMEC_Tutor"].ToString();
                A.Idade = reader["Idade"].ToString();

                listBoxAluno.Items.Add(A);
            }
            BDconnection.getConnection().Close();

            currentAluno = 0;
            ShowAluno();

            comboBoxDep.Text = "";
            comboBoxTurma.Text = "";
            comboBoxBiblio.Text = "";

        }

        //add n_turmas a combobox
        private void N_TURMAS()
        {
            if (!BDconnection.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("EXEC SAA.N_TURMAS", BDconnection.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxTurma.Items.Add(reader["ID_TURMA"].ToString());
            }
            BDconnection.getConnection().Close();
        }

        //filtra por turmas
        private void comboBoxTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BDconnection.getConnection();

            cmd.CommandText = "EXEC SAA.ALUNOS_DA_TURMA @ID_Turma";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID_Turma", Int32.Parse((String)comboBoxTurma.SelectedItem));


            SqlDataReader reader = cmd.ExecuteReader();
            listBoxAluno.Items.Clear();

            while (reader.Read())
            {

                Aluno A = new Aluno();
                A.Nome = reader["Nome"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC = reader["NMEC"].ToString();
                A.Email = reader["Email"].ToString();
                A.RegimeEstudo = reader["RegimeEstudo"].ToString();
                A.ID_Horario = reader["ID_Horario"].ToString();
                A.ID_Biblioteca = reader["ID_Biblioteca"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC_Tutor = reader["NMEC_Tutor"].ToString();
                A.Idade = reader["Idade"].ToString();

                listBoxAluno.Items.Add(A);
            }
            BDconnection.getConnection().Close();

            currentAluno = 0;
            ShowAluno();

            comboBoxCurso.Text = "";
            comboBoxDep.Text = "";
            comboBoxBiblio.Text = "";
        }

        //filtrar pela biblio
        private void comboBoxBiblio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BDconnection.getConnection();

            cmd.CommandText = "EXEC SAA.ALUNOS_DA_BIBLIO @ID_BIBLIO";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID_BIBLIO", Int32.Parse((String)comboBoxBiblio.SelectedItem));


            SqlDataReader reader = cmd.ExecuteReader();
            listBoxAluno.Items.Clear();

            while (reader.Read())
            {

                Aluno A = new Aluno();
                A.Nome = reader["Nome"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC = reader["NMEC"].ToString();
                A.Email = reader["Email"].ToString();
                A.RegimeEstudo = reader["RegimeEstudo"].ToString();
                A.ID_Horario = reader["ID_Horario"].ToString();
                A.ID_Biblioteca = reader["ID_Biblioteca"].ToString();
                A.ID_Curso = reader["ID_Curso"].ToString();
                A.NMEC_Tutor = reader["NMEC_Tutor"].ToString();
                A.Idade = reader["Idade"].ToString();

                listBoxAluno.Items.Add(A);
            }
            BDconnection.getConnection().Close();

            currentAluno = 0;
            ShowAluno();

            comboBoxCurso.Text = "";
            comboBoxDep.Text = "";
            comboBoxTurma.Text = "";

        }

        //add n_biblios à combobox
        private void N_BIBLIOS()
        {
            if (!BDconnection.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("EXEC SAA.N_BIBLIOS", BDconnection.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxBiblio.Items.Add(reader["ID_Biblioteca"].ToString());
            }
            BDconnection.getConnection().Close();
        }



        public void ShowAluno()
        {
            if (listBoxAluno.Items.Count == 0 | currentAluno < 0)
                return;
            Aluno aluno = new Aluno();
            aluno = (Aluno)listBoxAluno.Items[currentAluno];
            nomeAluno.Text = aluno.Nome.ToString();
            nmecAluno.Text = aluno.NMEC;
            emailAluno.Text = aluno.Email;
            regimeEstudoAluno.Text = aluno.RegimeEstudo;
            idHorarioAluno.Text = aluno.ID_Horario;
            comboBoxBiblioShow.Text = aluno.ID_Biblioteca.ToString();   //combobox
            comboBoxCursoShow.Text = aluno.ID_Curso.ToString();            //combobox
            nmecTutorAluno.Text = aluno.NMEC_Tutor;
            idadeAluno.Text = aluno.Idade;

            idCursoAluno.Text = aluno.ID_Curso; 
            idBibliotecaAluno.Text = aluno.ID_Biblioteca;

            n_Alunos.Text = listBoxAluno.Items.Count.ToString();
        }



        //butons
        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Visible = false;
            confirmBtn2.Visible = false;
            adicionarBtn.Visible = true;
            updateBtn.Visible = true;
            cancelarBtn.Visible = false;
            limparBtn.Visible = false;
            eliminarBtn.Visible = true;


            clearFields();

            nomeAluno.ReadOnly = true;
            nmecAluno.ReadOnly = true;
            emailAluno.ReadOnly = true;
            nmecTutorAluno.ReadOnly = true;
            idadeAluno.ReadOnly = true;
            idCursoAluno.ReadOnly = true;
            idBibliotecaAluno.ReadOnly = true;
            idHorarioAluno.ReadOnly = true;
            passAluno.ReadOnly = true;

            regimeEstudoAluno.Enabled = false;
        }

        private void limparBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Visible = true;
            cancelarBtn.Visible = true;
            adicionarBtn.Visible = false;
            updateBtn.Visible = false;
            confirmBtn2.Visible = false;
            limparBtn.Visible = true;
            eliminarBtn.Visible = false;


            nomeAluno.ReadOnly = false;
            emailAluno.ReadOnly = false;
            nmecTutorAluno.ReadOnly = false;
            idadeAluno.ReadOnly = false;
            idCursoAluno.ReadOnly = false;
            idBibliotecaAluno.ReadOnly = false;
            idHorarioAluno.ReadOnly = false;
            passAluno.ReadOnly = false;

            regimeEstudoAluno.Enabled = true;
        }

        //confirma add
        private void confirmBtn2_Click(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                if (!BDconnection.verifySGBDConnection())
                    return;
            Aluno aluno = new Aluno();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BDconnection.getConnection();


            if (String.IsNullOrEmpty(nomeAluno.Text) || String.IsNullOrEmpty(idadeAluno.Text) || String.IsNullOrEmpty(emailAluno.Text) || String.IsNullOrEmpty(idCursoAluno.Text) || String.IsNullOrEmpty(regimeEstudoAluno.Text) || String.IsNullOrEmpty(idHorarioAluno.Text)) //|| String.IsNullOrEmpty(passAluno.Text))
            {
                MessageBox.Show("Todos os campos devem estar preenchidos");
            }
            else
            {
                try
                {
                    cmd.CommandText = "EXEC SAA.addAluno @Nome, @Email, @RegimeEstudo, @ID_Horario, @ID_Biblioteca, @NMEC_TUTOR, @Idade, @PasswordAccount, @ID_Curso";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Nome", nomeAluno.Text);
                    cmd.Parameters.AddWithValue("@Email", emailAluno.Text);
                    cmd.Parameters.AddWithValue("@RegimeEstudo", regimeEstudoAluno.SelectedItem);
                    cmd.Parameters.AddWithValue("@ID_Horario", Int32.Parse(idHorarioAluno.Text));
                    cmd.Parameters.AddWithValue("@ID_Biblioteca", Int32.Parse(idBibliotecaAluno.Text));
                    if (!String.IsNullOrEmpty(nmecTutorAluno.Text))
                    {
                        cmd.Parameters.AddWithValue("@NMEC_TUTOR", Int32.Parse(nmecTutorAluno.Text));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NMEC_TUTOR", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@Idade", Int32.Parse(idadeAluno.Text));
                    cmd.Parameters.AddWithValue("@PasswordAccount", DBNull.Value); //passAluno.Text);
                    cmd.Parameters.AddWithValue("@ID_Curso", Int32.Parse(idCursoAluno.Text));
                    cmd.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    DisplaySqlErrors(ex);
                }

                FormPerfilAluno_Load(sender, e);
                ShowAluno();

                confirmBtn.Visible = false;
                confirmBtn2.Visible = false;
                cancelarBtn.Visible = false;
                adicionarBtn.Visible = true;
                updateBtn.Visible = true;
                limparBtn.Visible = false;
                eliminarBtn.Visible = true;


                nomeAluno.ReadOnly = true;
                emailAluno.ReadOnly = true;
                nmecAluno.ReadOnly = true;
                nmecTutorAluno.ReadOnly = true;
                idadeAluno.ReadOnly = true;
                idCursoAluno.ReadOnly = true;
                idBibliotecaAluno.ReadOnly = true;
                idHorarioAluno.ReadOnly = true;
                passAluno.ReadOnly = true;

                regimeEstudoAluno.Enabled = false;

            }
        }

        //confirm update
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                if (!BDconnection.verifySGBDConnection())
                    return;
            Aluno aluno = new Aluno();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BDconnection.getConnection();


            if (String.IsNullOrEmpty(nomeAluno.Text) || String.IsNullOrEmpty(nmecAluno.Text) || String.IsNullOrEmpty(idadeAluno.Text) || String.IsNullOrEmpty(emailAluno.Text) || String.IsNullOrEmpty(idCursoAluno.Text) || String.IsNullOrEmpty(regimeEstudoAluno.Text) || String.IsNullOrEmpty(idHorarioAluno.Text)) //|| String.IsNullOrEmpty(passAluno.Text))
            {
                MessageBox.Show("Todos os campos devem estar preenchidos");
            }
            else
            {
                try
                {
                    cmd.CommandText = "EXEC SAA.updateAluno @Nome, @NMEC, @Email, @RegimeEstudo, @ID_Horario, @ID_Biblioteca, @NMEC_TUTOR, @Idade, @PasswordAccount, @ID_Curso";
                    cmd.Parameters.Clear();
                    MessageBox.Show(nomeAluno.Text);
                    cmd.Parameters.AddWithValue("@Nome", nomeAluno.Text);
                    cmd.Parameters.AddWithValue("@NMEC", Int32.Parse(nmecAluno.Text));
                    cmd.Parameters.AddWithValue("@Email", emailAluno.Text);
                    cmd.Parameters.AddWithValue("@RegimeEstudo", (String)regimeEstudoAluno.SelectedItem);
                    cmd.Parameters.AddWithValue("@ID_Horario", Int32.Parse(idHorarioAluno.Text));
                    cmd.Parameters.AddWithValue("@ID_Biblioteca", Int32.Parse(idBibliotecaAluno.Text));
                    if (!String.IsNullOrEmpty(nmecTutorAluno.Text))
                    {
                        cmd.Parameters.AddWithValue("@NMEC_TUTOR", Int32.Parse(nmecTutorAluno.Text));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NMEC_TUTOR", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@Idade", Int32.Parse(idadeAluno.Text));
                    cmd.Parameters.AddWithValue("@PasswordAccount", passAluno.Text);
                    cmd.Parameters.AddWithValue("@ID_Curso", Int32.Parse(idCursoAluno.Text));


                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    DisplaySqlErrors(ex);
                }
            }

            FormPerfilAluno_Load(sender, e);
            ShowAluno();

            confirmBtn.Visible = false;
            confirmBtn2.Visible = false;
            cancelarBtn.Visible = false;
            adicionarBtn.Visible = true;
            updateBtn.Visible = true;
            limparBtn.Visible = false;
            eliminarBtn.Visible = true;


            nomeAluno.ReadOnly = true;
            emailAluno.ReadOnly = true;
            nmecTutorAluno.ReadOnly = true;
            idadeAluno.ReadOnly = true;
            idCursoAluno.ReadOnly = true;
            idBibliotecaAluno.ReadOnly = true;
            idHorarioAluno.ReadOnly = true;
            passAluno.ReadOnly = true;

            regimeEstudoAluno.Enabled = false;
        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            confirmBtn.Visible = false;
            cancelarBtn.Visible = true;
            adicionarBtn.Visible = false;
            updateBtn.Visible = false;
            confirmBtn2.Visible = true;
            limparBtn.Visible = true;
            eliminarBtn.Visible = false;


            nomeAluno.ReadOnly = false;
            emailAluno.ReadOnly = false;
            nmecAluno.ReadOnly = true;
            nmecTutorAluno.ReadOnly = false;
            idadeAluno.ReadOnly = false;
            idCursoAluno.ReadOnly = false;
            idBibliotecaAluno.ReadOnly = false;
            idHorarioAluno.ReadOnly = false;
            passAluno.ReadOnly = false;

            regimeEstudoAluno.Enabled = true;

            clearFields();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (!BDconnection.verifySGBDConnection())
                if (!BDconnection.verifySGBDConnection())
                    return;

            Object obj = MessageBox.Show("Tem a certeza que pretende eliminar?", "", MessageBoxButtons.YesNo);

            if (obj.ToString().Equals("Yes"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BDconnection.getConnection();

                cmd.CommandText = "EXEC SAA.del_Aluno @NMEC";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NMEC", nmecAluno.Text);

                cmd.ExecuteNonQuery();
                BDconnection.getConnection().Close();

                FormPerfilAluno_Load(sender, e);
                ShowAluno();

                confirmBtn.Visible = false;
                confirmBtn2.Visible = false;
                cancelarBtn.Visible = false;
                adicionarBtn.Visible = true;
                updateBtn.Visible = true;
                limparBtn.Visible = false;
                eliminarBtn.Visible = true;

                nomeAluno.ReadOnly = true;
                emailAluno.ReadOnly = true;
                nmecAluno.ReadOnly = true;
                nmecTutorAluno.ReadOnly = true;
                idadeAluno.ReadOnly = true;
                idCursoAluno.ReadOnly = true;
                idBibliotecaAluno.ReadOnly = true;
                idHorarioAluno.ReadOnly = true;
                passAluno.ReadOnly = true;

                regimeEstudoAluno.Enabled = false;
            }
        }

        //menu
        private void button1_Click(object sender, EventArgs e)
        {
            Object obj = MessageBox.Show("Quer ir para o menu principal? ", " ", MessageBoxButtons.YesNo);
            if (obj.ToString().Equals("Yes"))
            {
                this.Close();
                FormHomePage menu = new FormHomePage();
                menu.Show();
            }
        }

        //outros
        private static void DisplaySqlErrors(SqlException exception)
        {
            for (int i = 0; i < exception.Errors.Count; i++)
            {
                //MessageBox.Show("Index #" + i + "\n" +
                //    "Error: " + exception.Errors[i].ToString() + "\n");
                MessageBox.Show("ERRO SQL");
            }
            Console.ReadLine();
        }
        private void PreviousPage_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAluno faluno = new FormAluno();
            faluno.Show();
        }

        private void clearFields()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void regimeEstudoAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
