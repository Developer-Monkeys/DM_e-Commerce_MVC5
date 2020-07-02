using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using DM_e_Commerce_MVC.Migrations;
using MongoDB.Driver;

namespace DM_e_Commerce_MVC.App_Start
{
    public class MongoDbContext
    {
         MongoClient _client;
         public IMongoDatabase db;

         public MongoDbContext()
         {

            var _mongoClient = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            db = _mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
         }

    }
}