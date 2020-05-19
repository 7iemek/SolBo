﻿using SolBo.Shared.Domain.Configs;

namespace SolBo.Shared.Rules.Validation
{
    public class AverageValidationRule : IRule
    {
        public string RuleName => "AVERAGE VALIDATION";
        public string Message { get; set; }
        public ResultRule ExecutedRule(Solbot solbot)
        {
            var result = RulePassed(solbot);

            return new ResultRule
            {
                Success = result,
                Message = result
                    ? $"{RuleName} SUCCESS => Average: {solbot.Strategy.AvailableStrategy.Average}."
                    : $"{RuleName} error. Set Average."
            };
        }
        public bool RulePassed(Solbot solbot)
            => solbot.Strategy.AvailableStrategy.Average > 0;
    }
}