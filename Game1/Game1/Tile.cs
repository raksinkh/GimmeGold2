using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Game1
{
    class tile
    {
        private Texture2D _texture;
        public Vector2 position;
        public float speed = 5f;
        public int[,] mode;
        public tile(Texture2D texture)
        {
            _texture = texture;


        }

        public void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {

                if (position.Y <= 40)
                {
                    position.Y = 40;
                }
                else
                    position.Y -= speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                if (position.Y >= 400)
                {
                    position.Y = 400;
                }
                else
                    position.Y += speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                if (position.X <= 40)
                {
                    position.X = 40;
                }
                else
                    position.X -= speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                if (position.X >= 720)
                {
                    position.X = 720;
                }
                else
                    position.X += speed;
            }
        }
        public void randomtile()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, position, Color.White);

        }
        public void Drawtile(SpriteBatch spriteBatch)
        {


        }


        public void DrawWall(SpriteBatch spriteBatch, Vector2 pos)
        {
            for (int i = 0; i <= 800; i++)
            {
                position = new Vector2(i * 40, 0);
                spriteBatch.Draw(_texture, position, Color.White);
            }
            for (int i = 0; i <= 800; i++)
            {
                position = new Vector2(0, i * 40);
                spriteBatch.Draw(_texture, position, Color.White);
            }
            for (int i = 0; i <= 800; i++)
            {
                position = new Vector2(760, i * 40);
                spriteBatch.Draw(_texture, position, Color.White);
            }
            for (int i = 0; i <= 800; i++)
            {
                position = new Vector2(i * 40, 440);
                spriteBatch.Draw(_texture, position, Color.White);
            }
        }


    }

}
