﻿using Adamant.Exploratory.Common;
using Adamant.Exploratory.Compiler.Core;

namespace Adamant.Exploratory.Compiler.Syntax
{
	public class Token
	{
		public readonly TokenType Type;
		public readonly TextPosition Position;
		public readonly string Text;
		public readonly string ValueText;

		public Token(TokenType type, TextPosition position, string text, string valueText)
		{
			Requires.EnumDefined(type, nameof(type));
			Requires.NotNullOrEmpty(text, nameof(text));

			Type = type;
			Position = position;
			Text = text;
			ValueText = valueText;
		}
	}
}