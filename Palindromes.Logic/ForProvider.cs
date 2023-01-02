namespace Palindromes.Logic
{
    public class ForProvider : BaseProvider
    {
        public override bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            var cleanedString = GetCleanedString(stringToCheck.ToLower());
            var index = cleanedString.Length - 1;

            for (var i = 0; i <= index; i++)
                if (cleanedString[i] == cleanedString[index])
                    index--;
                else
                    return false;

            return true;
        }
    }
}