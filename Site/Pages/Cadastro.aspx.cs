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
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarClientes(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa();

                pessoa.Nome     = txtNome.Text;
                pessoa.Endereco = txtEndereco.Text;
                pessoa.Email    = txtEmail.Text;

                PessoaDAL pessoaDal = new PessoaDAL();

                pessoaDal.Gravar(pessoa);

                lblMensagem.Text = "Cliente " + pessoa.Nome + " cadastrado com Sucesso.";

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