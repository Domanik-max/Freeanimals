using System;

namespace Shelter.CLI
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string title = @"
DDDDD                       '           HH   HH                       
DD  DD   oooo  mm mm mmmm  '''  sss     HH   HH  oooo  pp pp     eee  
DD   DD oo  oo mmm  mm  mm ''' s        HHHHHHH oo  oo ppp  pp ee   e 
DD   DD oo  oo mmm  mm  mm      sss     HH   HH oo  oo pppppp  eeeee  
DDDDDD   oooo  mmm  mm  mm         s    HH   HH  oooo  pp       eeeee 
                                sss                    pp

Press [1]: Customer
Press [2]: Admin
                                                                  ";

            Console.WriteLine(title);
            Console.Read();



        }
    }
}
