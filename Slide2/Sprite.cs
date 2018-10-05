using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Slide2
{
    class Sprite
    {
        Texture2D sprite;
        SpriteBatch spriteBatch;
        Vector2 position;
        List<Texture2D> lst_sprite = new List<Texture2D>();

        public Sprite(Texture2D _sprite)
        {
            sprite = _sprite;
            Console.WriteLine(lst_sprite.Count);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(sprite, position);
        }
    }
}
