using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechfixRemotingService
{
    public class TechfixRemotingService
        : MarshalByRefObject, ITechfixRemotingService.ITechfixRemotingService
    {
        public string GetMessage(string name)
        {
            return "Hello" + name;
        }
    }
}
