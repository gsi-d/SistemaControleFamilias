using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_19_11.Model
{
    public class AcaoEntity
    {
        public int Id { get; set; }
        public int Id_cidade { get; set; }
        public string Nome { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtTermino { get; set; }



        public AcaoEntity(int id, int id_cidade, string nome, DateTime dtInicio, DateTime dtTermino)
        {
            Id = id;
            Id_cidade = id_cidade;
            Nome = nome;
            DtInicio = dtInicio;
            DtTermino = dtTermino;
        }
    }
}
