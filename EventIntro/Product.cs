using System;
using System.Collections.Generic;
using System.Text;

namespace EventIntro
{
    public delegate void StockControl();
    public class Product
    {
        int _stock;
        public Product(int stock)
        {
            _stock = stock; 
        }
        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        { 
            //stogu okuyoruz
            get { 
                return _stock; 
            } 
            //stogu set edebiliyoruz ve koşullar varsa event çalışıyor
            set { 
                _stock = value;
                if (value<=15 && StockControlEvent != null)//stok 15den az kaldığında bizi uyarsın ve stok kontolde abone mi kontol ediyoruz.--evente abone olmuş mu
                {
                    StockControlEvent();// eventı tetikliyoruz
                }
            }
        }  
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} Stock amount : {0}", Stock,ProductName); 
        }
    }
}
