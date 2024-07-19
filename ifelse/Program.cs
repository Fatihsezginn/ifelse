
            Console.Write("Lutfen bir sayi giriniz.");
            int sayi = Convert.ToInt32 (Console.ReadLine());
            if(sayi == 10)
            {
                Console.Write("Girilen sayi 10'a eşittir."); 
            }
            else if(sayi > 10)
            {
                Console.Write("Girilen sayı 10'dan büyüktür.");
            }
            else
            {
                Console.Write("Girilen sayi 10'dan küçüktür.");
            }
            if (sayi % 2 == 0)
            {
                Console.Write("Girilen sayi çifttir");
            }
            else
                Console.Write("Girilen sayi tektir.");
