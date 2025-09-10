﻿using System;

namespace Konu03Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu03 Operatörler");
            Console.WriteLine("1-Aritmetik Operatörler");
            int sayi1 = 3;
            int sayi2 = 4;
            int sayi3 = 5;
            Console.WriteLine();
            Console.WriteLine($"Sayılar sayi: {sayi1} sayi2: {sayi2} sayi3: {sayi3}"); // string tırnağının önüne $ işareti koyarak string interpolasyonu yapıyoruz.
            Console.WriteLine("1234" + sayi3); // string ile int arasında + işlemi yapıldığında toplama yerine birleştirme işlemi yapılır.
            Console.WriteLine("1-Aritmetik Operatörler");
            Console.WriteLine("Hesaplama İşlemleri: ");
            Console.WriteLine(); sayi2++; // değişken değerini arttırı
            Console.WriteLine("sayi1 + sayi2: " + (sayi1 + sayi2));
            Console.WriteLine("sayi1 - sayi2: " + (sayi1 - sayi2));
            Console.WriteLine("sayi1 * sayi2: " + (sayi1 * sayi2));
            Console.WriteLine("sayi1 / sayi2: " + (sayi1 / sayi2));
            Console.WriteLine("sayi1 % sayi2: " + (sayi1 % sayi2));

            Console.WriteLine();
    
            Console.WriteLine("Arttırım ve Azaltım Operatorleri");
            sayi2++; // değişken değerini arttırır   
            Console.WriteLine("sayi2: " + sayi2);
            sayi2--; // değişken değerini azaltır
            Console.WriteLine("sayi2: " + sayi2);
            
            Console.WriteLine();

            Console.WriteLine("Atama Operatörleri"); 

            Console.WriteLine("sayi1 += sayi2: " + (sayi1 += sayi2));
            Console.WriteLine("sayi1 -= sayi2: " + (sayi1 -= sayi2));
            Console.WriteLine("sayi1 *= sayi2: " + (sayi1 *= sayi2)); 
            Console.WriteLine("sayi1 /= sayi2: " + (sayi1 /= sayi2));
            Console.WriteLine("sayi1 %= sayi2: " + (sayi1 %= sayi2));

            Console.WriteLine();

            Console.WriteLine("ilişkisel Operatorler"); // birden fazla değeri karşılaştırıp aralarındaki durumu öğrenmek için kullanılır
            Console.WriteLine($"Sayılar sayi1: {sayi1} sayi2: {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayi1 ==sayi2: " + (sayi1 == sayi2));
            Console.WriteLine("sayi1 !=sayi2: " + (sayi1 != sayi2));
            Console.WriteLine("sayi1 >sayi2: " + (sayi1 > sayi2));
            Console.WriteLine("sayi1 <sayi2: " + (sayi1 < sayi2));
            Console.WriteLine("sayi1 >=sayi2: " + (sayi1 >= sayi2));
            Console.WriteLine("sayi1 <=sayi2: " + (sayi1 <= sayi2));

            Console.WriteLine();

            Console.WriteLine("Ternary Operatörü"); //eğer karşılaştırma için 2 değer kullanacaksak karşılaştırmanın kısa yolu için kullanılır
            Console.WriteLine("Ternary: " + ((sayi1 == sayi2) ? $"sayı 1({sayi1}) sayı 2({sayi2}) ye eşit" : $"sayı 1({sayi1}) sayı2({sayi2}) ye eşit değil"));

            Console.WriteLine("Mantıksal Operatörler");
            Console.WriteLine("And & Operatörü");
            Console.WriteLine(" & Operatörü her iki şartın da sağlanmasını ister");
            Console.WriteLine("((sayi1 == sayi2) && sayi1 < sayi2): " + ((sayi1 == sayi2) && (sayi1 < sayi2)));

            Console.WriteLine();

            Console.WriteLine("Veya || Operatörü");
            Console.WriteLine(" || Operatörü her iki şarttan birinin sağlanmasını ister");
            Console.WriteLine("(sayi1 == sayi2) || sayi1 < sayi2): " + ((sayi1 == sayi2) || (sayi1 < sayi2)));
        }
    }
}
