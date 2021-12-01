using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1.Model
{
    class Usuario
    {
        public int ID { get; set; }
        public string Serie { get; set; }
        public string Descricao { get; set; }
        public string Repeticao { get; set; }
        public int Peso { get; set; }
        public int FichaId { get; set; }
        public Ficha ficha { get; set; }
    }
}
