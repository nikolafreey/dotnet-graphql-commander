using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace CommanderGraphQL.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string LicenceKey { get; set; }
        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}