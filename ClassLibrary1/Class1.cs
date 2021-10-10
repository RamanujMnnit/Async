using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public async Task<String> DoAsync()
        {
            await Task.Delay(1000);
            return "abcd";
        }
    }
}
