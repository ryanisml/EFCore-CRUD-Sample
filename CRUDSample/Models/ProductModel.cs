using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace waterlevel_netcore.Models
{
    [Table("tb_product")]
    public partial class ProductModel
    {
        [Key]
        public int ID { get; set; }
        public string nama_barang { get; set; }
        public double harga { get; set; }
        public string stok { get; set; }
    }
}

