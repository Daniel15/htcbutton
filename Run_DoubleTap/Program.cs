﻿using System;
using PluginInterface;

namespace Run_DoubleTap
{
	class Program
	{
		static void Main(string[] args)
		{
			PluginServices ps = new PluginServices();
			ps.Load("DoubleTap");
		}
	}
}
