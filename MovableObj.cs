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
    class MovableObj : DrawableObject
    {
        public MovableObj(Texture2D texture,
                   Vector2 position,
                   Rectangle? sourceRectangle,
                   Color color, float rotation,
                   Vector2 origin, Vector2 scale,
                   SpriteEffects effects,
                   float layerDepth):
            base( texture,
                    position,
                     sourceRectangle,
                    color,  rotation,
                    origin,  scale,
                    effects,
                    layerDepth)
        {
            Game1.updating += update;
        }

        private void update()
        {
            Matrix m=  Matrix.CreateRotationZ(rotation);
            Vector2 dir= Vector2.Transform(-Vector2.UnitX, m);

            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                rotation -= 0.05f;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                rotation += 0.05f;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                position += dir * 6;
            } else if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                position -= dir * 6;
            }
        }
    }
}
