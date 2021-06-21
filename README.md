# PrimeChecker
**Prime Number Checking**

By definition, Prime Number can be divisible by only 1 and the number itself. Here I wrote a code for checking prime number in C#.

**1st Approach:**
- checking if the number (n) is divisible by any number starting from 2 upto n
- This approach will iterate n-1 times; time-complexity O(n).

**2nd Approach:**
- For reducing the number of iterations, I checked the number if it's divisible by 2 and then removed the divisibilty checking for all even numbers. As all even numbers are also divisible by 2.
- This optimization reduces the iteration counts to half of the previous approach; time-complexity O(n/2).

**3rd Approach:**
- We don't necessarily need to check all the odd numbers up to n; as many factors of a number can be gained by the product of the divisors. Hence, we only need unique divisors of n which are less than or equal to square root on n.
- Time-complexity O(√n).

**More optimization:**
- We can observe that all prime numbers greater than 3, starts form 6k ± 1, where k is any integer greater than 0. As all integers can be expressed as (6k + i), where i = −1, 0, 1, 2, 3, or 4 etc. So, a more efficient way is to test whether n is divisible by 2 or 3, then to check through all numbers of the form
(6k + 1)<=√n.
- This is 3 times faster than testing all numbers up to √n.

**Resources:**
- https://en.wikipedia.org/wiki/Primality_test
