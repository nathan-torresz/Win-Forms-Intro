using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_Forms_1
{
    class Funcionario
    {
        private  string _nome;
        private string _cpf;
        private string _telefone;
        private string _email;
        private  string _senha;
        private string _cargo;

        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Cargo { get => _cargo; set => _cargo = value; }

        public Funcionario(string nome, string cpf, string telefone, string email, string senha, string cargo)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            Cargo = cargo;
        }

    }
}
