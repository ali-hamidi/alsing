﻿using System;
using GenArt.Classes;
using GenArt.Core.Classes;

namespace GenArt.AST
{
    [Serializable]
    public class DnaPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Init(DnaDrawing drawing)
        {
            X = Tools.GetRandomNumber(0, drawing.SourceImage.Width);
            Y = Tools.GetRandomNumber(0, drawing.SourceImage.Height);
        }

        public DnaPoint Clone()
        {
            return new DnaPoint
                       {
                           X = X,
                           Y = Y,
                       };
        }

        public void Mutate(DnaDrawing drawing, Settings settings)
        {
            if (Tools.WillMutate(settings.MovePointMaxMutationRate))
            {
                X = Tools.GetRandomNumber(0, drawing.SourceImage.Width);
                Y = Tools.GetRandomNumber(0, drawing.SourceImage.Height);
                drawing.SetDirty();

                drawing.SetDirty();
            }
        }
    }
}