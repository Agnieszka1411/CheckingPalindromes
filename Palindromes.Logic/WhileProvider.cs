namespace Palindromes.Logic
{
    public class WhileProvider : BaseProvider
    {
        public override bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            var cleanedString = GetCleanedString(stringToCheck.ToLower());
            var index = cleanedString.Length - 1;
            var i = 0;

            while (i <= index)
            {
                if (cleanedString[i] == cleanedString[index])
                {
                    i++;
                    index--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}