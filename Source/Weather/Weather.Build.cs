// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Weather : ModuleRules
{
	public Weather(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Weather",
			"Weather/Variant_Platforming",
			"Weather/Variant_Platforming/Animation",
			"Weather/Variant_Combat",
			"Weather/Variant_Combat/AI",
			"Weather/Variant_Combat/Animation",
			"Weather/Variant_Combat/Gameplay",
			"Weather/Variant_Combat/Interfaces",
			"Weather/Variant_Combat/UI",
			"Weather/Variant_SideScrolling",
			"Weather/Variant_SideScrolling/AI",
			"Weather/Variant_SideScrolling/Gameplay",
			"Weather/Variant_SideScrolling/Interfaces",
			"Weather/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
