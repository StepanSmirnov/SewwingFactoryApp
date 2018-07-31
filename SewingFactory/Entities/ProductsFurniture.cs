﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SawingFactory.Entities
{
    public class ProductsFurniture
    {
        [Key]
        [Column(Order = 1)]
        public string FurnitureId { get; set; }
        public Furniture Furniture { get; set; }
        [Key]
        [Column(Order = 2)]
        public string ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public string Placing { get; set; }
        public double? Width { get; set; }
        public string WidthUnit { get; set; }
        public double? Length { get; set; }
        public string LengthUnit { get; set; }
        public double? Rotation { get; set; }
        public int Quantity { get; set; }
    }
}