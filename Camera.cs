using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace yoodalef92020
{
    class Camera
    {
        public Matrix mat;
        MovableObj focus;
        Vector2 pos;
        float scaleFact = 1;
        int scrollWheelVal = 0;
        public Camera(MovableObj focus)
        {
            this.focus = focus;
            pos = new Vector2(focus.position.X, focus.position.Y);
            Game1.updating += update;
        }

        private void update()
        {
            MouseState mState = Mouse.GetState();
            if (mState.ScrollWheelValue > scrollWheelVal && scaleFact + 0.1f < 3) { scaleFact += 0.1f; }
            else if (mState.ScrollWheelValue < scrollWheelVal && scaleFact - 0.1f > 0) { scaleFact -= 0.1f; }
            scrollWheelVal = mState.ScrollWheelValue;
            mat = Matrix.CreateTranslation(-pos.X , -pos.Y , 0) *
                Matrix.CreateTranslation((1 / scaleFact) * G.sb.GraphicsDevice.Viewport.Width/2, (1 / scaleFact) * G.sb.GraphicsDevice.Viewport.Height/2, 0) * 
                Matrix.CreateScale(scaleFact);
            pos = Vector2.Lerp(pos, focus.position, 0.03f);
        }
    }
}
