public class Solution {
    public bool IsPalindrome(int x) {
         int reverseNumber = 0;
            int aux = x;
            while (aux > 0) {
                reverseNumber = reverseNumber * 10 + aux % 10;
                aux = aux / 10;
            }
            return reverseNumber == x;
    }
}