using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppProductManagementSystem.Classes
{
    public enum SortProductFeild
    {
        ProductID = 1,
        ProductName = 2,
        ProductPrice = 3,
        ProductDate = 4,
        ProductQuantity = 5,
       
    }
    public class ProductManagement
    { 
        
        private ProductDetail[] _ListProduct;
        private int _currentPosition=0;
        public ProductManagement() { }
        public ProductManagement(ProductDetail[] productlist)
        {
            this._ListProduct = productlist;
        }
        public int Count
        {
            get
            {
                if (_ListProduct == null)
                {
                    return 0;
                }
                return _ListProduct.Length;
            }
        }
        public int CurrentPosition
        {
            get
            {
                if (_ListProduct == null || _ListProduct.Length == 0)
                {
                    return -1;
                }
                return _currentPosition + 1;
            }
        }
        public ProductDetail[] getListOfProduct
        {
            get
            {
                return _ListProduct;
            }
        }
        public void add(ProductDetail obj )
        {
            ProductDetail[] temp;
            if (_ListProduct == null || _ListProduct.Length == 0)
            {
                _ListProduct = new ProductDetail[1];
                _ListProduct[0] = obj;
                _currentPosition = _ListProduct.Length - 1;

            }
            else
            {
                temp = new ProductDetail[_ListProduct.Length + 1];
                Array.Copy(_ListProduct, temp, _ListProduct.Length);
                _ListProduct = temp;
                temp = null;
                _ListProduct[_ListProduct.Length - 1] = obj;
                _currentPosition = _ListProduct.Length - 1;

            }

        }

        public float getTotalAmount()
        {
            float _total = 0.0f;
            if (_ListProduct == null || _ListProduct.Length == 0)
            {
                return 0.0f;
            }
            foreach (ProductDetail exp in _ListProduct)
            {
                _total += exp.ProductPrice;
            }
            return _total;
        }
        public ProductDetail MoveFirst()
        {
            if (_ListProduct == null | _ListProduct.Length == 0)
            {
                return null;
            }
            else if (_currentPosition > 0)
            {
                _currentPosition = 0;

            }
            return _ListProduct[_currentPosition];
        }
        public ProductDetail MoveLast()
        {
            if (_ListProduct == null | _ListProduct.Length == 0)
            {
                return null;
            }
            else if (_currentPosition < _ListProduct.Length)
            {
                _currentPosition = _ListProduct.Length - 1;
            }
            return _ListProduct[_currentPosition];
        }
        public ProductDetail MovePrevious()
        {
            if (_ListProduct == null | _ListProduct.Length == 0)
            {
                return null;
            }
            else if (_currentPosition > 0)
            {
                _currentPosition--;

            }
            return _ListProduct[_currentPosition];
        }
        public ProductDetail MoveNext()
        {
            if (_ListProduct == null | _ListProduct.Length == 0)
            {
                return null;
            }
            else if (_currentPosition < _ListProduct.Length - 1)
            {
                _currentPosition++;

            }
            return _ListProduct[_currentPosition];
        }
        public void Update(ProductDetail old, ProductDetail exp_new)
        {
            for (int i = 0; i <= _ListProduct.Length - 1; i++)
            {
                if (_ListProduct[i].ProductId == old.ProductId)
                {
                    _ListProduct[i] = exp_new;
                }
            }
        }
        public void Delete(ProductDetail obj)
        {
            var The_remain_expense = from ex in _ListProduct
                                     where ex.ProductId != obj.ProductId
                                     select ex;
            if (The_remain_expense == null)
            {
                _currentPosition = -1;
                _ListProduct = null;
            }
            else if (The_remain_expense != null && The_remain_expense.Count() == 0)
            {
                _currentPosition = -1;
                _ListProduct= null;
            }
            _ListProduct = The_remain_expense.ToArray();
            if (_currentPosition > _ListProduct.Length - 1)
            {
                _currentPosition = _ListProduct.Length - 1;
            }
        }
    }
}
