using JazzFuzz.Enums;
using JazzFuzz.Game;
using JazzFuzz.Rules;
using JazzFuzz.RuleSettings;

namespace Tests.JazzFuzz
{
    public class GameBodyTest
    {

        private readonly GameLogic _gameBody;

        public GameBodyTest()
        {
            _gameBody = new GameLogic(new JazzFuzzRuleSettings());
        }

        [Fact]
        public void JazzBuzz_GetJazz()
        {
            var jazz = _gameBody.RunOnSingleNumber(54);

            Assert.Equal("Jazz", jazz);
        }

        [Fact]
        public void JazzBuzz_GetFuzz()
        {
            var fuzz = _gameBody.RunOnSingleNumber(20);

            Assert.Equal("Fuzz", fuzz);
        }

        [Fact]
        public void JazzBuzz_GetNumberAsString()
        {
            var number = _gameBody.RunOnSingleNumber(17);

            Assert.Equal("17", number);
        }
    }
}
