using Microsoft.EntityFrameworkCore;
using xxx.Models;

namespace xxx.DataContext
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public Dbset<Character> Characters { get; set; }
    }
}