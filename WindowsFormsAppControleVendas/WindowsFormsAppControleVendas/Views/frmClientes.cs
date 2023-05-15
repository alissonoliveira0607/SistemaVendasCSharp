using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppControleVendas.DAO;
using WindowsFormsAppControleVendas.Models;
using System.Globalization;

namespace WindowsFormsAppControleVendas.Views
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            //oculta um botão
            //buttonNovo.Hide();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            //Intanciando um objeto do tipo Cliente para acessar seus atributos e vincular as propriedades do form
            Cliente objCliente = new Cliente();


            //Acessando os atributos do meu objeto do tipo cliente e atribuindo a eles uma propriedade do form
            objCliente.Nome = textBoxNome.Text;
            objCliente.Rg = maskedTextBoxRg.Text;
            objCliente.Cpf = maskedTextBoxCpf.Text;
            objCliente.Email = textBoxEmail.Text;
            objCliente.Telefone = maskedTextBoxTelefone.Text;
            objCliente.Celular = maskedTextBoxCelular.Text;
            objCliente.Cep = maskedTextBoxCep.Text;
            objCliente.Endereco = textBoxEndereco.Text;
            objCliente.Numero = Convert.ToInt32(textBoxNumero.Text);
            objCliente.Complemento = textBoxComplemento.Text;
            objCliente.Bairro = textBoxBairro.Text;
            objCliente.Cidade = textBoxCidade.Text;
            objCliente.Estado = comBoxUf.Text;



            // Instanciando um obj do tipo ClienteDAO que possui a lógica com a execução da query
            ClienteDAO objClienteDAO = new ClienteDAO();

            //Chamando o método IsertCliente e passando meu objCliente que comtempla os atributos de cliente para execução do cadastro
            objClienteDAO.InsertCliente(objCliente);

            //Recarrega o Datagrid View após a operação realizada
            dataGridViewClientes.DataSource = objClienteDAO.SelectCliente();

        }


        //Método responsável pela limpeza dos TextBox's
        private void ClearProperties()
        {
            textBoxCodigo.Text = String.Empty;
            textBoxNome.Text = String.Empty;
            maskedTextBoxRg.Text = String.Empty;
            maskedTextBoxCpf.Text = String.Empty;
            textBoxEmail.Text = String.Empty;
            maskedTextBoxTelefone.Text = String.Empty;
            maskedTextBoxCelular.Text = String.Empty;
            maskedTextBoxCep.Text = String.Empty;
            textBoxEndereco.Text = String.Empty;
            textBoxNumero.Text = String.Empty;
            textBoxComplemento.Text = String.Empty;
            textBoxBairro.Text = String.Empty;
            textBoxCidade.Text = String.Empty;
            comBoxUf.Text = String.Empty;


        }

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            ClearProperties();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {

            //Fecha a aplicação através do botão
            this.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            /* ação executada na inicialização do form */

            //Instanciando um objeto do tipo ClienteDAO classe que comtempla toda lógica relacionada ao banco
            ClienteDAO objClienteDAO = new ClienteDAO();

            //Acessando a propriedade do form e preenchendo o data grid view com base no retorno da query executada no método SelectClient();
            dataGridViewClientes.DataSource = objClienteDAO.SelectCliente();
        }



        /* Implementar lógicar para atualizar dados dos clientes */
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();

            objCliente.Nome = textBoxNome.Text;
            objCliente.Rg = maskedTextBoxRg.Text;
            objCliente.Cpf = maskedTextBoxCpf.Text;
            objCliente.Email = textBoxEmail.Text;
            objCliente.Telefone = maskedTextBoxTelefone.Text;
            objCliente.Celular = maskedTextBoxCelular.Text;
            objCliente.Cep = maskedTextBoxCep.Text;
            objCliente.Endereco = textBoxEndereco.Text;
            objCliente.Numero = Convert.ToInt32(textBoxNumero.Text);
            objCliente.Complemento = textBoxComplemento.Text;
            objCliente.Bairro = textBoxBairro.Text;
            objCliente.Cidade = textBoxCidade.Text;
            objCliente.Estado = comBoxUf.Text;
            objCliente.Codigo = Convert.ToInt32(textBoxCodigo.Text);



            // Instanciando um obj do tipo ClienteDAO que possui a lógica com a execução da query
            ClienteDAO objClienteDAO = new ClienteDAO();

            //Chamando o método IsertCliente e passando meu objCliente que comtempla os atributos de cliente para execução do cadastro
            objClienteDAO.UpdateCliente(objCliente);


            //Recarrega o Datagrid View após a operação realizada
            dataGridViewClientes.DataSource = objClienteDAO.SelectCliente();
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            //Evento realizado ao clicar em uma celular do Data Drid View

            //Atribuindo aos textbox's o conteúdo da linha do meu data grid view quando selecionado
            textBoxCodigo.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
            maskedTextBoxRg.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
            maskedTextBoxCpf.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString();
            maskedTextBoxTelefone.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString();
            maskedTextBoxCelular.Text = dataGridViewClientes.CurrentRow.Cells[6].Value.ToString();
            maskedTextBoxCep.Text = dataGridViewClientes.CurrentRow.Cells[7].Value.ToString();
            textBoxEndereco.Text = dataGridViewClientes.CurrentRow.Cells[8].Value.ToString();
            textBoxNumero.Text = dataGridViewClientes.CurrentRow.Cells[9].Value.ToString();
            textBoxComplemento.Text = dataGridViewClientes.CurrentRow.Cells[10].Value.ToString();
            textBoxBairro.Text = dataGridViewClientes.CurrentRow.Cells[11].Value.ToString();
            textBoxCidade.Text = dataGridViewClientes.CurrentRow.Cells[12].Value.ToString();
            comBoxUf.Text = dataGridViewClientes.CurrentRow.Cells[13].Value.ToString();



            //Redirecionando para o form de cadastro após selecionado a linha do data grid view
            tabControlClientes.SelectedTab = tabPageDadosPessoais;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //Definindo a lógica do evento ao ser clicado o botão de exclusão
            Cliente objClientedelete = new Cliente();

            objClientedelete.Codigo = Convert.ToInt32(textBoxCodigo.Text);



            ClienteDAO objClienteDAO = new ClienteDAO();

            objClienteDAO.DeleteCliente(objClientedelete);


            //Recarrega o Datagrid View após a operação realizada
            dataGridViewClientes.DataSource = objClienteDAO.SelectCliente();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Instanciando o objeto cliente
            Cliente objClienteSelectNome = new Cliente();


            //Resgata o texto digitado no textbox para execução do método que comtempla a aquery
            string nome = textBoxNomeConsulta.Text;
            

            //Instanciando um objeto para acessar os métodos da minha classe responsável pela lógica do banco
            ClienteDAO objClienteDAO = new ClienteDAO();

            if (textBoxNomeConsulta.Text != "")
            {

                //Irá carregar o Data Grid View com o resultado da query que será executada no método SelectClienteNome()
                dataGridViewClientes.DataSource = objClienteDAO.SelectClientePorNome(nome);
            }
            else
            {
                MessageBox.Show("Necessário informar o nome a ser pesquisado!!!");
            }

            ////Recarrega o Datagrid View após a operação realizada
            //dataGridViewClientes.DataSource = objClienteDAO.SelectCliente();


        }

        private void buttonConsultaLimpar_Click(object sender, EventArgs e)
        {


            //Instanciando o obj ClienteDAO para acessar o método responsável por realizar um select no banco
            ClienteDAO objClienteDAO = new ClienteDAO();
            textBoxNomeConsulta.Text = String.Empty;
            //Recarrega o Datagrid View após a operação realizada
            dataGridViewClientes.DataSource = objClienteDAO.SelectCliente();
        }
    }


}
