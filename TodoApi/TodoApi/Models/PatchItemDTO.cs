using System;
namespace TodoApi.Models
{
    public class PatchItemDTO
    {
        public string? Name { get; set; }
        public bool? IsComplete { get; set; }
        public string? Secret { get; set; }
    }
}
