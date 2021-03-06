﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Utilities
{
    public class Uploader
    {
        IHostingEnvironment _environment;

        public Uploader(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public string DefineImagePath(IFormFile file)
        {
            string folderPath = Path.Combine(_environment.WebRootPath, "images", file.FileName);
            if (!String.IsNullOrEmpty(folderPath))
            {
                return folderPath;
            }
            return String.Empty;
            //Throw invalid file exeption...
        }

        public static async Task UploadToServer(string path, IFormFile file)
        {
            try
            {
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            catch (IOException ex)
            {
                //Handle exception
            }
        }

        public string DefineBookPath(IFormFile file)
        {
            string folderPath = Path.Combine(_environment.WebRootPath, "books", file.FileName);
            if (!String.IsNullOrEmpty(folderPath))
                return folderPath;
            return String.Empty;
        }

        public string DefinePostImagePath(IFormFile file)
        {
            var newFileName = Guid.NewGuid().ToString() + file.FileName;
            string folderPath = Path.Combine(_environment.WebRootPath, "images/posts", newFileName);
            if (!String.IsNullOrEmpty(folderPath))
                return folderPath;
            return String.Empty;
        }
    }
}
