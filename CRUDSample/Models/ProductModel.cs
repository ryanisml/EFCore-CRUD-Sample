using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDSample.Models
{
    [Table("tb_product")]
    public partial class ProductModel
    {
        public long Id { get; set; }
        public string NamaBarang { get; set; }
        public double Harga { get; set; }
        public int Stok { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

