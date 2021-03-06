﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiniMax
{
    public class IGameState
    {
        public IGameState()
        {

        }
        public int Value { get; set; }
        public bool IsTerminal { get; set; }
        public virtual IEnumerable<IGameState> Moves { get; }
    }
}
