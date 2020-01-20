﻿using Algorithms.BitManipulation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmsTest.BitManipulation
{
    public class ConvertNumberToBinaryTest
    {
        [Fact]
        public void Convert_18_To_Binary()
        {
            int number = 18;

            int[] result = new ConvertNumberToBinary().FirstTry(number);

            Assert.Equal(new int[] { 0, 0, 0, 1, 0, 0, 1, 0 }, result);
        }

        [Fact]
        public void Convert_123_To_Binary()
        {
            int number = 123;

            int[] result = new ConvertNumberToBinary().FirstTry(number);

            Assert.Equal(new int[] { 0, 1, 1, 1, 1, 0, 1, 1 }, result);
        }
    }
}