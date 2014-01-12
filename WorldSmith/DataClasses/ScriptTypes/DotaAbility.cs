/*****************************  NOTICE  ********************************************
* This file was autogenerated.  Do not edit.                                       *
* Instead, modify the schema in DataSchema related to this class and regenerate it *
***********************************************************************************/
using System;
using System.ComponentModel;
using WorldSmith.DataClasses.UI;
using WorldSmith.Panels;

namespace WorldSmith.DataClasses
{
	class DotaAbility : BaseScriptType
	{
		[Category("General")]
		[Description("The unique ID number of this ability. No spells may have the same ID number.")]
		[ReadOnly(true)]
		[DefaultValue(0)]
		public int ID
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string AbilityName
		{
			get;
			set;
		}

		public enum AbilityTypeEnum
		{
			DOTA_ABILITY_TYPE_BASIC,
			DOTA_ABILITY_TYPE_ATTRIBUTES,
			DOTA_ABILITY_TYPE_ULTIMATE,
			DOTA_ABILITY_TYPE_HIDDEN,
		}

		[Category("General")]
		[Description("States which type of ability this is, from basic, stats, ultimate, or hidden.")]
		[DefaultValue(AbilityTypeEnum.DOTA_ABILITY_TYPE_BASIC)]
		public AbilityTypeEnum AbilityType
		{
			get;
			set;
		}

		public enum AbilityUnitDamageTypeEnum
		{
			DAMAGE_TYPE_COMPOSITE,
			DAMAGE_TYPE_HP_REMOVAL,
			DAMAGE_TYPE_MAGICAL,
			DAMAGE_TYPE_PHYSICAL,
			DAMAGE_TYPE_PURE,
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityUnitDamageTypeEnum.DAMAGE_TYPE_MAGICAL)]
		public AbilityUnitDamageTypeEnum AbilityUnitDamageType
		{
			get;
			set;
		}

		[Flags]
		public enum AbilityBehaviorFlags
		{
			DOTA_ABILITY_BEHAVIOR_NONE = 0,
			DOTA_ABILITY_BEHAVIOR_HIDDEN = 1,
			DOTA_ABILITY_BEHAVIOR_PASSIVE = 2,
			DOTA_ABILITY_BEHAVIOR_NO_TARGET = 4,
			DOTA_ABILITY_BEHAVIOR_UNIT_TARGET = 8,
			DOTA_ABILITY_BEHAVIOR_POINT = 16,
			DOTA_ABILITY_BEHAVIOR_AOE = 32,
			DOTA_ABILITY_BEHAVIOR_NOT_LEARNABLE = 64,
			DOTA_ABILITY_BEHAVIOR_CHANNELLED = 128,
			DOTA_ABILITY_BEHAVIOR_ITEM = 256,
			DOTA_ABILITY_BEHAVIOR_TOGGLE = 512,
			DOTA_ABILITY_BEHAVIOR_DIRECTIONAL = 1024,
			DOTA_ABILITY_BEHAVIOR_IMMEDIATE = 2048,
			DOTA_ABILITY_BEHAVIOR_AUTOCAST = 4096,
			DOTA_ABILITY_BEHAVIOR_NOASSIST = 8192,
			DOTA_ABILITY_BEHAVIOR_AURA = 16384,
			DOTA_ABILITY_BEHAVIOR_ATTACK = 32768,
			DOTA_ABILITY_BEHAVIOR_DONT_RESUME_MOVEMENT = 65536,
			DOTA_ABILITY_BEHAVIOR_ROOT_DISABLES = 131072,
			DOTA_ABILITY_BEHAVIOR_UNRESTRICTED = 262144,
			DOTA_ABILITY_BEHAVIOR_IGNORE_PSEUDO_QUEUE = 524288,
			DOTA_ABILITY_BEHAVIOR_IGNORE_CHANNEL = 1048576,
			DOTA_ABILITY_BEHAVIOR_DONT_CANCEL_MOVEMENT = 2097152,
			DOTA_ABILITY_BEHAVIOR_DONT_ALERT_TARGET = 4194304,
			DOTA_ABILITY_BEHAVIOR_DONT_RESUME_ATTACK = 8388608,
			DOTA_ABILITY_BEHAVIOR_NORMAL_WHEN_STOLEN = 16777216,
			DOTA_ABILITY_BEHAVIOR_IGNORE_BACKSWING = 33554432,
			DOTA_ABILITY_BEHAVIOR_RUNE_TARGET = 67108864,
			DOTA_ABILITY_BEHAVIOR_IGNORE_TURN = 134217728,
			DOTA_ABILITY_BEHAVIOR_POINT_TARGET = 268435456,
			DOTA_ABILITY_TYPE_ULTIMATE = 536870912,
		}

        [Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
        //[Editor(typeof(FlagEnumUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("General")]
		[Description("States how this ability behaves.")]
		[DefaultValue(AbilityBehaviorFlags.DOTA_ABILITY_BEHAVIOR_NONE)]
		public AbilityBehaviorFlags AbilityBehavior
		{
			get;
			set;
		}

		[Category("General")]
		[Description("The icon image for this ability.")]
		[DefaultValue("")]
		public string AbilityTextureName
		{
			get;
			set;
		}

		[Flags]
		public enum AbilityUnitTargetTeamFlags
		{
			DOTA_UNIT_TARGET_TEAM_NONE = 0,
			DOTA_UNIT_TARGET_TEAM_ENEMY = 1 << 1,
			DOTA_UNIT_TARGET_TEAM_FRIENDLY = 1 << 2,
			DOTA_UNIT_TARGET_TEAM_CUSTOM = 1 << 3,
			DOTA_UNIT_TARGET_TEAM_BOTH = DOTA_UNIT_TARGET_TEAM_ENEMY | DOTA_UNIT_TARGET_TEAM_FRIENDLY,
			DOTA_UNIT_TARGET_ALL = 0xFFFF,
		}

        [Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityUnitTargetTeamFlags.DOTA_UNIT_TARGET_TEAM_NONE)]
		public AbilityUnitTargetTeamFlags AbilityUnitTargetTeam
		{
			get;
			set;
		}

		[Flags]
		public enum AbilityUnitTargetTypeFlags
		{
			DOTA_UNIT_TARGET_NONE = 0,
			DOTA_UNIT_TARGET_HERO = 1 << 1,
			DOTA_UNIT_TARGET_CREEP = 1 << 2,
			DOTA_UNIT_TARGET_BUILDING = 1 << 3,
			DOTA_UNIT_TARGET_MECHANICAL = 1 << 4,
			DOTA_UNIT_TARGET_COURIER = 1 << 5,
			DOTA_UNIT_TARGET_OTHER = 1 << 6,
			DOTA_UNIT_TARGET_TREE = 1 << 7,
			DOTA_UNIT_TARGET_CUSTOM = 1 << 8,
			DOTA_UNIT_TARGET_BASIC = 1 << 9,
			DOTA_UNIT_TARGET_ALL = 0xFFFF,
		}

        [Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityUnitTargetTypeFlags.DOTA_UNIT_TARGET_NONE)]
		public AbilityUnitTargetTypeFlags AbilityUnitTargetType
		{
			get;
			set;
		}

		[Flags]
		public enum AbilityUnitTargetFlagsFlags
		{
			DOTA_UNIT_TARGET_FLAG_NONE = 0,
			DOTA_UNIT_TARGET_FLAG_RANGED_ONLY = 1 << 1,
			DOTA_UNIT_TARGET_FLAG_MELEE_ONLY = 1 << 2,
			DOTA_UNIT_TARGET_FLAG_DEAD = 1 << 3,
			DOTA_UNIT_TARGET_FLAG_MAGIC_IMMUNE_ENEMIES = 1 << 4,
			DOTA_UNIT_TARGET_FLAG_NOT_MAGIC_IMMUNE_ALLIES = 1 << 5,
			DOTA_UNIT_TARGET_FLAG_INVULNERABLE = 1 << 6,
			DOTA_UNIT_TARGET_FLAG_FOW_VISIBLE = 1 << 7,
			DOTA_UNIT_TARGET_FLAG_NO_INVIS = 1 << 8,
			DOTA_UNIT_TARGET_FLAG_NOT_ANCIENTS = 1 << 9,
			DOTA_UNIT_TARGET_FLAG_PLAYER_CONTROLLED = 1 << 10,
			DOTA_UNIT_TARGET_FLAG_NOT_DOMINATED = 1 << 11,
			DOTA_UNIT_TARGET_FLAG_NOT_SUMMONED = 1 << 12,
			DOTA_UNIT_TARGET_FLAG_NOT_ILLUSION = 1 << 13,
			DOTA_UNIT_TARGET_FLAG_NOT_ATTACK_IMMUNE = 1 << 14,
			DOTA_UNIT_TARGET_FLAG_MANA_ONLY = 1 << 15,
			DOTA_UNIT_TARGET_FLAG_CHECK_DISABLE_HELP = 1 << 16,
			DOTA_UNIT_TARGET_FLAG_NOT_CREEP_HERO = 1 << 17,
			DOTA_UNIT_TARGET_FLAG_OUT_OF_WORLD = 1 << 18,
			DOTA_UNIT_TARGET_FLAG_NOT_NIGHTMARED = 1 << 19,
		}

        [Editor(typeof(FlagEnumDialogUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(AbilityUnitTargetFlagsFlags.DOTA_UNIT_TARGET_FLAG_NONE)]
		public AbilityUnitTargetFlagsFlags AbilityUnitTargetFlags
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool OnCastbar
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool OnLearnbar
		{
			get;
			set;
		}

		[Category("Casting")]
		[Description("The the range at which this spell can cast at.")]
		[DefaultValue(0)]
		public int AbilityCastRange
		{
			get;
			set;
		}

		[Category("Casting")]
		[Description("No Description Set")]
		[DefaultValue(250)]
		public int AbilityCastRangeBuffer
		{
			get;
			set;
		}

		[Category("Casting")]
		[Description("The cast point of the spell.")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityCastPoint
		{
			get;
			set;
		}

		[Category("Casting")]
		[Description("The duration that this spell can be channeled for.")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityChannelTime
		{
			get;
			set;
		}

		[Category("Casting")]
		[Description("The cooldown of this spell.")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityCooldown
		{
			get;
			set;
		}

		[Category("Casting")]
		[Description("The duration of this spell.")]
		[DefaultValue(typeof(PerLevel), "0.0 0.0 0.0 0.0")]
		public PerLevel AbilityDuration
		{
			get;
			set;
		}

		[Category("Casting")]
		[Description("No Description Set")]
		[DefaultValue("")]
		public string AbilitySharedCooldown
		{
			get;
			set;
		}

		[Category("Casting")]
		[Description("The damage that this spell does.")]
		[DefaultValue(typeof(PerLevel), "0 0 0 0")]
		public PerLevel AbilityDamage
		{
			get;
			set;
		}

		[Category("Casting")]
		[Description("The mana cost of this spell.")]
		[DefaultValue(typeof(PerLevel), "0 0 0 0")]
		public PerLevel AbilityManaCost
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(1.0)]
		public float AbilityModifierSupportValue
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(0)]
		public float AbilityModifierSupportBonus
		{
			get;
			set;
		}

		[Category("Misc")]
		[Description("No Description Set")]
		[DefaultValue(false)]
		public bool AbilityProcsMagicStick
		{
			get;
			set;
		}

	}
}