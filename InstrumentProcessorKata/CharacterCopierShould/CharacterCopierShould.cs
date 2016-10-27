using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharacterCopierKata;
using NUnit.Framework;

namespace CharacterCopierShould
{
    [TestFixture]
    public class CharacterCopierShould
    {
        private DestinationSpy _destinationSpy;
        private FakeCharacterSource _fakeCharacterSource;
        private Copier _copier;

        [Test]
        public void NotWriteToDestination_GivenEmptySource()
        {
            _destinationSpy = new DestinationSpy();
            _fakeCharacterSource = new FakeCharacterSource(new List<char>());
            _copier = new Copier();

            _copier.Copy(_fakeCharacterSource, _destinationSpy);

            _destinationSpy.VerifySetCharWasNotCalled();
        }

        [Test]
        public void WriteACharacterToDestination_GivenASourceWithACharacter()
        {
            var expectedCharacters = new List<char> {'a'};
            _destinationSpy = new DestinationSpy();
            _fakeCharacterSource = new FakeCharacterSource(expectedCharacters);
            _copier = new Copier();

            _copier.Copy(_fakeCharacterSource, _destinationSpy);

            _destinationSpy.VerifyCharactersWereSet(expectedCharacters);
        }

        [Test]
        public void WriteSeveralCharactersToDestination_GivenASourceWithSeveralCharacters()
        {

            IEnumerable<char> expectedCharacters = new List<char> { 'a', 'b' };
            _destinationSpy = new DestinationSpy();
            _fakeCharacterSource = new FakeCharacterSource(expectedCharacters);
            _copier = new Copier();

            _copier.Copy(_fakeCharacterSource, _destinationSpy);

            _destinationSpy.VerifyCharactersWereSet(expectedCharacters);
        }
    }
}