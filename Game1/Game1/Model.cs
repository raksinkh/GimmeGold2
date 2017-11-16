using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class Model : GoldRush
    {
        public Texture2D G_tile, St_tile, Di_tile, La_tile;
        private Vector2 i_position;
        //SpriteBatch spriteBatch1;
        private int[,] model1;

        public void loadcontent()
        {
            //spriteBatch1 = new SpriteBatch(GraphicsDevice);


            /////
            // int gold_reg = 1;
            // int stone_reg = 2;
            // int Dimond_reg = 3;
            // int Lapiz_reg = 4;
            ////////

        }
        public Model(int i)
        {
            if (i == 1)
            {
                model1 = new int[,]
                {
            { 1,2,2,1,2,3,4,1,2,3,4,1,3,2,1,4,3 },
            { 2,2,1,1,2,3,4,1,2,3,4,1,3,2,1,4,3 },
            { 2,2,1,1,2,3,1,1,2,3,4,1,1,2,1,4,3 },
            { 2,2,2,1,2,3,4,4,2,3,1,1,3,2,1,4,3 },
            { 2,2,2,1,2,4,4,1,2,3,4,1,3,2,1,4,3 },
            { 2,2,2,1,2,3,4,1,2,3,4,1,3,2,1,4,1 },
                };
            }
        }

        public void drawmodel(SpriteBatch spriteBatch)
        {


            i_position = new Vector2(0, 0);


        }

        private void rand()
        {

        }
    }
}