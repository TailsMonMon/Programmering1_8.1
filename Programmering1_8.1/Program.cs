using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_8._1 {
    class Program {
        static void Main(string[] args) {
            //      DEFINING DATA
            var temprature = 20;
            bool done = false;
            
            do {
                Console.WriteLine("Temperaturen är nu {0} Celcius",temprature);
                try {
                    Console.Write("Mata in temperaturen: ");
                    string input = Console.ReadLine();
                    if(input.ToUpper() == "Q") {    // a "q" will become a "Q". 
                        done = true;
                    }
                    else {
                        temprature = Convert.ToInt32(input);
                        if(temprature < 17 || temprature > 25) {
                            temprature = 20;
                        }
                    }

                }
                catch(FormatException){
                    Console.WriteLine("Skriv endast siffror.");
                    Console.WriteLine();
                }

            } while(!done);
            Console.WriteLine("Tack för denna gång.");
            Console.ReadLine();
        }
    }
}
            /*
             *          PSEUDO CODE
             *          
             * START
             * DO 
             *      Skriv ut temperatur
             *      Skriv ut Mata in temperatur:
             *      Mata in temeratur
             *      IF inmatningen är Q
             *          STOP
             *      ELSE IF temperatur < 17 OR temperatur > 25
             *          temperatur = 20
             * WHILE temperatur >= 17 AND <= 25
             * 
             */
