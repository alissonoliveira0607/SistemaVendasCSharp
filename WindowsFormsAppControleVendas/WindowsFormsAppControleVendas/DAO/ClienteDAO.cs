using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppControleVendas.Connection;
using WindowsFormsAppControleVendas.Models;

namespace WindowsFormsAppControleVendas.DAO
{
    class ClienteDAO
    {

        private MySqlConnection conexao;

        #region Construtor da classe Recupera a conexão com banco (Abre uma conexão)
        //Construtor Ao realizar uma nova instancia do meu objeto será recuperado a conexão com o banco
        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #endregion

        #region InsertClientes()
        /* Método cadastrar clientes <-INSERT */
        //Método não retorna nada porém espera receber como parametro um Objeto do tipo cliente
        public void InsertCliente(Cliente objCliente)
        {
            try
            {
                //Definir a query responsável pelo insert de novos clientes
                string sqlInsertClientes = @"INSERT INTO tb_clientes
                                                        (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                                  VALUES(@Nome,@Rg,@Cpf,@Email,@Telefone,@Celular,@Cep,@Endereco,@Numero,@Complemento,@Bairro,@Cidade,@Estado)";


                //Instanciando o objeto para execução da query com base no consumo dos atributos da classe cliente
                MySqlCommand executeInsertClientes = new MySqlCommand(sqlInsertClientes, conexao);

                executeInsertClientes.Parameters.AddWithValue("@Nome", objCliente.Nome);
                executeInsertClientes.Parameters.AddWithValue("@Rg", objCliente.Rg);
                executeInsertClientes.Parameters.AddWithValue("@Cpf", objCliente.Cpf);
                executeInsertClientes.Parameters.AddWithValue("@Email", objCliente.Email);
                executeInsertClientes.Parameters.AddWithValue("@Telefone", objCliente.Telefone);
                executeInsertClientes.Parameters.AddWithValue("@Celular", objCliente.Celular);
                executeInsertClientes.Parameters.AddWithValue("@Cep", objCliente.Cep);
                executeInsertClientes.Parameters.AddWithValue("@Endereco", objCliente.Endereco);
                executeInsertClientes.Parameters.AddWithValue("@Numero", objCliente.Numero);
                executeInsertClientes.Parameters.AddWithValue("@Complemento", objCliente.Complemento);
                executeInsertClientes.Parameters.AddWithValue("@Bairro", objCliente.Bairro);
                executeInsertClientes.Parameters.AddWithValue("@Cidade", objCliente.Cidade);
                executeInsertClientes.Parameters.AddWithValue("@Estado", objCliente.Estado);

                //Abrindo conexão para execução da query
                conexao.Open();
                executeInsertClientes.ExecuteNonQuery();  //Executando a Query

                System.Windows.Forms.MessageBox.Show("Cliente Cadastrado com sucesso!!!");

                //Fechando a conexão após realizar a operação
                conexao.Close();

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show($"Erro: {e}");
            }
        }

        #endregion

        #region UpdateCliente()
        /* Método alterar clientes  <-  UPDATE */
        public void UpdateCliente(Cliente objCliente)
        {

            try
            {

                /* Definindo a query */
                string sqlUpdateClientes = @"UPDATE tb_clientes SET 
                                                        nome=@Nome,
                                                         rg=@Rg,
                                                         cpf=@Cpf,
                                                         email=@Email,
                                                         telefone=@Telefone,
                                                         celular=@Celular,
                                                         cep=@Cep,
                                                         endereco=@Endereco,
                                                         numero=@Numero,
                                                         complemento=@Complemento,
                                                         bairro=@Bairro,
                                                         cidade=@Cidade,
                                                         estado=@Estado
                                  where id=@Id";

                //Instanciando o objeto para execução da query com base no consumo dos atributos da classe cliente
                MySqlCommand executeUpdateClientes = new MySqlCommand(sqlUpdateClientes, conexao);

                executeUpdateClientes.Parameters.AddWithValue("@Nome", objCliente.Nome);
                executeUpdateClientes.Parameters.AddWithValue("@Rg", objCliente.Rg);
                executeUpdateClientes.Parameters.AddWithValue("@Cpf", objCliente.Cpf);
                executeUpdateClientes.Parameters.AddWithValue("@Email", objCliente.Email);
                executeUpdateClientes.Parameters.AddWithValue("@Telefone", objCliente.Telefone);
                executeUpdateClientes.Parameters.AddWithValue("@Celular", objCliente.Celular);
                executeUpdateClientes.Parameters.AddWithValue("@Cep", objCliente.Cep);
                executeUpdateClientes.Parameters.AddWithValue("@Endereco", objCliente.Endereco);
                executeUpdateClientes.Parameters.AddWithValue("@Numero", objCliente.Numero);
                executeUpdateClientes.Parameters.AddWithValue("@Complemento", objCliente.Complemento);
                executeUpdateClientes.Parameters.AddWithValue("@Bairro", objCliente.Bairro);
                executeUpdateClientes.Parameters.AddWithValue("@Cidade", objCliente.Cidade);
                executeUpdateClientes.Parameters.AddWithValue("@Estado", objCliente.Estado);
                executeUpdateClientes.Parameters.AddWithValue("@Id", objCliente.Codigo);


                //Abrindo conexão para execução da query
                conexao.Open();
                executeUpdateClientes.ExecuteNonQuery();  //Executando a Query

                System.Windows.Forms.MessageBox.Show("Cliente alterado com sucesso!!!");

                //Fechando a conexão após realizar a operação
                conexao.Close();
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show($"Erro: {e}");
            }

        }

        #endregion



        #region DeleteCliente()
        /* Método excluir clientes  <-  DELETE */
        public void DeleteCliente(Cliente objCliente)
        {

            try
            {

                /* Definindo a query */
                string sqlDeleteClientes = @"DELETE FROM tb_clientes WHERE id=@Id";

                //Instanciando o objeto para execução da query com base no consumo dos atributos da classe cliente
                MySqlCommand executeDeleteClientes = new MySqlCommand(sqlDeleteClientes, conexao);

                //Acessando atributo Id da classe Cliente
                executeDeleteClientes.Parameters.AddWithValue("@Id", objCliente.Codigo);


                //Abrindo conexão para execução da query
                conexao.Open();
                executeDeleteClientes.ExecuteNonQuery();  //Executando a Query



                System.Windows.Forms.MessageBox.Show("Cliente excluido com sucesso!!!");

                //Fechando a conexão após realizar a operação
                conexao.Close();
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show($"Erro: {e}");
            }

        }

        #endregion

        #region SelectClientes
        /* Método listar clientes  <-   SELECT Data Grid View*/
        public DataTable SelectCliente()
        {
            try
            {
                //Instanciando um DataTable e definindo minha consulta
                DataTable dataTableCliente = new DataTable();
                string sqlSlect = "SELECT * FROM tb_clientes";


                //Instanciando o objeto para execução da query e abrindo a conexão com o banco
                MySqlCommand executeSelect = new MySqlCommand(sqlSlect, conexao);
                conexao.Open();  // <- Abrindo a conexão
                executeSelect.ExecuteNonQuery();  // <- Executando a query

                //Criando um adaptador e preenchendo o datatable com base no retorno da consulta
                MySqlDataAdapter adapterCliente = new MySqlDataAdapter(executeSelect);  // <-  Criando meu obj adapter que recebe o resultado do meu executeSelect
                adapterCliente.Fill(dataTableCliente);  // <- Atualizando meu data Grid com base no retor da query

                //Fechando a conexão após realizar a operação
                conexao.Close();

                return dataTableCliente;  // <-  Retorna meu DataTable

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show($"Erro: {e}");
                return null;
            }
        }

        #endregion

        /* Método consultar clientes por CPF  <-  SELECT*/



        #region SelectClientePorNome()
        public DataTable SelectClientePorNome(string nome)
        {

            try
            {
                //Instanciando um DataTable e definindo minha consulta
                DataTable dataTableCliente = new DataTable();
                string sqlSlect = "SELECT * FROM tb_clientes WHERE nome=@nome";


                //Instanciando o objeto para execução da query e abrindo a conexão com o banco
                MySqlCommand executeSelect = new MySqlCommand(sqlSlect, conexao);

                //Substituindo a correspondência pelo parametro retornado
                executeSelect.Parameters.AddWithValue("@nome",nome);

                conexao.Open();  // <- Abrindo a conexão
                executeSelect.ExecuteNonQuery();  // <- Executando a query

                //Criando um adaptador e preenchendo o datatable com base no retorno da consulta
                MySqlDataAdapter adapterCliente = new MySqlDataAdapter(executeSelect);  // <-  Criando meu obj adapter que recebe o resultado do meu executeSelect
                adapterCliente.Fill(dataTableCliente);  // <- Atualizando meu data Grid com base no retor da query

                //Fechando a conexão após realizar a operação
                conexao.Close();

                return dataTableCliente;  // <-  Retorna meu DataTable

            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show($"Erro: {e}");
                return null;
            }

        }

        #endregion


    }
}
