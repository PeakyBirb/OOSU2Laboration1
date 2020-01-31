using System;
using System.Collections.Generic;
using System.Text;

namespace Business_layer
{
    public class BusinessManager
    {
        Repository.BokningRepository BokningR = new Repository.BokningRepository();

        public IEnumerable<Bokning> HämtaAllaBokningar()
        {
            return BokningR.HämtaAlla();
        }



    }
}
