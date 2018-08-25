using CodeAcademy.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Utilities
{
    public class OldFileRemover
    {
        IHostingEnvironment _environment;

        public OldFileRemover(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public Task DeleteOldFacultyLogoAsync(Faculty faculty)     
        {
            int indexOf = faculty.LogoImagePath.IndexOf("/images\\");
            string fileName = faculty.LogoImagePath.Remove(indexOf,"/images\\".Length);
            string path = Path.Combine(_environment.WebRootPath, "images", fileName);
            try
            {
                if (File.Exists(path))
                {
                    return Task.Factory.StartNew(() => System.IO.File.Delete(path));
                }
            }
            catch (IOException ex)
            {
                //TODO: Handle IO exception...
            }
            return default;
        }

        public Task DeleteOldUserAvatarAsync()
        {
            //TODO: Delete old user avatar before replacing with new one...
            return default;
        }
    }
}
