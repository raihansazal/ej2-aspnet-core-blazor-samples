﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_heatmapdata
{
    public class HeatMapData
    {
        public static int[,] GetDefaultData()
        {
            int[,] dataSource = new int[,]
            {
                {52, 65, 67, 45, 37, 52},
                {68, 52, 63, 51, 30, 51},
                {7, 16, 47, 47, 88, 6},
                {66, 64, 46, 40, 47, 41},
                {14, 46, 97, 69, 69, 3},
                {54, 46, 61, 46, 40, 39},
                {48, 46, 61, 47, 49, 41},
                {41, 55, 73, 23, 3, 79},
                {50, 59, 44, 43, 27, 42},
                {47, 49, 66, 53, 50, 34},
                {61, 40, 62, 26, 34, 54},
                {41, 69, 61, 84, 84, 87}
            };
            return dataSource;
        }

        public static int?[,] GetEmptyPointData()
        {
            int?[,] dataSource = new int?[11, 12]
            {
                {8, 5, 2, 6, 8, 2, 9, 3, 7, 8, 7, 6},
                {5, null, 4, 9, 10, null, 11, 7, 3, 7, 8, null},
                {8, 7, 2, null, 5, 3, null, 2, 1, 8, null, 4},
                {10, 2, null, 4, 5, null, 1, 10, 5, 2, 1, null},
                {1, 2, 9, 4, null, 5, 1, null, 12, 1, null, 4},
                {4, null, 3, 5, 2, null, null, null, 5, null, 1, 3},
                {null, null, 4, 10, null, 5, 11, 2, 8, 1, null, 1},
                {1, 4, null, 4, 5, null, 1, 3, null, 1, null, 3},
                {null, 2, 1, 4, null, 5, 1, null, 2, 1, null, 2},
                {1, null, 4, null, null, 2, null, 5, 1, 5, 2, 1},
                {1, null, 2, 1, 5, null, null, null, 5, 2, 1, null}
            };
            return dataSource;
        }
        
    }
}