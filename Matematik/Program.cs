using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortislem = new DortIslem();
            dortislem.Topla(5, 6);
            dortislem.Cikar(9, 6);
            dortislem.Carp(6, 9);
            dortislem.Bolme(90, 9);
        }
    }
}
