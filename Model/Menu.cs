using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalMenuView.Model
{
    public enum Category
    {
        Starter, MainCourse, Dessert, Beverage
    }
    public enum AvaliabilityTime
    {
        AllTime, Breakfast, Lunch, Dinner, MidDays
    }
    public enum AvaliabilityDays
    {
        AllDays, Weekends, Monday, Tuesday, Wednesday, Thrusday, friday, Saturday, Sunday
    }

    [BsonIgnoreExtraElements]
    public class Menu
    {
        //[BsonId]
        //public ObjectId Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Price")]
        public Double Price { get; set; }
        [BsonElement("Category")]
        public Int32 Category { get; set; }
        [BsonElement("AvaliabilityTime")]
        public Int32 AvaliabilityTime { get; set; }
        [BsonElement("AvaliabilityDays")]
        public Int32 AvaliabilityDays { get; set; }
        [BsonElement("IsSoldOut")]
        public bool IsSoldOut { get; set; }
        [BsonElement("WaitingTime")]
        public Int32 WaitingTime { get; set; }
        [BsonElement("IsFastSelling")]
        public bool IsFastSelling { get; set; }
        [BsonElement("IsChefSpecial")]
        public bool IsChefSpecial { get; set; }
        [BsonElement("IsVegan")]
        public bool IsVegan { get; set; }
        [BsonElement("IsVegetarian")]
        public bool IsVegetarian { get; set; }
        [BsonElement("SpiceLevel")]
        public int SpiceLevel { get; set; }
        [BsonElement("Cusine")]
        public string Cusine { get; set; }
        [BsonElement("ShortDescription")]
        public string ShortDescription { get; set; }
        //[BsonExtraElements]
        //public object[] ExtraElements { get; set; }
    }
    
}