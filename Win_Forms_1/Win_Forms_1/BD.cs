using System.Data.SqlClient;

namespace Win_Forms_1
{
    class BD
    {
        private static SqlConnection conexao = new SqlConnection();
        private static SqlCommand sql = new SqlCommand();

        private static SqlDataAdapter Inicializar()
        {
            conexao.ConnectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=CadastroFuncionário;Integrated Security=True";
            sql.Connection = conexao;
            SqlDataAdapter adapt = new SqlDataAdapter(sql.CommandText, conexao);
            return adapt;
        }
        public static int Executar(out SqlDataAdapter adapt)
        {
            adapt = Inicializar();
            int i = 0;
            conexao.Open();
            i = sql.ExecuteNonQuery();
            conexao.Close();
            return i;
        }
        public static int Executar()
        {
            return Executar(out SqlDataAdapter adapt);
        }
        public static int InserirFuncionario(Funcionario f)
        {
            sql = new SqlCommand();
            sql.CommandText = "INSERT INTO Usuario (Nome, Cpf, Telefone, Email, Senha, Cargo) VALUES (@nome, @cpf, @telefone, @email, @senha, @cargo)";
            sql.Parameters.AddWithValue("@nome", f.Nome);
            sql.Parameters.AddWithValue("@cpf", f.Cpf);
            sql.Parameters.AddWithValue("@telefone", f.Telefone);
            sql.Parameters.AddWithValue("@email", f.Email);
            sql.Parameters.AddWithValue("@senha", f.Senha);
            sql.Parameters.AddWithValue("@cargo", f.Cargo);
            int linhasAfetadas = Executar();
            return linhasAfetadas;
        }
        public static int InserirProduto(Produto p)
        {
            sql = new SqlCommand();
            sql.CommandText = $"INSERT INTO Estoque (Numero, Nome_Produto, Marca_Produto, Descricao, Preco) " +
                $"VALUES ('{p.NumeroProduto}','{p.NomeProduto}','{p.MarcaProduto}','{p.DescricaoProduto}','{p.PrecoProduto}')";
            int linhasAfetadas = Executar();
            return linhasAfetadas;
        }

        public static SqlDataAdapter SelectProdutosExceptID()
        {
            sql = new SqlCommand();
            sql.CommandText = $"SELECT Numero, Nome_Produto, Marca_Produto, Descricao, Preco FROM Estoque";
            int linhasAfetadas = Executar(out SqlDataAdapter adapt);
            return adapt;
        }
        public static SqlDataAdapter SelectNumeroNomeProdutos()
        {
            sql = new SqlCommand();
            sql.CommandText = $"SELECT Numero, Nome_Produto FROM Estoque";
            int linhasAfetadas = Executar(out SqlDataAdapter adapt);
            return adapt;
        }

        public static SqlDataAdapter Logar(string usuario, string senha)
        {
            sql = new SqlCommand();
            sql.CommandText = $"SELECT Nome, Senha, Cargo FROM Usuario " +
                $"WHERE Nome= '{usuario}' AND Senha= '{senha}' AND Cargo= 'Vendedor'";
            int linhasAfetadas = Executar(out SqlDataAdapter adapt);
            return adapt;
        }
    }
}
    

