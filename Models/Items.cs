using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2.Asp.net_Core_L1.Models
{
    public class Items
    {
        public int id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string image { get; set; }

        public List<Items> AddItems()
        {
            List<Items> Item = new List<Items>
        {
            new Items{id=1,name="Stylish Jeans",image="1.jpg",price="400"},
            new Items{id=2,name="Casual Jeans",image="2.jpg",price="1000"},
            new Items{id=3,name="White Tshirt",image="3.jpg",price="3000"},
            new Items{id=4,name="Apple",image="4.jpg",price="2332"},
            new Items{id=5,name="Telephone",image="5.jpg",price="4444"},
            new Items{id=6,name="IPhone",image="6.jpg",price="2424"},
            new Items{id=7,name="Shirt",image="7.jpg",price="3333"},
            new Items{id=8,name="Samsung",image="8.jpg",price="1000"},
            new Items{id=9,name="Cola",image="9.jpg",price="300"},
            new Items{id=10,name="Casual Jeans",image="2.jpg",price="3000"},
            new Items{id=11,name="TelePhone",image="5.jpg",price="200"},
            new Items{id=12,name="Iphone",image="6.jpg",price="3300"},
            new Items{id=13,name="Casual Jeans",image="2.jpg",price="3000"},
            new Items{id=14,name="Stylish Jeans",image="1.jpg",price="1010"},
            new Items{id=15,name="Samsung",image="8.jpg",price="1003"},
            new Items{id=16,name="Cola",image="9.jpg",price="2000"},
            new Items{id=17,name="Apple",image="4.jpg",price="2000"},
            new Items{id=18,name="Iphone",image="6.jpg",price="2000"}

        };
            return Item;
        }
    }
}
