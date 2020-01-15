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
    public delegate void DlgUpdating();
    #region delegates
    public delegate void DlgDraw(); 
    #endregion
    #region globals
    static class G
    {
        public static SpriteBatch sb;
        public static void init(GraphicsDevice graphicsDevice)
        {
            sb = new SpriteBatch(graphicsDevice);
        }
    } 
    #endregion
}
