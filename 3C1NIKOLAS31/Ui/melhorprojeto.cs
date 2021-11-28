using System;
using System.Windows.Forms;
using _3C1NIKOLAS31.Code.BLL;
using _3C1NIKOLAS31.Code.DTO;
namespace _3C1NIKOLAS31.Ui
{
    public partial class melhorprojeto : Form
    {
        MProjetoBLL MProjetobll = new MProjetoBLL();
        MProjetoDTO MProjetodto = new MProjetoDTO();
        MProjetodadosDTO MProjetodadosdto = new MProjetodadosDTO();
        MProjetodadosBLL MProjetodadosbll = new MProjetodadosBLL();
        public melhorprojeto()
        {
            InitializeComponent();
            dgtlista.DataSource = MProjetobll.Listar();
            dgtlistadados.DataSource = MProjetodadosbll.Listar();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            MProjetodto.cpf = txtcpf.Text;
            MProjetodto.nome = txtnome.Text;
            MProjetodto.email = txtemail.Text;
            MProjetodto.senha = txtsenha.Text;
            MProjetodto.rg = txtrg.Text;
            MProjetodto.datanascimento = txtdata.Text;
            MProjetodto.rua = txtrua.Text;
            MProjetodto.numero = txtnumero.Text;
            MProjetodto.cidade = txtcidade.Text;
            MProjetodto.estado = txtestado.Text;
            MProjetodto.pais = txtpais.Text;
            MProjetodto.bairro = txtbairro.Text;
            MProjetodto.telefone = txttelefone.Text;

            MProjetobll.Inserir(MProjetodto);
            dgtlista.DataSource = MProjetobll.Listar();
            MessageBox.Show("Cadastrado!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            MProjetodto.cpf = txtcpf.Text;
            MProjetobll.Excluir(MProjetodto);
            dgtlista.DataSource = MProjetobll.Listar();
            MessageBox.Show("Excluido!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            MProjetodto.cpf = txtcpf.Text;
            MProjetodto.nome = txtnome.Text;
            MProjetodto.email = txtemail.Text;
            MProjetodto.senha = txtsenha.Text;
            MProjetodto.rg = txtrg.Text;
            MProjetodto.datanascimento = txtdata.Text;
            MProjetodto.rua = txtrua.Text;
            MProjetodto.numero = txtnumero.Text;
            MProjetodto.cidade = txtcidade.Text;
            MProjetodto.estado = txtestado.Text;
            MProjetodto.pais = txtpais.Text;
            MProjetodto.bairro = txtbairro.Text;
            MProjetodto.telefone = txttelefone.Text;

            MProjetobll.Editar(MProjetodto);


            MessageBox.Show("Alterado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgtlista.DataSource = MProjetobll.Listar();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void SavassiGames_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgtlista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgtlistadados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cadastrardados_Click(object sender, EventArgs e)
        {
            MProjetodadosdto.id = txtid.Text;
            MProjetodadosdto.ngca = txtngca.Text;
            MProjetodadosdto.n02 = txtn02.Text;
            MProjetodadosdto.a01 = txta01.Text;

            MProjetodadosbll.Inserir(MProjetodadosdto);
            dgtlistadados.DataSource = MProjetodadosbll.Listar();
            MessageBox.Show("Cadastrado!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_editardados_Click(object sender, EventArgs e)
        {
            MProjetodadosdto.id = txtid.Text;
            MProjetodadosdto.ngca = txtngca.Text;
            MProjetodadosdto.n02 = txtn02.Text;
            MProjetodadosdto.a01 = txta01.Text;

            MProjetodadosbll.Editar(MProjetodadosdto);


            MessageBox.Show("Alterado com sucesso!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgtlistadados.DataSource = MProjetodadosbll.Listar();
        }


        private void btn_excluirdados_Click(object sender, EventArgs e)
        {
            MProjetodadosdto.id = txtid.Text;

            MProjetodadosbll.Excluir(MProjetodadosdto);
            dgtlistadados.DataSource = MProjetodadosbll.Listar();
            MessageBox.Show("Excluido!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

