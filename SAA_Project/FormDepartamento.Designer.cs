namespace SAA_Project
{
    partial class FormDepartamento
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
            this.listDepartamento = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeDep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idDep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.localizacaoDep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listDepartamento
            // 
            this.listDepartamento.FormattingEnabled = true;
            this.listDepartamento.Location = new System.Drawing.Point(34, 27);
            this.listDepartamento.Name = "listDepartamento";
            this.listDepartamento.Size = new System.Drawing.Size(258, 368);
            this.listDepartamento.TabIndex = 4;
            this.listDepartamento.SelectedIndexChanged += new System.EventHandler(this.listDepartamento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // nomeDep
            // 
            this.nomeDep.Location = new System.Drawing.Point(449, 152);
            this.nomeDep.Name = "nomeDep";
            this.nomeDep.ReadOnly = true;
            this.nomeDep.Size = new System.Drawing.Size(155, 20);
            this.nomeDep.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // idDep
            // 
            this.idDep.Location = new System.Drawing.Point(449, 80);
            this.idDep.Name = "idDep";
            this.idDep.ReadOnly = true;
            this.idDep.Size = new System.Drawing.Size(155, 20);
            this.idDep.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Localização";
            // 
            // localizacaoDep
            // 
            this.localizacaoDep.Location = new System.Drawing.Point(449, 236);
            this.localizacaoDep.Name = "localizacaoDep";
            this.localizacaoDep.ReadOnly = true;
            this.localizacaoDep.Size = new System.Drawing.Size(155, 20);
            this.localizacaoDep.TabIndex = 9;
            // 
            // FormDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.localizacaoDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idDep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeDep);
            this.Controls.Add(this.listDepartamento);
            this.Name = "FormDepartamento";
            this.Text = "FormDepartamento";
            this.Load += new System.EventHandler(this.FormDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox localizacaoDep;
    }
}