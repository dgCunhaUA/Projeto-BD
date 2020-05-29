namespace SAA_Project
{
    partial class FormRegistos
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
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.n_Alunos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelRegistos = new System.Windows.Forms.Label();
            this.listAlunos = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.comboBoxCurso = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxTurma = new System.Windows.Forms.ComboBox();
            this.listRegistos = new System.Windows.Forms.ListBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelHorario = new System.Windows.Forms.Label();
            this.labelNMEC = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.idCursoAluno = new System.Windows.Forms.TextBox();
            this.idHorarioAluno = new System.Windows.Forms.TextBox();
            this.nmecAluno = new System.Windows.Forms.TextBox();
            this.emailAluno = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.nomeAluno = new System.Windows.Forms.TextBox();
            this.confirmBtn2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_uc_nota = new System.Windows.Forms.TextBox();
            this.nota_Nota = new System.Windows.Forms.TextBox();
            this.NMEC_nota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id_uc_Registo = new System.Windows.Forms.TextBox();
            this.id_Aval_Registo = new System.Windows.Forms.TextBox();
            this.nmecRegisto = new System.Windows.Forms.TextBox();
            this.id_registo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11F);
            this.button1.Location = new System.Drawing.Point(731, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 26);
            this.button1.TabIndex = 96;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(130, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 152;
            this.label8.Text = "Numero de Alunos:";
            // 
            // n_Alunos
            // 
            this.n_Alunos.Location = new System.Drawing.Point(246, 269);
            this.n_Alunos.Name = "n_Alunos";
            this.n_Alunos.ReadOnly = true;
            this.n_Alunos.Size = new System.Drawing.Size(46, 20);
            this.n_Alunos.TabIndex = 151;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 7F);
            this.label15.Location = new System.Drawing.Point(167, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 150;
            this.label15.Text = "Nome";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 7F);
            this.label16.Location = new System.Drawing.Point(111, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 149;
            this.label16.Text = "NMEC";
            // 
            // labelRegistos
            // 
            this.labelRegistos.AutoSize = true;
            this.labelRegistos.Font = new System.Drawing.Font("Arial", 14F);
            this.labelRegistos.Location = new System.Drawing.Point(12, 12);
            this.labelRegistos.Name = "labelRegistos";
            this.labelRegistos.Size = new System.Drawing.Size(131, 22);
            this.labelRegistos.TabIndex = 148;
            this.labelRegistos.Text = "Lista Registos";
            // 
            // listAlunos
            // 
            this.listAlunos.FormattingEnabled = true;
            this.listAlunos.Location = new System.Drawing.Point(114, 69);
            this.listAlunos.Name = "listAlunos";
            this.listAlunos.Size = new System.Drawing.Size(213, 199);
            this.listAlunos.TabIndex = 147;
            this.listAlunos.SelectedIndexChanged += new System.EventHandler(this.listAluno_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F);
            this.label14.Location = new System.Drawing.Point(5, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 16);
            this.label14.TabIndex = 158;
            this.label14.Text = "Departamento";
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(8, 79);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(91, 21);
            this.comboBoxDep.TabIndex = 157;
            // 
            // comboBoxCurso
            // 
            this.comboBoxCurso.FormattingEnabled = true;
            this.comboBoxCurso.Location = new System.Drawing.Point(8, 136);
            this.comboBoxCurso.Name = "comboBoxCurso";
            this.comboBoxCurso.Size = new System.Drawing.Size(91, 21);
            this.comboBoxCurso.TabIndex = 156;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F);
            this.label13.Location = new System.Drawing.Point(5, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 16);
            this.label13.TabIndex = 155;
            this.label13.Text = "Curso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(5, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 154;
            this.label10.Text = "ID Turma";
            // 
            // comboBoxTurma
            // 
            this.comboBoxTurma.FormattingEnabled = true;
            this.comboBoxTurma.Location = new System.Drawing.Point(8, 194);
            this.comboBoxTurma.Name = "comboBoxTurma";
            this.comboBoxTurma.Size = new System.Drawing.Size(91, 21);
            this.comboBoxTurma.TabIndex = 153;
            // 
            // listRegistos
            // 
            this.listRegistos.FormattingEnabled = true;
            this.listRegistos.Location = new System.Drawing.Point(333, 69);
            this.listRegistos.Name = "listRegistos";
            this.listRegistos.Size = new System.Drawing.Size(75, 199);
            this.listRegistos.TabIndex = 159;
            this.listRegistos.SelectedIndexChanged += new System.EventHandler(this.listRegistos_SelectedIndexChanged);
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Location = new System.Drawing.Point(129, 395);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(34, 13);
            this.labelCurso.TabIndex = 175;
            this.labelCurso.Text = "Curso";
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Location = new System.Drawing.Point(179, 393);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(41, 13);
            this.labelHorario.TabIndex = 173;
            this.labelHorario.Text = "Horario";
            // 
            // labelNMEC
            // 
            this.labelNMEC.AutoSize = true;
            this.labelNMEC.Location = new System.Drawing.Point(236, 395);
            this.labelNMEC.Name = "labelNMEC";
            this.labelNMEC.Size = new System.Drawing.Size(38, 13);
            this.labelNMEC.TabIndex = 172;
            this.labelNMEC.Text = "NMEC";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(130, 354);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 171;
            this.labelEmail.Text = "Email";
            // 
            // idCursoAluno
            // 
            this.idCursoAluno.Location = new System.Drawing.Point(132, 411);
            this.idCursoAluno.Name = "idCursoAluno";
            this.idCursoAluno.ReadOnly = true;
            this.idCursoAluno.Size = new System.Drawing.Size(45, 20);
            this.idCursoAluno.TabIndex = 166;
            // 
            // idHorarioAluno
            // 
            this.idHorarioAluno.Location = new System.Drawing.Point(183, 411);
            this.idHorarioAluno.Name = "idHorarioAluno";
            this.idHorarioAluno.ReadOnly = true;
            this.idHorarioAluno.Size = new System.Drawing.Size(50, 20);
            this.idHorarioAluno.TabIndex = 164;
            // 
            // nmecAluno
            // 
            this.nmecAluno.Location = new System.Drawing.Point(239, 411);
            this.nmecAluno.Name = "nmecAluno";
            this.nmecAluno.ReadOnly = true;
            this.nmecAluno.Size = new System.Drawing.Size(56, 20);
            this.nmecAluno.TabIndex = 163;
            // 
            // emailAluno
            // 
            this.emailAluno.Location = new System.Drawing.Point(133, 370);
            this.emailAluno.Name = "emailAluno";
            this.emailAluno.ReadOnly = true;
            this.emailAluno.Size = new System.Drawing.Size(162, 20);
            this.emailAluno.TabIndex = 162;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(130, 307);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(47, 17);
            this.labelNome.TabIndex = 161;
            this.labelNome.Text = "Nome";
            // 
            // nomeAluno
            // 
            this.nomeAluno.Location = new System.Drawing.Point(133, 327);
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            this.nomeAluno.Size = new System.Drawing.Size(162, 20);
            this.nomeAluno.TabIndex = 160;
            // 
            // confirmBtn2
            // 
            this.confirmBtn2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn2.Location = new System.Drawing.Point(438, 327);
            this.confirmBtn2.Name = "confirmBtn2";
            this.confirmBtn2.Size = new System.Drawing.Size(90, 28);
            this.confirmBtn2.TabIndex = 176;
            this.confirmBtn2.Text = "Adicionar Nota";
            this.confirmBtn2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(438, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 177;
            this.button2.Text = "Adicionar Falta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 183;
            this.label1.Text = "ID UC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 182;
            this.label2.Text = "Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 181;
            this.label3.Text = "NMEC";
            // 
            // id_uc_nota
            // 
            this.id_uc_nota.Location = new System.Drawing.Point(609, 331);
            this.id_uc_nota.Name = "id_uc_nota";
            this.id_uc_nota.ReadOnly = true;
            this.id_uc_nota.Size = new System.Drawing.Size(45, 20);
            this.id_uc_nota.TabIndex = 180;
            // 
            // nota_Nota
            // 
            this.nota_Nota.Location = new System.Drawing.Point(660, 331);
            this.nota_Nota.Name = "nota_Nota";
            this.nota_Nota.ReadOnly = true;
            this.nota_Nota.Size = new System.Drawing.Size(50, 20);
            this.nota_Nota.TabIndex = 179;
            // 
            // NMEC_nota
            // 
            this.NMEC_nota.Location = new System.Drawing.Point(547, 331);
            this.NMEC_nota.Name = "NMEC_nota";
            this.NMEC_nota.ReadOnly = true;
            this.NMEC_nota.Size = new System.Drawing.Size(56, 20);
            this.NMEC_nota.TabIndex = 178;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7F);
            this.label4.Location = new System.Drawing.Point(330, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 184;
            this.label4.Text = "Registos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 192;
            this.label5.Text = "ID_UC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 191;
            this.label6.Text = "ID_Aval";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 190;
            this.label7.Text = "NMEC";
            // 
            // id_uc_Registo
            // 
            this.id_uc_Registo.Location = new System.Drawing.Point(426, 155);
            this.id_uc_Registo.Name = "id_uc_Registo";
            this.id_uc_Registo.ReadOnly = true;
            this.id_uc_Registo.Size = new System.Drawing.Size(56, 20);
            this.id_uc_Registo.TabIndex = 188;
            // 
            // id_Aval_Registo
            // 
            this.id_Aval_Registo.Location = new System.Drawing.Point(502, 114);
            this.id_Aval_Registo.Name = "id_Aval_Registo";
            this.id_Aval_Registo.ReadOnly = true;
            this.id_Aval_Registo.Size = new System.Drawing.Size(50, 20);
            this.id_Aval_Registo.TabIndex = 187;
            // 
            // nmecRegisto
            // 
            this.nmecRegisto.Location = new System.Drawing.Point(426, 114);
            this.nmecRegisto.Name = "nmecRegisto";
            this.nmecRegisto.ReadOnly = true;
            this.nmecRegisto.Size = new System.Drawing.Size(56, 20);
            this.nmecRegisto.TabIndex = 186;
            // 
            // id_registo
            // 
            this.id_registo.Location = new System.Drawing.Point(426, 69);
            this.id_registo.Name = "id_registo";
            this.id_registo.ReadOnly = true;
            this.id_registo.Size = new System.Drawing.Size(126, 20);
            this.id_registo.TabIndex = 185;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(423, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 193;
            this.label11.Text = "ID Registo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7F);
            this.label9.Location = new System.Drawing.Point(110, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 194;
            this.label9.Text = "Alunos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 7F);
            this.label12.Location = new System.Drawing.Point(330, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 195;
            this.label12.Text = "ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 7F);
            this.label17.Location = new System.Drawing.Point(372, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 13);
            this.label17.TabIndex = 196;
            this.label17.Text = "UC";
            // 
            // FormRegistos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.id_uc_Registo);
            this.Controls.Add(this.id_Aval_Registo);
            this.Controls.Add(this.nmecRegisto);
            this.Controls.Add(this.id_registo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_uc_nota);
            this.Controls.Add(this.nota_Nota);
            this.Controls.Add(this.NMEC_nota);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.confirmBtn2);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.labelNMEC);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.idCursoAluno);
            this.Controls.Add(this.idHorarioAluno);
            this.Controls.Add(this.nmecAluno);
            this.Controls.Add(this.emailAluno);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.nomeAluno);
            this.Controls.Add(this.listRegistos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxDep);
            this.Controls.Add(this.comboBoxCurso);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxTurma);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.n_Alunos);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelRegistos);
            this.Controls.Add(this.listAlunos);
            this.Controls.Add(this.button1);
            this.Name = "FormRegistos";
            this.Text = "FormRegistos";
            this.Load += new System.EventHandler(this.FormRegistos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox n_Alunos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelRegistos;
        private System.Windows.Forms.ListBox listAlunos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.ComboBox comboBoxCurso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxTurma;
        private System.Windows.Forms.ListBox listRegistos;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.Label labelNMEC;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox idCursoAluno;
        private System.Windows.Forms.TextBox idHorarioAluno;
        private System.Windows.Forms.TextBox nmecAluno;
        private System.Windows.Forms.TextBox emailAluno;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox nomeAluno;
        private System.Windows.Forms.Button confirmBtn2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_uc_nota;
        private System.Windows.Forms.TextBox nota_Nota;
        private System.Windows.Forms.TextBox NMEC_nota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox id_uc_Registo;
        private System.Windows.Forms.TextBox id_Aval_Registo;
        private System.Windows.Forms.TextBox nmecRegisto;
        private System.Windows.Forms.TextBox id_registo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
    }
}