using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baddie_Clicks_v2._0
{
    interface IBaddie
    {
        int SpawnRate { get;}
        void MoveSpeed();
        void Attack();
    }
}
