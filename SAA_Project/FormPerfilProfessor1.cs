using System;
using System.Collections;
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
    public partial class FormPerfilProfessor1 : Form
    {
        private int currentProfTurma;
        public FormPerfilProfessor1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            showProfs();


        }

        private void FormPerfilProfessor1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //showProfs();
            showTurmasProf();
            comboBox1.SelectedItem = " ";


        }

        private void showProfs()
        {
            if (!BDconnection.verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("EXEC SAA.NomeProf", BDconnection.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Nome_Prof"].ToString());
            }
            BDconnection.getConnection().Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                //professor selecionado
                currentProfTurma = listBox1.SelectedIndex;
                ShowTurma_Prof();
            }
        }

    
        public void ShowTurma_Prof()
        {
            if (listBox1.Items.Count == 0 | currentProfTurma < 0)
                return;
            ProfTurma p = new ProfTurma();
            p = (ProfTurma)listBox1.Items[currentProfTurma];   

        }





        //para a listBox
        public void showTurmasProf()
        {
            if (!BDconnection.verifySGBDConnection())
                return;
            if (comboBox1.Items.Count == 0)
                return;
            String profSelected = (String)comboBox1.SelectedItem;
            //MessageBox.Show(depSelected);
            SqlCommand cmd = new SqlCommand("select * from SAA.TURMAS_POR_PROFESSOR ('" +profSelected+ "') ", BDconnection.getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {

                ProfTurma A = new ProfTurma();

                A.ID_turma = (int)reader["ID_turma"];
                A.TNMEC = (int)reader["TMEC"];
                A.Nome = reader["Nome_Prof"].ToString();
                A.Email = reader["Email"].ToString();

                listBox1.Items.Add(A);
            }
            BDconnection.getConnection().Close();
            currentProfTurma = 0;
            ShowTurma_Prof();
        }


    
















        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            FormProfessor fperfil = new FormProfessor();
            fperfil.Show();
        }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
