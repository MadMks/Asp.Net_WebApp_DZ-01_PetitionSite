using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.Net_WebApp_DZ_01_PetitionSite.Models
{
    public class PetitionContext : DbContext
    {
        public DbSet<Petition> Petitions { get; set; }
        // TODO DbSet: list_of_votes, state_of_petitions, users
    }

    public class PetitionDbInitializer : DropCreateDatabaseAlways<PetitionContext>
    {
        protected override void Seed(PetitionContext context)
        {
            // TODO наполнить начальными данными таблицы.

            context.Petitions.Add(new Petition { Title = "name book 1", Description = "desc 1", CountOfVotes = 1 });

            base.Seed(context);
        }
    }
}