using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL.Model;

namespace DAL.Persistence
{
    public class PessoaDAL : Conexao
    {
        public void Gravar(Pessoa pessoa)
        {
			try
			{
				AbrirConexao();
				Cmd = new SqlCommand("insert into Pessoa(Nome, Endereco, Email) values (@v1, @v2, @v3)", Con);

				Cmd.Parameters.AddWithValue("@v1", pessoa.Nome);
				Cmd.Parameters.AddWithValue("@v2", pessoa.Endereco);
				Cmd.Parameters.AddWithValue("@v3", pessoa.Email);

				Cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{

				throw new Exception("Erro ao gravar a pessoa:" + ex.Message);
			}
			finally
			{
				FecharConexao();
			}
        }

		public void Atualizar(Pessoa pessoa)
		{
			try
			{
				AbrirConexao();

			}
			catch (Exception ex)
			{

				throw new Exception("Erro ao atualizar a pessoa: "+ ex.Message);
			}
			finally
			{
				FecharConexao();
			}
		}

    }
}
