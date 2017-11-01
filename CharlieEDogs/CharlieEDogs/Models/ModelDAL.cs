using CharlieEDogs.Models.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CharlieEDogs.Models
{
    public class ModelDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        
        public IList<Cachorro> ListarCachorros()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            IList<Cachorro> _lista = new List<Cachorro>();

            try
            {    
                connection.Open();
                string query = "SELECT * FROM Cachorro.Cachorro CC " +
                               " JOIN Cachorro.Porte CP ON CP.idTipoPorte = CC.idTipoPorte";
                
                SqlCommand command = new SqlCommand(query, connection);                
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Cachorro cachorro = new Cachorro();
                    cachorro.IdCachorro = int.Parse(dr["idCachorro"].ToString());
                    cachorro.Idade = int.Parse(dr["intIdade"].ToString());
                    cachorro.IdPorte = int.Parse(dr["idTipoPorte"].ToString());
                    cachorro.Nome = dr["strNome"].ToString();
                    cachorro.Foto = dr["strFoto"].ToString();
                    cachorro.Porte = dr["strTipoPorte"].ToString();
                    cachorro.Preco = float.Parse(dr["preco"].ToString());

                    _lista.Add(cachorro);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {
                connection.Close();
            }

            return _lista;
        }

        public int InserirPessoa(Pessoa _pessoa)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            IList<Cachorro> _lista = new List<Cachorro>();
            int _id = 0;

            try
            {
                connection.Open();
                string nomeProcedure = "Pessoa.InserePessoa";

                SqlCommand command = new SqlCommand(nomeProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idPessoa", _pessoa.IdPessoa);
                command.Parameters.AddWithValue("@strNome", _pessoa.Nome);
                command.Parameters.AddWithValue("@strEmail", _pessoa.Email);
                command.Parameters.AddWithValue("@strCPF", _pessoa.CPF);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    _id = int.Parse(dr["idPessoa"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {
                connection.Close();
            }
            return _id;
        }

        public int InserirCidade(Cidade _cidade)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            IList<Cachorro> _lista = new List<Cachorro>();
            int _id = 0;

            try
            {
                connection.Open();
                string nomeProcedure = "Cidade.InsereCidade";

                SqlCommand command = new SqlCommand(nomeProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idCidade", _cidade.IdCidade);
                command.Parameters.AddWithValue("@strNome", _cidade.NomeCidade);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    _id = int.Parse(dr["idCidade"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {
                connection.Close();
            }
            return _id;
        }

        public int InserirEndereco(Endereco _endereco)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            IList<Cachorro> _lista = new List<Cachorro>();
            int _id = 0;

            try
            {
                connection.Open();
                string nomeProcedure = "Cidade.InsereEndereco";

                SqlCommand command = new SqlCommand(nomeProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idCidade", _endereco.IdCidade);
                command.Parameters.AddWithValue("@idEndereco", _endereco.IdEndereco);
                command.Parameters.AddWithValue("@strEndereco", _endereco.Rua);
                command.Parameters.AddWithValue("@strBairro", _endereco.Bairro);
                command.Parameters.AddWithValue("@strNumero", _endereco.Numero);
                command.Parameters.AddWithValue("@strComplemento", _endereco.Complemento);
                command.Parameters.AddWithValue("@strCEP", _endereco.CEP);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    _id = int.Parse(dr["idEndereco"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {
                connection.Close();
            }
            return _id;
        }

        public int InserirCompra(Compra _compra)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            IList<Cachorro> _lista = new List<Cachorro>();
            int _id = 0;

            try
            {
                connection.Open();
                string nomeProcedure = "Compra.InsereCompra";

                SqlCommand command = new SqlCommand(nomeProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idCachorro", _compra.IdCachorro);
                command.Parameters.AddWithValue("@idPessoa", _compra.IdPessoa);
                command.Parameters.AddWithValue("@qtd", _compra.Quanitdade);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    _id = int.Parse(dr["idCompra"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {
                connection.Close();
            }
            return _id;
        }
    }
}