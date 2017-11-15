using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryLab2
{
    public class Discount
    {
        public DateTime StartDate {
            get { return StartDate; } set{} } 
        public DateTime EndDate { get;  set; }
        public int DiscountPercentage { get;  set; }
        public List<Discount> ExistingDiscounts;
        
        public Discount()
        {
        }

        public void SetDiscountPercentage(int discountPercentage)
        {
            if (discountPercentage < 30)
            {
                this.DiscountPercentage = discountPercentage;
            }
            else
            {
                throw new BusinessException("Discount percentage bigger than 30");
            }

       
        }

        public void SetPeriod(DateTime startDate, DateTime endDate)
        {
            if (startDate < endDate)
            {
                this.StartDate = startDate;
                this.EndDate = endDate;
            }
            else
            {
                throw  new BusinessException("Start date is ahead end date ");
            }
        }

        public void GetDiscountsForTimePeriod(DateTime startTime, DateTime endTime)
        {
            ExistingDiscounts.ForEach(existingDiscount =>
            {
                if (existingDiscount.StartDate >= startTime && existingDiscount.EndDate <= endTime)
                {
                    Console.WriteLine("Discount value:" + DiscountPercentage.ToString() + "Period:" + StartDate.ToString() + " " + EndDate.ToString());
                };
               
            });
        }

        
    }
}
