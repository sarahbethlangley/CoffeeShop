﻿using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int BeanVarietyId { get; set; }
        public string BeanVariety { get; set; }

    }
}
