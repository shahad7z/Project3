using System;
using System.Collections.Generic;


namespace test.Net.Models
{
    public class product
    {

        public int productId { get; set; }

        public string name { get; set; }

        public string prand { get; set; }

        public float price { get; set; }

        public string Discription { get; set; }

        public virtual order Order { get; set; }

       
        //public List<order> orders { get; set; }
    }

   
}


