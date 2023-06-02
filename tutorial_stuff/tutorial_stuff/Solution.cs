using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace beginnerTutorials
{
    public class Solution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] jointNums;
            jointNums = new int[nums1.Length + nums2.Length];
            int jCnt = 0, n1Cnt = 0, n2Cnt = 0;
            if (nums1.Length >= 1 && nums2.Length >= 1)
            {
                while (jCnt < jointNums.Length)
                {
                    if (nums1[n1Cnt] < nums2[n2Cnt])
                    {
                        jointNums[jCnt] = nums1[n1Cnt];
                        jCnt++;
                        n1Cnt++;
                        if (n1Cnt == nums1.Length)
                        {
                            while (jCnt < jointNums.Length)
                            {
                                jointNums[jCnt] = nums2[n2Cnt];
                                jCnt++;
                                n2Cnt++;
                            }
                        }
                    }
                    else if (nums2[n2Cnt] < nums1[n1Cnt])
                    {
                        jointNums[jCnt] = nums2[n2Cnt];
                        jCnt++;
                        n2Cnt++;
                        if (n2Cnt == nums2.Length)
                        {
                            while (jCnt < jointNums.Length)
                            {
                                jointNums[jCnt] = nums1[n1Cnt];
                                jCnt++;
                                n1Cnt++;
                            }
                        }
                    }
                    else if (nums1[n1Cnt] == nums2[n2Cnt])
                    {
                        jointNums[jCnt] = nums1[n1Cnt];
                        jCnt++;
                        n1Cnt++;
                        if (n1Cnt == nums1.Length)
                        {
                            while (jCnt < jointNums.Length)
                            {
                                jointNums[jCnt] = nums2[n2Cnt];
                                jCnt++;
                                n2Cnt++;
                            }
                        }
                    }
                    else
                    {
                        return 0.0;
                    }
                }
            }
            else if (nums1.Length == 0 && nums2.Length >= 1)
            {
                jointNums = nums2;
            }
            else if (nums2.Length == 0 && nums1.Length >= 1)
            {
                jointNums = nums1;
            }
            else
            {
                return 0.0;
            }

            foreach (int digit in jointNums)
                Console.Write(digit + " ");
            int middle = 0;
            double result = 0;
            if (jointNums.Length % 2 == 0)
            {
                middle = jointNums.Length / 2;
                result = (Decimal.ToDouble(jointNums[middle]) + Decimal.ToDouble(jointNums[middle - 1])) / 2;
            }
            else
            {
                middle = Decimal.ToInt32(Math.Floor((decimal)jointNums.Length / 2));
                result = jointNums[middle];
            }
            return result;
        }
    }
}

