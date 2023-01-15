using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Material
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public string Catalog { get; set; }
        public string Location { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public double Thicknes{ get; set; }
        public IdentityUser Owner { get; set; }
        public Guid OwnerId { get; set; } 
    }
}
