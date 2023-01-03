namespace Palindromes.Logic
{
    public class ForeachProvider : BaseProvider
    {
        public override bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            var cleanedString = GetCleanedString(stringToCheck.ToLower());

            var index = cleanedString.Length - 1;

            foreach (var element in cleanedString)
            {
                if (element == cleanedString[index])
                    index--;
                else
                    return false;
            }

            return true;
        }
    }
}
