using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret_Dal.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool IsApproved { get; set; }//Onayli mi ? onayliysa satista olacak
        public bool IsHome { get; set; }// Anasayfada gorunsun mu 
        public int CategoryId { get; set; }
        public Category Category { get; set; }//category categoryId ve yukardaki  id ayni olmak zorunda 

    }
}
