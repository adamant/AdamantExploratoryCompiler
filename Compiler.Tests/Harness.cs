﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Adamant.Exploratory.Compiler.Compiled;
using Adamant.Exploratory.Compiler.Core;
using Adamant.Exploratory.Compiler.Syntax;
using Adamant.Exploratory.Compiler.Syntax.PackageConfig;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Adamant.Exploratory.Compiler.Tests
{
	[TestFixture]
	public class Harness
	{
		private const string Extension = ".adam";
		private readonly AdamantCompiler compiler = new AdamantCompiler();
		private readonly PackageDependency runtimeDependency = new PackageDependency("System.Runtime", null, true);

		[Test, TestCaseSource(nameof(TestCases))]
		public void Test(TestCaseConfig config, TextReader reader)
		{
			var dependencies = config.Runtime ? new[] { runtimeDependency } : Enumerable.Empty<PackageDependency>();
			var package = new Package($"Adamant.Exploratory.Compiler.Tests.{config.TestName}", dependencies);
			var unit = compiler.Parse(package, new SourceReader(config.FileName, reader));
			package = package.With(new[] { unit });
			if(package.Diagnostics.Count > 0)
				Assert.Fail(ToStringDiagnostics(package));
			var compiledPackage = compiler.Compile(package, Enumerable.Empty<CompiledPackage>());
			// TODO fail on any compilation errors at this stage
			Assert.Fail("C++ code generation not implemented");
			Assert.Fail("C++ compilation not implemented");
			Assert.Fail("App execution not implemented");
		}

		private static string ToStringDiagnostics(Package package)
		{
			var builder = new StringBuilder();
			ISourceText file = null;
			foreach(var diagnostic in package.Diagnostics)
			{
				if(file != diagnostic.File)
				{
					file = diagnostic.File;
					builder.AppendLine($"In {file.Name}");
				}
				var level = diagnostic.IsError ? "Error" : "Warning";
				var line = diagnostic.Position.Line + 1;
				var column = diagnostic.Position.Column + 1;
				builder.AppendLine($"{level} on line {line} at character {column}: ");
				builder.AppendLine($"    {diagnostic.Message}");
			}
			return builder.ToString();
		}

		public IEnumerable<TestCaseData> TestCases()
		{
			var namespaceLength = typeof(Harness).Namespace.Length + 1;
			var assembly = Assembly.GetExecutingAssembly();
			var resourceNames = assembly.GetManifestResourceNames().Where(name => name.EndsWith(Extension));
			foreach(var resourceName in resourceNames)
			{
				var stream = assembly.GetManifestResourceStream(resourceName);
				var reader = new StreamReader(stream);
				var config = ReadConfig(reader);
				config.FileName = resourceName;
				config.TestName = resourceName.Substring(namespaceLength, resourceName.Length - namespaceLength - Extension.Length);
				var testCaseData = new TestCaseData(config, reader).SetName(config.TestName);
				if(!string.IsNullOrWhiteSpace(config.Description))
					testCaseData.SetDescription(config.Description);
				yield return testCaseData;
			}
		}

		public static TestCaseConfig ReadConfig(TextReader reader)
		{
			var line = reader.ReadLine().Trim();
			Assert.AreEqual("/*---", line);
			var lines = new List<string>();
			string rawLine;
			while((line = (rawLine = reader.ReadLine()).Trim()) != "---" && line != "*/")
				lines.Add(rawLine);

			var vson = string.Join("\r\n", lines);
			var config = JsonConvert.DeserializeObject<TestCaseConfig>(vson);

			if(line == "---")
			{
				// read in expected console output
				lines.Clear();
				while((line = (rawLine = reader.ReadLine()).Trim()) != "*/")
					lines.Add(rawLine);

				config.VerifyConsoleOutput = true;
				config.ExpectedConsoleOutput = string.Join("\r\n", lines);
			}

			return config;
		}
	}
}
