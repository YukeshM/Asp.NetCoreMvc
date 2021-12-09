#nullable disable

using Microsoft.AspNetCore.Http;

namespace ImageUpload.Entity
{
    public partial class UploadImageModel
    {
        public string ImageName
        {
            get; set;
        }
        public string ImagePath
        {
            get; set;
        }
        public IFormFile Image
        {
            get; set;
        }

    }
}
