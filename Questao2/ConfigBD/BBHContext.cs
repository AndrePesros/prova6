﻿using Questao2.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2.ConfigBD
{
    class BBHContext: DbContext
    {
         DbSet<Usuario> Usuarios { get; set; }
    }
}
