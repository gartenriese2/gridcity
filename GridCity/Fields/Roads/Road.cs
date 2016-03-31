﻿using System;
using System.Drawing;

namespace GridCity.Fields.Roads {
    class Road : ConnectableField {
        internal Road(Utility.GlobalCoordinate pos, Pathfinding.BaseNodeLayout layout, Orientation_CW orientation, Bitmap tex, string name) : base(pos, layout, orientation) {
            switch (orientation) {
                case Orientation_CW.NINETY:
                    tex.RotateFlip(RotateFlipType.Rotate90FlipY);
                    break;
                case Orientation_CW.ONEEIGHTY:
                    tex.RotateFlip(RotateFlipType.Rotate180FlipY);
                    break;
                case Orientation_CW.TWOSEVENTY:
                    tex.RotateFlip(RotateFlipType.Rotate270FlipY);
                    break;
                default:
                    tex.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
            }
            Texture = new Graphics.Texture(name + "_" + orientation.ToString(), tex);
        }
    }
}