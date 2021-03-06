﻿using Jm.Core.Mir2.Server.VisualMapInfo.Class.AStart;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jm.Core.Mir2.Helper.Extensions
{
    public static class PointExtensions
    {
        public static APoint ToAPoint(this Point point)
        {
            return new APoint(point.X, point.Y);
        }
        public static Point ToPoint(this APoint point)
        {
            return new Point(point.X, point.Y);
        }
    }
}
