using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rand
{
    public static class Rand
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(byte from, byte to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(sbyte from, byte to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(sbyte from, sbyte to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(sbyte from, sbyte to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(short from, sbyte to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(short from, short to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / Convert.ToSingle(divided_by));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(short from, short to, short divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / Convert.ToSingle(divided_by));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(short from, short to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / Convert.ToSingle(divided_by));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(short from, ushort to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / Convert.ToSingle(divided_by));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(ushort from, ushort to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / Convert.ToSingle(divided_by));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(int from, int to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(int from, int to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(int from, int to, short divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(int from, int to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(int from, int to, int divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>float</returns>
        public static float RandomFloat(int from, int to, float divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToSingle((r.Next(from, to)) / divided_by);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(byte from, byte to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(sbyte from, byte to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(sbyte from, sbyte to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(sbyte from, sbyte to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(short from, sbyte to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(short from, short to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(short from, short to, short divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(short from, short to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(short from, ushort to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(ushort from, ushort to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(int from, int to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(int from, int to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(int from, int to, short divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(int from, int to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(int from, int to, int divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(int from, int to, long divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(int from, int to, float divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>double</returns>
        public static double RandomDouble(int from, int to, double divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDouble(r.Next(from, to)) / divided_by;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(byte from, byte to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(sbyte from, byte to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(sbyte from, sbyte to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(sbyte from, sbyte to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(short from, sbyte to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(short from, short to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(short from, short to, short divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(short from, short to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(short from, ushort to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(ushort from, ushort to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, byte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, sbyte divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, short divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, ushort divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, int divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, long divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, ulong divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, float divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / Convert.ToDecimal(divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, double divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / Convert.ToDecimal(divided_by);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="from">from what number will starts random</param>
        /// <param name="to">until what number</param>
        /// <param name="divided_by">to what number you want divide</param>
        /// <returns>decimal</returns>
        public static decimal RandomDecimal(int from, int to, decimal divided_by)
        {
            Random r = new Random();
            Thread.Sleep(15);
            return Convert.ToDecimal(r.Next(from, to)) / divided_by;
        }
    }
}
