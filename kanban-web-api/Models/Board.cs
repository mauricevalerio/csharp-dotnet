namespace kanban_web_api.Models
{
    public class Board
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public List<Column>? Columns { get; set; }
    }
}