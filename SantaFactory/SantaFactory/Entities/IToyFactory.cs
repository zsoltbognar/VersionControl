using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SantaFactory.Abstractions;
using SantaFactory.Abstrations;

namespace SantaFactory.Entities
{
    public class IToyFactory: Abstractions.IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }

        
    }
}
