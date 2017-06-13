using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheLongestSequence
{    
    public class SophisticatedProcessingOfBinaryMatrix
    {
        private int[,] arr;
        private int widthOfArray;
        private int heightOfArray;

        private List<List<Sequence>> ListWidth;
        private List<List<Sequence>> ListHeight;

        public int GetWidth { get { return this.widthOfArray+1; } }
        public int GetHeight { get { return this.heightOfArray+1; } }

        public Sequence GetCurrentLongestSequence { get; private set; }

        public void SetArray(int[,] arr)
        {
            this.arr = arr;

            this.heightOfArray = arr.GetUpperBound(0);
            this.widthOfArray = arr.GetUpperBound(1);

            ListWidth = new List<List<Sequence>>(this.widthOfArray);
            ListHeight = new List<List<Sequence>>(this.heightOfArray);

            for (int i = 0; i <= this.widthOfArray; i++)
                this.ListWidth.Add(new List<Sequence>());

            for (int i = 0; i <= this.heightOfArray; i++)
                this.ListHeight.Add(new List<Sequence>());
        }

        public int Processing()
        {
            if (arr == null)
            {
                throw new NotFoundArrayException("First you need to set an array");
            }
            int max = 0;
            int current = 0;
            for (int height = 0; height <= this.heightOfArray; height++)
            {
                for (int width = 0; width <= this.widthOfArray; width++)
                {
                    current = Logic(height, width);
                    if (current > max) max = current;
                }
            }

            return max;
        }
        private int Logic(int height, int width)
        {
            if (arr[height, width] == 1)
            {
                if (this.ListWidth[width].Count > 0 && this.ListWidth[width][this.ListWidth[width].Count - 1].Flag == true )
                {
                    this.ListWidth[width][this.ListWidth[width].Count - 1].AddPoint(new Point(width, height));
                }
                else
                {
                    this.ListWidth[width].Add(new Sequence(new Point(width, height)));
                }

                if (this.ListHeight[height].Count > 0 && this.ListHeight[height][this.ListHeight[height].Count - 1].Flag == true )
                {
                    this.ListHeight[height][this.ListHeight[height].Count - 1].AddPoint(new Point(width, height));
                }
                else
                {
                    this.ListHeight[height].Add(new Sequence(new Point(width, height)));
                }
            }
            else
            {
                if (this.ListHeight[height].Count > 0)
                    this.ListHeight[height][this.ListHeight[height].Count - 1].Flag = false;
                if (this.ListWidth[width].Count > 0)
                    this.ListWidth[width][this.ListWidth[width].Count - 1].Flag = false;
            }

            int a1 = this.ListHeight[height].Count > 0 ? this.ListHeight[height][this.ListHeight[height].Count - 1].Length : 0;
            int a2 = this.ListWidth[width].Count > 0 ? this.ListWidth[width][this.ListWidth[width].Count - 1].Length : 0;
            int max = a1 > a2 ? a1 : a2;

            if (max > 0)
            {
                if (GetCurrentLongestSequence == null)
                    SetCurrentLongestSequence(height, width, a1, max);
                else if (GetCurrentLongestSequence.Length < max)
                    SetCurrentLongestSequence(height, width, a1, max);
            }
            return max;
        }

        private void SetCurrentLongestSequence(int height, int width, int a1, int max)
        {
            GetCurrentLongestSequence =
                (max == a1) ?
                this.ListHeight[height][this.ListHeight[height].Count - 1] :
                this.ListWidth[width][this.ListWidth[width].Count - 1];
        }
    }

    public class NotFoundArrayException : ApplicationException
    {
        public NotFoundArrayException(string message): base(message)
        {

        }
    }
    public class Sequence
	{
        public int Length { get; private set; }
        public bool Flag { get; set; }
        Point Start;
        Point Finish;
        public Sequence(Point p)
        {
            this.Flag = true;
            this.Start = p;
            this.Finish = p;
            this.Length = 1;
        }
        public void AddPoint(Point p)
        {
            this.Finish = p;
            this.Length++;
        }
        public override string ToString()
        {
            return string.Format("Point 1 => {0}\nPoint 2 => {1}",this.Start, this.Finish);
        }
	}
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return string.Format("X: {0,-5} Y: {1,-5}",this.X,this.Y);
        }
    }

}
