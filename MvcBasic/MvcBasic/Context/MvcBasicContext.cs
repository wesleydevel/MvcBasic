using MvcBasic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBasic.Context
{
    public class MvcBasicContext : DbContext
    {
        public MvcBasicContext()
            : base("MvcBasic")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}