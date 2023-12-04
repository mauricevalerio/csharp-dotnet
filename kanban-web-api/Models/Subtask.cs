namespace kanban_web_api.Models
{
    public class Subtask
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}