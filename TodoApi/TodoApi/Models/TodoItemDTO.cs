using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        [Required] public string Name { get; set; }
        [Required] public bool IsComplete { get; set; }
    }
}
