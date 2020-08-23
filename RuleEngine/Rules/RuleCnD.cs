using RuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuleEngine.Rules
{
    public class RuleCnD : IRule
    {
        public float EvaluateRulesetAndCalculateTotal(List<Items> items)
        {
            var itemsWithSkuC = items.FirstOrDefault(e => e.Sku == ItemType.C);
            var itemsWithSkuD = items.FirstOrDefault(e => e.Sku == ItemType.D);
            if (itemsWithSkuC == null && itemsWithSkuD != null)
                return itemsWithSkuD.Quantity * (float)ItemType.D;
            if (itemsWithSkuD == null && itemsWithSkuC != null)
                return itemsWithSkuC.Quantity * (float)ItemType.C;

            var diff = Math.Abs(itemsWithSkuC.Quantity - itemsWithSkuD.Quantity);
            if (itemsWithSkuC.Quantity >= itemsWithSkuD.Quantity)
                return itemsWithSkuD.Quantity * 30.0F + diff * (float)ItemType.C;
            else
                return itemsWithSkuC.Quantity * 30.0F + diff * (float)ItemType.D;

        }
    }
}
