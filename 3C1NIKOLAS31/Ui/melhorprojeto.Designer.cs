namespace _3C1NIKOLAS31.Ui
{
    partial class melhorprojeto
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
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.dgtlista = new System.Windows.Forms.DataGridView();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgtlistadados = new System.Windows.Forms.DataGridView();
            this.btn_editardados = new System.Windows.Forms.Button();
            this.btn_excluirdados = new System.Windows.Forms.Button();
            this.btn_cadastrardados = new System.Windows.Forms.Button();
            this.txtngca = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.ngca = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.txta01 = new System.Windows.Forms.TextBox();
            this.txtn02 = new System.Windows.Forms.TextBox();
            this.a01 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtlistadados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(163, 159);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(153, 43);
            this.btn_editar.TabIndex = 39;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(321, 159);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(157, 43);
            this.btn_excluir.TabIndex = 38;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(44, 30);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(110, 20);
            this.txtcpf.TabIndex = 37;
            this.txtcpf.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "CPF:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(3, 159);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(157, 43);
            this.btn_cadastrar.TabIndex = 35;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // dgtlista
            // 
            this.dgtlista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgtlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtlista.Location = new System.Drawing.Point(3, 208);
            this.dgtlista.Name = "dgtlista";
            this.dgtlista.Size = new System.Drawing.Size(475, 230);
            this.dgtlista.TabIndex = 34;
            this.dgtlista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtlista_CellContentClick);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(368, 30);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(110, 20);
            this.txtemail.TabIndex = 33;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(204, 30);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(110, 20);
            this.txtnome.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(327, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Email:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(160, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(44, 56);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(110, 20);
            this.txtsenha.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Senha:";
            // 
            // txtrg
            // 
            this.txtrg.Location = new System.Drawing.Point(204, 56);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(110, 20);
            this.txtrg.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(318, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Data(nasc):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(160, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Rg:";
            // 
            // txtrua
            // 
            this.txtrua.Location = new System.Drawing.Point(44, 82);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(110, 20);
            this.txtrua.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Rua:";
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(368, 82);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(110, 20);
            this.txtcidade.TabIndex = 49;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(204, 82);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(110, 20);
            this.txtnumero.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(327, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(160, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Número:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(8, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Telefone:";
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(59, 133);
            this.txttelefone.Mask = "0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(95, 20);
            this.txttelefone.TabIndex = 54;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(377, 56);
            this.txtdata.Mask = "0000/00/00";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(101, 20);
            this.txtdata.TabIndex = 55;
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(44, 108);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(110, 20);
            this.txtestado.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(8, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Estado:";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(368, 108);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(110, 20);
            this.txtbairro.TabIndex = 59;
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(204, 108);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(110, 20);
            this.txtpais.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(327, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Bairro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(160, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Pais:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(484, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 443);
            this.dataGridView1.TabIndex = 62;
            // 
            // dgtlistadados
            // 
            this.dgtlistadados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgtlistadados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtlistadados.Location = new System.Drawing.Point(496, 208);
            this.dgtlistadados.Name = "dgtlistadados";
            this.dgtlistadados.Size = new System.Drawing.Size(292, 230);
            this.dgtlistadados.TabIndex = 63;
            this.dgtlistadados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtlistadados_CellContentClick);
            // 
            // btn_editardados
            // 
            this.btn_editardados.Location = new System.Drawing.Point(597, 159);
            this.btn_editardados.Name = "btn_editardados";
            this.btn_editardados.Size = new System.Drawing.Size(91, 43);
            this.btn_editardados.TabIndex = 66;
            this.btn_editardados.Text = "Editar";
            this.btn_editardados.UseVisualStyleBackColor = true;
            this.btn_editardados.Click += new System.EventHandler(this.btn_editardados_Click);
            // 
            // btn_excluirdados
            // 
            this.btn_excluirdados.Location = new System.Drawing.Point(693, 159);
            this.btn_excluirdados.Name = "btn_excluirdados";
            this.btn_excluirdados.Size = new System.Drawing.Size(95, 43);
            this.btn_excluirdados.TabIndex = 65;
            this.btn_excluirdados.Text = "Excluir";
            this.btn_excluirdados.UseVisualStyleBackColor = true;
            this.btn_excluirdados.Click += new System.EventHandler(this.btn_excluirdados_Click);
            // 
            // btn_cadastrardados
            // 
            this.btn_cadastrardados.Location = new System.Drawing.Point(496, 159);
            this.btn_cadastrardados.Name = "btn_cadastrardados";
            this.btn_cadastrardados.Size = new System.Drawing.Size(95, 43);
            this.btn_cadastrardados.TabIndex = 64;
            this.btn_cadastrardados.Text = "Cadastrar";
            this.btn_cadastrardados.UseVisualStyleBackColor = true;
            this.btn_cadastrardados.Click += new System.EventHandler(this.btn_cadastrardados_Click);
            // 
            // txtngca
            // 
            this.txtngca.Location = new System.Drawing.Point(678, 69);
            this.txtngca.Name = "txtngca";
            this.txtngca.Size = new System.Drawing.Size(110, 20);
            this.txtngca.TabIndex = 70;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(529, 69);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(110, 20);
            this.txtid.TabIndex = 69;
            // 
            // ngca
            // 
            this.ngca.AutoSize = true;
            this.ngca.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ngca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ngca.Location = new System.Drawing.Point(645, 72);
            this.ngca.Name = "ngca";
            this.ngca.Size = new System.Drawing.Size(36, 13);
            this.ngca.TabIndex = 68;
            this.ngca.Text = "Ngca:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id.Location = new System.Drawing.Point(493, 72);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(19, 13);
            this.id.TabIndex = 67;
            this.id.Text = "Id:";
            // 
            // txta01
            // 
            this.txta01.Location = new System.Drawing.Point(678, 104);
            this.txta01.Name = "txta01";
            this.txta01.Size = new System.Drawing.Size(110, 20);
            this.txta01.TabIndex = 74;
            // 
            // txtn02
            // 
            this.txtn02.Location = new System.Drawing.Point(529, 104);
            this.txtn02.Name = "txtn02";
            this.txtn02.Size = new System.Drawing.Size(110, 20);
            this.txtn02.TabIndex = 73;
            // 
            // a01
            // 
            this.a01.AutoSize = true;
            this.a01.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.a01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.a01.Location = new System.Drawing.Point(645, 107);
            this.a01.Name = "a01";
            this.a01.Size = new System.Drawing.Size(26, 13);
            this.a01.TabIndex = 72;
            this.a01.Text = "A01";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(493, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 71;
            this.label17.Text = "N02";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(616, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 75;
            this.label18.Text = "Dados";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(220, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 76;
            this.label19.Text = "Usuários";
            // 
            // melhorprojeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txta01);
            this.Controls.Add(this.txtn02);
            this.Controls.Add(this.a01);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtngca);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.ngca);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btn_editardados);
            this.Controls.Add(this.btn_excluirdados);
            this.Controls.Add(this.btn_cadastrardados);
            this.Controls.Add(this.dgtlistadados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.dgtlista);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "melhorprojeto";
            this.Text = "Menu - Melhor Projeto da História da minha vida até agora ";
            this.Load += new System.EventHandler(this.SavassiGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtlistadados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.DataGridView dgtlista;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.MaskedTextBox txtdata;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgtlistadados;
        private System.Windows.Forms.Button btn_editardados;
        private System.Windows.Forms.Button btn_excluirdados;
        private System.Windows.Forms.Button btn_cadastrardados;
        private System.Windows.Forms.TextBox txtngca;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label ngca;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txta01;
        private System.Windows.Forms.TextBox txtn02;
        private System.Windows.Forms.Label a01;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}