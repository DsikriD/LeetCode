using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp5
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];
            int temp_sum;

            for (int i = nums.Length - 1; i > 0; i--)
            {
                int now_num = nums[i];
                temp_sum = target - now_num;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[j] == temp_sum)
                    {
                        Console.Write(nums[j] + "+" + now_num + "=" + target);
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }
                }
            }
            return res;
        }

        public bool IsPalindrome(int x)
        {
            string str_X = x.ToString();
            char[] arr = str_X.ToCharArray();
            Array.Reverse(arr);
            string str_X_res = new string(arr);
            return str_X == str_X_res;
        }

        public int RomanToInt(string s)
        {
            int num = 0;
            char[] a = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                switch (a[i])
                {
                    case 'I':
                        if (s.Length == 1 || (i + 1) == s.Length)
                            num++;
                        else if ((a[i + 1] != 'V' && a[i + 1] != 'X'))
                            num++;
                        else if (a[i + 1] == 'V')
                        {
                            num = num + 4;
                            i++;
                        }
                        else
                        {
                            num = num + 9;
                            i++;
                        }
                        break;
                    case 'V':
                        num = num + 5;
                        break;
                    case 'X':
                        if (s.Length == 1 || (i + 1) == s.Length)
                            num = num + 10;
                        else if ((a[i + 1] != 'L' && a[i + 1] != 'C'))
                            num = num + 10;
                        else if (a[i + 1] == 'L')
                        {
                            num = num + 40;
                            i++;
                        }
                        else
                        {
                            num = num + 90;
                            i++;
                        }
                        break;
                    case 'L':
                        num = num + 50;
                        break;
                    case 'C':

                        if (s.Length == 1 || (i + 1) == s.Length)
                            num = num + 100;
                        else if ((a[i + 1] != 'D' && a[i + 1] != 'M'))
                            num = num + 100;
                        else if (a[i + 1] == 'D')
                        {
                            num = num + 400;
                            i++;
                        }
                        else
                        {
                            num = num + 900;
                            i++;
                        }
                        break;
                    case 'D':
                        num = num + 500;
                        break;
                    case 'M':
                        num = num + 1000;
                        break;

                }
                Console.WriteLine(num);
            }
            return num;
        }

        public bool IsValid(string s)
        {
            char[] arr = s.ToCharArray();
            Stack<char> stack = new Stack<char>();
            foreach (var a in arr)
            {
                if (a == '(' || a == '{' || a == '[')
                {
                    stack.Push(a);
                }
                else if (a == ')' && stack.Count != 0 && stack.Peek() == '(')
                    stack.Pop();
                else if (a == '}' && stack.Count != 0 && stack.Peek() == '{')
                    stack.Pop();
                else if (a == ']' && stack.Count != 0 && stack.Peek() == '[')
                    stack.Pop();
                else return false;
            }
            return stack.Count == 0;
        }

        public int RemoveElement(int[] nums, int val)
        {
            int index = nums.Length - 1;
            int temp = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] != val)
                    continue;
                else if (i != nums.Length - 1)
                {
                    temp = nums[index];
                    nums[index] = val;
                    nums[i] = temp;
                }
                index--;
            }
            return index + 1;
        }

        public int SearchInsert(int[] nums, int target)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target)
                    break;
                index++;
            }
            return index;
        }

        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    if (i == j || (i + j) == (mat.Length - 1))
                        sum += mat[i][j];
                }
            }
            return sum;
        }

            public int RemoveDuplicates(int[] nums)
            {
            int index = 1;
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++) {
                bool flag = true;
                for(int j = i-1; j >=0; j--)
                {
                    if (nums[j] == nums[i])
                    {
                        flag = false; 
                        break;
                    }
                }
                if (flag)
                    nums[index++] = nums[i];
            }

                return index;
            }

        public int[] SortMin(int[] array) {
            for (int i = 0; i < array.Length; i++) {
                int min = array[i];
                int index = i;
                for (int j = i; j < array.Length; j++) {
                    if (min > array[j])
                    {
                        min = array[j];
                        index = j;
                    }
                }
                array[index] = array[i];
                array[i] = min;
            }
        return array;
        }

        public void PrintMassive(int[] nums)
        {
            foreach (var a in nums)
                Console.Write(a+";");
            Console.WriteLine();
        }

        public int[] BubleSort(int[] nums)
        {
            bool swap = false;
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length-1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                        swap= true;
                        continue;
                    }
                    if (!swap)
                    break;
                }
            return nums;
        }

        public int SerchIndexInStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length-needle.Length; i++) {
                if (haystack.Substring(i, needle.Length) == needle)
                    return i;
            }
            return -1;
        }

        public int LengthOfLastWord(string s)
        {
            int sub_index = 0;
            s = s.Trim();
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
                if (chars[i] == ' ')
                    sub_index = i;
            return sub_index==0?s.Length:(s.Length-1)-sub_index;
        }


        public double MyPow(double x, int n)
        {
            if (n == int.MaxValue) return x;
            if(n==int.MinValue) return (x == 1 || x == -1) ? 1 : 0;
            if (n==0) return 1;
            double result = x;
            for (int i = 0; i < Math.Abs(n) - 1; i++) {
                result = result * x;
            }
            return n > 0?result :(1/result) ;
        }

        public void Rotate(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return;

            int LEN_ROW = matrix[0].Length;
           for (int i = 0; i < LEN_ROW/2; i++) {
                for (int j = i; j < LEN_ROW - i - 1; j++)
                {
                    int TEMP_VALUE = matrix[i][j];
                    matrix[i][j] = matrix[LEN_ROW - j - 1][i];
                    matrix[LEN_ROW - j - 1][i] = matrix[LEN_ROW - i - 1][LEN_ROW - j - 1];
                    matrix[LEN_ROW - i - 1][LEN_ROW - j - 1] = matrix[j][LEN_ROW - i - 1];
                    matrix[j][LEN_ROW - i - 1]= TEMP_VALUE;

                } 
            }

            
        }






    }//Solution

}//Program






 





