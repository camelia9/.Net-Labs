using System;
using ClassLibraryLab2;
using Xunit;

namespace XUnitTestLab2
{
    public class UnitTest1
    {
        [Fact]
        public void TestDiscount()
        {
            Discount discount = new Discount();
            Assert.Throws<BusinessException>(() => discount.SetDiscountPercentage(35));
            Assert.Throws<BusinessException>(() => discount.SetPeriod(DateTime.Now.AddDays(1), DateTime.Now));
        }

        [Fact]
        public void TestShoppingCart()
        {
            ShoppingCart shoppingCart = new ShoppingCart();
            Discount discount = new Discount();
            discount.SetDiscountPercentage(20);
            discount.SetPeriod(new DateTime(2017, 10, 10), new DateTime(2017, 10, 14));
            shoppingCart.AddDiscount(discount);

            Discount discount2 = new Discount();
            discount2.SetDiscountPercentage(10);
            discount2.SetPeriod(new DateTime(2017,10,11), new DateTime(2017, 10, 12));
            shoppingCart.AddDiscount(discount2);
            Assert.Throws<BusinessException>(() => shoppingCart.AddDiscount(discount2));

        }
    }
}
