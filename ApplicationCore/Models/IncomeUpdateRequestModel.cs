﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Models
{
    public class IncomeUpdateRequestModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [Range(0.0, Double.MaxValue, ErrorMessage = "This is Income Record, Please enter Amount greater than 0.00")]
        public decimal Amount { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime IncomeDate { get; set; }
        public string Remarks { get; set; }
    }
}
