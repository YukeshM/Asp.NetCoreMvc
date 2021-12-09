using System;
using System.Collections.Generic;

#nullable disable

namespace ImageUpload.Models
{
    public partial class UploadImage
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public string Image { get; set; }
    }
}
