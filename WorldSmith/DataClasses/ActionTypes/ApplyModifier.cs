/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.Panels;
using WorldSmith.Dialogs;

namespace WorldSmith.DataClasses
{
	[DotaAction]
	[EditorGrammar("Apply %ModifierName on %Target")]
	public partial class ApplyModifier : TargetedAction
	{
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string ModifierName
		{
			get;
			set;
		}

	}
}
