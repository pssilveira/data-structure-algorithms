using NuGet.Frameworks;
using System.ComponentModel;

namespace DSA4Fun
{
    public class Arrays
    {
        [Description("How to use Basic two pointers")]
        [Fact]
        public void TwoPointers()
        {
            // One simple use to understand two pointer is check if a word is a valid palindrome

            string palindrome = "level";

            // start first pointer at the start of the string ( 0 ) as a string has a 0-based index.
            int pointer1 = 0;

            // the second pointer is set at the end of the string - 1 ( the size is the length of the string but with the correction for -1 )
            int pointer2 = palindrome.Length - 1;

            // now we check if every pair or values are equal
            while(pointer1 < pointer2)
            {
                if (!palindrome[pointer1].Equals(palindrome[pointer2]))
                    Assert.Fail("It is not a palindrome");
                //we move the first pointer 1 step ahead 
                pointer1++;
                // we move the last pointer 1 step before
                pointer2--;
            }

            Assert.True(true);
        }
    }
}