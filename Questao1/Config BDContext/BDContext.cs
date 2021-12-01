using Questao1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1.Config_BDContext
{
    class BDContext: DbContext
    {
        DbSet<Ficha> Fichas { get; set; }
        DbSet<Atividade> Atividades { get; set; }
        DbSet<Usuario> Usuarios { get; set; }
    }
}
