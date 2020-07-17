using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorldResume.Services
{
    public class NullMailService
    {
        private readonly ILogger<NullMailService> _logger;
        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }


        public void SendMessage(string to, string subject, string body)
        {

            //log the message
            _logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");

        }
    }
}
