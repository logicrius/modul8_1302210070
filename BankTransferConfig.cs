using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul8_1302210070
{
    internal class BankTransferConfig
    {
        private String BT = "bank_transfer_config.json";
        private BTConfig ReadConfigFile(BTConfig config)

        {
            String configJsonString = File.ReadAllText(@"E:\praktik\modul8_1302210070\modul8_1302210070\bank_transfer_config.json");
            config = JsonSerializer.Deserialize<BTConfig>(configJsonString);
            return config;
        }
        string configJsonString = File.ReadAllText(@"E:\praktik\modul8_1302210070\modul8_1302210070\bank_transfer_config.json");
    }
}
