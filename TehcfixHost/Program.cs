using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Services;

namespace TehcfixHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TechfixRemotingService.TechfixRemotingService remotingService = new TechfixRemotingService.TechfixRemotingService();
            TcpChannel channel = new TcpChannel(8080);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(TechfixRemotingService.TechfixRemotingService), "GetMessage", 
WellKnownObjectMode.Singleton);
            Console.WriteLine("Remoting service started @ " + DateTime.Now);
            Console.ReadLine();
        }
    }
}
