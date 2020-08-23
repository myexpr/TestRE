using RuleEngine;
using RuleEngine.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange 
            var list = new List<Items>
            {
                new Items
                {
                    Quantity = 1,
                    Sku = ItemType.A
                },
                new Items
                {
                    Quantity = 1,
                    Sku = ItemType.B
                },
                new Items
                {
                    Quantity = 1,
                    Sku = ItemType.C
                }
            };
            var calculateTotal = new CalculateTotal();

            //Act 
            var total = calculateTotal.ApplyPromotionsAndCalculateTotal(list);

            //Assert
            Assert.Equal(100.0F, total);

        }

        [Fact]
        public void Test2()
        {
            //Arrange 
            var list = new List<Items>
            {
                new Items
                {
                    Quantity = 5,
                    Sku = ItemType.A
                },
                new Items
                {
                    Quantity = 5,
                    Sku = ItemType.B
                },
                new Items
                {
                    Quantity = 1,
                    Sku = ItemType.C
                }
            };
            var calculateTotal = new CalculateTotal();

            //Act 
            var total = calculateTotal.ApplyPromotionsAndCalculateTotal(list);

            //Assert
            Assert.Equal(370.0F, total);

        }

        [Fact]
        public void Test3()
        {
            //Arrange 
            var list = new List<Items>
            {
                new Items
                {
                    Quantity = 3,
                    Sku = ItemType.A
                },
                new Items
                {
                    Quantity = 5,
                    Sku = ItemType.B
                },
                new Items
                {
                    Quantity = 1,
                    Sku = ItemType.C
                },
                new Items
                {
                    Quantity = 1,
                    Sku = ItemType.D
                }
            };
            var calculateTotal = new CalculateTotal();

            //Act 
            var total = calculateTotal.ApplyPromotionsAndCalculateTotal(list);

            //Assert
            Assert.Equal(280.0F, total);

        }
    }
}
