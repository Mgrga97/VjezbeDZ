﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program unosi brojeve sve dok se ne unese broj -1
    // Program ispisuje zbroj svih unesenih brojeva

    internal class E09Z2
    {
        public static void Izvedi()
        {
            // Console.WriteLine("E09");
            int sum = 0, n;
            while (true)
            {
                Console.WriteLine("Unesi broj: ");
                n=int.Parse(Console.ReadLine());
                if(n == -1)
                {
                    break;
                    
                }
                sum = sum + n;
                
            }
            Console.WriteLine(sum);

        }
        
    }
}
