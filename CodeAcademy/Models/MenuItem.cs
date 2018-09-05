using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Models
{
    public class MenuItem
    {
        public MenuItem()
        {
            RoleMenuItems = new List<RoleMenuItem>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }

        public string Url { get; set; }

        public int Order { get; set; }

        public bool Visibility { get; set; }

        public List<RoleMenuItem> RoleMenuItems { get; set; }

        public bool IsDeleted { get; set; }
    }
}
