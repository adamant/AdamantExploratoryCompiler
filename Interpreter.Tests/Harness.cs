﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Adamant.Exploratory.Common.Tests;
using Adamant.Exploratory.Compiler;
using Adamant.Exploratory.Compiler.Core;
using Adamant.Exploratory.Compiler.Core.Diagnostics;
using Adamant.Exploratory.Compiler.Semantics;
using Adamant.Exploratory.Compiler.Syntax;
using NUnit.Framework;

namespace Adamant.Exploratory.Interpreter.Tests
{
	[TestFixture]
	public class Harness
	{
		private const string Extension = ".adam";
		private readonly AdamantCompiler compiler = new AdamantCompiler();
		private readonly PackageReferenceSyntax runtimeDependency = new PackageReferenceSyntax("System.Runtime", null, true);

		private string WorkPath;

		[TestFixtureSetUp]
		public void SetUp()
		{
			WorkPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
			Directory.CreateDirectory(WorkPath);
		}

		[TestFixtureTearDown]
		public void TearDown()
		{
			Directory.Delete(WorkPath, true);
		}

		[Test, TestCaseSource(nameof(TestCases))]
		public void Test(TestCaseConfig config, TextReader reader)
		{
			var dependencies = config.Runtime ? new[] { runtimeDependency } : Enumerable.Empty<PackageReferenceSyntax>();
			var package = new PackageSyntax($"Adamant.Exploratory.Compiler.Tests.{config.TestName}", true, dependencies);
			var unit = compiler.Parse(package, new SourceReader(config.FileName, reader));
			package = package.With(new[] { unit });
			if(package.Diagnostics.Count > 0)
				Assert.Fail(ToString(package.Diagnostics));
			var compiledPackage = compiler.Compile(package, Enumerable.Empty<Package>());
			if(compiledPackage.Diagnostics.Count > 0)
				Assert.Fail(ToString(compiledPackage.Diagnostics));

			var interpreter = new AdamantInterpreter(compiledPackage);
			var entryPoint = compiledPackage.EntryPoints.Single();
			var outputBuffer = new StringBuilder();
			var errorBuffer = new StringBuilder();
			var exitCode = interpreter.Invoke(entryPoint, new StringWriter(outputBuffer), new StringWriter(errorBuffer));
			Assert.AreEqual(config.Result, exitCode, "Exit Code");
			if(config.VerifyConsoleOutput)
				Assert.AreEqual(config.ExpectedConsoleOutput, outputBuffer.ToString());
		}

		private static string ToString(IReadOnlyList<Diagnostic> diagnostics)
		{
			var builder = new StringBuilder();
			ISourceText file = null;
			foreach(var diagnostic in diagnostics)
			{
				if(file != diagnostic.File)
				{
					file = diagnostic.File;
					builder.AppendLine($"In {file.Name}");
				}
				var level = diagnostic.Level.ToString();
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
				var config = TestCaseConfig.Read(reader);
				config.FileName = resourceName;
				config.TestName = resourceName.Substring(namespaceLength, resourceName.Length - namespaceLength - Extension.Length);
				var testCaseData = new TestCaseData(config, reader).SetName(config.TestName);
				if(!string.IsNullOrWhiteSpace(config.Description))
					testCaseData.SetDescription(config.Description);
				yield return testCaseData;
			}
		}
	}
}
