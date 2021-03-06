﻿using PossumLabs.Specflow.Core;
using PossumLabs.Specflow.Core.Variables;
using System;
using System.Collections.Generic;

namespace PossumLabs.Specflow.Slipka
{
    public class CallTemplate : IEntity
    {
        public CallTemplate()
        {
            Tags = new List<string>();
        }

        public Message Response { get; set; }
        public Message Request { get; set; }
        public string StatusCode { get; set; }

        //request
        public string Method { get; set; }
        public string Uri { get; set; }

        //metadata
        public int? Duration { get; set; }

        public List<string> Tags { get; set; }

        public string LogFormat()
            => $"{Method} {Uri}";
    }
}
