using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    interface ILoggerService   // Yapilan islemleri kim ne zaman yapmis verilerin tutulma bicimini ayarliyoruz
                              // dosyada mi? database demi tutulsun diye interface olusturduk  
    {
        void Log();
    }
}
