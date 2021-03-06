﻿using Jm.Core.Mir2.Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jm.Core.Mir2.Helper.Extensions
{
    public static class MasterExtensions
    {
        /// <summary>
        /// 找到最近的一个怪物
        /// </summary>
        /// <param name="masters"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static MasterInfo NearbyMaster(this List<MasterInfo> masters,PositionInfo position)
        {
            return masters.OrderBy(x => Math.Abs(x.Position.Point.X - position.Point.X) + Math.Abs(x.Position.Point.Y - position.Point.Y)).FirstOrDefault();
        }
    }
}
