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
	public partial class TargetedAction : BaseAction
	{
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(null)]
		public TargetKey Target
		{
			get;
			set;
		}

	}
}
