using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeFiExplore
{
    public class Kline
    {
        //public string symbol { get; set; }
        public DateTime OpenTime { get; set; }
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double Volume { get; set; }
        public Kline(string line)
        {
            var split = line.Split(';');
            OpenTime = Convert.ToDateTime(split[0]);
            Open = Convert.ToDouble(split[1]);
            High = Convert.ToDouble(split[2]);
            Low = Convert.ToDouble(split[3]);
            Close = Convert.ToDouble(split[4]);
            Volume = Convert.ToDouble(split[5]);
        }
        public static List<Kline> getKlines()
        {
            var data = File.ReadLines(@"historicBTCdaily.csv").Select(line => new Kline(line)).ToList();
            return data;
        }
    }
}
