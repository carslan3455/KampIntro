using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac kredisi odeme plani hesaplandi...");
        }
    }
}
