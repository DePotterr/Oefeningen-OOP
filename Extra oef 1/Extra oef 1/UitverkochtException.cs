using System;
using System.Runtime.Serialization;

namespace Extra_oef_1
{
    internal class UitverkochtException : Exception
    {
        public Product Product { get; set; }
        public UitverkochtException(Product product) : base("DIT PRODUCT IS UITVERKOCHT: " + product.Naam)
        {
            Product = product;
        }
    }
}