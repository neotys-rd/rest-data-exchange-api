﻿/*
 * Copyright (c) 2015, Neotys
 * All rights reserved.
 */
namespace Neotys.DataExchangeAPI.Utils
{

	/// <summary>
	/// Util class to escape invalid characters.
	/// 
	/// @author srichert
	/// 
	/// </summary>
	public sealed class Escaper
	{

		private Escaper()
		{
            throw new System.AccessViolationException();
		}

        private static readonly char[] FORBIDDEN_CHARS = { '£', '€', '$', '\"', '[', ']', '<', '>', '|', '*', '¤', '?', '§',
            'µ', '#', '`', '@', '^', '²', '°', '¨' };

		/// <summary>
		/// Replace special characters in a string. </summary>
		/// <param name="name">
		/// @return </param>
		public static string Escape(string name)
		{
			if (name == null)
			{
				return null;
			}

			string escaped = name;

			// replace all special characters
			foreach (char c in FORBIDDEN_CHARS)
			{
				escaped = escaped.Replace(c, '_');
			}

			return escaped;
		}
	}

}