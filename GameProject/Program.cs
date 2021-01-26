using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Gamer gamer1 = new Gamer() { Id = 1,FirstName="Ali",LastName="Yılmaz",NationalityId="123213553",DateOfBirth=new DateTime(2005,12,1) };
            Gamer gamer2=new Gamer() { Id = 2, FirstName = "Yeşim", LastName = "Sanar", NationalityId = "456897654", DateOfBirth = new DateTime(2004, 5, 6) };
            GamerManager gamerManager = new GamerManager();
            gamerManager.Save(gamer1);

            Game game1 = new Game() {Id=1, Name="Grand Theft Auto:San Andreas",Price=19.75 };
            Game game2 = new Game() {Id=2, Name= "Undertale", Price=28.75 };
            SaleManager sale = new SaleManager();
            sale.Sale(gamer2, game1);

            Campaign campaign1 = new Campaign() {Id=1, Name="New Year Campaign", StartingDate=new DateTime(2020,12,24), EndDate=new DateTime(2021,1,2) };
            Campaign campaign2 = new Campaign() { Id = 2, Name = "Valentine's Day", StartingDate = new DateTime(2021, 2, 7),EndDate=new DateTime(2021,2,17) };
            SaleManager sale2 = new SaleManager();
            sale2.CampaignSale(campaign1, game2, gamer1);
            

            
        }
    }
}
