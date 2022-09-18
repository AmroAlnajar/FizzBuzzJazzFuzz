using JazzFuzz.Enums;
using JazzFuzz.Models;

namespace JazzFuzz.RuleSettings;

public interface IGameRuleSettings
{
    GameRuleModel GetRuleSettings();
}

