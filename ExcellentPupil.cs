using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_1
{
    internal class ExcellentPupil : Pupil
    {
        public ExcellentPupil(string name) : base(name) { }

        public override void Read()
        {
            Console.WriteLine($"{Name} читает очень быстро!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} отдыхает, играя в шахматы!");

        }

        public override void Study()
        {
            Console.WriteLine($"{Name} учится отлично!");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name} пишет без ошибок!");
        }
    }
}
