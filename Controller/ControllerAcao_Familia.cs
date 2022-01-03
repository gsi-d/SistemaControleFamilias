using ExercicioCrudBanco.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CRUD_19_11.Controller
{
    public class ControllerAcao_Familia
    {
        public DataTable buscarAcao_Familia(int id_familia, int id_acao)
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT * FROM Acao_Familia WHERE Id_Familia LIKE @1 and Id_Acao LIKE @2", out dtresultado, "@1", id_familia, "@2", id_acao);
            }
            return dtresultado;
        }

        public DataTable buscarAcao_FamiliaporId_Familia(int id_familia)
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT * FROM Acao_Familia WHERE Id_Familia LIKE @1", out dtresultado, "@1", id_familia);
            }
            return dtresultado;
        }

        public DataTable buscarNome_Acao(string acao)
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select AF.Id_Acao, F.Nome_Familia, A.Nome_Acao, C.Nome_Cidade, E.Nome_Estado, A.Dt_inicio, A.Dt_final 
                from Acao_Familia AF 
                INNER JOIN Familia F ON F.Id_Familia = AF.Id_Familia
                INNER JOIN Acao A ON A.Id_Acao = AF.Id_Acao
                INNER JOIN Cidades C ON C.Id_Cidade = A.Id_Cidade
                INNER JOIN Estado E ON E.Id_Estado = C.Id_Estado
                WHERE A.Nome_Acao LIKE @1", out dtresultado, "@1", acao);
            }
            return dtresultado;
        }

        public DataTable buscarNome_AcaoTodas()
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select AF.Id_Acao, F.Nome_Familia, A.Nome_Acao, C.Nome_Cidade, E.Nome_Estado, A.Dt_inicio, A.Dt_final from Acao_Familia AF 
                INNER JOIN Familia F ON F.Id_Familia = AF.Id_Familia
                INNER JOIN Acao A ON A.Id_Acao = AF.Id_Acao
                INNER JOIN Cidades C ON C.Id_Cidade = A.Id_Cidade
                INNER JOIN Estado E ON E.Id_Estado = C.Id_Estado", out dtresultado);
            }
            return dtresultado;
        }

        public DataTable buscarNome_Familia(string familia)
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select AF.Id_Acao, A.Nome_Acao, F.Id_Familia, F.Nome_Familia, A.Nome_Acao, C.Nome_Cidade, E.Nome_Estado, A.Dt_inicio, A.Dt_final 
                from Acao_Familia AF 
                INNER JOIN Familia F ON F.Id_Familia = AF.Id_Familia
                INNER JOIN Acao A ON A.Id_Acao = AF.Id_Acao
                INNER JOIN Cidades C ON C.Id_Cidade = A.Id_Cidade
                INNER JOIN Estado E ON E.Id_Estado = C.Id_Estado
                WHERE F.Nome_Familia LIKE @1", out dtresultado, "@1", familia);
            }
            return dtresultado;
        }

        public DataTable buscarNome_FamiliaTodas()
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select AF.Id_Acao, A.Nome_Acao, F.Id_Familia, F.Nome_Familia, A.Nome_Acao, C.Nome_Cidade, E.Nome_Estado, A.Dt_inicio, A.Dt_final 
                from Acao_Familia AF 
                INNER JOIN Familia F ON F.Id_Familia = AF.Id_Familia
                INNER JOIN Acao A ON A.Id_Acao = AF.Id_Acao
                INNER JOIN Cidades C ON C.Id_Cidade = A.Id_Cidade
                INNER JOIN Estado E ON E.Id_Estado = C.Id_Estado
                ", out dtresultado);
            }
            return dtresultado;
        }

        public bool gravarAcao_Familia(int cpf, int acao)
        {
            BancoInstance banco;
            bool ok = false;
            using (banco = new BancoInstance())
            {
                ok = banco.Banco.ExecuteNonQuery(@"INSERT INTO Acao_Familia(Id_Familia, Id_Acao) VALUES(@1, @2)", "@1", cpf, "@2", acao);
            }
            return ok;
        }

        public DataTable buscarNome_Pessoa()
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT AF.Id_Acao, A.Nome_Acao, P.Nome_Pessoa, P.CPF, F.Nome_Familia, C.Nome_Cidade, E.Nome_Estado, A.Dt_inicio, A.Dt_final 
                FROM Acao_Familia AF
                INNER JOIN Pessoa P ON P.Id_Familia = AF.Id_Familia
                INNER JOIN Acao A ON A.Id_Acao = AF.Id_Acao
                INNER JOIN Cidades C ON C.Id_Cidade = A.Id_Cidade
                INNER JOIN Estado E ON E.Id_Estado = C.Id_Estado
                INNER JOIN Familia F ON F.Id_Familia = P.Id_Familia", out dtresultado);
            }
            return dtresultado;
        }

        public DataTable buscarAcao_FamiliaporId_FamiliapeloNomePessoa(int id_familia)
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT AF.Id_Acao, P.Id_Pessoa, P.Nome_Pessoa, P.CPF, F.Nome_Familia, A.Nome_Acao
                FROM Acao_Familia AF
                INNER JOIN Pessoa P ON P.Id_Familia = AF.Id_Familia
                INNER JOIN Familia F ON F.Id_Familia = P.Id_Familia
                INNER JOIN Acao A ON A.Id_Acao = AF.Id_Acao
                WHERE AF.Id_Familia LIKE @1", out dtresultado, "@1", id_familia);
            }
            return dtresultado;
        }

        public DataTable buscarCPFpessoa()
        {
            BancoInstance banco;
            DataTable dtresultado = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"SELECT  AF.Id_Acao, A.Nome_Acao, P.Nome_Pessoa, P.CPF, F.Nome_Familia, C.Nome_Cidade, E.Nome_Estado, , A.Dt_inicio, A.Dt_final 
                FROM Acao_Familia AF
                INNER JOIN Pessoa P ON P.Id_Familia = AF.Id_Familia
                INNER JOIN Acao A ON A.Id_Acao = AF.Id_Acao
                INNER JOIN Cidades C ON C.Id_Cidade = A.Id_Cidade
                INNER JOIN Estado E ON E.Id_Estado = C.Id_Estado
                INNER JOIN Familia F ON F.Id_Familia = P.Id_Familia", out dtresultado);
            }
            return dtresultado;
        }

        public bool excluirAcao_Familia(int id)
        {
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                bool ok = banco.Banco.ExecuteNonQuery(@"DELETE FROM Acao_Familia WHERE Id_Acao = @1", "@1", id);
                return ok;
            }
        }
    }
}
