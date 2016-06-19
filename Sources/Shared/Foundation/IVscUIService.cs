﻿using Microsoft.VisualStudio.Shell.Interop;
using SquaredInfinity.Foundation.Presentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SquaredInfinity.VSCommands.Foundation
{
    public interface IVscUIService : IUIService
    {
        void Run(Action action);
        T Run<T>(Func<T> action);

        void ShowToolWindowPane<TToolWindow>();
        void ShowToolWindowPane<TToolWindow>(VSFRAMEMODE frameMode);
    }
}
