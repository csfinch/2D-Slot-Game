﻿using UnityEngine;
using System.Collections;

public class PayData {
    public static int[,] table = new int[,]{
        {0, 0, 2, 10, 30}, 
        {0, 0, 3, 15, 45}, 
        {0, 0, 4, 20, 60}, 
        {0, 0, 5, 25, 75}, 
        {0, 0, 6, 30, 90}, 
        {0, 0, 7, 30, 90}, 
        {0, 0, 8, 40, 120}, 
        {0, 2, 10, 50, 150}, 
        {0, 2, 20, 100, 300}, 
        {0, 2, 40, 200, 600}
    };

    public static int[,] line = new int[,]{
        {1, 1, 1, 1, 1}, 
        {0, 0, 0, 0, 0}, 
        {2, 2, 2, 2, 2}, 
        {0, 1, 2, 1, 0}, 
        {2, 1, 0, 1, 2}, 
        {0, 0, 1, 2, 2}, 
        {2, 2, 1, 0, 0}, 
        {1, 1, 0, 1, 1}, 
        {1, 1, 2, 1, 1}, 
        {0, 1, 0, 1, 0}, 
        {2, 1, 2, 1, 2}, 
        {0, 1, 1, 1, 0}, 
        {2, 1, 1, 1, 2}, 
        {1, 0, 1, 2, 1}, 
        {1, 2, 1, 0, 1}, 
        {1, 0, 0, 0, 1}, 
        {1, 2, 2, 2, 1}, 
        {0, 0, 0, 1, 2}, 
        {2, 2, 2, 1, 0}, 
        {0, 1, 2, 2, 2}, 
        {2, 1, 0, 0, 0}, 
        {0, 0, 1, 0, 0}, 
        {2, 2, 1, 2, 2}, 
        {1, 1, 1, 0, 1}, 
        {1, 1, 1, 2, 1}
    };

    public static double[] betting = new double[] {
        .25, .50, .75, 1.00, 1.25, 1.50, 1.75, 2.00, 2.25, 2.50, 2.75, 3.00, 3.25, 3.50, 3.75, 4.00
    };
}