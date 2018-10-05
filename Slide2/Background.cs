using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace Slide2
{
    class Background : Sprite
    {
        SpriteBatch spriteBatch;
        Texture2D sprite;
        Vector2 position;
        
        
        public float speed;
        int posY;

        public Background(Texture2D _texture,float _speed): base(_texture)
        {
            sprite = _texture;
            speed = _speed;
        }

        public void Update(float speed)
        {
            if (position.X <= -sprite.Width)
                position.X = 0;
            position.X -= speed;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position);

            if (position.X < 0)
            {
                spriteBatch.Draw(sprite, new Vector2(position.X + sprite.Width, posY));
            }
        }
    }
}
