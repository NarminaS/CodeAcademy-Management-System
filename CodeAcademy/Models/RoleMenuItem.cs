using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    [Table(name:"RoleMenuItems")]
    public class RoleMenuItem
    {
        public RoleMenuItem()
        {
            Role = new Role();
            MenuItem = new MenuItem();
        }
        public string RoleId { get; set; }
        public Role Role { get; set; }

        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }  
    }
}