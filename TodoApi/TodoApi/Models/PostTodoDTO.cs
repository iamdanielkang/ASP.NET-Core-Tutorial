using System;
namespace TodoApi.Models
{
    public class PostTodoDTO : TodoItemDTO 
    {
        public long Id { get; set; }
    }
}
