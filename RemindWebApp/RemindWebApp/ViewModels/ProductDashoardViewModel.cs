﻿using Microsoft.AspNetCore.Http;
using RemindWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RemindWebApp.ViewModels
{
    public class ProductDashoardViewModel
    {
       

        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(300, ErrorMessage = "Length can't be more than 300")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required"), StringLength(5000, ErrorMessage = "Length can't be more than 5000")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Required")]
        public int Count { get; set; }

        public int DiscountProduct { get; set; }
        public DateTime? ProductDedline { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Active { get; set; }

        public int MostView { get; set; }
        public int SellerCount { get; set; }

        public int CategoryMarkaId { get; set; }

        public  CategoryMarka CategoryMarka { get; set; }
        public int MarkaId { get; set; }
        public int CategoryId { get; set; }

        public virtual ICollection<Image> Images { get; set; }
      

        [NotMapped]
        [Required(ErrorMessage = "Required")]
        public List<IFormFile> PhotoList { get; set; }

        [NotMapped]

        public List<IFormFile> ChangePhotoList { get; set; }


    }
}