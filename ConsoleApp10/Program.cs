using System;

public class Person
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public DateTime DogumTarihi { get; set; }

    public Person(string ad, string soyad, DateTime dogumTarihi)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = dogumTarihi;
    }

    public override string ToString()
    {
        return $"{Ad} {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Öğrenci nesneleri oluşturuluyor
        Person ogrenci1 = new Person("Ali", "Yılmaz", new DateTime(2003, 5, 21));
        Person ogrenci2 = new Person("Ayşe", "Demir", new DateTime(2002, 8, 13));

        // Öğretmen nesneleri oluşturuluyor
        Person ogretmen1 = new Person("Ahmet", "Kaya", new DateTime(1975, 12, 19));
        Person ogretmen2 = new Person("Fatma", "Şahin", new DateTime(1980, 3, 30));

        // Öğrencilerin bilgilerini yazdırma
        Console.WriteLine("Öğrenciler:");
        Console.WriteLine(ogrenci1);
        Console.WriteLine(ogrenci2);

        // Öğretmenlerin bilgilerini yazdırma
        Console.WriteLine("\nÖğretmenler:");
        Console.WriteLine(ogretmen1);
        Console.WriteLine(ogretmen2);
    }
}
