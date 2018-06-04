﻿using PossumLabs.Specflow.Core;
using PossumLabs.Specflow.Slipka;
using PossumLabs.Specflow.Slipka.ValueObjects;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace LegacyTest.Steps
{
    [Binding]
    public class SessionSteps : RepositoryStepBase<Session>
    {
        public SessionSteps(ScenarioContext scenarioContext, FeatureContext featureContext) : base(scenarioContext, featureContext)
        {
        }

        protected override void Create(Session l)
        {
            throw new NotImplementedException();
        }

        //TODO: cleanup
        new public void Add(string key, Session value) 
            => base.Add(key, value);
    }
}
