
using _3C1NIKOLAS31.Code.DTO;
using _3C1NIKOLAS31.Code.DAL;
using System.Data;

namespace _3C1NIKOLAS31.Code.BLL
{
    internal class MProjetoBLL
    {
        Banco bd = new Banco();
        string tabela = "tbl_usuarios";



        public void Inserir(MProjetoDTO MProjetoDTO)
        {

            string inserir = $"insert into {tabela} values('{ MProjetoDTO.cpf}','{ MProjetoDTO.nome}','{ MProjetoDTO.email}','{ MProjetoDTO.senha}'," +
                $"'{ MProjetoDTO.rg}','{ MProjetoDTO.datanascimento}','{ MProjetoDTO.rua}','{ MProjetoDTO.numero}','{ MProjetoDTO.cidade}'," +
                $"'{ MProjetoDTO.estado}','{ MProjetoDTO.pais}','{ MProjetoDTO.bairro}','{ MProjetoDTO.telefone}')";
            bd.ExecutarComando(inserir);
        }


        public void Excluir(MProjetoDTO MProjetoDTO)
        {
            string excluir = $"delete from {tabela} where cpf = '{MProjetoDTO.cpf}';";
            bd.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela}; ";
            return bd.ExecutarConsulta(sql);
        }
        public void Editar(MProjetoDTO MProjetoDTO)
        {
            string alterar = $"update {tabela} set nome = '{ MProjetoDTO.nome}', email = '{MProjetoDTO.email}', senha = '{ MProjetoDTO.senha}'," +
                $" rg = '{ MProjetoDTO.rg}', datanascimento = '{ MProjetoDTO.datanascimento}', rua = '{ MProjetoDTO.rua}', numero = '{ MProjetoDTO.numero}'," +
                $" cidade = '{ MProjetoDTO.cidade}', estado = '{ MProjetoDTO.estado}', pais = '{ MProjetoDTO.pais}', bairro = '{ MProjetoDTO.bairro}', " +
                $" telefone = '{ MProjetoDTO.telefone}' where cpf = '{MProjetoDTO.cpf}';";
            bd.ExecutarComando(alterar);
        }
    }

    internal class MProjetodadosBLL
    {
        Banco bd = new Banco();
        string tabela = "tbl_dados";



        public void Inserir(MProjetodadosDTO MProjetodadosDTO)
        {

            string inserir = $"insert into {tabela} values('{ MProjetodadosDTO.id}','{ MProjetodadosDTO.ngca}'," +
                $"'{ MProjetodadosDTO.n02}', '{ MProjetodadosDTO.a01}')";
            bd.ExecutarComando(inserir);
        }


        public void Excluir(MProjetodadosDTO MProjetodadosDTO)
        {
            string excluir = $"delete from {tabela} where id = '{ MProjetodadosDTO.id}';";
            bd.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela}; ";
            return bd.ExecutarConsulta(sql);
        }
        public void Editar(MProjetodadosDTO MProjetodadosDTO)
        {
            string alterar = $"update {tabela} set id = '{ MProjetodadosDTO.id}', ngca = '{ MProjetodadosDTO.ngca}', " +
                $" n02 = '{ MProjetodadosDTO.n02}', a01 = '{ MProjetodadosDTO.a01}';";
            bd.ExecutarComando(alterar);
        }
    }
}
