using RuleEngine.Models;
using RuleEngine.Rules;
using System;
using System.Collections.Generic;
using System.Text;

namespace RuleEngine
{
    public class CalculateTotal
    {
        public float ApplyPromotionsAndCalculateTotal(List<Items> items)
        {
            IRule ruleA = new RuleA();
            IRule ruleB = new RuleB();
            IRule ruleCnD = new RuleCnD();
            return ruleA.EvaluateRulesetAndCalculateTotal(items) +
                ruleB.EvaluateRulesetAndCalculateTotal(items) +
                ruleCnD.EvaluateRulesetAndCalculateTotal(items);
            
        }
    }
}
