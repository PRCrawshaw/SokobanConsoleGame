﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobanGame
{
    public interface iFileable
    {
        Parts WhatsAt(int row, int column);
        int GetColumnCount();
        int GetRowCount();
    } 
}
