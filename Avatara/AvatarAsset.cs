﻿using Avatara.Figure;

namespace Avatara
{
    internal class AvatarAsset
    {
        public string Name;
        public int X;
        public int Y;
        public int ImageX;
        public int ImageY;
        public string FileName;
        public FigurePart Part;
        public FigureSet Set;
        public string[] Parts;

        public AvatarAsset(bool isSmall, string name, string fileName, int X, int Y, FigurePart part, FigureSet set, int canvasW, int canvasH, string[] parts)
        {
            this.Name = name;
            this.X = X;
            this.Y = Y;
            this.FileName = fileName;
            this.ImageX = X + (canvasW / 2) + (isSmall ? 5 : 10);
            this.ImageY = Y + (canvasH / 2) - (isSmall ? 11 : 22);
            this.Part = part;
            this.Set = set;
            this.Parts = parts;
        }

    }
}