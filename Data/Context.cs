using Microsoft.EntityFrameworkCore;

namespace TodoListCore.Data
{
    public class Context:DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Todo> Todos { get; set; }
    }
}
