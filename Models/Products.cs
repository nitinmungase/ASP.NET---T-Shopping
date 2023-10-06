using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace T_Shopping.Models
{
    public class Products
    {

        [Key]
        public int Pid { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public int Price { get; set; }

        [DisplayName("Image Name")]
        public string Imgname { get; set; }
        
        [NotMapped]
        [DisplayName("Upload file")]
        public IFormFile ImgFile { get; set; }

    }
}
