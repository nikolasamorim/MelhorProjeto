

namespace _3C1NIKOLAS31.Code.DTO
{
    internal class MProjetoDTO
    {
        private string _cpf;
        private string _nome;
        private string _email;
        private string _senha;
        private string _rg;
        private string _datanascimento;
        private string _rua;
        private string _numero;
        private string _cidade;
        private string _estado;
        private string _pais;
        private string _bairro;
        private string _telefone;

        public string cpf { get => _cpf; set => _cpf = value; }
        public string nome { get => _nome; set => _nome = value; }
        public string email { get => _email; set => _email = value; }
        public string senha { get => _senha; set => _senha = value; }
        public string rg { get => _rg; set => _rg = value; }
        public string datanascimento { get => _datanascimento; set => _datanascimento = value; }
        public string rua { get => _rua; set => _rua = value; }
        public string numero { get => _numero; set => _numero = value; }
        public string cidade { get => _cidade; set => _cidade = value; }
        public string estado { get => _estado; set => _estado = value; }
        public string pais { get => _pais; set => _pais = value; }
        public string bairro { get => _bairro; set => _bairro = value; }
        public string telefone { get => _telefone; set => _telefone = value; }
    }

    internal class MProjetodadosDTO
    {
        private string _id;
        private string _ngca;
        private string _n02;
        private string _a01;

        public string id { get => _id; set => _id = value; }
        public string ngca { get => _ngca; set => _ngca = value; }
        public string n02 { get => _n02; set => _n02 = value; }
        public string a01 { get => _a01; set => _a01 = value; }
    }
}
