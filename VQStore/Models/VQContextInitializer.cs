using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VQStore.Models
{
    public class VQContextInitializer : IDatabaseInitializer<UsersContext>
    {
        public void InitializeDatabase(UsersContext context)
        {
            if (!context.Database.Exists())
            {
                context.Database.Create();
                context.Database.Initialize(true);
            }
            //context.Database.CreateIfNotExists();
        }
    }
}