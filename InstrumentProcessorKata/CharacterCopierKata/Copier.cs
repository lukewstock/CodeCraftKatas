namespace CharacterCopierKata
{
    public class Copier
    {
        public void Copy(FakeCharacterSource fakeCharacterSource, DestinationSpy destinationSpy)
        {
            var characterRetrieved = fakeCharacterSource.GetChar();

            while (characterRetrieved != '\n')
            {
                destinationSpy.SetChar(characterRetrieved);
                characterRetrieved = fakeCharacterSource.GetChar();
            }
        }
    }
}