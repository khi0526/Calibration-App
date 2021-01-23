using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calibration
{
    class DeviceInfo
    {
        public string Name;
        public string Address;
        public string Port;
        public double Value;

        public bool Using;
        public bool Connecting;
        public bool[,] Complete = new bool[3, 3];
        public int[] Dose;

        public DeviceInfo()
        {
            Name = "";
            Address = "";
            Port = "";
            Value = 0;

            Using = false;
            Connecting = false;
        }

        public DeviceInfo(string file, int index)
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
                    Value = Convert.ToDouble(rd.ReadLine().Split('=')[1]);

                    break;
                }
            }

            Connecting = false;
        }
    }
}
