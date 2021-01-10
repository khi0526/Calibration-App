using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calibration
{
    class UserInfo
    {
        public string Name;
        public string Address;
        public string Port;
        public string Value;

        public UserInfo()
        {
            Name = "";
            Address = "";
            Port = "";
            Value = "";
        }

        public UserInfo(string file, int index)
        {
            var rd = new StreamReader(file);
            string line;
            while(!rd.EndOfStream)
            {
                line = rd.ReadLine();
                if(line.Contains($"Device{index}"))
                {
                    Name = rd.ReadLine().Split('=')[1];
                    Address = rd.ReadLine().Split('=')[1];
                    Port = rd.ReadLine().Split('=')[1];
                    Value = rd.ReadLine().Split('=')[1];

                    break;
                }
            }
        }
    }
}
