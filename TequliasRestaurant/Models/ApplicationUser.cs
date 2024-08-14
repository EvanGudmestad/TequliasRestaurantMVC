using Microsoft.AspNetCore.Identity;

namespace TequliasRestaurant.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
