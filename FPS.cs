using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Stone_Evan
{
    class FPS : Game
    {
        //sets FPS
        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;

        }
        //overrides Describe
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }

    }
}
