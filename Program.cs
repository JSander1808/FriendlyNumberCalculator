using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace BefreundeteZahlenBerechnen
{
    class Program
    {

        

        private static int loop = 2000;
        private static int threads = 4;






        private static bool thread1finish = true;
        private static bool thread2finish = true;
        private static bool thread3finish = true;
        private static bool thread4finish = true;
        private static bool thread5finish = true;
        private static bool thread6finish = true;
        private static bool thread7finish = true;
        private static bool thread8finish = true;
        private static bool thread9finish = true;
        private static bool thread10finish = true;
        private static bool thread11finish = true;
        private static bool thread12finish = true;
        private static bool thread13finish = true;
        private static bool thread14finish = true;
        private static bool thread15finish = true;
        private static bool thread16finish = true;
        private static bool thread17finish = true;
        private static bool thread18finish = true;
        private static bool thread19finish = true;
        private static bool thread20finish = true;
        private static bool thread21finish = true;
        private static bool thread22finish = true;
        private static bool thread23finish = true;
        private static bool thread24finish = true;
        private static bool thread25finish = true;
        private static bool thread26finish = true;
        private static bool thread27finish = true;
        private static bool thread28finish = true;
        private static bool thread29finish = true;
        private static bool thread30finish = true;
        private static bool thread31finish = true;
        private static bool thread32finish = true;
        private static bool thread33finish = true;
        private static bool thread34finish = true;
        private static bool thread35finish = true;
        private static bool thread36finish = true;
        private static bool thread37finish = true;
        private static bool thread38finish = true;
        private static bool thread39finish = true;
        private static bool thread40finish = true;
        private static Stopwatch stopwatch = new Stopwatch();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Loop:");
            loop = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Threads:  ");
            threads = Int32.Parse(Console.ReadLine());
            init();
            stopwatch.Start();
            Console.ReadKey();
        }

        static void init()
        {
            List<int> threadnumber = new List<int>();
            List<int> threadnumberend = new List<int>();
            for(int i = 0; i < threads; i++)
            {
                int temp = loop/threads;
                if (threads == 1)
                {
                    threadnumber.Add(temp * (i + 1));
                }
                else
                {
                    threadnumber.Add(temp * (i));
                }
            }



            for(int i = 0; i < threads; i++)
            {
                threadnumberend.Add(threadnumber[i] + (loop / threads - 1));
            }
            if (threads == 1)
            {
                Thread t1 = new Thread(() => calc(0, loop - 1, 1));
                t1.Start();
            }
            else if (threads == 2)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                t1.Start();
                t2.Start();
                finished(2);
            }
            else if (threads == 3)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                t1.Start();
                t2.Start();
                t3.Start();
            }
            else if (threads == 4)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
            }
            else if (threads == 5)
            {

                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
            }
            else if (threads == 6)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
            }
            else if (threads == 7)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
            }
            else if (threads == 8)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
            }
            else if (threads == 9)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                Thread t9 = new Thread(() => calc(threadnumber[8], threadnumberend[8], 9));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
                t9.Start();
            }
            else if (threads == 10)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                Thread t9 = new Thread(() => calc(threadnumber[8], threadnumberend[8], 9));
                Thread t10 = new Thread(() => calc(threadnumber[9], threadnumberend[9], 10));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
                t9.Start();
                t10.Start();
            }
            else if (threads == 11)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                Thread t9 = new Thread(() => calc(threadnumber[8], threadnumberend[8], 9));
                Thread t10 = new Thread(() => calc(threadnumber[9], threadnumberend[9], 10));
                Thread t11 = new Thread(() => calc(threadnumber[10], threadnumberend[10], 11));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
                t9.Start();
                t10.Start();
                t11.Start();
            }
            else if (threads == 12)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                Thread t9 = new Thread(() => calc(threadnumber[8], threadnumberend[8], 9));
                Thread t10 = new Thread(() => calc(threadnumber[9], threadnumberend[9], 10));
                Thread t11 = new Thread(() => calc(threadnumber[10], threadnumberend[10], 11));
                Thread t12 = new Thread(() => calc(threadnumber[11], threadnumberend[11], 12));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
                t9.Start();
                t10.Start();
                t11.Start();
                t12.Start();
            }
            else if (threads == 13)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                Thread t9 = new Thread(() => calc(threadnumber[8], threadnumberend[8], 9));
                Thread t10 = new Thread(() => calc(threadnumber[9], threadnumberend[9], 10));
                Thread t11 = new Thread(() => calc(threadnumber[10], threadnumberend[10], 11));
                Thread t12 = new Thread(() => calc(threadnumber[11], threadnumberend[11], 12));
                Thread t13 = new Thread(() => calc(threadnumber[12], threadnumberend[12], 13));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
                t9.Start();
                t10.Start();
                t11.Start();
                t12.Start();
                t13.Start();
            }
            else if (threads == 14)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                Thread t9 = new Thread(() => calc(threadnumber[8], threadnumberend[8], 9));
                Thread t10 = new Thread(() => calc(threadnumber[9], threadnumberend[9], 10));
                Thread t11 = new Thread(() => calc(threadnumber[10], threadnumberend[10], 11));
                Thread t12 = new Thread(() => calc(threadnumber[11], threadnumberend[11], 12));
                Thread t13 = new Thread(() => calc(threadnumber[12], threadnumberend[12], 13));
                Thread t14 = new Thread(() => calc(threadnumber[13], threadnumberend[13], 14));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
                t9.Start();
                t10.Start();
                t11.Start();
                t12.Start();
                t13.Start();
                t14.Start();
            }
            else if (threads == 15)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                Thread t9 = new Thread(() => calc(threadnumber[8], threadnumberend[8], 9));
                Thread t10 = new Thread(() => calc(threadnumber[9], threadnumberend[9], 10));
                Thread t11 = new Thread(() => calc(threadnumber[10], threadnumberend[10], 11));
                Thread t12 = new Thread(() => calc(threadnumber[11], threadnumberend[11], 12));
                Thread t13 = new Thread(() => calc(threadnumber[12], threadnumberend[12], 13));
                Thread t14 = new Thread(() => calc(threadnumber[13], threadnumberend[13], 14));
                Thread t15 = new Thread(() => calc(threadnumber[14], threadnumberend[14], 15));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
                t9.Start();
                t10.Start();
                t11.Start();
                t12.Start();
                t13.Start();
                t14.Start();
                t15.Start();
            }
            else if (threads == 16)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                Thread t9 = new Thread(() => calc(threadnumber[8], threadnumberend[8], 9));
                Thread t10 = new Thread(() => calc(threadnumber[9], threadnumberend[9], 10));
                Thread t11 = new Thread(() => calc(threadnumber[10], threadnumberend[10], 11));
                Thread t12 = new Thread(() => calc(threadnumber[11], threadnumberend[11], 12));
                Thread t13 = new Thread(() => calc(threadnumber[12], threadnumberend[12], 13));
                Thread t14 = new Thread(() => calc(threadnumber[13], threadnumberend[13], 14));
                Thread t15 = new Thread(() => calc(threadnumber[14], threadnumberend[14], 15));
                Thread t16 = new Thread(() => calc(threadnumber[15], threadnumberend[15], 16));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
                t9.Start();
                t10.Start();
                t11.Start();
                t12.Start();
                t13.Start();
                t14.Start();
                t15.Start();
                t16.Start();
            }else if (threads == 40)
            {
                Thread t1 = new Thread(() => calc(threadnumber[0], threadnumberend[0], 1));
                Thread t2 = new Thread(() => calc(threadnumber[1], threadnumberend[1], 2));
                Thread t3 = new Thread(() => calc(threadnumber[2], threadnumberend[2], 3));
                Thread t4 = new Thread(() => calc(threadnumber[3], threadnumberend[3], 4));
                Thread t5 = new Thread(() => calc(threadnumber[4], threadnumberend[4], 5));
                Thread t6 = new Thread(() => calc(threadnumber[5], threadnumberend[5], 6));
                Thread t7 = new Thread(() => calc(threadnumber[6], threadnumberend[6], 7));
                Thread t8 = new Thread(() => calc(threadnumber[7], threadnumberend[7], 8));
                Thread t9 = new Thread(() => calc(threadnumber[8], threadnumberend[8], 9));
                Thread t10 = new Thread(() => calc(threadnumber[9], threadnumberend[9], 10));
                Thread t11 = new Thread(() => calc(threadnumber[10], threadnumberend[10], 11));
                Thread t12 = new Thread(() => calc(threadnumber[11], threadnumberend[11], 12));
                Thread t13 = new Thread(() => calc(threadnumber[12], threadnumberend[12], 13));
                Thread t14 = new Thread(() => calc(threadnumber[13], threadnumberend[13], 14));
                Thread t15 = new Thread(() => calc(threadnumber[14], threadnumberend[14], 15));
                Thread t16 = new Thread(() => calc(threadnumber[15], threadnumberend[15], 16));
                Thread t17 = new Thread(() => calc(threadnumber[16], threadnumberend[16], 17));
                Thread t18 = new Thread(() => calc(threadnumber[17], threadnumberend[17], 18));
                Thread t19 = new Thread(() => calc(threadnumber[18], threadnumberend[18], 19));
                Thread t20 = new Thread(() => calc(threadnumber[19], threadnumberend[19], 20));
                Thread t21 = new Thread(() => calc(threadnumber[20], threadnumberend[20], 21));
                Thread t22 = new Thread(() => calc(threadnumber[21], threadnumberend[21], 22));
                Thread t23 = new Thread(() => calc(threadnumber[22], threadnumberend[22], 23));
                Thread t24 = new Thread(() => calc(threadnumber[23], threadnumberend[23], 24));
                Thread t25 = new Thread(() => calc(threadnumber[24], threadnumberend[24], 25));
                Thread t26 = new Thread(() => calc(threadnumber[25], threadnumberend[25], 26));
                Thread t27 = new Thread(() => calc(threadnumber[26], threadnumberend[26], 27));
                Thread t28 = new Thread(() => calc(threadnumber[27], threadnumberend[27], 28));
                Thread t29 = new Thread(() => calc(threadnumber[28], threadnumberend[28], 29));
                Thread t30 = new Thread(() => calc(threadnumber[29], threadnumberend[29], 30));
                Thread t31 = new Thread(() => calc(threadnumber[30], threadnumberend[30], 31));
                Thread t32 = new Thread(() => calc(threadnumber[31], threadnumberend[31], 32));
                Thread t33 = new Thread(() => calc(threadnumber[32], threadnumberend[32], 33));
                Thread t34 = new Thread(() => calc(threadnumber[33], threadnumberend[33], 34));
                Thread t35 = new Thread(() => calc(threadnumber[34], threadnumberend[34], 35));
                Thread t36 = new Thread(() => calc(threadnumber[35], threadnumberend[35], 36));
                Thread t37 = new Thread(() => calc(threadnumber[36], threadnumberend[36], 37));
                Thread t38 = new Thread(() => calc(threadnumber[37], threadnumberend[37], 38));
                Thread t39 = new Thread(() => calc(threadnumber[38], threadnumberend[38], 39));
                Thread t40 = new Thread(() => calc(threadnumber[39], threadnumberend[39], 40));
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
                t5.Start();
                t6.Start();
                t7.Start();
                t8.Start();
                t9.Start();
                t10.Start();
                t11.Start();
                t12.Start();
                t13.Start();
                t14.Start();
                t15.Start();
                t16.Start();
                t17.Start();
                t18.Start();
                t19.Start();
                t20.Start();
                t21.Start();
                t22.Start();
                t23.Start();
                t24.Start();
                t25.Start();
                t26.Start();
                t27.Start();
                t28.Start();
                t29.Start();
                t30.Start();
                t31.Start();
                t32.Start();
                t33.Start();
                t34.Start();
                t35.Start();
                t36.Start();
                t37.Start();
                t38.Start();
                t39.Start();
                t40.Start();
            }
        }

        static void calc(int number, int endnumber, int thread)
        {
            worked(thread);
            int number1 = 0;
            int number2 = number;
            for (int i = 0; i < 1; i++)
            {
                while (number2 <= endnumber)
                {
                    if (number1 >= loop)
                    {
                        number1 = 0;
                        number2++;
                    }
                    else
                    {
                        int result1 = 0;
                        int result2 = 0;
                        List<int> result1list = new List<int>();
                        List<int> result2list = new List<int>();
                        for (int e = 1; e < number1; e++)
                        {
                            if ((number1 % e) == 0)
                            {
                                result1list.Add(e);
                            }
                        }
                        for (int e = 0; e < result1list.Count; e++)
                        {
                            if (result1 == 0)
                            {
                                result1 = result1list[e];
                            }else
                            {
                                result1 = result1 + result1list[e];
                            }
                        }
                        for (int e = 1; e < number2; e++)
                        {
                            if ((number2 % e) == 0)
                            {
                                result2list.Add(e);
                            }
                        }
                        for (int e = 0; e < result2list.Count; e++)
                        {
                            if (result2 == 0)
                            {
                                result2 = result2list[e];
                            }else
                            {
                                result2 = result2 + result2list[e];
                            }
                        }
                        if (result1 == number2 && result2 == number1)
                        {
                            if (!(result1 == result2))
                            {
                                TimeSpan ts = stopwatch.Elapsed;
                                String resulttime = String.Format("{00:00}:{01:00}:{02:00}:{03:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                                Console.WriteLine(result1 + "  " + result2+"     "+resulttime);
                            }
                        }
                        number1++;
                    }
                }
            }
            Console.WriteLine("Thread: " + thread + "  ist fertig");
            finished(thread);
        }

        static void finished(int thread)
        {
            if (thread == 1)
            {
                thread1finish = true;
            }
            if (thread == 2)
            {
                thread2finish = true;
            }
            if (thread == 3)
            {
                thread3finish = true;
            }
            if (thread == 4)
            {
                thread4finish = true;
            }
            if (thread == 5)
            {
                thread5finish = true;
            }
            if (thread == 6)
            {
                thread6finish = true;
            }
            if (thread == 7)
            {
                thread7finish = true;
            }
            if (thread == 8)
            {
                thread8finish = true;
            }
            if (thread == 9)
            {
                thread9finish = true;
            }
            if (thread == 10)
            {
                thread10finish = true;
            }
            if (thread == 11)
            {
                thread11finish = true;
            }
            if (thread == 12)
            {
                thread12finish = true;
            }
            if (thread == 13)
            {
                thread13finish = true;
            }
            if (thread == 14)
            {
                thread14finish = true;
            }
            if (thread == 15)
            {
                thread15finish = true;
            }
            if (thread == 16)
            {
                thread16finish = true;
            }
            if(thread == 17)
            {
                thread17finish = true;
            }
            if (thread == 18)
            {
                thread18finish = true;
            }
            if (thread == 19)
            {
                thread19finish = true;
            }
            if (thread == 20)
            {
                thread20finish = true;
            }
            if (thread == 21)
            {
                thread21finish = true;
            }
            if (thread == 22)
            {
                thread22finish = true;
            }
            if (thread == 23)
            {
                thread23finish = true;
            }
            if (thread == 24)
            {
                thread24finish = true;
            }
            if (thread == 25)
            {
                thread25finish = true;
            }
            if (thread == 26)
            {
                thread26finish = true;
            }
            if (thread == 27)
            {
                thread27finish = true;
            }
            if (thread == 28)
            {
                thread28finish = true;
            }
            if (thread == 29)
            {
                thread29finish = true;
            }
            if (thread == 30)
            {
                thread30finish = true;
            }
            if (thread == 31)
            {
                thread31finish = true;
            }
            if (thread == 32)
            {
                thread32finish = true;
            }
            if (thread == 33)
            {
                thread33finish = true;
            }
            if (thread == 34)
            {
                thread34finish = true;
            }
            if (thread == 35)
            {
                thread35finish = true;
            }
            if (thread == 36)
            {
                thread36finish = true;
            }
            if (thread == 37)
            {
                thread37finish = true;
            }
            if (thread == 38)
            {
                thread38finish = true;
            }
            if (thread == 39)
            {
                thread39finish = true;
            }
            if (thread == 40)
            {
                thread40finish = true;
            }
            if (thread1finish && thread2finish && thread3finish && thread4finish && thread5finish && thread6finish && thread7finish && thread8finish && thread9finish && thread10finish && thread11finish && thread12finish && thread13finish && thread14finish && thread15finish && thread16finish&&thread17finish&&thread18finish&&thread19finish&&thread20finish&&thread21finish&&thread22finish&&thread23finish&&thread24finish&&thread25finish&&thread26finish&&thread27finish&&thread28finish&&thread29finish&&thread30finish&&thread31finish&&thread32finish&&thread33finish&&thread34finish&&thread35finish&&thread36finish&&thread37finish&&thread38finish&&thread39finish&&thread40finish)
            {
                TimeSpan ts = stopwatch.Elapsed;
                String resulttime = String.Format("{00:00}:{01:00}:{02:00}:{03:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                Console.WriteLine("Benchmarkt fertig nach:  "+resulttime);
            }
        }

        static void worked(int thread)
        {
            if (thread == 1)
            {
                thread1finish = false;
            }
            if (thread == 2)
            {
                thread2finish = false;
            }
            if (thread == 3)
            {
                thread3finish = false;
            }
            if (thread == 4)
            {
                thread4finish = false;
            }
            if (thread == 5)
            {
                thread5finish = false;
            }
            if (thread == 6)
            {
                thread6finish = false;
            }
            if (thread == 7)
            {
                thread7finish = false;
            }
            if (thread == 8)
            {
                thread8finish = false;
            }
            if (thread == 9)
            {
                thread9finish = false;
            }
            if (thread == 10)
            {
                thread10finish = false;
            }
            if (thread == 11)
            {
                thread11finish = false;
            }
            if (thread == 12)
            {
                thread12finish = false;
            }
            if (thread == 13)
            {
                thread13finish = false;
            }
            if (thread == 14)
            {
                thread14finish = false;
            }
            if (thread == 15)
            {
                thread15finish = false;
            }
            if (thread == 16)
            {
                thread16finish = false;
            }
            if (thread == 17)
            {
                thread17finish = false;
            }
            if (thread == 18)
            {
                thread18finish = false;
            }
            if (thread == 19)
            {
                thread19finish = false;
            }
            if (thread == 20)
            {
                thread20finish = false;
            }
            if (thread == 21)
            {
                thread21finish = false;
            }
            if (thread == 22)
            {
                thread22finish = false;
            }
            if (thread == 23)
            {
                thread23finish = false;
            }
            if (thread == 24)
            {
                thread24finish = false;
            }
            if (thread == 25)
            {
                thread25finish = false;
            }
            if (thread == 26)
            {
                thread26finish = false;
            }
            if (thread == 27)
            {
                thread27finish = false;
            }
            if (thread == 28)
            {
                thread28finish = false;
            }
            if (thread == 29)
            {
                thread29finish = false;
            }
            if (thread == 30)
            {
                thread30finish = false;
            }
            if (thread == 31)
            {
                thread31finish = false;
            }
            if (thread == 32)
            {
                thread32finish = false;
            }
            if (thread == 33)
            {
                thread33finish = false;
            }
            if (thread == 34)
            {
                thread34finish = false;
            }
            if (thread == 35)
            {
                thread35finish = false;
            }
            if (thread == 36)
            {
                thread36finish = false;
            }
            if (thread == 37)
            {
                thread37finish = false;
            }
            if (thread == 38)
            {
                thread38finish = false;
            }
            if (thread == 39)
            {
                thread39finish = false;
            }
            if (thread == 40)
            {
                thread40finish = false;
            }
        }
    }
}
