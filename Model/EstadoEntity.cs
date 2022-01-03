using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_19_11.Model
{
    class EstadoEntity
    {
        public string Nome_Estado { get; set; }
        public string Sigla { get; set; }

        public EstadoEntity()
        {

        }

        public EstadoEntity(string nome_Estado, string sigla)
        {
            Nome_Estado = nome_Estado;
            Sigla = sigla;
        }

    }
}
