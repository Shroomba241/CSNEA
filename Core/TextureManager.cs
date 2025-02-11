﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompSci_NEA.Core
{
    public static class TextureManager
    {
        public static Texture2D TESTGRASS { get; private set; }
        public static Texture2D TESTWATER { get; private set; }
        public static Texture2D ATLAS { get; private set; }
        public static Texture2D DEBUG_Collider { get; private set; }


        public static void LoadContent(ContentManager content)
        {
            Console.WriteLine("loading textures");
            TESTGRASS = content.Load<Texture2D>("TESTGRASS");
            TESTWATER = content.Load<Texture2D>("TESTWATER");
            ATLAS = content.Load<Texture2D>("ATLASV6");
            DEBUG_Collider = content.Load<Texture2D>("DEBUG_Collide");


            if (TESTGRASS == null) throw new Exception("Failed to load TESTGRASS texture.");
            if (TESTWATER == null) throw new Exception("Failed to load TESTWATER texture.");
            if (ATLAS == null) throw new Exception("Failed to load TESTWATER texture.");
        }
    }
}
