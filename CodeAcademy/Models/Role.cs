using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class Role:IdentityRole
    {
        public Role()
        {
            RoleMenuItems = new List<RoleMenuItem>();
        }
        public bool IsDeleted { get; set; }

        public List<RoleMenuItem> RoleMenuItems { get; set; }   
    }
}
