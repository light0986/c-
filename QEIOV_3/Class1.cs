﻿using System;

namespace project01
{
    public class QEIOV
    {
        public double[] Math1(double a, double b, double c)
        {
            double ans = 2 * a;//2Ａ
            double ans2 = -b;//-B
            double ans3 = (b * b) - (4 * a * c);//

            if (ans3 < 0)
            {
                ans3 = ans3 * -1;
                ans3 = Math.Sqrt(ans3);
                ans3 = ans3 * -1;
            }
            else
            {
                ans3 = Math.Sqrt(ans3);
            }
            double ans4 = Math.Round((ans2 + ans3) / ans, 2);
            double ans5 = Math.Round((ans2 - ans3) / ans, 2);
            double[] ans6 = new double[2];
            ans6[0] = ans4;
            ans6[1] = ans5;
            return ans6; //根號b平方減4ac
        }
    }
}