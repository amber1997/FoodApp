using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp
{
    class RptMenuShow : ShowMenuRpt
    {
        private int FoodPrice,sumOfPrice=0;
        private DateTime dateTime = DateTime.Now;
        private string dateTimeStr;

        public int Price(int FoodPrice)
        {
            this.FoodPrice = FoodPrice;
            sumOfPrice += FoodPrice;
            return sumOfPrice;

        }

        

        public void ShowTime()
        {
            dateTimeStr = this.dateTime.ToString() ;
        }
    }
}
