using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;

namespace Mvc4BaseApp.Controllers
{
    public class MongoDbBaseController : Controller
    {
        public MongoDatabase Database
        {
            get
            {
                return MongoDatabase.Create(GetMongoDbConnectionString());
            }
        }

        public MongoCollection<T> GetCollection<T>(string collectionName)
        {
            return Database.GetCollection<T>(collectionName);
        }

        private string GetMongoDbConnectionString()
        {
            return ConfigurationManager.AppSettings.Get("MONGODB_URL");
        }
    }
}