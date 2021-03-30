using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    // interfaceleri I harfiyle başlatırız okunurluğu kolay olsun diye interface olduğunu anlamak için
    // interface bizim şablonumuzdur
    // interfaceleri bir birinin alternatifi olan ama kod içerikleri farklı olan içerikler için kullanırız
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
