using Person;


public class Program
{
    public static void Main(string[] args)
    {
        // Öğrenci nesneleri oluşturuluyor
        oop ogrenci1 = new oop("Ali", "Yılmaz", new DateTime(2003, 5, 21));
        oop ogrenci2 = new oop("Ayşe", "Demir", new DateTime(2002, 8, 13));

        // Öğretmen nesneleri oluşturuluyor
        oop ogretmen1 = new oop("Ahmet", "Kaya", new DateTime(1975, 12, 19));
        oop ogretmen2 = new oop("Fatma", "Şahin", new DateTime(1980, 3, 30));

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
