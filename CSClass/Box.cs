using System;

namespace CSClass
{
    class Box
    {
        private int width;
        private int height;

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) width = value;
                else throw new Exception("자연수만 가능합니다~");
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
                else throw new Exception("자연수만 가능합니다~");
            }
        }


        public Box(int w, int h)
        {
            if (w > 0 && h > 0)
            {
                this.Width = w;
                this.Height = h;
            }
            else throw new Exception("자연수만 가능합니다~");

        }

        private int area;

        public int Area
        {
            get { return this.Width * this.Height };
        }
    }
}