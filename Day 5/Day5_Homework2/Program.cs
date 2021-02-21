/*Bir oyun yazmak istiyorsunuz. Bu yazılım için backend kodlarını C# ile geliştirmeyi planlıyoruz. Yeni üye, satış ve kampanya yönetimi yapılması isteniyor. 
 Nesnelere ait özellikleri istediğiniz gibi verebilirsiniz. Burada amaç yazdığınız kodun kalitesidir. Ödevde gereksinimleri tam anlamadığınız durum benim 
 için önemli değil, kendinize göre mantık geliştirebilirsiniz. Dediğim gibi kod kalitesiyle ilgileniyoruz şu an :)

Gereksinimler

1. Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. Müşteri bilgilerinin doğruluğunu 
e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak 
servisi simule etmeniz yeterlidir.)

2. Oyun satışı yapılabilecek satış ortamını simule ediniz.(Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

3. Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

4. Satışlarda kampanya entegrasyonunu simule ediniz.*/

using System;
using System.Collections.Generic;

namespace Day5_Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //İlk player, game, campaign tanımlama tanımlama
            Player player1 = new Player() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", NationalityNo = "1234567890", YearOfBirth = 1980 };
            Player player2 = new Player() { Id = 2, FirstName = "Muhammet Ali", LastName = "Fidan", NationalityNo = "1234567890", YearOfBirth = 2002 };
            Player player3 = new Player() { Id = 3, FirstName = "Mustafa Murat", LastName = "Coşkun", NationalityNo = "1234567890", YearOfBirth = 1991 };

            Game game1 = new Game() { Id = 1, Name = "GTA I", ReleaseDate = 2011, Price = 29.99 };
            Game game2 = new Game() { Id = 2, Name = "GTA II", ReleaseDate = 2012, Price = 39.99 };
            Game game3 = new Game() { Id = 3, Name = "GTA III", ReleaseDate = 2013, Price = 49.99 };

            Campaign campaign1 = new Campaign() { Id = 1, CampaignName = "Happy New Year", DurationCampaign = 2, Discount = 9.99 };
            Campaign campaign2 = new Campaign() { Id = 2, CampaignName = "Black Friday", DurationCampaign = 7, Discount = 4.99 };
            Campaign campaign3 = new Campaign() { Id = 3, CampaignName = "Valentines Day", DurationCampaign = 10, Discount = 7.99 };

            //İkinci olarak Player/Game/Campaign Manager çağırımı
            PlayerManager playerManager = new PlayerManager();
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();

            //Üçüncü olarak içlerindeki her metodu uygulama
            playerManager.Add(player1);
            playerManager.Delete(player2);
            playerManager.Update(player3);

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

            gameManager.Add(game1);
            gameManager.Delete(game2);
            gameManager.Update(game3);

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.Update(campaign3);

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

            //Dördüncü olarak E-Devlet tarzı kontrol için CheckManager'ı uygulayalım
            CheckManager checkManager = new CheckManager();
            checkManager.Check(player1);
            checkManager.Check(player2);

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

            //Beşinci olarak SaleManager'ı çağıralım ve detayları girelim.
            SaleManager saleManager = new SaleManager();
            saleManager.Sale(player1, game1);
            saleManager.Sale(player2, game2, campaign2);
            saleManager.Sale(player3, game3, campaign3);
        }
    }
}