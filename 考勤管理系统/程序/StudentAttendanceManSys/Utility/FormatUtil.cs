using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public class FormatUtil
    {
        /// <summary>
        /// 将实数转化为百分比格式
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string doubleToPercent(double number)
        {
            return string.Format("{0}%", Math.Round(number * 100));
        }

        /// <summary>
        /// 百分比转化为实数
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double percentToDobule(string percent)
        {
            double number = Convert.ToDouble(percent.Split('%')[0]);
            return number/100;
        }
    }
}
