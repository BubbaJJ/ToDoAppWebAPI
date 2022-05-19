using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAppWebAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; } = false;
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateFinished { get; set; }
        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(3);
        public User AssignedTo { get; set; }
    }
}