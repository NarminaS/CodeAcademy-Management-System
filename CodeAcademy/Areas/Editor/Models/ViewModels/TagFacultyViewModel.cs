using CodeAcademy.Areas.Admin.Models.ViewModels;
using CodeAcademy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Areas.Editor.Models.ViewModels
{
    public class TagFacultyViewModel
    {
        public List<FacultyViewModel> Faculties { get; set; }
        public List<TagViewModel> Tags { get; set; } 
    }
}
