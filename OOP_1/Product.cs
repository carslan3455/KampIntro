using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_1
{
    class Product   // Entitiy  - > varlik  bu tip class larda sadece özellik olur
    {
        // snippet  - otomatik tamamlanmasi
        public int Id { get; set; }   // Primarykey   - 1.siraya
        public int CategoryId { get; set; }   // Ref Key  - 2.siraya  genel kullanim
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }  // Tc kimlik 
        public int UnitInStock { get; set; }   // urun stok adedi

        // CRUD  ->  Create - Read - Update - Delete
    }
}
