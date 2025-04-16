using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_1
{
    internal class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name) { }

        public override void Read()
        {
            Console.WriteLine($"{Name} читает достаточно быстро!");
        }

        public override void Relax()
        {
            Console.WriteLine($"{Name} отдыхает, смотря телевизор!");

        }

        public override void Study()
        {
            Console.WriteLine($"{Name} учится хорошо!");
        }

        public override void Write()
        {
            Console.WriteLine($"{Name} пишет с небольшими ошибками!");
        }
    }
}
