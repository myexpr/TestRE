using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuleEngine.Models;

namespace RuleEngine.Rules
{
    public class RuleB : IRule
    {
        public float EvaluateRulesetAndCalculateTotal(List<Items> items)
        {
            var itemsWithSkuB = items.First(e => e.Sku == ItemType.B);
            var x = itemsWithSkuB.Quantity / 2;
            var y = itemsWithSkuB.Quantity % 2;
            return x * 45.0F + y * (float)ItemType.B;
        }
    }
}
