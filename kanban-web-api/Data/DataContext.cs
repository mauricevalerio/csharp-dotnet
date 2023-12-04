namespace kanban_web_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }
    }
}