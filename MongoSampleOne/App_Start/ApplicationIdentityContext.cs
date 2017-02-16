using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MongoSampleOne.App_Start
{
    public class ApplicationIdentityContext : IDisposable
    {
        public static ApplicationIdentityContext Create()
        {
            // todo add settings where appropriate to switch server & database in your own application
            var client = new MongoClient("mongodb://local:27017/");
            var database = client.GetDatabase("MongoSamples");
            return new ApplicationIdentityContext();
        }
        public void Dispose()
        {
        }
    }
}