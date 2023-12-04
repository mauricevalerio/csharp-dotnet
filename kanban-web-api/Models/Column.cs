namespace kanban_web_api.Models
{
    public class Column
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public List<Task>? Tasks { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }
    }
}