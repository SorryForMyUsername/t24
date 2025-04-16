using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_1
{
    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name) { }

        public override void Read()
        {
            Console.WriteLine($"{Name} читает очень медленно!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} отдыхает, играя в компьютерные игры!");
            
        }

        public override void Study()
        {
            Console.WriteLine($"{Name} учится плохо!");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name} пишет с большим количеством ошибок!");
        }
    }
}
