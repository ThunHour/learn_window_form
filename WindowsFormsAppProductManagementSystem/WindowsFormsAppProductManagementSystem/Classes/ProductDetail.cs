using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace WindowsFormsAppProductManagementSystem.Classes
{
 
    public class ProductDetail: IComparable
    {
        public static SortProductFeild _SortProductField = SortProductFeild.ProductID;
        public void SetProductFeild(SortProductFeild sortExpenseFeild)
        {
            _SortProductField = sortExpenseFeild;
        }
        private string _productId;
        private string _productName;
        private float _productPrice;
        private DateTime _productDeadline;
        private int _productQuantity;
        public ProductDetail() { }
        public ProductDetail(         string productId,
         string productName,
         float productPrice,
         DateTime productDeadline,
         int productQuantity)
        {
            this._productId = productId;
            this._productName = productName;
            this._productPrice = productPrice;
            this._productDeadline = productDeadline;
            this.ProductQuantity = productQuantity;
        }
        public override string ToString()
        {
            return String.Format("Product ID :{0}   ,   Product Name :{1}", _productId, _productName);
        }
        public string ProductId { get => _productId; set => _productId = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public float ProductPrice { get => _productPrice; set => _productPrice = value; }
        public DateTime ProductDeadline { get => _productDeadline; set => _productDeadline = value; }
        public int ProductQuantity { get => _productQuantity; set => _productQuantity = value; }


        public int CompareTo(object obj)
        {
            ProductDetail temp = (ProductDetail)obj;
            if (_SortProductField == SortProductFeild.ProductID)
            {
                return this.ProductId.CompareTo(temp.ProductId);
            }
            else if (_SortProductField == SortProductFeild.ProductName)
            {
                return this.ProductName.CompareTo(temp.ProductName);
            }
            else if (_SortProductField == SortProductFeild.ProductPrice)
            {
                return this.ProductPrice.CompareTo(temp.ProductPrice);
            }
            else if (_SortProductField == SortProductFeild.ProductDate)
            {
                return this.ProductDeadline.CompareTo(temp.ProductDeadline);
            }
            else if (_SortProductField == SortProductFeild.ProductQuantity)
            {
                return this.ProductQuantity.CompareTo(temp.ProductQuantity);
            }
            return 0;

        }
    }
}
