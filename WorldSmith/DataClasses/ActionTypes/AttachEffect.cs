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
	public partial class AttachEffect : TargetedAction
	{
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string EffectName
		{
			get;
			set;
		}

		public enum EffectAttachTypeEnum
		{
			start_at_origin,
			follow_origin,
			start_at_customorigin,
			follow_customorigin,
			start_at_attachment,
			follow_attachment,
			follow_eyes,
			follow_overhead,
			world_origin,
			follow_rootbone,
			follow_attachment_substepped,
			follow_renderorigin,
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(EffectAttachTypeEnum.follow_origin)]
		public EffectAttachTypeEnum EffectAttachType
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(null)]
		public ControlPointList ControlPoints
		{
			get;
			set;
		}

	}
}