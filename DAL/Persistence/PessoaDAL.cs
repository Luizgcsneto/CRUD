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
			}
			catch (Exception ex)
			{

				throw;
			}
			finally
			{
				FecharConexao();
			}
        }
    }
}
