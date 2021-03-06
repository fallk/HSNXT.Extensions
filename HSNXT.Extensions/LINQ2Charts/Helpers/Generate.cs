// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace HSNXT.Linq.Charting
{
    public static class Generate
    {
        static readonly Random random = new Random();

        public static IEnumerable<int> Random(int minValue, int maxValue)
        {
            while (true)
            {
                yield return random.Next(minValue, maxValue);
            }
        }

        public static IEnumerable<T> Random<T>(int minValue, int maxValue) where T : DataPoint
        {
            while (true)
            {
                yield return (T) Activator.CreateInstance(typeof(T), random.Next(minValue, maxValue));
            }
        }
    }
}