class Solution777
{
    public bool CanTransform(String start, String target)
    {
        if (!start.Replace("X", "").Equals(target.Replace("X", "")))
        {
            return false;
        }
        for (int i = 0, j = 0; i < start.Length; i++)
        {
            if (start[i] == 'X')
            {
                continue;
            }
            while (target[j] == 'X')
            {
                j++;
            }
            if (i != j && (start[i] == 'L') != (i > j))
            {
                return false;
            }
            j++;
        }
        return true;
    }
}