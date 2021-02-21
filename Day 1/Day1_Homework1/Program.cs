/*Kodlama.io sistemimizde detaylı bir gezinti yapınız.
Sistemde şart blokları, döngüler ve fonksiyon(metot) olarak kullanıldığını düşündüğünüz kısımları bulunuz. Her biri için en az iki örnek vermelisiniz.*/

using System;
namespace Day1_Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops - Döngüler
            Course course = new Course();
            course.CourseName = "Yazılım Geliştirici Yetiştirme Kampı";
            course.TeacherName = "Engin Demiroğ";
            course.Rate = 40;

            Course[] courses = new Course[] { course };

            foreach (Course item in courses)
            {
                Console.WriteLine("Kursun Adı: " + course.CourseName + " - " + "Öğretmenin Adı: " + course.TeacherName + 
" - " + "Kurs Tamamlama Oranı: " + course.Rate);        //Kursun Adı: Yazılım Geliştirici Yetiştirme Kampı - Öğretmenin Adı: Engin Demiroğ - Kurs Tamamlama Oranı: 40
            }
            
            //Condition and Methods - Koşul ve Metot
            Control control = new Control();
            control.HaveYouSıgnedIn("E");               //Sisteme Hoşgeldiniz!
            control.HaveYouSıgnedIn("H");               //Lütfen Giriş Yapınız!
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int Rate { get; set; }
    }

    class Control
    {
        public void HaveYouSıgnedIn(string control)
        {
            if (control == "E")
            {
                Console.WriteLine("Sisteme Hoşgeldiniz!");
            }
            else
            {
                Console.WriteLine("Lütfen Giriş Yapınız");
            }
        }

    }
}
