﻿namespace CSIntermediate
{
    internal partial class Class2
    {
        public class Calculator
        {
            public int Add(params int[] numbers) 
            {
                var sum = 0;
                foreach ( var i in numbers )
                {
                    sum += i;
                }
                return sum;
            }
        }
    }
}
