using System;

class Program

{
    static void Main()
    {
        Console.WriteLine("Lütfen ilk dersin notunu giriniz");
        int not1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen ikinci dersin notunu giriniz");
        int not2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lütfen Üçüncü Dersin notunu giriniz");
        int not3 = Convert.ToInt32(Console.ReadLine());

        double ort = (not1 + not2 + not3) / 3;
        
        if (ort < 50)

        Console.WriteLine("Sinifta Kaldiniz Ortalamaniz: {0}", ort);

        else if (ort > 50)

        Console.WriteLine("Sinifi Geçtiniz Ortalamaniz: {0}", ort);

    


    }











}




