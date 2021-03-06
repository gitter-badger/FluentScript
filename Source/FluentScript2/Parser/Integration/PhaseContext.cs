﻿using ComLib.Lang.AST;
using System.Collections.Generic;

namespace ComLib.Lang.Parsing
{
    /// <summary>
    /// Contextual information for phases in the interpreter.
    /// </summary>
    public class PhaseContext
    {
        /// <summary>
        /// Path to the script.
        /// </summary>
        public string ScriptPath;

        /// <summary>
        /// The script text
        /// </summary>
        public string ScriptText;

        /// <summary>
        /// The ast nodes created from the script.
        /// </summary>
        public List<List<Expr>> NodesStack;

        /// <summary>
        /// The ast nodes created from the script.
        /// </summary>
        public List<Expr> Nodes;

        /// <summary>
        /// The context of the runtime.
        /// </summary>
        public Context Ctx;
    }
}