﻿using System;

namespace Essential.Templating.Razor.Compilation
{
    public class CompilationException : Exception
    {
        public CompilationException() : base("Compilation error occured.")
        {
        }

        public CompilationException(Exception innerException)
            : base("Compilation error occured. See inner exception.", innerException)
        {
        }
    }
}