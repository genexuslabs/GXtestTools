﻿using GeneXus.GXtest.Tools.TestConvert.BL.v3;
using System.Diagnostics;
using System.Text;

namespace GeneXus.GXtest.Tools.TestConvert.BL.Generation.Commands
{
    class FillInput : CommandGenerator
    {
        public FillInput(Command command)
            : base(command)
        {
            Debug.Assert(command.Name == CommandNames.FillInput);
        }

        public override void Generate(StringBuilder builder)
        {
            builder.AppendCommentLine("FillInput command generation", Verbosity.Diagnostic);
            builder.AppendCommentLine($"Ignoring first parm {Command.Parameters[0]}", Verbosity.Diagnostic);

            builder.AppendDriverMethod(MethodNames.Type, Command.Parameters[1], Command.Parameters[2]);
        }
    }
}
