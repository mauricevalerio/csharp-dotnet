namespace kanban_web_api.Models
{
    public class Task
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<Subtask> Subtasks { get; set; }
        public int ColumnId { get; set; }
        public Column Column { get; set; }
    }
}