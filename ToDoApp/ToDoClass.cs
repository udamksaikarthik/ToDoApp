using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    internal class ToDoClass
    {
        public ToDoClass() { }

        public ToDoClass(int id, string title, string description, Priority priority = Priority.low, bool isCompleted = false)
        {
            Id = id;
            Title = title;
            Description = description;
            Priority = priority;
            IsCompleted = isCompleted;
        }
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Priority Priority { get; set; } = Priority.low;
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
