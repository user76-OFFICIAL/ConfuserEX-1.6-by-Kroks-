﻿using System;
using dnlib.DotNet;

namespace Confuser.Core.Project.Patterns {
	/// <summary>
	///     A function that compare the full name of definition.
	/// </summary>
	public class FullNameFunction : PatternFunction {
		internal const string FnName = "full-name";

		/// <inheritdoc />
		public override string Name {
			get { return FnName; }
		}

		/// <inheritdoc />
		public override int ArgumentCount {
			get { return 1; }
		}

		/// <inheritdoc />
		public override object Evaluate(IDnlibDef definition) {
			object name = Arguments[0].Evaluate(definition);
			return definition.FullName == name.ToString();
		}
	}
}