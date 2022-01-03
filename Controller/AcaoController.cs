using CRUD_19_11.Model;
using ExercicioCrudBanco.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CRUD_19_11.Controller
{
    public class AcaoController
    {
        public bool GravarAcao(AcaoEntity Acao)
        {
            BancoInstance banco;
            bool ok = false;
            using (banco = new BancoInstance())
            {
                ok = banco.Banco.ExecuteNonQuery(@"INSERT INTO Acao (Id_Cidade, Nome_Acao, Dt_inicio, Dt_final) VALUES (@1, @2, @3, @4)","@1", Acao.Id_cidade, "@2", Acao.Nome, "@3", Acao.DtInicio, "@4", Acao.DtTermino);
            }
            return ok;
        }

        public DataTable buscarTodasAcaoCompletas()
        {
            BancoInstance banco;
            DataTable resultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT Acao.Id_Acao as ID, Nome_Acao, Cidades.Nome_Cidade as Cidade, Estado.Nome_Estado as Estado
                FROM Acao
                INNER JOIN Cidades ON Acao.Id_Cidade = Cidades.Id_Cidade
                INNER JOIN Estado ON Estado.Id_Estado = Cidades.Id_Estado", out resultado);
            }
            return resultado;
        }

        public DataTable buscarAcao(string acao)
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT * FROM Acao WHERE Nome_Acao LIKE @1", out dtresultado, "@1", acao);
            }
            return dtresultado;
        }

        public bool excluirAcao(int id)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                bool ok;
                return ok = banco.Banco.ExecuteNonQuery(@"DELETE FROM Acao WHERE Id_Acao= @1", "@1", id);
            }
            
        }

        public bool alterarAcao(AcaoEntity acao)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                bool ok;
                return ok = banco.Banco.ExecuteNonQuery(@"UPDATE Acao SET Id_Cidade = @1, Nome_Acao = @2, Dt_inicio = @3, Dt_final = @4 WHERE Id_Acao = @5",
                    "@1", acao.Id_cidade,
                    "@2", acao.Nome,
                    "@3", acao.DtInicio,
                    "@4", acao.DtTermino,
                    "@5", acao.Id);
            }
        }

        public DataTable buscarAcaoCompleta(string acao)
        {
            BancoInstance banco;
            DataTable resultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT Acao.Id_Acao as ID, Nome_Acao, Cidades.Nome_Cidade as Cidade, Estado.Nome_Estado as Estado, Acao.Dt_Inicio, Acao.Dt_final
                FROM Acao
                INNER JOIN Cidades ON Acao.Id_Cidade = Cidades.Id_Cidade
                INNER JOIN Estado ON Estado.Id_Estado = Cidades.Id_Estado
                WHERE Nome_Acao LIKE @acao", out resultado, "@acao", acao);
            }
            return resultado;

        }

        public DataTable buscarId_CidadeAcao(string nome)
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
