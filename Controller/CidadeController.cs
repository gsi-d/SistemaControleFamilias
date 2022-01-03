using ExercicioCrudBanco.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CRUD_19_11.Controller
{
    public class CidadeController
    {
        public DataTable BuscarCidade(int idEstado)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Cidades where Id_Estado=@1",
                    out retorno, "@1", idEstado);

                return retorno;
            }
        }
    }
}
