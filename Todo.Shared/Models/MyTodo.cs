using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Todo.Shared.Models
{
    public class MyTodo
    {
        public int? Id { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 10)]
        public string Description { get; set; }
        public DateTime ToDoDateTime { get; set; }
        public bool Important { get; set; }
    }
}
