﻿using FortniteReplayReader.Models.Enums;
using Unreal.Core.Models;

namespace FortniteReplayReader.Models;

public class PlayerEliminationInfo
{
	public FQuat Rotation { get; internal set; }
	public FVector Scale { get; internal set; }
	public FVector Location { get; internal set; }
	public PlayerTypes PlayerType { get; internal set; }

	public string Id { get; internal set; }
	public bool IsBot => PlayerType == PlayerTypes.Bot || PlayerType == PlayerTypes.NamedBot;
}