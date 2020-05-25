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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listAluno = new System.Windows.Forms.ListBox();
            this.emailAluno = new System.Windows.Forms.TextBox();
            this.regimeEstudoAluno = new System.Windows.Forms.TextBox();
            this.nmecAluno = new System.Windows.Forms.TextBox();
            this.idHorarioAluno = new System.Windows.Forms.TextBox();
            this.idBibliotecaAluno = new System.Windows.Forms.TextBox();
            this.idSecretariaAluno = new System.Windows.Forms.TextBox();
            this.idCursoAluno = new System.Windows.Forms.TextBox();
            this.nmecTutorAluno = new System.Windows.Forms.TextBox();
            this.idadeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.voltarAoMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.uCToolStripMenuItem,
            this.toolStripSeparator1,
            this.voltarAoMenuToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // uCToolStripMenuItem
            // 
            this.uCToolStripMenuItem.Name = "uCToolStripMenuItem";
            this.uCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uCToolStripMenuItem.Text = "UC";
            // 
            // nomeAluno
            // 
            this.nomeAluno.Location = new System.Drawing.Point(373, 43);
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            this.nomeAluno.Size = new System.Drawing.Size(155, 20);
            this.nomeAluno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // listAluno
            // 
            this.listAluno.FormattingEnabled = true;
            this.listAluno.Location = new System.Drawing.Point(12, 43);
            this.listAluno.Name = "listAluno";
            this.listAluno.Size = new System.Drawing.Size(245, 368);
            this.listAluno.TabIndex = 3;
            this.listAluno.SelectedIndexChanged += new System.EventHandler(this.listAluno_SelectedIndexChanged);
            // 
            // emailAluno
            // 
            this.emailAluno.Location = new System.Drawing.Point(373, 82);
            this.emailAluno.Name = "emailAluno";
            this.emailAluno.ReadOnly = true;
            this.emailAluno.Size = new System.Drawing.Size(155, 20);
            this.emailAluno.TabIndex = 4;
            // 
            // regimeEstudoAluno
            // 
            this.regimeEstudoAluno.Location = new System.Drawing.Point(373, 124);
            this.regimeEstudoAluno.Name = "regimeEstudoAluno";
            this.regimeEstudoAluno.ReadOnly = true;
            this.regimeEstudoAluno.Size = new System.Drawing.Size(155, 20);
            this.regimeEstudoAluno.TabIndex = 5;
            // 
            // nmecAluno
            // 
            this.nmecAluno.Location = new System.Drawing.Point(373, 165);
            this.nmecAluno.Name = "nmecAluno";
            this.nmecAluno.ReadOnly = true;
            this.nmecAluno.Size = new System.Drawing.Size(155, 20);
            this.nmecAluno.TabIndex = 6;
            // 
            // idHorarioAluno
            // 
            this.idHorarioAluno.Location = new System.Drawing.Point(373, 210);
            this.idHorarioAluno.Name = "idHorarioAluno";
            this.idHorarioAluno.ReadOnly = true;
            this.idHorarioAluno.Size = new System.Drawing.Size(155, 20);
            this.idHorarioAluno.TabIndex = 7;
            // 
            // idBibliotecaAluno
            // 
            this.idBibliotecaAluno.Location = new System.Drawing.Point(373, 254);
            this.idBibliotecaAluno.Name = "idBibliotecaAluno";
            this.idBibliotecaAluno.ReadOnly = true;
            this.idBibliotecaAluno.Size = new System.Drawing.Size(155, 20);
            this.idBibliotecaAluno.TabIndex = 8;
            // 
            // idSecretariaAluno
            // 
            this.idSecretariaAluno.Location = new System.Drawing.Point(373, 295);
            this.idSecretariaAluno.Name = "idSecretariaAluno";
            this.idSecretariaAluno.ReadOnly = true;
            this.idSecretariaAluno.Size = new System.Drawing.Size(155, 20);
            this.idSecretariaAluno.TabIndex = 9;
            // 
            // idCursoAluno
            // 
            this.idCursoAluno.Location = new System.Drawing.Point(373, 338);
            this.idCursoAluno.Name = "idCursoAluno";
            this.idCursoAluno.ReadOnly = true;
            this.idCursoAluno.Size = new System.Drawing.Size(155, 20);
            this.idCursoAluno.TabIndex = 10;
            // 
            // nmecTutorAluno
            // 
            this.nmecTutorAluno.Location = new System.Drawing.Point(644, 46);
            this.nmecTutorAluno.Name = "nmecTutorAluno";
            this.nmecTutorAluno.ReadOnly = true;
            this.nmecTutorAluno.Size = new System.Drawing.Size(130, 20);
            this.nmecTutorAluno.TabIndex = 11;
            // 
            // idadeAluno
            // 
            this.idadeAluno.Location = new System.Drawing.Point(644, 85);
            this.idadeAluno.Name = "idadeAluno";
            this.idadeAluno.ReadOnly = true;
            this.idadeAluno.Size = new System.Drawing.Size(130, 20);
            this.idadeAluno.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Regime Estudo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "NMEC Tutor";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // voltarAoMenuToolStripMenuItem
            // 
            this.voltarAoMenuToolStripMenuItem.Name = "voltarAoMenuToolStripMenuItem";
            this.voltarAoMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voltarAoMenuToolStripMenuItem.Text = "Voltar ao Menu";
            this.voltarAoMenuToolStripMenuItem.Click += new System.EventHandler(this.voltarAoMenuToolStripMenuItem_Click);
            // 
            // FormAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idadeAluno);
            this.Controls.Add(this.nmecTutorAluno);
            this.Controls.Add(this.idCursoAluno);
            this.Controls.Add(this.idSecretariaAluno);
            this.Controls.Add(this.idBibliotecaAluno);
            this.Controls.Add(this.idHorarioAluno);
            this.Controls.Add(this.nmecAluno);
            this.Controls.Add(this.regimeEstudoAluno);
            this.Controls.Add(this.emailAluno);
            this.Controls.Add(this.listAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeAluno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAluno";
            this.Text = "Aluno";
            this.Load += new System.EventHandler(this.FormAluno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uCToolStripMenuItem;
        private System.Windows.Forms.TextBox nomeAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listAluno;
        private System.Windows.Forms.TextBox emailAluno;
        private System.Windows.Forms.TextBox regimeEstudoAluno;
        private System.Windows.Forms.TextBox nmecAluno;
        private System.Windows.Forms.TextBox idHorarioAluno;
        private System.Windows.Forms.TextBox idBibliotecaAluno;
        private System.Windows.Forms.TextBox idSecretariaAluno;
        private System.Windows.Forms.TextBox idCursoAluno;
        private System.Windows.Forms.TextBox nmecTutorAluno;
        private System.Windows.Forms.TextBox idadeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem voltarAoMenuToolStripMenuItem;
    }
}