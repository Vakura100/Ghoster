// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Ghoster : ModuleRules
{
	public Ghoster(ReadOnlyTargetRules Target) : base(Target)
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
			"Ghoster",
			"Ghoster/Variant_Platforming",
			"Ghoster/Variant_Platforming/Animation",
			"Ghoster/Variant_Combat",
			"Ghoster/Variant_Combat/AI",
			"Ghoster/Variant_Combat/Animation",
			"Ghoster/Variant_Combat/Gameplay",
			"Ghoster/Variant_Combat/Interfaces",
			"Ghoster/Variant_Combat/UI",
			"Ghoster/Variant_SideScrolling",
			"Ghoster/Variant_SideScrolling/AI",
			"Ghoster/Variant_SideScrolling/Gameplay",
			"Ghoster/Variant_SideScrolling/Interfaces",
			"Ghoster/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
