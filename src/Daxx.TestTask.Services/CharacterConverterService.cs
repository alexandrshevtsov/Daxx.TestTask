namespace Daxx.TestTask.Services
{
    /// <summary>
    /// Character converter BL service class
    /// </summary>
    public class CharacterConverterService : ICharacterConverterService
    {
        /// <summary>
        /// Rewerces letters in each word (token) without changing token place
        /// </summary>
        /// <param name="source">Reference to array of chars representing the string. After execution of method array will contain words with reverted characters</param>
        public void ReverseTokens(ref char[] source)
        {
            if (source == null)
            {
                return;
            }
            var lowerBound = 0;
            var upperBound = 0;
            for (var i = 0; i < source.Length; i++)
            {
                if (source[i] == ' ')
                {
                    upperBound = i - 1;
                    ReverseSingleToken(ref source, lowerBound, upperBound);
                    lowerBound = i + 1;
                }
            }
            upperBound = source.Length - 1;
            ReverseSingleToken(ref source, lowerBound, upperBound);
        }

        /// <summary>
        /// Auxilary method to reverse range of letters in the array of characters
        /// </summary>
        /// <param name="source">Reference to array of chars. Reversion will be applied to character in this array</param>
        /// <param name="lowerBound">start position</param>
        /// <param name="upperBound">end position</param>
        private void ReverseSingleToken(ref char[] source, int lowerBound, int upperBound)
        {
            for (var i = 0; i < (upperBound - lowerBound + 1) / 2; i++)
            {
                var tmp = source[i + lowerBound];
                source[i + lowerBound] = source[upperBound - i];
                source[upperBound - i] = tmp;
            }
        }
    }
}
