using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI.Models
{
    public class DeliveryMethodResponse : DeliveryMethodRequest
    {

        public float CalculateCost(BookStoreDb.DeliveryMethod deliveryMethod)
        {
            var month = DateTime.UtcNow.Month;
            float cost = 0.0F;
            switch (month)
            {
                case 1:
                    cost = deliveryMethod.BaseCost * deliveryMethod.January;
                    break;
                case 2:
                    cost = deliveryMethod.BaseCost * deliveryMethod.February;
                    break;
                case 3:
                    cost = deliveryMethod.BaseCost * deliveryMethod.March;
                    break;
                case 4:
                    cost = deliveryMethod.BaseCost * deliveryMethod.April;
                    break;
                case 5:
                    cost = deliveryMethod.BaseCost * deliveryMethod.May;
                    break;
                case 6:
                    cost = deliveryMethod.BaseCost * deliveryMethod.June;
                    break;
                case 7:
                    cost = deliveryMethod.BaseCost * deliveryMethod.July;
                    break;
                case 8:
                    cost = deliveryMethod.BaseCost * deliveryMethod.August;
                    break;
                case 9:
                    cost = deliveryMethod.BaseCost * deliveryMethod.September;
                    break;
                case 10:
                    cost = deliveryMethod.BaseCost * deliveryMethod.October;
                    break;
                case 11:
                    cost = deliveryMethod.BaseCost * deliveryMethod.November;
                    break;
                case 12:
                    cost = deliveryMethod.BaseCost * deliveryMethod.December;
                    break;
            }
            return cost;
        }
    }
}
