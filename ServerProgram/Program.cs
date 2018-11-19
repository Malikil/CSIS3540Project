﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Test t = new Test();
            //t.AddStudentTest();
            t.AddAccountTest();
            
            IClientListener server = new ClientListener();
            server.BeginWaitForConnections();
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
            server.EndWaitForConnections();
            server.Disconnect();
            
        }
    }
}