﻿using System;

namespace Adamant.Exploratory.Forge.Commands
{
	public class BuildCommand : ProjectDirCommand
	{
		public BuildCommand()
		{
			IsCommand("build", "Build a forge project");
		}

		public override int Run(string[] remainingArguments)
		{
			try
			{
				var compiler = new ProjectCompiler(ProjectPath);
				var projects = compiler.Compile();
				// TODO split out compile and emit
				return 0;
			}
			catch(CompileFailedException)
			{
				Console.WriteLine("Build Failed, stopping");
				return 1;
			}
		}
	}
}
