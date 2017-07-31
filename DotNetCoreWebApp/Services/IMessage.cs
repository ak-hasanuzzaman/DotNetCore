using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DotNetCoreWebApp.Services
{
    public interface IMessage
    {
        string CustomMessage();
    }
    public class Message : IMessage
    {
        private IConfiguration _configuration;
        public Message(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string CustomMessage()
        {
            return _configuration["Message"];
        }
    }
}
