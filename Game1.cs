using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace yoodalef92020
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        MovableObj car,balooba;
        DrawableObject reka;
        public static event DlgDraw drawing;
        public static event DlgUpdating updating;
        Camera cam;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }
       
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            G.init(GraphicsDevice);

            reka = new DrawableObject(
             Content.Load<Texture2D>("rekakaka2"),
             new Vector2(0, 0),
             null, Color.Wheat ,
             0, new Vector2(0), Vector2.One * 3f, SpriteEffects.None, 0);

            car = new MovableObj(
                Content.Load<Texture2D>("cars/car"),
                new Vector2(200, 200),
                null, Color.MediumOrchid,
                1, new Vector2(86,64), Vector2.One * 0.5f, SpriteEffects.None, 0);

            balooba  = new MovableObj(
                Content.Load<Texture2D>("cars/car"),
                new Vector2(300, 200),
                null, Color.Yellow ,
                0, new Vector2(86,64), Vector2.One * 0.5f, SpriteEffects.None, 0);

            cam = new Camera(car);


        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            updating?.Invoke();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            G.sb.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null,
                null, null, null, cam.mat);

            drawing?.Invoke();
            
            G.sb.End();
          

            base.Draw(gameTime);
            

            
        }
    }
}
