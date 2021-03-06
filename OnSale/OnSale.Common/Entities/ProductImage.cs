﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Common.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            //? $"https://localhost:44304/images/noimage.png"
            ? $"https://onsaleivan.azurewebsites.net/images/noimage.png"
            : $"https://onsaledemo.blob.core.windows.net/products/{ImageId}";
    }

}
