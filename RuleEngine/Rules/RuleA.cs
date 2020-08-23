using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuleEngine.Models;

namespace RuleEngine.Rules
{
    public class RuleA : IRule
    {
        public float EvaluateRulesetAndCalculateTotal(List<Items> items)
        {
            var itemsWithSkuA = items.First(e => e.Sku == ItemType.A);
            var x = itemsWithSkuA.Quantity / 3;
            var y = itemsWithSkuA.Quantity % 3;
            return x * 130.0F + y * (float)ItemType.A;
        }
    }
}
