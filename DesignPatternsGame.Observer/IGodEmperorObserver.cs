﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsGame.Observer
{
    public interface IGodEmperorObserver
    {
        void Update(Vector2 godPosition);
    }
}
