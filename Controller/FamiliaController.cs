using CRUD_19_11.Model;
using ExercicioCrudBanco.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CRUD_19_11.Controller
{
    public class FamiliaController
    {
        public bool GravarFamilia(FamiliaEntity familia)
        {
            BancoInstance banco;
            bool ok = false;
            using (banco = new BancoInstance())
            {
                ok = banco.Banco.ExecuteNonQuery(@"INSERT INTO Familia (Id_Cidade, Nome_Familia) VALUES (@1, @2)", "@1", familia.Id_Cidade, "@2", familia.Nome_Familia);
            }
            return ok;
        }

        public DataTable buscarFamilia(int id)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT * FROM Familia WHERE Id_Familia LIKE @1", out retorno, "@1", id);
            }
            return retorno;
        }

        public bool excluirFamilia(int id)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                bool ok = banco.Banco.ExecuteNonQuery(@"DELETE FROM Familia WHERE Id_Familia = @1", "@1", id);
                return ok;
            }
        }

        public bool alterarFamilia(FamiliaEntity familia)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                bool ok = banco.Banco.ExecuteNonQuery(@"UPDATE Familia SET Nome_Familia = @1, Id_Cidade = @2 WHERE Id_Familia = @3", "@1", familia.Nome_Familia, "@2", familia.Id_Cidade, "@3", familia.Id);
                return ok;
            }
        }

        public DataTable buscarFamiliaCompleta(string familia)
        {
            BancoInstance banco;
            DataTable resultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT Familia.Id_Familia as ID, Familia.Id_Cidade, Nome_Familia as Nome_Familia, Cidades.Nome_Cidade as Cidade, Estado.Nome_Estado as Estado
                FROM Familia
                INNER JOIN Cidades ON Familia.Id_Cidade = Cidades.Id_Cidade
                INNER JOIN Estado ON Estado.Id_Estado = Cidades.Id_Estado
                WHERE Familia.Nome_Familia LIKE @1", out resultado, "@1", familia);
            }
            return resultado;
        }

        public DataTable buscarTodasFamiliasCompletas()
        {
            BancoInstance banco;
            DataTable resultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT Familia.Id_Familia as ID, Cidades.Nome_Cidade as Cidade, Nome_Familia as Nome_Familia, Estado.Nome_Estado as Estado
                FROM Familia
                INNER JOIN Cidades ON Familia.Id_Cidade = Cidades.Id_Cidade
                INNER JOIN Estado ON Estado.Id_Estado = Cidades.Id_Estado", out resultado);
            }
            return resultado;
        }

        public DataTable buscarId_CidadeFamilia(string nome)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT Id_Cidade FROM Cidades WHERE Nome_Cidade = @1", out retorno, "@1", nome);
            }
            return retorno;
        }
    }
}
