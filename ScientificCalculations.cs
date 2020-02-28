using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computerScienceProblems
{
    class ScientificCalculations
    {

        private int[] numArray;
        private List<int> l;
        public ScientificCalculations(int[] numArray)
        {
            this.numArray = numArray;
            
        }
        public ScientificCalculations(List<int> l)
        {
            this.l = l;
        }


        public string getMedian()
        {
            string medianAnswer = string.Empty;
            for (int i = 0; i < numArray.Length; i++)
            {
                for (int j = i + 1; j < numArray.Length; j++)
                {
                    if (numArray[i] > numArray[j])
                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = temp;

                    }

                    if (numArray.Length % 2 == 0)
                    {
                        double middleNumber = numArray[numArray.Length / 2];
                        double otherMiddleNumber = numArray[(numArray.Length / 2) + 1];
                        double average = ((middleNumber + otherMiddleNumber) / 2);
                        medianAnswer = average.ToString();
                    }
                    else
                    {
                        medianAnswer = numArray[numArray.Length / 2].ToString();
                    }

                }
            }
            return medianAnswer;
        }

        public string getRandomizingListOrder()
        {
            string arrayElements = string.Empty;
            Random random = new Random();
            int randnum;
            for (int i = 0; i < numArray.Length; i++)
            {
                randnum = random.Next(numArray.Length);
                int temp = numArray[i];
                numArray[i] = numArray[randnum];
                numArray[randnum] = temp;

            }

            foreach (int element in numArray)
            {
                arrayElements += element.ToString() + " ";  // "\r\n";
            }

            return "[ " + arrayElements + "]";
        }

        public string getAverage()
        {
            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)

            {
                sum += numArray[i];
            }

            return (sum / numArray.Length).ToString();
        }
        public string getMode()
        {
            Dictionary<int, int> hash = new Dictionary<int, int>();

            for (int i = 0; i < numArray.Length; i++)
            {
                if (hash.ContainsKey(numArray[i]))
                {
                    hash[numArray[i]] = hash[numArray[i]] + 1;

                }
                else
                {
                    hash.Add(numArray[i], 1);
                }
            }
            int maxKey = hash.ElementAt(0).Key; ;
            int maxValue = hash.ElementAt(0).Value;
            string mode = string.Empty;

            for (int i = 0; i < hash.Count; i++)
            {

                if (maxValue < hash.ElementAt(i).Value)
                {
                    maxValue = hash.ElementAt(i).Value;
                    maxKey = hash.ElementAt(i).Key;
                    mode = maxKey + " ";
                }
                else if (maxValue == hash.ElementAt(i).Value)
                {
                    mode += hash.ElementAt(i).Key + " ";
                }
            }

            return mode;
        }
        public string getMinimumValue()
        {
            int minimum = numArray[0];
            for (int i = 1; i < numArray.Length; i++)
            {
                if (minimum > numArray[i])
                {
                    minimum = numArray[i];
                }
            }
            return minimum.ToString();
        }
    }
}
