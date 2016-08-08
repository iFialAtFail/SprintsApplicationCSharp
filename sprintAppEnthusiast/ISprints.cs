using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprintAppEnthusiast
{
    //Interface allows for polymorphic treatment of Sprint notification style objects.    
    public interface ISprints
    {
        void finishSprints();

        void startSprints();
    }
    
}
