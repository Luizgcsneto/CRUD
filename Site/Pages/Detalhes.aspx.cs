using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnPesquisarCliente(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL d = new PessoaDAL();
                Pessoa p = d.PesquisarPorCodigo(Codigo);

                if (p != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                    txtEndereco.Text = p.Endereco;
                    txtEmail.Text = p.Email;
                }
                else
                {

                    lblMensagem.Text = "Cliente não cadastrado.";

                    txtCodigo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluirCliente(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                Pessoa pessoa = new Pessoa();
                PessoaDAL pessoaDal = new PessoaDAL();
                pessoaDal.Excluir(Codigo);

                lblMensagem.Text = "Cliente Excluído com sucesso";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtualizarCliente(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa();

                pessoa.Codigo = Convert.ToInt32(txtCodigo.Text);
                pessoa.Nome = Convert.ToString(txtNome.Text);
                pessoa.Endereco = Convert.ToString(txtEndereco.Text);
                pessoa.Email = Convert.ToString(txtEmail.Text);

                PessoaDAL pessoaDal = new PessoaDAL();

                pessoaDal.Atualizar(pessoa);

                lblMensagem.Text = "Cadastro atualizado com sucesso";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}