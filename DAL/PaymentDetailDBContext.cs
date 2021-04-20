using Microsoft.EntityFrameworkCore;
using PaymentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.DAL
{
    public class PaymentDetailDBContext : DbContext
    {
        public PaymentDetailDBContext(DbContextOptions<PaymentDetailDBContext> options) : base(options)
        {

        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
