using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLongestSequence
{
    public class ElementaryProcessingOfBinaryMatrix
    {
        private int[,] arr;
        private int widthOfArray;
        private int heightOfArray;
        private List<int> listOS;
        private bool flag;
        public int GetWidth { get { return this.widthOfArray+1; } }
        public int GetHeight { get { return this.heightOfArray+1; } }
        public int GetCurrentLongestSequence { get; private set; }
        public ElementaryProcessingOfBinaryMatrix()
        {
            listOS = new List<int>();

        }

        public void SetArray(int[,] arr)
        {
            this.arr = arr;
            this.heightOfArray = arr.GetUpperBound(0);
            this.widthOfArray = arr.GetUpperBound(1);
        }
        public int Processing()
        {
            if (arr == null)
            {
                throw new NotFoundArrayException("First you need to set an array");
            }

            for (int height = 0; height <= this.heightOfArray; height++)
            {
                flag = false;
                for (int width = 0; width <= this.widthOfArray; width++)
                {
                    Logic(height, width);
                }
            }

            for (int width = 0; width <= this.widthOfArray; width++)
            {
                flag = false;
                for (int height = 0; height <= this.heightOfArray; height++)
                {
                    Logic(height, width);
                }
            }

            this.GetCurrentLongestSequence = listOS.Max();

            return this.GetCurrentLongestSequence;
        }


        private void Logic(int height, int width)
        {
            if (arr[height, width] == 1)
            {
                if (flag == true)
                {
                    listOS[listOS.Count - 1]++;
                }
                else
                {
                    flag = true;
                    listOS.Add(1);
                }
            }
            else
            {
                flag = false;
            }
        }
    }


}
