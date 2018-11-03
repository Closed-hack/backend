using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data_grab
{
    public class Query
    {
        public List<Test> getAll()
        {
            List<Test> tests = new List<Test>();
            tests.Add(new Test() { Name = "Hello", Value = 1337 });
            return tests;
        }
        
    }
}
