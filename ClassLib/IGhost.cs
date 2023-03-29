using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib                                                                          
{
    public interface IGhost                                                                 //Interface used for the basic things that both ghosts need
    {
        int positionX { get; set; }                                                         //These are used to set and get the positions for the ghosts
        int positionY { get; set; }
    }
}
