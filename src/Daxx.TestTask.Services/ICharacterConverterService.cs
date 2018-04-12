namespace Daxx.TestTask.Services
{
    /// <summary>
    /// Character converter BL service interface
    /// </summary>
    public interface ICharacterConverterService
    {
        /// <summary>
        /// Rewerces letters in each word (token) without changing token place
        /// </summary>
        /// <param name="source">Reference to array of chars representing the string. After execution of method array will contain words with reverted characters</param>
        void ReverseTokens(ref char[] source);
    }
}
