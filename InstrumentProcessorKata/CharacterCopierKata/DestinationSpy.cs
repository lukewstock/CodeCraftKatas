using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace CharacterCopierKata
{
    public class DestinationSpy : IDestination
    {
        private bool _wasCalled;
        private char _character;
        private readonly IList<char> _characters = new List<char>();

        public void SetChar(char characterToSet)
        {
            _wasCalled = true;
            _character = characterToSet;
            _characters.Add(characterToSet);
        }

        public void VerifySetCharWasNotCalled()
        {
            _wasCalled.Should().BeFalse();
        }

        public void VerifyCharacterWasSet(char expectedCharacter)
        {
            _character.Should().Be(expectedCharacter);
        }

        public void VerifyCharactersWereSet(IEnumerable<char> expectedCharacters)
        {
            var setCharactersAsString = string.Concat(_characters);
            var expectedCharactersAsString = string.Concat(expectedCharacters);

            Assert.AreEqual(expectedCharactersAsString, setCharactersAsString);
        }
    }
}