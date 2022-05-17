using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        ///<summary>
        ///자동차가 들어온 시간 설정
        ///</summary>
        public void SetInTIme()
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTIme()
        {
            this.outTime = DateTime.Now;
        }
    }
}
