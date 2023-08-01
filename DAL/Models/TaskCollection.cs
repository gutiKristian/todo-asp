

namespace DAL.Models
{
    public class TaskCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<TaskTodo> Tasks { get; set; }
    }
}
