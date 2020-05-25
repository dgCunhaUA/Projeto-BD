namespace SAA_Project
{
    partial class FormAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomeAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listAluno = new System.Windows.Forms.ListBox();
            this.emailAluno = new System.Windows.Forms.TextBox();
            this.nmecAluno = new System.Windows.Forms.TextBox();
            this.idHorarioAluno = new System.Windows.Forms.TextBox();
            this.idBibliotecaAluno = new System.Windows.Forms.TextBox();
            this.idCursoAluno = new System.Windows.Forms.TextBox();
            this.nmecTutorAluno = new System.Windows.Forms.TextBox();
            this.idadeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTurma = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBoxAluno = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adicionarBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.passAluno = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.confirmBtn2 = new System.Windows.Forms.Button();
            this.regimeEstudoAluno = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeAluno
            // 
            this.nomeAluno.Location = new System.Drawing.Point(373, 54);
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            this.nomeAluno.Size = new System.Drawing.Size(260, 20);
            this.nomeAluno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // listAluno
            // 
            this.listAluno.FormattingEnabled = true;
            this.listAluno.Location = new System.Drawing.Point(32, 61);
            this.listAluno.Name = "listAluno";
            this.listAluno.Size = new System.Drawing.Size(245, 342);
            this.listAluno.TabIndex = 3;
            this.listAluno.SelectedIndexChanged += new System.EventHandler(this.listAluno_SelectedIndexChanged);
            // 
            // emailAluno
            // 
            this.emailAluno.Location = new System.Drawing.Point(373, 134);
            this.emailAluno.Name = "emailAluno";
            this.emailAluno.ReadOnly = true;
            this.emailAluno.Size = new System.Drawing.Size(260, 20);
            this.emailAluno.TabIndex = 4;
            // 
            // nmecAluno
            // 
            this.nmecAluno.Location = new System.Drawing.Point(373, 95);
            this.nmecAluno.Name = "nmecAluno";
            this.nmecAluno.ReadOnly = true;
            this.nmecAluno.Size = new System.Drawing.Size(76, 20);
            this.nmecAluno.TabIndex = 6;
            // 
            // idHorarioAluno
            // 
            this.idHorarioAluno.Location = new System.Drawing.Point(455, 216);
            this.idHorarioAluno.Name = "idHorarioAluno";
            this.idHorarioAluno.ReadOnly = true;
            this.idHorarioAluno.Size = new System.Drawing.Size(63, 20);
            this.idHorarioAluno.TabIndex = 7;
            // 
            // idBibliotecaAluno
            // 
            this.idBibliotecaAluno.Location = new System.Drawing.Point(546, 175);
            this.idBibliotecaAluno.Name = "idBibliotecaAluno";
            this.idBibliotecaAluno.ReadOnly = true;
            this.idBibliotecaAluno.Size = new System.Drawing.Size(87, 20);
            this.idBibliotecaAluno.TabIndex = 8;
            // 
            // idCursoAluno
            // 
            this.idCursoAluno.Location = new System.Drawing.Point(373, 216);
            this.idCursoAluno.Name = "idCursoAluno";
            this.idCursoAluno.ReadOnly = true;
            this.idCursoAluno.Size = new System.Drawing.Size(63, 20);
            this.idCursoAluno.TabIndex = 10;
            // 
            // nmecTutorAluno
            // 
            this.nmecTutorAluno.Location = new System.Drawing.Point(465, 95);
            this.nmecTutorAluno.Name = "nmecTutorAluno";
            this.nmecTutorAluno.ReadOnly = true;
            this.nmecTutorAluno.Size = new System.Drawing.Size(76, 20);
            this.nmecTutorAluno.TabIndex = 11;
            // 
            // idadeAluno
            // 
            this.idadeAluno.Location = new System.Drawing.Point(558, 95);
            this.idadeAluno.Name = "idadeAluno";
            this.idadeAluno.ReadOnly = true;
            this.idadeAluno.Size = new System.Drawing.Size(75, 20);
            this.idadeAluno.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Regime Estudo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "NMEC Tutor";
            // 
            // labelProf
            // 
            this.labelProf.AutoSize = true;
            this.labelProf.Font = new System.Drawing.Font("Arial", 14F);
            this.labelProf.Location = new System.Drawing.Point(28, 24);
            this.labelProf.Name = "labelProf";
            this.labelProf.Size = new System.Drawing.Size(133, 22);
            this.labelProf.TabIndex = 15;
            this.labelProf.Text = "Perfil do Aluno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "NMEC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Horario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Idade";
            // 
            // comboBoxTurma
            // 
            this.comboBoxTurma.FormattingEnabled = true;
            this.comboBoxTurma.Items.AddRange(new object[] {
            "1",
            "3"});
            this.comboBoxTurma.Location = new System.Drawing.Point(443, 357);
            this.comboBoxTurma.Name = "comboBoxTurma";
            this.comboBoxTurma.Size = new System.Drawing.Size(36, 21);
            this.comboBoxTurma.TabIndex = 82;
            this.comboBoxTurma.SelectedIndexChanged += new System.EventHandler(this.comboBoxTurma_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(371, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 83;
            this.label10.Text = "Nº Turma";
            // 
            // listBoxAluno
            // 
            this.listBoxAluno.FormattingEnabled = true;
            this.listBoxAluno.Location = new System.Drawing.Point(501, 325);
            this.listBoxAluno.Name = "listBoxAluno";
            this.listBoxAluno.Size = new System.Drawing.Size(159, 69);
            this.listBoxAluno.TabIndex = 82;
            this.listBoxAluno.SelectedIndexChanged += new System.EventHandler(this.listBoxAlunoTurma_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(498, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 82;
            this.label8.Text = "NMEC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.Location = new System.Drawing.Point(555, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 84;
            this.label9.Text = "Nome";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Curso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(354, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 2);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.Font = new System.Drawing.Font("Arial", 11F);
            this.adicionarBtn.Location = new System.Drawing.Point(373, 253);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(76, 28);
            this.adicionarBtn.TabIndex = 86;
            this.adicionarBtn.Text = "Adicionar";
            this.adicionarBtn.UseVisualStyleBackColor = true;
            this.adicionarBtn.Click += new System.EventHandler(this.adicionarBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.Font = new System.Drawing.Font("Arial", 11F);
            this.limparBtn.Location = new System.Drawing.Point(546, 210);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(87, 28);
            this.limparBtn.TabIndex = 87;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Visible = false;
            this.limparBtn.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Arial", 11F);
            this.updateBtn.Location = new System.Drawing.Point(464, 253);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(76, 28);
            this.updateBtn.TabIndex = 88;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.Update_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Font = new System.Drawing.Font("Arial", 11F);
            this.cancelarBtn.Location = new System.Drawing.Point(584, 253);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(76, 28);
            this.cancelarBtn.TabIndex = 89;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Visible = false;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // passAluno
            // 
            this.passAluno.Location = new System.Drawing.Point(663, 95);
            this.passAluno.Name = "passAluno";
            this.passAluno.ReadOnly = true;
            this.passAluno.Size = new System.Drawing.Size(47, 20);
            this.passAluno.TabIndex = 90;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Arial", 11F);
            this.confirmBtn.Location = new System.Drawing.Point(373, 253);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(95, 28);
            this.confirmBtn.TabIndex = 91;
            this.confirmBtn.Text = "Confirmar";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Visible = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmButon_Click);
            // 
            // confirmBtn2
            // 
            this.confirmBtn2.Font = new System.Drawing.Font("Arial", 11F);
            this.confirmBtn2.Location = new System.Drawing.Point(373, 253);
            this.confirmBtn2.Name = "confirmBtn2";
            this.confirmBtn2.Size = new System.Drawing.Size(95, 28);
            this.confirmBtn2.TabIndex = 92;
            this.confirmBtn2.Text = "Confirmar";
            this.confirmBtn2.UseVisualStyleBackColor = true;
            this.confirmBtn2.Visible = false;
            this.confirmBtn2.Click += new System.EventHandler(this.confirmBtn2_Click);
            // 
            // regimeEstudoAluno
            // 
            this.regimeEstudoAluno.Enabled = false;
            this.regimeEstudoAluno.FormattingEnabled = true;
            this.regimeEstudoAluno.Items.AddRange(new object[] {
            "Estudante",
            "TrabalhadorEstudante",
            "EstudanteInternacional",
            "Erasmus"});
            this.regimeEstudoAluno.Location = new System.Drawing.Point(373, 174);
            this.regimeEstudoAluno.Name = "regimeEstudoAluno";
            this.regimeEstudoAluno.Size = new System.Drawing.Size(155, 21);
            this.regimeEstudoAluno.TabIndex = 93;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(543, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "Biblioteca";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11F);
            this.button1.Location = new System.Drawing.Point(731, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 26);
            this.button1.TabIndex = 95;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F);
            this.label13.Location = new System.Drawing.Point(321, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 16);
            this.label13.TabIndex = 96;
            this.label13.Text = "Nº Departamento";
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(443, 320);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(36, 21);
            this.comboBoxDep.TabIndex = 97;
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxDep);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.regimeEstudoAluno);
            this.Controls.Add(this.confirmBtn2);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.passAluno);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.limparBtn);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBoxAluno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxTurma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelProf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idadeAluno);
            this.Controls.Add(this.nmecTutorAluno);
            this.Controls.Add(this.idCursoAluno);
            this.Controls.Add(this.idBibliotecaAluno);
            this.Controls.Add(this.idHorarioAluno);
            this.Controls.Add(this.nmecAluno);
            this.Controls.Add(this.emailAluno);
            this.Controls.Add(this.listAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeAluno);
            this.Name = "FormAluno";
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.FormAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nomeAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAluno;
        private System.Windows.Forms.TextBox emailAluno;
        private System.Windows.Forms.TextBox nmecAluno;
        private System.Windows.Forms.TextBox idHorarioAluno;
        private System.Windows.Forms.TextBox idBibliotecaAluno;
        private System.Windows.Forms.TextBox idCursoAluno;
        private System.Windows.Forms.TextBox nmecTutorAluno;
        private System.Windows.Forms.TextBox idadeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTurma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBoxAluno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button adicionarBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.TextBox passAluno;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button confirmBtn2;
        private System.Windows.Forms.ComboBox regimeEstudoAluno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxDep;
    }
}