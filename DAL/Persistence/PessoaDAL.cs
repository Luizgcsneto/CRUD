﻿using System;
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

				Cmd = new SqlCommand("update Pessoa set Nome=@v1, Endereco=@v2, Email=@v3 where Codigo=@v4", Con);

				Cmd.Parameters.AddWithValue("@v1", pessoa.Nome);
				Cmd.Parameters.AddWithValue("@v2", pessoa.Endereco);
				Cmd.Parameters.AddWithValue("@v3", pessoa.Email);
				Cmd.Parameters.AddWithValue("@v4", pessoa.Codigo);

				Cmd.ExecuteNonQuery();

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

		public void Excluir(int Codigo)
		{
			try
			{
				AbrirConexao();

				Cmd = new SqlCommand("delete from Pessoa where Codigo=@v1", Con);

				Cmd.Parameters.AddWithValue("@v1", Codigo);

				Cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{

				throw new Exception("Erro ao excluir a pessoa." + ex.Message);
			}
			finally
			{
				FecharConexao();
			}
		}
		
		public Pessoa PesquisarPorCodigo(int Codigo)
		{
			try
			{
				AbrirConexao();

				Cmd = new SqlCommand("select * from Pessoa where Codigo=@v1",Con);

				Cmd.Parameters.AddWithValue("@v1", Codigo);

				Dr = Cmd.ExecuteReader();

				Pessoa pessoa = null;

				if (Dr.Read())
				{
					pessoa = new Pessoa();

					pessoa.Codigo    = Convert.ToInt32(Dr["Codigo"]);
					pessoa.Nome      = Convert.ToString(Dr["Nome"]);
					pessoa.Endereco  = Convert.ToString(Dr["Endereco"]);
					pessoa.Email     = Convert.ToString(Dr["Email"]);
				}
				return pessoa;


			}
			catch (Exception ex)
			{

				throw new Exception("Erro ao buscar a pessoa: "+ex.Message);
			}
			finally
			{
				FecharConexao();
			}
		}

		public List<Pessoa> Listar()
		{
			try
			{
				AbrirConexao();

				Cmd = new SqlCommand("select * from Pessoa", Con);

				Dr  = Cmd.ExecuteReader();

				List<Pessoa> Lista = new List<Pessoa>();

				while (Dr.Read())
				{
					Pessoa pessoa = new Pessoa();

					pessoa.Codigo   = Convert.ToInt32(Dr["Codigo"]);
					pessoa.Nome     = Convert.ToString(Dr["Nome"]);
					pessoa.Endereco = Convert.ToString(Dr["Endereco"]);
					pessoa.Email = Convert.ToString(Dr["Email"]);

					Lista.Add(pessoa);
				}

				return Lista;

			}
			catch (Exception ex)
			{

				throw new Exception("Erro ao listar as pessoas: "+ex.Message);
			}
			finally
			{
				FecharConexao();
			}
		}
    }
}
