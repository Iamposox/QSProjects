﻿using System;
using System.Collections.Generic;
using QS.Navigation;
using QS.Tdi;

namespace QS.GtkUI.Navigation
{
	public interface ITdiPageFactory
	{
		IPage CreateTdiPageTypedArgs<TTdiTab>(Type[] ctorTypes, object[] ctorValues, string hash) where TTdiTab : ITdiTab;

		IPage CreateTdiPageNamedArgs<TTdiTab>(IDictionary<string, object> ctorArgs, string hash) where TTdiTab : ITdiTab;
	}
}
