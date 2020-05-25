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
    public partial class FormLogin : Form
    {
        private SqlConnection cn;

        public FormLogin()
        {
            InitializeComponent();
            passBox.PasswordChar = '*';
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            bool w = false;

            if (!BDconnection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BDconnection.getConnection();
            cmd.CommandText = "select Email, PasswordAccount from SAA.ALUNO";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) { 
                //ja lê da BD 
                //reader["Email"].ToString()
                //reader["PasswordAccount"].ToString()
                if (mailBox.Text.Equals("1") & passBox.Text.Equals("1"))
                {
                    w = true;
                   
                   
                    break;
                 
                    // FormMenu fMenu = new FormMenu();
                    //home_Page.ShowDialog();
                    //.Close();
                    //fMenu.ShowDialog();
                    //  MessageBox.Show("Sim");
                }
                else
                {
                    MessageBox.Show("Email ou password estão incorretas");
                }
               
            }
            BDconnection.getConnection().Close();

            if (w == true)
            {
                this.Hide();
                FormHomePage home_Page = new FormHomePage();
                home_Page.ShowDialog();

            }








        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
