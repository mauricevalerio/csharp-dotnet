namespace kanban_web_api.Dtos
{
    public class GetKanbanDto
    {
        public string Name { get; set; } = string.Empty;
        public List<Column>? Columns { get; set; }
    }
}