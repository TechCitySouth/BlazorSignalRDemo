using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorSignalR.Shared
{
    public class MPClass
    {
        [MessagePackObject]
        public class MyMessage
        {
            [Key(0)]
            public string user { get; set; }
            [Key(1)]
            public string message { get; set; }
        }
    }
}
