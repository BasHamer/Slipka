﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PossumLabs.Specflow.Core.Exceptions
{
    public class ActionExecutor
    {
        public void Execute(Action action)
        {
            try
            {
                action();
            }
            catch(Exception e)
            {
                if (ExpectException && Exception == null)
                    Exception = e;
                else if (ExpectException)
                    throw new AggregateException(Exception, e);
                else
                    throw e;

            }
        }

        public bool ExpectException { get; set; }

        public Exception Exception { get; set; }
    }
}