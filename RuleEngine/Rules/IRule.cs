using RuleEngine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RuleEngine.Rules
{
    public interface IRule
    {
        float EvaluateRulesetAndCalculateTotal(List<Items> items);
    }
}
