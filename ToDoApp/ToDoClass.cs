using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp
{
    internal class ToDoClass
    {
        private static int _nextId = 1;

        public ToDoClass()
        {
            Id = _nextId++;
        }

        public ToDoClass(string title, string description)
        {
            Id = _nextId++;
            Title = title;
            Description = description;
        }

        public int Id { get; private set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Priority Priority { get; set; } = Priority.low;
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
