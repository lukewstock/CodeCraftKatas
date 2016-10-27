using System.Collections.Generic;

namespace CharacterCopierKata
{
    public class FakeCharacterSource : ISource
    {
        private readonly char _characterToReturn;
        private Queue<char> _characterQueue;

        public FakeCharacterSource(IEnumerable<char> charactersToReturn)
        {
            _characterQueue = new Queue<char>(charactersToReturn);
            _characterQueue.Enqueue('\n');
        }
    
        public char GetChar()
        {
            return _characterQueue.Dequeue();
        }
    }
}