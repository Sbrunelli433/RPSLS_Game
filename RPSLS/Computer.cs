using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        // member variables (HAS A...)

        //Player Child Object


        // Constructor(spawner)
        public Computer(string name) : base(name)
        {
            this.name = name;

        }

        // Member Methods (CAN DO...)
        //CAN DO RANDOM NUMBER GENERATOR FOR GESTURE CHOICE();

        public override void ChooseGesture()
        {
            Random random = new Random();
            Console.WriteLine("RANDOM: " + random.Next(0, 4));
            Console.ReadLine();
        }




        //public override void DisplayGestureChoiceP2()
        //{
        //    base.DisplayGestureChoiceP2();
        //    Console.ReadLine();




        //}
    }
}
