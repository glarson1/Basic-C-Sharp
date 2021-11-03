using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    interface IWalkAway
    {
        //everything is public in an interface so we dont have to put public before void WalkAway
        void WalkAway(Player player);

    }
}
