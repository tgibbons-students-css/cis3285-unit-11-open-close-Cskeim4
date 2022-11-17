using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Abstract class to interface
namespace AbstractTrader
{
    public interface ITradeProcessor
    {
        void ProcessTrades(Stream stream);
    }
}