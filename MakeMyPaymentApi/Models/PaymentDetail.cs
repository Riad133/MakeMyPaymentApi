﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MakeMyPaymentApi.Models
{
    public class PaymentDetail
    {
        
      
        public int PaymentDetailId { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        
        public string ExpirationDate { get; set; }
        
        public string SecurityCode { get; set; }
    }
}