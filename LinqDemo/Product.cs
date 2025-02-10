using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class ProductEqualityComparer02 : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            return x.UnitPrice.Equals(y.UnitPrice);
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
           return   obj.ProductID.GetHashCode();
        }
    }
    class ProductCompraer : IComparer<Product> 
    {
        public int Compare(Product? x, Product? y)
        {
           return  x.UnitPrice.CompareTo(y.UnitPrice);
        }
    }

    public class Product:IComparable<Product> , IEquatable<Product>
    {
            public long ProductID { get; set; }
            public string ProductName { get; set; }
            public string Category { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }

        public int CompareTo(Product? other)

           => this.UnitPrice.CompareTo(other.UnitPrice);

        public bool Equals(Product? other)
        {
          if(other is null)
            {
                return false;
            }
            return this.ProductID.Equals(other.ProductID)
                   && this.UnitPrice.Equals(other.UnitPrice)
                   && this.UnitsInStock.Equals(other.UnitsInStock)
                  && this.ProductID.Equals(other.ProductID)
                  && this.Category.Equals(other.Category);
        }
        public override int GetHashCode()
        
            =>HashCode.Combine(this.ProductID, this.ProductName, this.Category, this.UnitPrice, this.UnitsInStock);
        

        public override string ToString()
                => $"ProductID: {ProductID}, ProductName: {ProductName}, Category: {Category}, UnitPrice: {UnitPrice:c}, UnitsInStock: {UnitsInStock}";

        
    }
}
