using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Penalty
{
    class AnimSprite : Sprite
    {
        int frameWidth, frameHeight;
        int currentFrame = 0;
        int ellapsed = 0;
        public int totalNoOfFrame;
        public int offsetY, offsetX = 0;

        public AnimSprite(int frameWidth, int frameHeight, int x, int y, int w, int h, Bitmap src)
            : base(x, y, w, h, src)
        {
            this.frameHeight = frameHeight;
            this.frameWidth = frameWidth;
            //this.x = x; Waste your code
        }

        public void draw(Graphics target, int interval, Rectangle destRect)
        {
            this.ellapsed += interval;
            if (ellapsed >= 5)
            {
                currentFrame++;
                ellapsed = 0;
            }
            Rectangle srcRect;
            srcRect = new Rectangle(this.frameWidth * currentFrame, offsetY, width, height);
            target.DrawImage(GameResources.ball_ani, destRect, srcRect, GraphicsUnit.Pixel);
            if (currentFrame == totalNoOfFrame)
            {
                currentFrame = 0;
            }
        }
    }
}
