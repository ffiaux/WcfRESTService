﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RESTService.svc or RESTService.svc.cs at the Solution Explorer and start debugging.
    public class RESTService : IRESTService
    {
        public string DoWork(string id)
        {
            return "Hello " + id;
        }

        public void DoPostWork(string id)
        {
            System.IO.File.Create("c:\\Users\\ffiaux\\Desktop\\teste_"+id+".txt");
        }
    }
}
