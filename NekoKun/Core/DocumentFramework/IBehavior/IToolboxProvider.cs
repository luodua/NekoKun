﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NekoKun
{
    public interface IToolboxProvider
    {
        System.Windows.Forms.Control ToolboxControl
        {
            get;
        }
    }
}
