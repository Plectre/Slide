using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Slide2
{
    class Player : Sprite
    {
        Vector2 position;
        Texture2D player_text;
        KeyboardState kb;
        float speed = 4f;


        public Player(Texture2D _sprite) : base(_sprite)
        {
            player_text = _sprite;

        }

        public void update()
        {
            kb = Keyboard.GetState();
            if (kb.IsKeyDown(Keys.Right))
            {
                position.X += speed;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            SpriteEffects spriteEffects;
            spriteEffects = SpriteEffects.None;
            spriteBatch.Draw(player_text,
                             new Vector2(position.X, 600 - player_text.Height),
                             null,
                             Color.White,
                             0,
                             Vector2.Zero,
                             0.5f,
                             spriteEffects,
                             0
                             );
        }
    }
}
