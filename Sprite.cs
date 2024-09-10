using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Penalty
{
    class Sprite
    {
        public int x, y, width, height;
        public Bitmap bmp;

        public Sprite(int x, int y, int w, int h, Bitmap src)
        {
            this.x = x;
            this.y = y;
            this.bmp = src;
            this.width = w;
            this.height = h;
        }
        public virtual void draw(Graphics target)
        {
            target.DrawImage(this.bmp, x, y);
        }
    }
}
