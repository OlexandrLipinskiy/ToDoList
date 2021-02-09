using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string Description { get; set; }

        [Display(Name = "Is Done")]
        public bool IsDone { get; set; }
    }
}
