using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Selamver(isim:"Oğuzhan");
            Selamver();
            //diziler / arrays
            string[] ogrenciler = new string[3];
                ogrenciler[0] = "engin";
                ogrenciler[0] = "kerem";
                ogrenciler[0] = "Oğuzhan";
                ogrenciler[0] = "Ahmet";
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            Person person1 = new Person();
            person1.FirstName = "Oğuzhan";
            person1.LastName = "Cebeci";
            person1.DateOfBirthday = 1998;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Engin";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }
        static void Selamver(string isim="Kullanıcı") 
        {
            Console.WriteLine("merhaba"+" " + isim); 
        }
        
    }
}
