
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Data
{
    public class DataContext: DbContext
    {
        // Constructor
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        // name of DBset -> name of corresponding db table
        // usally pluratize the name of the entity
        public DbSet<Character> Characters => Set<Character>();
    }
}