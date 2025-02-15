﻿using FortniteReplayReader.Models.NetFieldExports.Enums;
using Unreal.Core.Attributes;
using Unreal.Core.Contracts;
using Unreal.Core.Models;
using Unreal.Core.Models.Enums;

namespace FortniteReplayReader.Models.NetFieldExports;

[NetFieldExportGroup("/Script/FortniteGame.FortLevelSaveComponent", ParseType.Full)]
[RedirectPath("LevelSave")]
public class FortLevelMap : INetFieldExportGroup
{
	[NetFieldExport("bIsActive", RepLayoutCmdType.PropertyBool)]
	public bool? bIsActive { get; set; }

	[NetFieldExport("AccountIdOfOwner", RepLayoutCmdType.PropertyString)]
	public string AccountIdOfOwner { get; set; }


	[NetFieldExport("LoadedPlotInstanceId", RepLayoutCmdType.PropertyString)]
	public string LoadedPlotInstanceId { get; set; }

	[NetFieldExport("bUserInitiatedLoad", RepLayoutCmdType.PropertyBool)]
	public bool? bUserInitiatedLoad { get; set; }

	[NetFieldExport("CreatorName", RepLayoutCmdType.PropertyString)]
	public string CreatorName { get; set; }

	[NetFieldExport("SupportCode", RepLayoutCmdType.PropertyString)]
	public string SupportCode { get; set; }

	[NetFieldExport("Mnemonic", RepLayoutCmdType.PropertyString)]
	public string Mnemonic { get; set; }

	[NetFieldExport("Privacy", RepLayoutCmdType.Enum)]
	public int? Privacy { get; set; }

	[NetFieldExport("Version", RepLayoutCmdType.PropertyInt)]
	public int? Version { get; set; }

	[NetFieldExport("AccountId", RepLayoutCmdType.PropertyString)]
	public string AccountId { get; set; }

	[NetFieldExport("IslandIntroduction", RepLayoutCmdType.DynamicArray)]
	public string[] IslandIntroduction { get; set; }

	[NetFieldExport("DescriptionTags", RepLayoutCmdType.DynamicArray)]
	public string[] DescriptionTags { get; set; }

	[NetFieldExport("LinkTitle", RepLayoutCmdType.DynamicArray)]
	public string[] LinkTitle { get; set; }

	[NetFieldExport("TextLiteral", RepLayoutCmdType.DynamicArray)]
	public string[] TextLiteral { get; set; }

	[NetFieldExport("AltTitle", RepLayoutCmdType.PropertyString)]
	public string AltTitle { get; set; }

	[NetFieldExport("LinkTagline", RepLayoutCmdType.DynamicArray)]
	public string[] LinkTagline { get; set; }

	[NetFieldExport("LinkType", RepLayoutCmdType.PropertyString)]
	public string LinkType { get; set; }

	[NetFieldExport("bAllowJoinInProgress", RepLayoutCmdType.PropertyBool)]
	public bool? bAllowJoinInProgress { get; set; }

	[NetFieldExport("bIsLoaded", RepLayoutCmdType.PropertyBool)]
	public bool? bIsLoaded { get; set; }

	[NetFieldExport("bIsAutoSaving", RepLayoutCmdType.PropertyBool)]
	public bool? bIsAutoSaving { get; set; }

	[NetFieldExport("JoinInProgressType", RepLayoutCmdType.Enum)]
	public EJoinInProgress JoinInProgressType { get; set; } = EJoinInProgress.EJoinInProgress_MAX;

	[NetFieldExport("MinimumNumberOfPlayers", RepLayoutCmdType.PropertyInt)]
	public int? MinimumNumberOfPlayers { get; set; }

	[NetFieldExport("MaximumNumberOfPlayers", RepLayoutCmdType.PropertyInt)]
	public int? MaximumNumberOfPlayers { get; set; }

	[NetFieldExport("PlayerCount", RepLayoutCmdType.PropertyInt)]
	public int? PlayerCount { get; set; }

	[NetFieldExport("NumberOfTeams", RepLayoutCmdType.PropertyInt)]
	public int? NumberOfTeams { get; set; }

	[NetFieldExport("PlayersPerTeam", RepLayoutCmdType.PropertyInt)]
	public int? PlayersPerTeam { get; set; }

}

[NetFieldExportGroup("/Game/Playgrounds/Items/BGA_IslandPortal.BGA_IslandPortal_C", ParseType.Full)]
[PartialNetFieldExportGroup("/Game/Playgrounds/Items/BGA_IslandPortal")]
public class IslandPortal : FortLevelMap
{
	[NetFieldExport("ReplicatedMovement", RepLayoutCmdType.RepMovement)]
	public FRepMovement ReplicatedMovement { get; set; }

	[NetFieldExport("bReturnToCreativeHub", RepLayoutCmdType.PropertyBool)]
	public bool? bReturnToCreativeHub { get; set; }

	[NetFieldExport("CurrentPopulation", RepLayoutCmdType.PropertyInt)]
	public int? CurrentPopulation { get; set; }

	[NetFieldExport("OwningPlayer", RepLayoutCmdType.Debug)]
	public DebuggingObject OwningPlayer { get; set; }

	[NetFieldExport("PlayersReady", RepLayoutCmdType.DynamicArray)]
	public FUniqueNetIdRepl[] PlayersReady { get; set; } //Net ids

	[NetFieldExport("TeleportLocation", RepLayoutCmdType.PropertyVector)]
	public FVector? TeleportLocation { get; set; }

	[NetFieldExport("bPortalOpen", RepLayoutCmdType.PropertyBool)]
	public bool? bPortalOpen { get; set; }

	[NetFieldExport("PlayerPawn", RepLayoutCmdType.Property)]
	public NetworkGUID PlayerPawn { get; set; }
}