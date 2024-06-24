using PalindromeExercise;
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", "racecar", true)]
        [InlineData("kayak", "kayak", true)]
        [InlineData("mom", "mom", true)]
        [InlineData("dog", "cat", false)]
        [InlineData("bird", "bird", true)]
        public void IsAPalindrome(string word1, string word2, bool expected)
        {
            //Arrange
            WordSmith instance = new WordSmith();
            //Act
            bool actual = instance.IsAPalindrome(word1, word2);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
