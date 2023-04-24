using System.Collections;

namespace DSA_CCI.Strings;

internal class UniqueCharacters
{
    // problem 1.1 in CCI
    public static bool isUniqueChars(string input)
    {
        bool result = true;
        // make a hash table
        Hashtable hashtable = new Hashtable();
        for(int i=0; i<input.Length; i++)
        {
            if (hashtable[input[i]] == null)
            {
                hashtable.Add(input[i], i);
                continue;
            }
            else
            {
                result = false;
                break;
            }
        }
        return result;
    }

}
