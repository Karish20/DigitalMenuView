using DigitalMenuView.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalMenuView
{
    public class MenuService
    {
        private readonly IMongoCollection<Menu> FoodCollections;
        private Random rd = new Random();
        public MenuService()
        {
            var Client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass&directConnection=true&ssl=false");
            var Db = Client.GetDatabase("DigitalMenu");
            FoodCollections = Db.GetCollection<Menu>("Menu");
        }

        public List<Menu> Get()            
        {
            return FoodCollections.Find(Menu => true).ToList();
        }
                   

        public List<Menu> Create()
        {
            try
            {
                int TotalCount = FoodCollections.Find(Menu => true).ToList().Count;
                Menu FoodItem = new Menu();
                FoodItem.Name = "FoodItem_" + TotalCount;
                FoodItem.AvaliabilityDays = rd.Next(0, 8);
                FoodItem.AvaliabilityTime = rd.Next(0, 4);
                FoodItem.Category = rd.Next(0, 3);
                FoodItem.Cusine = "Indian";
                FoodItem.IsChefSpecial = rd.Next(0, 9) % 2 == 0 ? false : true;
                FoodItem.IsFastSelling = rd.Next(0, 9) % 2 == 0 ? false : true;
                FoodItem.IsSoldOut = rd.Next(0, 1) == 0 ? false : true;
                FoodItem.IsVegetarian = rd.Next(0, 9) % 2 == 0 ? false : true;
                FoodItem.IsVegan = FoodItem.IsVegetarian ? true : false;
                FoodItem.WaitingTime = rd.Next(1, 9);
                FoodItem.SpiceLevel = rd.Next(0, 5);
                FoodItem.Price = rd.Next(1, 9);
                FoodItem.ShortDescription = "Food Item with description";

                FoodCollections.InsertOne(FoodItem);
            }
            catch(Exception ex)
            {
                //Write log
            }
            return Get();
        }
    }
}