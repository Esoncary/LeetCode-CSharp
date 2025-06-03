public class Solution923
{
    public int ThreeSumMulti(int[] arr, int target)
    {
        Array.Sort(arr);
        int n = arr.Length;
        long ans = 0;
        const int MOD = 1_000_000_007;

        for (int i = 0; i < n - 2; i++)
        {
            int t = target - arr[i];
            int l = i + 1, r = n - 1;

            while (l < r)
            {
                int sum = arr[l] + arr[r];
                if (sum < t)
                {
                    l++;
                }
                else if (sum > t)
                {
                    r--;
                }
                else
                {
                    if (arr[l] == arr[r])
                    {
                        int count = r - l + 1;
                        ans += (long)count * (count - 1) / 2;
                        ans %= MOD;
                        break;
                    }

                    int countL = 1, countR = 1;
                    int tempL = arr[l], tempR = arr[r];
                    while (l + 1 < r && arr[l + 1] == tempL)
                    {
                        countL++;
                        l++;
                    }
                    while (r - 1 > l && arr[r - 1] == tempR)
                    {
                        countR++;
                        r--;
                    }

                    ans += (long)countL * countR;
                    ans %= MOD;

                    l++;
                    r--;
                }
            }
        }

        return (int)ans;
    }
}
