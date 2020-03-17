using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Inner
{
    public class Class1
    {
        public static void Test()
        {
            JsonConvert.DeserializeObject<List<string>>("['test', 'test']");
        }
    }
}
