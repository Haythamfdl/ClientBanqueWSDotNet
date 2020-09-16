﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientBanqueWS
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.BanqueServiceClient stub = new ServiceReference1.BanqueServiceClient();
            Console.WriteLine(stub.ConversionEuroToDH(90));
            ServiceReference1.compte cp = stub.getCompte(6);
            Console.WriteLine("Code:" + cp.code);
            Console.WriteLine("Solde:" + cp.solde);
            ServiceReference1.compte[] cptes = stub.listComptes();
            foreach(var c in cptes)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Code:" + c.code);
                Console.WriteLine("Solde:" + c.solde);
            }
            Console.ReadLine();
        }
    }
}
