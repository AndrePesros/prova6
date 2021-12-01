using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1.Model
{
    class Atividade
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public int Peso { get; set; }
        public int Altura { get; set; }
        public int IMC { get; set; }
        public int FichaId { get; set; }
        public Ficha ficha { get; set; }
    }
}
