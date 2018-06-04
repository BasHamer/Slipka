﻿using PossumLabs.Specflow.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PossumLabs.Specflow.Slipka
{
    public class Header : IValueObject
    {
        public Header()
        {

        }

        public Header(string key, IEnumerable<string> values)
        {
            Key = key;
            Values = values.ToList();
        }

        public string Key { get; set; }
        public List<string> Values { get; set; }
    }
}
