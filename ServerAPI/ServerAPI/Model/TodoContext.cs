using Microsoft.EntityFrameworkCore;

namespace ServerAPI.Model
{
	public class TodoContext : DbContext
	{
		public TodoContext(DbContextOptions<TodoContext> options)
			: base(options)
		{
		}

		public DbSet<TodoItem> TodoItems { get; set; }
	}
}