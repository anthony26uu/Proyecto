using Login.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Login.DAL
{
  public  class RegistroDb : DbContext
    {
        public RegistroDb(): base("ConStr")
        {

        }
        public DbSet<Usuario> usuario { get; set; }
    }
}
