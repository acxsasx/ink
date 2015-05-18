﻿using System;
using System.Collections.Generic;

namespace inklecate2Sharp
{
	public partial class InkParser : StringParser
	{
		public InkParser(string str) : base(str) { }

		// Main entry point
		public void Parse()
		{
			var r = Interleave(() => ParseString("A"),
				Optional(() => ParseString("B"))
			);

			Console.WriteLine (r);
			
//			MultilineWhitespace();
//
//			ParseString ("§");
//
//			Whitespace ();
//
//			string identifier = Identifier ();
//
//			System.Console.WriteLine ("Knot id: " + identifier);
		}

		protected string Identifier()
		{
			if (_identifierCharSet == null) {

				_identifierCharSet = new CharacterSet();
				_identifierCharSet.AddRange ('A', 'Z');
				_identifierCharSet.AddRange ('a', 'z');
				_identifierCharSet.AddRange ('0', '9');
				_identifierCharSet.Add ('_');
			}

			return ParseCharactersFromCharSet (_identifierCharSet);
		}

		private CharacterSet _identifierCharSet;
	}
}

