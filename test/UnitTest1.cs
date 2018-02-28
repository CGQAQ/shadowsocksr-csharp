using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.NetworkInformation;


namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Ping ping = new Ping();
            for (int i = 0; i < 50; i++)
            {
                PingReply pingReply = ping.Send("baidu.com");
                Console.Out.WriteLine(pingReply.RoundtripTime);
                Console.Out.WriteLine(pingReply.Status);
            }
            

        }
    }
}
