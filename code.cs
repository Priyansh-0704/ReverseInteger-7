public class Solution {
    public int Reverse(int x) {
        int revNum = 0;
        while(x != 0)
        {
            int digit = x % 10; // finding each digit strting from right
            if( revNum > int.MaxValue / 10 || revNum < int.MinValue / 10)
            {
                // if revNum is about to go beyond the limits of int after being multiplied by 10 then return 0
                return 0;
            }
            // if revNum is in bounds then multiply it by 10 and add the current digit
            revNum = revNum * 10 + digit;
            // update x digit
            x /= 10;
        }
        return revNum;
    }
}
