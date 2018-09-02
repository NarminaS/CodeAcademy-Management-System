using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class RoleMenuItem
    {
        public RoleMenuItem()
        {
            MenuItem = new MenuItem();
            Role = new Role();
        }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }  
    }
}
