﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Paint.Classes.Instruments
{
    public abstract class Tool: LoadableItem, ITool
    {
        public virtual void Call(YVector pos)
        {
        }
    }
}
