﻿using System;
using GammaBinding.ColumnConfig;

namespace GammaBinding
{
	public static class ColumnsConfigFactory
	{
		public static FluentColumnsConfig<TNode> Create<TNode>()
		{
			return new FluentColumnsConfig<TNode> ();
		}
	}
}

