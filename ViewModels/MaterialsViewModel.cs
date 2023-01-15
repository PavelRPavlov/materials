using Microsoft.AspNetCore.Identity;
using Models;

namespace Materials.ViewModels
{
    public class MaterialsViewModel
    {
        public List<Material> AllMaterials { get; set; }
        public IdentityUser User { get; set; }
        public MaterialsViewModel(List<Material> all, IdentityUser user)
        {
            AllMaterials = all;
            User = user;
        }
    }
}
