namespace TodoListCore.Data
{
    public class Todo
    {
        public int Id { get; set; }
        public string Action { get; set; }=string.Empty;
        public bool Completed { get; set; }
    }
}
