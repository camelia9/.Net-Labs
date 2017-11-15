using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ClassLibraryLab2
{
    public class ShoppingCart
    {
        public List<Discount> Discounts = new List<Discount>();

        public void AddDiscount(Discount discount)
        {
            if (Discounts.Count <= 4)
            {
                Discounts.ForEach(existingDiscount =>
                {
                    if (discount.StartDate > existingDiscount.EndDate || discount.EndDate < existingDiscount.StartDate)
                        Discounts.Add(discount);
                    else throw new BusinessException("You have more than one discount for a period of time");
                });
            }
            else throw new BusinessException("You have more than 4 discounts for this shopping cart");
        }

        public void GetDiscountsForTimePeriod(DateTime startTime, DateTime endTime)
        {
            Discounts.ForEach(existingDiscount =>
            {
                if (existingDiscount.StartDate >= startTime && existingDiscount.EndDate <= endTime)
                {
                    Console.WriteLine("Discount value:" + existingDiscount.DiscountPercentage.ToString() + "Period:" +
                                      existingDiscount.StartDate.ToString() + " " +
                                      existingDiscount.EndDate.ToString());
                }
                ;

            });
        }
    }
}
