﻿namespace Consolida.Models
{
    public class Customer
    {
        public int? Id { get; set; }

        public int? CustomerCode { get; set; }

        public string? ProductCode { get; set; }

        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? SurName { get; set; }

        public string? Product { get; set; }

        public decimal? Price { get; set; }
    }
}
