﻿/*
TShock, a server mod for Terraria
Copyright (C) 2011-2019 Pryaxis & TShock Contributors

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using Microsoft.Xna.Framework;
using System;

namespace TShockAPI
{
	public static class StringExt
	{
		//Can't name it Format :(
		public static String SFormat(this String str, params object[] args)
		{
			return String.Format(str, args);
		}

		/// <summary>
		/// Wraps the string representation of an object with a Terraria color code for the given color
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="color"></param>
		/// <returns></returns>
		public static string Color(this object obj, string color)
		{
			return $"[c/{color}:{obj}]";
		}
	}
}
