using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class CardItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }

        //public static decimal operator + (CardItem left, CardItem right)
        //{
        //    return (left.Price * left.Quantity) + (right.Price * right.Quantity);
        //}

        public static int operator +(CardItem left, CardItem right)
        {
            if (left == right)
            {
               return  left.Quantity += right.Quantity;
            }
            throw new ArgumentException("Her iki eleman da aynı ürün olmalı");

        }

        public static decimal operator +(decimal left, CardItem right)
        {
            return (right.Quantity * right.Price) + left;
        }

        public static bool operator ==(CardItem left, CardItem right) {
            return left.ProductId == right.ProductId ;
            //elbette sadece productId değil fiyat alanları da denetlenmeli.... 

        }

        public static bool operator !=(CardItem left, CardItem right)
        {
            return left.ProductId != right.ProductId;

        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            return this.ProductId == ((CardItem)obj).ProductId;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}
