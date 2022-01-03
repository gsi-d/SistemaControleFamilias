
using ExercicioCrudBanco.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ExemploComboBox.Controller
{
    public class EstadoController
    {
        public DataTable BuscarPorId(int id)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Estado where
                    IdEstado = @id", out retorno, "@id", id);
            }
            return retorno;
        }        
        public DataTable BuscarPorNome(string nomeEstado)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Estado where
                    Estado = @nome", out retorno, "@nome", nomeEstado);
            }
            return retorno;
        }
        public DataTable BuscarPorSigla(string sigla)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Estado where
                    Sigla = @sigla", out retorno, "@sigla", sigla);
            }
            return retorno;
        }

        public DataTable BuscarPorLike(string nome)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Estado where
                    Estado like @nome", out retorno, "@nome", nome);
            }
            return retorno;
        }

        public DataTable BuscarEstado()
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Estado", out retorno);

                return retorno;
            }
        }
    }
}
