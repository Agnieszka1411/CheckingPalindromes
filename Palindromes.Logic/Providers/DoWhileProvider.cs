namespace Palindromes.Logic
{
    public class DoWhileProvider : BaseProvider
    {
        public override bool CheckString(string stringToCheck)
        {
            if (string.IsNullOrWhiteSpace(stringToCheck))
                return false;

            var cleanedString = GetCleanedString(stringToCheck.ToLower());
            var index = cleanedString.Length - 1;
            var i = 0;

            do
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
            while (i <= index);

            return true;
        }
    }
}