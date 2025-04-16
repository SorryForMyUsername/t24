using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t24_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom room = new ClassRoom(
                new ExcellentPupil("Петров"), 
                new GoodPupil("Иванов"), 
                new BadPupil("Сидоров"));

            room.OutputPupils();
        }
    }
}
