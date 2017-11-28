﻿/*
 * Copyright (C) 2012-2017 CypherCore <http://github.com/CypherCore>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Framework.Database
{
    public class HotfixDatabase : MySqlBase<HotfixStatements>
    {
        public override void PreparedStatements()
        {
            // Achievement.db2
            PrepareStatement(HotfixStatements.SEL_ACHIEVEMENT, "SELECT Title, Description, Flags, Reward, MapID, Supercedes, Category, UIOrder, SharesCriteria, " +
                "CriteriaTree, Faction, Points, MinimumCriteria, ID, IconFileDataID, CriteriaTree FROM achievement ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ACHIEVEMENT_LOCALE, "SELECT ID, Title_lang, Description_lang, Reward_lang FROM achievement_locale WHERE locale = ?");

            // AnimKit.db2
            PrepareStatement(HotfixStatements.SEL_ANIM_KIT, "SELECT ID, OneShotDuration, OneShotStopAnimKitID, LowDefAnimKitID FROM anim_kit ORDER BY ID DESC");

            // AreaGroupMember.db2
            PrepareStatement(HotfixStatements.SEL_AREA_GROUP_MEMBER, "SELECT ID, AreaGroupID, AreaID FROM area_group_member ORDER BY ID DESC");

            // AreaTable.db2
            PrepareStatement(HotfixStatements.SEL_AREA_TABLE, "SELECT ID, Flags1, Flags2, ZoneName, AmbientMultiplier, AreaName, MapID, ParentAreaID, AreaBit, " +
                "AmbienceID, ZoneMusic, IntroSound, LiquidTypeID1, LiquidTypeID2, LiquidTypeID3, LiquidTypeID4, UWZoneMusic, UWAmbience, " +
                "PvPCombatWorldStateID, SoundProviderPref, SoundProviderPrefUnderwater, ExplorationLevel, FactionGroupMask, MountFlags, " +
                "WildBattlePetLevelMin, WildBattlePetLevelMax, WindSettingsID, UWIntroSound FROM area_table ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_AREA_TABLE_LOCALE, "SELECT ID, AreaName_lang FROM area_table_locale WHERE locale = ?");

            // AreaTrigger.db2
            PrepareStatement(HotfixStatements.SEL_AREA_TRIGGER, "SELECT PosX, PosY, PosZ, Radius, BoxLength, BoxWidth, BoxHeight, BoxYaw, MapID, PhaseID, PhaseGroupID, " +
                "ShapeID, AreaTriggerActionSetID, PhaseUseFlags, ShapeType, Flag, ID FROM area_trigger ORDER BY ID DESC");

            // ArmorLocation.db2
            PrepareStatement(HotfixStatements.SEL_ARMOR_LOCATION, "SELECT ID, Modifier1, Modifier2, Modifier3, Modifier4, Modifier5 FROM armor_location ORDER BY ID DESC");

            // Artifact.db2
            PrepareStatement(HotfixStatements.SEL_ARTIFACT, "SELECT ID, Name, BarConnectedColor, BarDisconnectedColor, TitleColor, ClassUiTextureKitID, SpecID, " +
                "ArtifactCategoryID, Flags, UiModelSceneID, SpellVisualKitID FROM artifact ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_LOCALE, "SELECT ID, Name_lang FROM artifact_locale WHERE locale = ?");

            // ArtifactAppearance.db2
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_APPEARANCE, "SELECT Name, SwatchColor, ModelDesaturation, ModelAlpha, ShapeshiftDisplayID, " +
                "ArtifactAppearanceSetID, Unknown, DisplayIndex, AppearanceModID, Flags, ModifiesShapeshiftFormDisplay, ID, PlayerConditionID, " +
                "ItemAppearanceID, AltItemAppearanceID FROM artifact_appearance ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_APPEARANCE_LOCALE, "SELECT ID, Name_lang FROM artifact_appearance_locale WHERE locale = ?");

            // ArtifactAppearanceSet.db2
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_APPEARANCE_SET, "SELECT Name, Name2, UiCameraID, AltHandUICameraID, ArtifactID, DisplayIndex, " +
                "AttachmentPoint, Flags, ID FROM artifact_appearance_set ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_APPEARANCE_SET_LOCALE, "SELECT ID, Name_lang, Name2_lang FROM artifact_appearance_set_locale WHERE locale = ?");

            // ArtifactCategory.db2
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_CATEGORY, "SELECT ID, ArtifactKnowledgeCurrencyID, ArtifactKnowledgeMultiplierCurveID FROM artifact_category ORDER BY ID DESC");

            // ArtifactPower.db2
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_POWER, "SELECT PosX, PosY, ArtifactID, Flags, MaxRank, ArtifactTier, ID, RelicType FROM artifact_power" +
                " ORDER BY ID DESC");

            // ArtifactPowerLink.db2
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_POWER_LINK, "SELECT ID, FromArtifactPowerID, ToArtifactPowerID FROM artifact_power_link ORDER BY ID DESC");

            // ArtifactPowerPicker.db2
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_POWER_PICKER, "SELECT ID, PlayerConditionID FROM artifact_power_picker ORDER BY ID DESC");

            // ArtifactPowerRank.db2
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_POWER_RANK, "SELECT ID, SpellID, Value, ArtifactPowerID, Unknown, Rank FROM artifact_power_rank ORDER BY ID DESC");

            // ArtifactQuestXp.db2
            PrepareStatement(HotfixStatements.SEL_ARTIFACT_QUEST_XP, "SELECT ID, Exp1, Exp2, Exp3, Exp4, Exp5, Exp6, Exp7, Exp8, Exp9, Exp10 FROM artifact_quest_xp ORDER BY ID DESC");

            // AuctionHouse.db2
            PrepareStatement(HotfixStatements.SEL_AUCTION_HOUSE, "SELECT ID, Name, FactionID, DepositRate, ConsignmentRate FROM auction_house ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_AUCTION_HOUSE_LOCALE, "SELECT ID, Name_lang FROM auction_house_locale WHERE locale = ?");

            // BankBagSlotPrices.db2
            PrepareStatement(HotfixStatements.SEL_BANK_BAG_SLOT_PRICES, "SELECT ID, Cost FROM bank_bag_slot_prices ORDER BY ID DESC");

            // BannedAddons.db2
            PrepareStatement(HotfixStatements.SEL_BANNED_ADDONS, "SELECT ID, Name, Version, Flags FROM banned_addons ORDER BY ID DESC");

            // BarberShopStyle.db2
            PrepareStatement(HotfixStatements.SEL_BARBER_SHOP_STYLE, "SELECT DisplayName, Description, CostModifier, Type, Race, Sex, Data, ID FROM barber_shop_style" +
                " ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_BARBER_SHOP_STYLE_LOCALE, "SELECT ID, DisplayName_lang, Description_lang FROM barber_shop_style_locale WHERE locale = ?");

            // BattlePetBreedQuality.db2
            PrepareStatement(HotfixStatements.SEL_BATTLE_PET_BREED_QUALITY, "SELECT ID, Modifier, Quality FROM battle_pet_breed_quality ORDER BY ID DESC");

            // BattlePetBreedState.db2
            PrepareStatement(HotfixStatements.SEL_BATTLE_PET_BREED_STATE, "SELECT ID, Value, BreedID, State FROM battle_pet_breed_state ORDER BY ID DESC");

            // BattlePetSpecies.db2
            PrepareStatement(HotfixStatements.SEL_BATTLE_PET_SPECIES, "SELECT CreatureID, IconFileID, SummonSpellID, SourceText, Description, Flags, PetType, Source, " +
                "ID, CardModelSceneID, LoadoutModelSceneID FROM battle_pet_species ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_BATTLE_PET_SPECIES_LOCALE, "SELECT ID, SourceText_lang, Description_lang FROM battle_pet_species_locale WHERE locale = ?");

            // BattlePetSpeciesState.db2
            PrepareStatement(HotfixStatements.SEL_BATTLE_PET_SPECIES_STATE, "SELECT ID, Value, SpeciesID, State FROM battle_pet_species_state ORDER BY ID DESC");

            // BattlemasterList.db2
            PrepareStatement(HotfixStatements.SEL_BATTLEMASTER_LIST, "SELECT ID, Name, IconFileDataID, GameType, ShortDescription, LongDescription, MapID1, MapID2, " +
                "MapID3, MapID4, MapID5, MapID6, MapID7, MapID8, MapID9, MapID10, MapID11, MapID12, MapID13, MapID14, MapID15, MapID16, HolidayWorldState, " +
                "PlayerConditionID, InstanceType, GroupsAllowed, MaxGroupSize, MinLevel, MaxLevel, RatedPlayers, MinPlayers, MaxPlayers, Flags" +
                " FROM battlemaster_list ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_BATTLEMASTER_LIST_LOCALE, "SELECT ID, Name_lang, GameType_lang, ShortDescription_lang, LongDescription_lang" +
                " FROM battlemaster_list_locale WHERE locale = ?");

            // BroadcastText.db2
            PrepareStatement(HotfixStatements.SEL_BROADCAST_TEXT, "SELECT ID, MaleText, FemaleText, EmoteID0, EmoteID1, EmoteID2, EmoteDelay0, EmoteDelay1, " +
                "EmoteDelay2, SoundID, UnkMoP1, UnkMoP2, Language FROM broadcast_text ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_BROADCAST_TEXT_LOCALE, "SELECT ID, MaleText_lang, FemaleText_lang FROM broadcast_text_locale WHERE locale = ?");

            // CharacterFacialHairStyles.db2
            PrepareStatement(HotfixStatements.SEL_CHARACTER_FACIAL_HAIR_STYLES, "SELECT ID, Geoset1, Geoset2, Geoset3, Geoset4, Geoset5, RaceID, SexID, VariationID" +
                " FROM character_facial_hair_styles ORDER BY ID DESC");

            // CharBaseSection.db2
            PrepareStatement(HotfixStatements.SEL_CHAR_BASE_SECTION, "SELECT ID, Variation, ResolutionVariation, Resolution FROM char_base_section ORDER BY ID DESC");

            // CharSections.db2
            PrepareStatement(HotfixStatements.SEL_CHAR_SECTIONS, "SELECT ID, TextureFileDataID1, TextureFileDataID2, TextureFileDataID3, Flags, RaceID, SexID, " +
                "BaseSection, VariationIndex, ColorIndex FROM char_sections ORDER BY ID DESC");

            // CharStartOutfit.db2
            PrepareStatement(HotfixStatements.SEL_CHAR_START_OUTFIT, "SELECT ID, ItemID1, ItemID2, ItemID3, ItemID4, ItemID5, ItemID6, ItemID7, ItemID8, ItemID9, " +
                "ItemID10, ItemID11, ItemID12, ItemID13, ItemID14, ItemID15, ItemID16, ItemID17, ItemID18, ItemID19, ItemID20, ItemID21, ItemID22, ItemID23, " +
                "ItemID24, PetDisplayID, RaceID, ClassID, GenderID, OutfitID, PetFamilyID FROM char_start_outfit ORDER BY ID DESC");

            // CharTitles.db2
            PrepareStatement(HotfixStatements.SEL_CHAR_TITLES, "SELECT ID, NameMale, NameFemale, MaskID, Flags FROM char_titles ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_CHAR_TITLES_LOCALE, "SELECT ID, NameMale_lang, NameFemale_lang FROM char_titles_locale WHERE locale = ?");

            // ChatChannels.db2
            PrepareStatement(HotfixStatements.SEL_CHAT_CHANNELS, "SELECT ID, Flags, Name, Shortcut, FactionGroup FROM chat_channels ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_CHAT_CHANNELS_LOCALE, "SELECT ID, Name_lang, Shortcut_lang FROM chat_channels_locale WHERE locale = ?");

            // ChrClasses.db2
            PrepareStatement(HotfixStatements.SEL_CHR_CLASSES, "SELECT PetNameToken, Name, NameFemale, NameMale, Filename, CreateScreenFileDataID, " +
                "SelectScreenFileDataID, IconFileDataID, LowResScreenFileDataID, Flags, CinematicSequenceID, DefaultSpec, PowerType, SpellClassSet, " +
                "AttackPowerPerStrength, AttackPowerPerAgility, RangedAttackPowerPerAgility, Unk1, ID FROM chr_classes ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_CHR_CLASSES_LOCALE, "SELECT ID, Name_lang, NameFemale_lang, NameMale_lang FROM chr_classes_locale WHERE locale = ?");

            // ChrClassesXPowerTypes.db2
            PrepareStatement(HotfixStatements.SEL_CHR_CLASSES_X_POWER_TYPES, "SELECT ID, ClassID, PowerType FROM chr_classes_x_power_types ORDER BY ID DESC");

            // ChrRaces.db2
            PrepareStatement(HotfixStatements.SEL_CHR_RACES, "SELECT ID, Flags, MaleDisplayID, FemaleDisplayID, ClientPrefix, ClientFileString, Name, NameFemale, " +
                "NameMale, FacialHairCustomization1, FacialHairCustomization2, HairCustomization, CreateScreenFileDataID, SelectScreenFileDataID, " +
                "MaleCustomizeOffset1, MaleCustomizeOffset2, MaleCustomizeOffset3, FemaleCustomizeOffset1, FemaleCustomizeOffset2, FemaleCustomizeOffset3, " +
                "LowResScreenFileDataID, FactionID, ResSicknessSpellID, SplashSoundID, CinematicSequenceID, BaseLanguage, CreatureType, TeamID, RaceRelated, " +
                "UnalteredVisualRaceID, CharComponentTextureLayoutID, DefaultClassID, NeutralRaceID, ItemAppearanceFrameRaceID, " +
                "CharComponentTexLayoutHiResID, HighResMaleDisplayID, HighResFemaleDisplayID, AlteredFormTransitionSpellVisualID1, " +
                "AlteredFormTransitionSpellVisualID2, AlteredFormTransitionSpellVisualID3, AlteredFormTransitionSpellVisualKitID1, " +
                "AlteredFormTransitionSpellVisualKitID2, AlteredFormTransitionSpellVisualKitID3 FROM chr_races ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_CHR_RACES_LOCALE, "SELECT ID, Name_lang, NameFemale_lang, NameMale_lang FROM chr_races_locale WHERE locale = ?");

            // ChrSpecialization.db2
            PrepareStatement(HotfixStatements.SEL_CHR_SPECIALIZATION, "SELECT MasterySpellID1, MasterySpellID2, Name, Name2, Description, ClassID, OrderIndex, " +
                "PetTalentType, Role, PrimaryStatOrder, ID, IconFileDataID, Flags, AnimReplacementSetID FROM chr_specialization ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_CHR_SPECIALIZATION_LOCALE, "SELECT ID, Name_lang, Name2_lang, Description_lang FROM chr_specialization_locale" +
                " WHERE locale = ?");

            // CinematicCamera.db2
            PrepareStatement(HotfixStatements.SEL_CINEMATIC_CAMERA, "SELECT ID, SoundID, OriginX, OriginY, OriginZ, OriginFacing, ModelFileDataID FROM cinematic_camera" +
                " ORDER BY ID DESC");

            // CinematicSequences.db2
            PrepareStatement(HotfixStatements.SEL_CINEMATIC_SEQUENCES, "SELECT ID, SoundID, Camera1, Camera2, Camera3, Camera4, Camera5, Camera6, Camera7, Camera8" +
                " FROM cinematic_sequences ORDER BY ID DESC");

            // ConversationLine.db2
            PrepareStatement(HotfixStatements.SEL_CONVERSATION_LINE, "SELECT ID, BroadcastTextID, SpellVisualKitID, Duration, NextLineID, Unk1, Yell, Unk2, Unk3" +
                " FROM conversation_line ORDER BY ID DESC");

            // CreatureDisplayInfo.db2
            PrepareStatement(HotfixStatements.SEL_CREATURE_DISPLAY_INFO, "SELECT ID, CreatureModelScale, ModelID, NPCSoundID, SizeClass, Flags, Gender, " +
                "ExtendedDisplayInfoID, TextureVariation1, TextureVariation2, TextureVariation3, PortraitTextureFileDataID, CreatureModelAlpha, SoundID, " +
                "PlayerModelScale, PortraitCreatureDisplayInfoID, BloodID, ParticleColorID, CreatureGeosetData, ObjectEffectPackageID, AnimReplacementSetID, " +
                "UnarmedWeaponSubclass, StateSpellVisualKitID, InstanceOtherPlayerPetScale, MountSpellVisualKitID FROM creature_display_info ORDER BY ID DESC");

            // CreatureDisplayInfoExtra.db2
            PrepareStatement(HotfixStatements.SEL_CREATURE_DISPLAY_INFO_EXTRA, "SELECT ID, FileDataID, HDFileDataID, DisplayRaceID, DisplaySexID, DisplayClassID, " +
                "SkinID, FaceID, HairStyleID, HairColorID, FacialHairID, CustomDisplayOption1, CustomDisplayOption2, CustomDisplayOption3, Flags" +
                " FROM creature_display_info_extra ORDER BY ID DESC");

            // CreatureFamily.db2
            PrepareStatement(HotfixStatements.SEL_CREATURE_FAMILY, "SELECT ID, MinScale, MaxScale, Name, IconFileDataID, SkillLine1, SkillLine2, PetFoodMask, " +
                "MinScaleLevel, MaxScaleLevel, PetTalentType FROM creature_family ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_CREATURE_FAMILY_LOCALE, "SELECT ID, Name_lang FROM creature_family_locale WHERE locale = ?");

            // CreatureModelData.db2
            PrepareStatement(HotfixStatements.SEL_CREATURE_MODEL_DATA, "SELECT ID, ModelScale, FootprintTextureLength, FootprintTextureWidth, FootprintParticleScale, " +
                "CollisionWidth, CollisionHeight, MountHeight, GeoBoxMin1, GeoBoxMin2, GeoBoxMin3, GeoBoxMax1, GeoBoxMax2, GeoBoxMax3, WorldEffectScale, " +
                "AttachedEffectScale, MissileCollisionRadius, MissileCollisionPush, MissileCollisionRaise, OverrideLootEffectScale, OverrideNameScale, " +
                "OverrideSelectionRadius, TamedPetBaseScale, HoverHeight, Flags, FileDataID, SizeClass, BloodID, FootprintTextureID, FoleyMaterialID, " +
                "FootstepEffectID, DeathThudEffectID, SoundID, CreatureGeosetDataID FROM creature_model_data ORDER BY ID DESC");

            // CreatureType.db2
            PrepareStatement(HotfixStatements.SEL_CREATURE_TYPE, "SELECT ID, Name, Flags FROM creature_type ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_CREATURE_TYPE_LOCALE, "SELECT ID, Name_lang FROM creature_type_locale WHERE locale = ?");

            // Criteria.db2
            PrepareStatement(HotfixStatements.SEL_CRITERIA, "SELECT ID, Asset, StartAsset, FailAsset, ModifierTreeId, StartTimer, EligibilityWorldStateID, Type, StartEvent, " +
                "FailEvent, Flags, EligibilityWorldStateValue FROM criteria ORDER BY ID DESC");

            // CriteriaTree.db2
            PrepareStatement(HotfixStatements.SEL_CRITERIA_TREE, "SELECT ID, Amount, Description, Flags, Operator, CriteriaID, Parent, OrderIndex FROM criteria_tree ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_CRITERIA_TREE_LOCALE, "SELECT ID, Description_lang FROM criteria_tree_locale WHERE locale = ?");

            // CurrencyTypes.db2
            PrepareStatement(HotfixStatements.SEL_CURRENCY_TYPES, "SELECT ID, Name, MaxQty, MaxEarnablePerWeek, Flags, Description, CategoryID, SpellCategory, Quality, " +
                "InventoryIconFileDataID, SpellWeight FROM currency_types ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_CURRENCY_TYPES_LOCALE, "SELECT ID, Name_lang, Description_lang FROM currency_types_locale WHERE locale = ?");

            // Curve.db2
            PrepareStatement(HotfixStatements.SEL_CURVE, "SELECT ID, Type, Unused FROM curve ORDER BY ID DESC");

            // CurvePoint.db2
            PrepareStatement(HotfixStatements.SEL_CURVE_POINT, "SELECT ID, X, Y, CurveID, `Index` FROM curve_point ORDER BY ID DESC");

            // DestructibleModelData.db2
            PrepareStatement(HotfixStatements.SEL_DESTRUCTIBLE_MODEL_DATA, "SELECT ID, StateDamagedDisplayID, StateDestroyedDisplayID, StateRebuildingDisplayID, " +
                "StateSmokeDisplayID, HealEffectSpeed, StateDamagedImpactEffectDoodadSet, StateDamagedAmbientDoodadSet, StateDamagedNameSet, " +
                "StateDestroyedDestructionDoodadSet, StateDestroyedImpactEffectDoodadSet, StateDestroyedAmbientDoodadSet, StateDestroyedNameSet, " +
                "StateRebuildingDestructionDoodadSet, StateRebuildingImpactEffectDoodadSet, StateRebuildingAmbientDoodadSet, StateRebuildingNameSet, " +
                "StateSmokeInitDoodadSet, StateSmokeAmbientDoodadSet, StateSmokeNameSet, EjectDirection, DoNotHighlight, HealEffect" +
                " FROM destructible_model_data ORDER BY ID DESC");

            // Difficulty.db2
            PrepareStatement(HotfixStatements.SEL_DIFFICULTY, "SELECT ID, Name, GroupSizeHealthCurveID, GroupSizeDmgCurveID, GroupSizeSpellPointsCurveID, " +
                "FallbackDifficultyID, InstanceType, MinPlayers, MaxPlayers, OldEnumValue, Flags, ToggleDifficultyID, ItemBonusTreeModID, OrderIndex " +
                "FROM difficulty ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_DIFFICULTY_LOCALE, "SELECT ID, Name_lang FROM difficulty_locale WHERE locale = ?");

            // DungeonEncounter.db2
            PrepareStatement(HotfixStatements.SEL_DUNGEON_ENCOUNTER, "SELECT Name, CreatureDisplayID, MapID, DifficultyID, Bit, Flags, ID, OrderIndex, " +
                "TextureFileDataID FROM dungeon_encounter ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_DUNGEON_ENCOUNTER_LOCALE, "SELECT ID, Name_lang FROM dungeon_encounter_locale WHERE locale = ?");

            // DurabilityCosts.db2
            PrepareStatement(HotfixStatements.SEL_DURABILITY_COSTS, "SELECT ID, WeaponSubClassCost1, WeaponSubClassCost2, WeaponSubClassCost3, WeaponSubClassCost4, " +
                "WeaponSubClassCost5, WeaponSubClassCost6, WeaponSubClassCost7, WeaponSubClassCost8, WeaponSubClassCost9, WeaponSubClassCost10, " +
                "WeaponSubClassCost11, WeaponSubClassCost12, WeaponSubClassCost13, WeaponSubClassCost14, WeaponSubClassCost15, WeaponSubClassCost16, " +
                "WeaponSubClassCost17, WeaponSubClassCost18, WeaponSubClassCost19, WeaponSubClassCost20, WeaponSubClassCost21, ArmorSubClassCost1, " +
                "ArmorSubClassCost2, ArmorSubClassCost3, ArmorSubClassCost4, ArmorSubClassCost5, ArmorSubClassCost6, ArmorSubClassCost7, ArmorSubClassCost8" +
                " FROM durability_costs ORDER BY ID DESC");

            // DurabilityQuality.db2
            PrepareStatement(HotfixStatements.SEL_DURABILITY_QUALITY, "SELECT ID, QualityMod FROM durability_quality ORDER BY ID DESC");

            // Emotes.db2
            PrepareStatement(HotfixStatements.SEL_EMOTES, "SELECT ID, EmoteSlashCommand, SpellVisualKitID, EmoteFlags, RaceMask, AnimID, EmoteSpecProc, " +
                "EmoteSpecProcParam, EmoteSoundID, ClassMask FROM emotes ORDER BY ID DESC");

            // EmotesText.db2
            PrepareStatement(HotfixStatements.SEL_EMOTES_TEXT, "SELECT ID, Name, EmoteID FROM emotes_text ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_EMOTES_TEXT_LOCALE, "SELECT ID, Name_lang FROM emotes_text_locale WHERE locale = ?");

            // EmotesTextSound.db2
            PrepareStatement(HotfixStatements.SEL_EMOTES_TEXT_SOUND, "SELECT ID, EmotesTextId, RaceId, SexId, ClassId, SoundId FROM emotes_text_sound ORDER BY ID DESC");

            // Faction.db2
            PrepareStatement(HotfixStatements.SEL_FACTION, "SELECT ID, ReputationRaceMask1, ReputationRaceMask2, ReputationRaceMask3, ReputationRaceMask4, " +
                "ReputationBase1, ReputationBase2, ReputationBase3, ReputationBase4, ParentFactionModIn, ParentFactionModOut, Name, Description, " +
                "ReputationMax1, ReputationMax2, ReputationMax3, ReputationMax4, ReputationIndex, ReputationClassMask1, ReputationClassMask2, " +
                "ReputationClassMask3, ReputationClassMask4, ReputationFlags1, ReputationFlags2, ReputationFlags3, ReputationFlags4, ParentFactionID, " +
                "ParagonFactionID, ParentFactionCapIn, ParentFactionCapOut, Expansion, Flags, FriendshipRepID FROM faction ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_FACTION_LOCALE, "SELECT ID, Name_lang, Description_lang FROM faction_locale WHERE locale = ?");

            // FactionTemplate.db2
            PrepareStatement(HotfixStatements.SEL_FACTION_TEMPLATE, "SELECT ID, Faction, Flags, Enemies1, Enemies2, Enemies3, Enemies4, Friends1, Friends2, Friends3, " +
                "Friends4, Mask, FriendMask, EnemyMask FROM faction_template ORDER BY ID DESC");

            // Gameobjects.db2
            PrepareStatement(HotfixStatements.SEL_GAMEOBJECTS, "SELECT PositionX, PositionY, PositionZ, RotationX, RotationY, RotationZ, RotationW, Size, Data1, Data2, " +
                "Data3, Data4, Data5, Data6, Data7, Data8, Name, MapID, DisplayID, PhaseID, PhaseGroupID, PhaseUseFlags, Type, ID FROM gameobjects" +
                " ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_GAMEOBJECTS_LOCALE, "SELECT ID, Name_lang FROM gameobjects_locale WHERE locale = ?");

            // GameobjectDisplayInfo.db2
            PrepareStatement(HotfixStatements.SEL_GAMEOBJECT_DISPLAY_INFO, "SELECT ID, FileDataID, GeoBoxMinX, GeoBoxMinY, GeoBoxMinZ, GeoBoxMaxX, GeoBoxMaxY, " +
                "GeoBoxMaxZ, OverrideLootEffectScale, OverrideNameScale, ObjectEffectPackageID FROM gameobject_display_info ORDER BY ID DESC");

            // GarrAbility.db2
            PrepareStatement(HotfixStatements.SEL_GARR_ABILITY, "SELECT Name, Description, IconFileDataID, Flags, OtherFactionGarrAbilityID, GarrAbilityCategoryID, " +
                "FollowerTypeID, ID FROM garr_ability ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_GARR_ABILITY_LOCALE, "SELECT ID, Name_lang, Description_lang FROM garr_ability_locale WHERE locale = ?");

            // GarrBuilding.db2
            PrepareStatement(HotfixStatements.SEL_GARR_BUILDING, "SELECT ID, HordeGameObjectID, AllianceGameObjectID, NameAlliance, NameHorde, Description, Tooltip, " +
                "IconFileDataID, CostCurrencyID, HordeTexPrefixKitID, AllianceTexPrefixKitID, AllianceActivationScenePackageID, " +
                "HordeActivationScenePackageID, FollowerRequiredGarrAbilityID, FollowerGarrAbilityEffectID, CostMoney, Unknown, Type, Level, Flags, " +
                "MaxShipments, GarrTypeID, BuildDuration, CostCurrencyAmount, BonusAmount FROM garr_building ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_GARR_BUILDING_LOCALE, "SELECT ID, NameAlliance_lang, NameHorde_lang, Description_lang, Tooltip_lang" +
                " FROM garr_building_locale WHERE locale = ?");

            // GarrBuildingPlotInst.db2
            PrepareStatement(HotfixStatements.SEL_GARR_BUILDING_PLOT_INST, "SELECT LandmarkOffsetX, LandmarkOffsetY, UiTextureAtlasMemberID, GarrSiteLevelPlotInstID, " +
                "GarrBuildingID, ID FROM garr_building_plot_inst ORDER BY ID DESC");

            // GarrClassSpec.db2
            PrepareStatement(HotfixStatements.SEL_GARR_CLASS_SPEC, "SELECT NameMale, NameFemale, NameGenderless, ClassAtlasID, GarrFollItemSetID, `Limit`, Flags, ID" +
                " FROM garr_class_spec ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_GARR_CLASS_SPEC_LOCALE, "SELECT ID, NameMale_lang, NameFemale_lang, NameGenderless_lang FROM garr_class_spec_locale" +
                " WHERE locale = ?");

            // GarrFollower.db2
            PrepareStatement(HotfixStatements.SEL_GARR_FOLLOWER, "SELECT HordeCreatureID, AllianceCreatureID, HordeSourceText, AllianceSourceText, HordePortraitIconID, " +
                "AlliancePortraitIconID, HordeAddedBroadcastTextID, AllianceAddedBroadcastTextID, Name, HordeGarrFollItemSetID, AllianceGarrFollItemSetID, " +
                "ItemLevelWeapon, ItemLevelArmor, HordeListPortraitTextureKitID, AllianceListPortraitTextureKitID, FollowerTypeID, HordeUiAnimRaceInfoID, " +
                "AllianceUiAnimRaceInfoID, Quality, HordeGarrClassSpecID, AllianceGarrClassSpecID, Level, Unknown1, Flags, Unknown2, Unknown3, GarrTypeID, " +
                "MaxDurability, Class, HordeFlavorTextGarrStringID, AllianceFlavorTextGarrStringID, ID FROM garr_follower ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_GARR_FOLLOWER_LOCALE, "SELECT ID, HordeSourceText_lang, AllianceSourceText_lang, Name_lang FROM garr_follower_locale" +
                " WHERE locale = ?");

            // GarrFollowerXAbility.db2
            PrepareStatement(HotfixStatements.SEL_GARR_FOLLOWER_X_ABILITY, "SELECT ID, GarrFollowerID, GarrAbilityID, FactionIndex FROM garr_follower_x_ability" +
                " ORDER BY ID DESC");

            // GarrPlot.db2
            PrepareStatement(HotfixStatements.SEL_GARR_PLOT, "SELECT ID, Name, AllianceConstructionGameObjectID, HordeConstructionGameObjectID, GarrPlotUICategoryID, " +
                "PlotType, Flags, MinCount, MaxCount FROM garr_plot ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_GARR_PLOT_LOCALE, "SELECT ID, Name_lang FROM garr_plot_locale WHERE locale = ?");

            // GarrPlotBuilding.db2
            PrepareStatement(HotfixStatements.SEL_GARR_PLOT_BUILDING, "SELECT ID, GarrPlotID, GarrBuildingID FROM garr_plot_building ORDER BY ID DESC");

            // GarrPlotInstance.db2
            PrepareStatement(HotfixStatements.SEL_GARR_PLOT_INSTANCE, "SELECT ID, Name, GarrPlotID FROM garr_plot_instance ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_GARR_PLOT_INSTANCE_LOCALE, "SELECT ID, Name_lang FROM garr_plot_instance_locale WHERE locale = ?");

            // GarrSiteLevel.db2
            PrepareStatement(HotfixStatements.SEL_GARR_SITE_LEVEL, "SELECT ID, TownHallX, TownHallY, MapID, SiteID, MovieID, UpgradeResourceCost, UpgradeMoneyCost, " +
                "Level, UITextureKitID, Level2 FROM garr_site_level ORDER BY ID DESC");

            // GarrSiteLevelPlotInst.db2
            PrepareStatement(HotfixStatements.SEL_GARR_SITE_LEVEL_PLOT_INST, "SELECT ID, LandmarkX, LandmarkY, GarrSiteLevelID, GarrPlotInstanceID, Unknown" +
                " FROM garr_site_level_plot_inst ORDER BY ID DESC");

            // GemProperties.db2
            PrepareStatement(HotfixStatements.SEL_GEM_PROPERTIES, "SELECT ID, Type, EnchantID, MinItemLevel FROM gem_properties ORDER BY ID DESC");

            // GlyphBindableSpell.db2
            PrepareStatement(HotfixStatements.SEL_GLYPH_BINDABLE_SPELL, "SELECT ID, SpellID, GlyphPropertiesID FROM glyph_bindable_spell ORDER BY ID DESC");

            // GlyphProperties.db2
            PrepareStatement(HotfixStatements.SEL_GLYPH_PROPERTIES, "SELECT ID, SpellID, SpellIconID, Type, GlyphExclusiveCategoryID FROM glyph_properties ORDER BY ID DESC");

            // GlyphRequiredSpec.db2
            PrepareStatement(HotfixStatements.SEL_GLYPH_REQUIRED_SPEC, "SELECT ID, GlyphPropertiesID, ChrSpecializationID FROM glyph_required_spec ORDER BY ID DESC");

            // GuildColorBackground.db2
            PrepareStatement(HotfixStatements.SEL_GUILD_COLOR_BACKGROUND, "SELECT ID, Red, Green, Blue FROM guild_color_background ORDER BY ID DESC");

            // GuildColorBorder.db2
            PrepareStatement(HotfixStatements.SEL_GUILD_COLOR_BORDER, "SELECT ID, Red, Green, Blue FROM guild_color_border ORDER BY ID DESC");

            // GuildColorEmblem.db2
            PrepareStatement(HotfixStatements.SEL_GUILD_COLOR_EMBLEM, "SELECT ID, Red, Green, Blue FROM guild_color_emblem ORDER BY ID DESC");

            // GuildPerkSpells.db2
            PrepareStatement(HotfixStatements.SEL_GUILD_PERK_SPELLS, "SELECT ID, SpellID FROM guild_perk_spells ORDER BY ID DESC");

            // Heirloom.db2
            PrepareStatement(HotfixStatements.SEL_HEIRLOOM, "SELECT ItemID, SourceText, OldItem1, OldItem2, NextDifficultyItemID, UpgradeItemID1, UpgradeItemID2, " +
                "UpgradeItemID3, ItemBonusListID1, ItemBonusListID2, ItemBonusListID3, Flags, Source, ID FROM heirloom ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_HEIRLOOM_LOCALE, "SELECT ID, SourceText_lang FROM heirloom_locale WHERE locale = ?");

            // Holidays.db2
            PrepareStatement(HotfixStatements.SEL_HOLIDAYS, "SELECT ID, Date1, Date2, Date3, Date4, Date5, Date6, Date7, Date8, Date9, Date10, Date11, Date12, Date13, " +
                "Date14, Date15, Date16, Duration1, Duration2, Duration3, Duration4, Duration5, Duration6, Duration7, Duration8, Duration9, Duration10, " +
                "Region, Looping, CalendarFlags1, CalendarFlags2, CalendarFlags3, CalendarFlags4, CalendarFlags5, CalendarFlags6, CalendarFlags7, " +
                "CalendarFlags8, CalendarFlags9, CalendarFlags10, Priority, CalendarFilterType, Flags, HolidayNameID, HolidayDescriptionID, " +
                "TextureFileDataID1, TextureFileDataID2, TextureFileDataID3 FROM holidays ORDER BY ID DESC");

            // ImportPriceArmor.db2
            PrepareStatement(HotfixStatements.SEL_IMPORT_PRICE_ARMOR, "SELECT ID, ClothFactor, LeatherFactor, MailFactor, PlateFactor FROM import_price_armor" +
                " ORDER BY ID DESC");

            // ImportPriceQuality.db2
            PrepareStatement(HotfixStatements.SEL_IMPORT_PRICE_QUALITY, "SELECT ID, Factor FROM import_price_quality ORDER BY ID DESC");

            // ImportPriceShield.db2
            PrepareStatement(HotfixStatements.SEL_IMPORT_PRICE_SHIELD, "SELECT ID, Factor FROM import_price_shield ORDER BY ID DESC");

            // ImportPriceWeapon.db2
            PrepareStatement(HotfixStatements.SEL_IMPORT_PRICE_WEAPON, "SELECT ID, Factor FROM import_price_weapon ORDER BY ID DESC");

            // Item.db2
            PrepareStatement(HotfixStatements.SEL_ITEM, "SELECT ID, FileDataID, Class, SubClass, SoundOverrideSubclass, Material, InventoryType, Sheath, GroupSoundsID" +
                " FROM item ORDER BY ID DESC");

            // ItemAppearance.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_APPEARANCE, "SELECT ID, DisplayID, IconFileDataID, UIOrder, ObjectComponentSlot FROM item_appearance" +
                " ORDER BY ID DESC");

            // ItemArmorQuality.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_ARMOR_QUALITY, "SELECT ID, QualityMod1, QualityMod2, QualityMod3, QualityMod4, QualityMod5, QualityMod6, " +
                "QualityMod7, ItemLevel FROM item_armor_quality ORDER BY ID DESC");

            // ItemArmorShield.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_ARMOR_SHIELD, "SELECT ID, Quality1, Quality2, Quality3, Quality4, Quality5, Quality6, Quality7, ItemLevel" +
                " FROM item_armor_shield ORDER BY ID DESC");

            // ItemArmorTotal.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_ARMOR_TOTAL, "SELECT ID, Value1, Value2, Value3, Value4, ItemLevel FROM item_armor_total ORDER BY ID DESC");

            // ItemBagFamily.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_BAG_FAMILY, "SELECT ID, Name FROM item_bag_family ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ITEM_BAG_FAMILY_LOCALE, "SELECT ID, Name_lang FROM item_bag_family_locale WHERE locale = ?");

            // ItemBonus.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_BONUS, "SELECT ID, Value1, Value2, BonusListID, Type, `Index` FROM item_bonus ORDER BY ID DESC");

            // ItemBonusListLevelDelta.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_BONUS_LIST_LEVEL_DELTA, "SELECT Delta, ID FROM item_bonus_list_level_delta ORDER BY ID DESC");

            // ItemBonusTreeNode.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_BONUS_TREE_NODE, "SELECT ID, BonusTreeID, SubTreeID, BonusListID, ItemLevelSelectorID, BonusTreeModID" +
                " FROM item_bonus_tree_node ORDER BY ID DESC");

            // ItemChildEquipment.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_CHILD_EQUIPMENT, "SELECT ID, ItemID, AltItemID, AltEquipmentSlot FROM item_child_equipment ORDER BY ID DESC");

            // ItemClass.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_CLASS, "SELECT ID, PriceMod, Name, OldEnumValue, Flags FROM item_class ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ITEM_CLASS_LOCALE, "SELECT ID, Name_lang FROM item_class_locale WHERE locale = ?");

            // ItemCurrencyCost.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_CURRENCY_COST, "SELECT ID, ItemId FROM item_currency_cost ORDER BY ID DESC");

            // ItemDamageAmmo.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_DAMAGE_AMMO, "SELECT ID, DPS1, DPS2, DPS3, DPS4, DPS5, DPS6, DPS7, ItemLevel FROM item_damage_ammo" +
                " ORDER BY ID DESC");

            // ItemDamageOneHand.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_DAMAGE_ONE_HAND, "SELECT ID, DPS1, DPS2, DPS3, DPS4, DPS5, DPS6, DPS7, ItemLevel FROM item_damage_one_hand" +
                " ORDER BY ID DESC");

            // ItemDamageOneHandCaster.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_DAMAGE_ONE_HAND_CASTER, "SELECT ID, DPS1, DPS2, DPS3, DPS4, DPS5, DPS6, DPS7, ItemLevel" +
                " FROM item_damage_one_hand_caster ORDER BY ID DESC");

            // ItemDamageTwoHand.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_DAMAGE_TWO_HAND, "SELECT ID, DPS1, DPS2, DPS3, DPS4, DPS5, DPS6, DPS7, ItemLevel FROM item_damage_two_hand" +
                " ORDER BY ID DESC");

            // ItemDamageTwoHandCaster.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_DAMAGE_TWO_HAND_CASTER, "SELECT ID, DPS1, DPS2, DPS3, DPS4, DPS5, DPS6, DPS7, ItemLevel" +
                " FROM item_damage_two_hand_caster ORDER BY ID DESC");

            // ItemDisenchantLoot.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_DISENCHANT_LOOT, "SELECT ID, MinItemLevel, MaxItemLevel, RequiredDisenchantSkill, ItemClass, ItemSubClass, " +
                "ItemQuality FROM item_disenchant_loot ORDER BY ID DESC");

            // ItemEffect.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_EFFECT, "SELECT ID, ItemID, SpellID, Cooldown, CategoryCooldown, Charges, Category, ChrSpecializationID, " +
                "OrderIndex, `Trigger` FROM item_effect ORDER BY ID DESC");

            // ItemExtendedCost.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_EXTENDED_COST, "SELECT ID, RequiredItem1, RequiredItem2, RequiredItem3, RequiredItem4, RequiredItem5, " +
                "RequiredCurrencyCount1, RequiredCurrencyCount2, RequiredCurrencyCount3, RequiredCurrencyCount4, RequiredCurrencyCount5, RequiredItemCount1, " +
                "RequiredItemCount2, RequiredItemCount3, RequiredItemCount4, RequiredItemCount5, RequiredPersonalArenaRating, RequiredCurrency1, " +
                "RequiredCurrency2, RequiredCurrency3, RequiredCurrency4, RequiredCurrency5, RequiredArenaSlot, RequiredFactionId, RequiredFactionStanding, " +
                "RequirementFlags, RequiredAchievement FROM item_extended_cost ORDER BY ID DESC");

            // ItemLevelSelector.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_LEVEL_SELECTOR, "SELECT ID, ItemLevel, ItemLevelSelectorQualitySetID FROM item_level_selector ORDER BY ID DESC");

            // ItemLevelSelectorQuality.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_LEVEL_SELECTOR_QUALITY, "SELECT ID, ItemBonusListID, ItemLevelSelectorQualitySetID, Quality" +
                " FROM item_level_selector_quality ORDER BY ID DESC");
            
            // ItemLevelSelectorQualitySet.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_LEVEL_SELECTOR_QUALITY_SET, "SELECT ID, ItemLevelMin, ItemLevelMax FROM item_level_selector_quality_set" +
                " ORDER BY ID DESC");

            // ItemLimitCategory.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_LIMIT_CATEGORY, "SELECT ID, Name, Quantity, Flags FROM item_limit_category ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ITEM_LIMIT_CATEGORY_LOCALE, "SELECT ID, Name_lang FROM item_limit_category_locale WHERE locale = ?");

            // ItemModifiedAppearance.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_MODIFIED_APPEARANCE, "SELECT ItemID, AppearanceID, AppearanceModID, `Index`, SourceType, ID" +
                " FROM item_modified_appearance ORDER BY ID DESC");

            // ItemPriceBase.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_PRICE_BASE, "SELECT ID, ArmorFactor, WeaponFactor, ItemLevel FROM item_price_base ORDER BY ID DESC");

            // ItemRandomProperties.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_RANDOM_PROPERTIES, "SELECT ID, Name, Enchantment1, Enchantment2, Enchantment3, Enchantment4, Enchantment5" +
                " FROM item_random_properties ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ITEM_RANDOM_PROPERTIES_LOCALE, "SELECT ID, Name_lang FROM item_random_properties_locale WHERE locale = ?");

            // ItemRandomSuffix.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_RANDOM_SUFFIX, "SELECT ID, Name, Enchantment1, Enchantment2, Enchantment3, Enchantment4, Enchantment5, " +
                "AllocationPct1, AllocationPct2, AllocationPct3, AllocationPct4, AllocationPct5 FROM item_random_suffix ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ITEM_RANDOM_SUFFIX_LOCALE, "SELECT ID, Name_lang FROM item_random_suffix_locale WHERE locale = ?");

            // ItemSearchName.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_SEARCH_NAME, "SELECT ID, Name, Flags1, Flags2, Flags3, AllowableRace, ItemLevel, Quality, RequiredExpansion, " +
                "RequiredLevel, AllowableClass, RequiredReputationFaction, RequiredReputationRank, RequiredSkill, RequiredSkillRank, RequiredSpell" +
                " FROM item_search_name ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ITEM_SEARCH_NAME_LOCALE, "SELECT ID, Name_lang FROM item_search_name_locale WHERE locale = ?");

            // ItemSet.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_SET, "SELECT ID, Name, ItemID1, ItemID2, ItemID3, ItemID4, ItemID5, ItemID6, ItemID7, ItemID8, ItemID9, " +
                "ItemID10, ItemID11, ItemID12, ItemID13, ItemID14, ItemID15, ItemID16, ItemID17, RequiredSkillRank, RequiredSkill, Flags FROM item_set" +
                " ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ITEM_SET_LOCALE, "SELECT ID, Name_lang FROM item_set_locale WHERE locale = ?");

            // ItemSetSpell.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_SET_SPELL, "SELECT ID, SpellID, ItemSetID, ChrSpecID, Threshold FROM item_set_spell ORDER BY ID DESC");

            // ItemSparse.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_SPARSE, "SELECT ID, Flags1, Flags2, Flags3, Flags4, Unk1, Unk2, BuyCount, BuyPrice, SellPrice, AllowableRace, " +
                "RequiredSpell, MaxCount, Stackable, ItemStatAllocation1, ItemStatAllocation2, ItemStatAllocation3, ItemStatAllocation4, ItemStatAllocation5, " +
                "ItemStatAllocation6, ItemStatAllocation7, ItemStatAllocation8, ItemStatAllocation9, ItemStatAllocation10, ItemStatSocketCostMultiplier1, " +
                "ItemStatSocketCostMultiplier2, ItemStatSocketCostMultiplier3, ItemStatSocketCostMultiplier4, ItemStatSocketCostMultiplier5, " +
                "ItemStatSocketCostMultiplier6, ItemStatSocketCostMultiplier7, ItemStatSocketCostMultiplier8, ItemStatSocketCostMultiplier9, " +
                "ItemStatSocketCostMultiplier10, RangedModRange, Name, Name2, Name3, Name4, Description, BagFamily, ArmorDamageModifier, Duration, " +
                "StatScalingFactor, AllowableClass, ItemLevel, RequiredSkill, RequiredSkillRank, RequiredReputationFaction, ItemStatValue1, ItemStatValue2, " +
                "ItemStatValue3, ItemStatValue4, ItemStatValue5, ItemStatValue6, ItemStatValue7, ItemStatValue8, ItemStatValue9, ItemStatValue10, " +
                "ScalingStatDistribution, Delay, PageText, StartQuest, LockID, RandomProperty, RandomSuffix, ItemSet, Area, Map, TotemCategory, SocketBonus, " +
                "GemProperties, ItemLimitCategory, HolidayID, RequiredTransmogHolidayID, ItemNameDescriptionID, Quality, InventoryType, RequiredLevel, " +
                "RequiredHonorRank, RequiredCityRank, RequiredReputationRank, ContainerSlots, ItemStatType1, ItemStatType2, ItemStatType3, ItemStatType4, " +
                "ItemStatType5, ItemStatType6, ItemStatType7, ItemStatType8, ItemStatType9, ItemStatType10, DamageType, Bonding, LanguageID, PageMaterial, " +
                "Material, Sheath, SocketColor1, SocketColor2, SocketColor3, CurrencySubstitutionID, CurrencySubstitutionCount, ArtifactID, " +
                "RequiredExpansion FROM item_sparse ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_ITEM_SPARSE_LOCALE, "SELECT ID, Name_lang, Name2_lang, Name3_lang, Name4_lang, Description_lang FROM item_sparse_locale" +
                " WHERE locale = ?");

            // ItemSpec.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_SPEC, "SELECT ID, SpecID, MinLevel, MaxLevel, ItemType, PrimaryStat, SecondaryStat FROM item_spec" +
                " ORDER BY ID DESC");

            // ItemSpecOverride.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_SPEC_OVERRIDE, "SELECT ID, ItemID, SpecID FROM item_spec_override ORDER BY ID DESC");

            // ItemUpgrade.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_UPGRADE, "SELECT ID, CurrencyCost, PrevItemUpgradeID, CurrencyID, ItemUpgradePathID, ItemLevelBonus" +
                " FROM item_upgrade ORDER BY ID DESC");

            // ItemXBonusTree.db2
            PrepareStatement(HotfixStatements.SEL_ITEM_X_BONUS_TREE, "SELECT ID, ItemID, BonusTreeID FROM item_x_bonus_tree ORDER BY ID DESC");

            // Keychain.db2
            PrepareStatement(HotfixStatements.SEL_KEYCHAIN, "SELECT ID, Key1, Key2, Key3, Key4, Key5, Key6, Key7, Key8, Key9, Key10, Key11, Key12, Key13, Key14, Key15, " +
                "Key16, Key17, Key18, Key19, Key20, Key21, Key22, Key23, Key24, Key25, Key26, Key27, Key28, Key29, Key30, Key31, Key32 FROM keychain" +
                " ORDER BY ID DESC");

            // LfgDungeons.db2
            PrepareStatement(HotfixStatements.SEL_LFG_DUNGEONS, "SELECT ID, Name, Flags, Description, MinItemLevel, MaxLevel, TargetLevelMax, MapID, RandomID, " +
                "ScenarioID, LastBossJournalEncounterID, BonusReputationAmount, MentorItemLevel, PlayerConditionID, MinLevel, TargetLevel, TargetLevelMin, " +
                "DifficultyID, Type, Faction, Expansion, OrderIndex, GroupID, CountTank, CountHealer, CountDamage, MinCountTank, MinCountHealer, " +
                "MinCountDamage, SubType, MentorCharLevel, TextureFileDataID, RewardIconFileDataID, ProposalTextureFileDataID FROM lfg_dungeons" +
                " ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_LFG_DUNGEONS_LOCALE, "SELECT ID, Name_lang, Description_lang FROM lfg_dungeons_locale WHERE locale = ?");

            // Light.db2
            PrepareStatement(HotfixStatements.SEL_LIGHT, "SELECT ID, PosX, PosY, PosZ, FalloffStart, FalloffEnd, MapID, LightParamsID1, LightParamsID2, LightParamsID3, " +
                "LightParamsID4, LightParamsID5, LightParamsID6, LightParamsID7, LightParamsID8 FROM light ORDER BY ID DESC");

            // LiquidType.db2
            PrepareStatement(HotfixStatements.SEL_LIQUID_TYPE, "SELECT ID, Name, SpellID, MaxDarkenDepth, FogDarkenIntensity, AmbDarkenIntensity, DirDarkenIntensity, " +
                "ParticleScale, Texture1, Texture2, Texture3, Texture4, Texture5, Texture6, Color1, Color2, Float1, Float2, Float3, `Float4`, Float5, Float6, " +
                "Float7, `Float8`, Float9, Float10, Float11, Float12, Float13, Float14, Float15, Float16, Float17, Float18, `Int1`, `Int2`, `Int3`, `Int4`, " +
                "Flags, LightID, Type, ParticleMovement, ParticleTexSlots, MaterialID, DepthTexCount1, DepthTexCount2, DepthTexCount3, DepthTexCount4, " +
                "DepthTexCount5, DepthTexCount6, SoundID FROM liquid_type ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_LIQUID_TYPE_LOCALE, "SELECT ID, Name_lang FROM liquid_type_locale WHERE locale = ?");

            // Lock.db2
            PrepareStatement(HotfixStatements.SEL_LOCK, "SELECT ID, Index1, Index2, Index3, Index4, Index5, Index6, Index7, Index8, Skill1, Skill2, Skill3, Skill4, " +
                "Skill5, Skill6, Skill7, Skill8, Type1, Type2, Type3, Type4, Type5, Type6, Type7, Type8, Action1, Action2, Action3, Action4, Action5, " +
                "Action6, Action7, Action8 FROM `lock` ORDER BY ID DESC");

            // MailTemplate.db2
            PrepareStatement(HotfixStatements.SEL_MAIL_TEMPLATE, "SELECT ID, Body FROM mail_template ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_MAIL_TEMPLATE_LOCALE, "SELECT ID, Body_lang FROM mail_template_locale WHERE locale = ?");

            // Map.db2
            PrepareStatement(HotfixStatements.SEL_MAP, "SELECT ID, Directory, Flags1, Flags2, MinimapIconScale, CorpsePosX, CorpsePosY, MapName, MapDescription0, " +
                "MapDescription1, ShortDescription, LongDescription, AreaTableID, LoadingScreenID, CorpseMapID, TimeOfDayOverride, ParentMapID, " +
                "CosmeticParentMapID, WindSettingsID, InstanceType, unk5, ExpansionID, MaxPlayers, TimeOffset FROM map ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_MAP_LOCALE, "SELECT ID, MapName_lang, MapDescription0_lang, MapDescription1_lang, ShortDescription_lang, " +
                "LongDescription_lang FROM map_locale WHERE locale = ?");

            // MapDifficulty.db2
            PrepareStatement(HotfixStatements.SEL_MAP_DIFFICULTY, "SELECT ID, Message, MapID, DifficultyID, RaidDurationType, MaxPlayers, LockID, Flags, " +
                "ItemBonusTreeModID, Context FROM map_difficulty ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_MAP_DIFFICULTY_LOCALE, "SELECT ID, Message_lang FROM map_difficulty_locale WHERE locale = ?");

            // ModifierTree.db2
            PrepareStatement(HotfixStatements.SEL_MODIFIER_TREE, "SELECT ID, Asset1, Asset2, Parent, Type, Unk700, Operator, Amount FROM modifier_tree ORDER BY ID DESC");

            // Mount.db2
            PrepareStatement(HotfixStatements.SEL_MOUNT, "SELECT SpellId, Name, Description, SourceDescription, CameraPivotMultiplier, MountTypeId, Flags, Source, ID, " +
                "PlayerConditionId, UiModelSceneID FROM mount ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_MOUNT_LOCALE, "SELECT ID, Name_lang, Description_lang, SourceDescription_lang FROM mount_locale WHERE locale = ?");

            // MountCapability.db2
            PrepareStatement(HotfixStatements.SEL_MOUNT_CAPABILITY, "SELECT RequiredSpell, SpeedModSpell, RequiredRidingSkill, RequiredArea, RequiredMap, Flags, ID, " +
                "RequiredAura FROM mount_capability ORDER BY ID DESC");

            // MountTypeXCapability.db2
            PrepareStatement(HotfixStatements.SEL_MOUNT_TYPE_X_CAPABILITY, "SELECT ID, MountTypeID, MountCapabilityID, OrderIndex FROM mount_type_x_capability" +
                " ORDER BY ID DESC");

            // MountXDisplay.db2
            PrepareStatement(HotfixStatements.SEL_MOUNT_X_DISPLAY, "SELECT ID, MountID, DisplayID, PlayerConditionID FROM mount_x_display ORDER BY ID DESC");

            // Movie.db2
            PrepareStatement(HotfixStatements.SEL_MOVIE, "SELECT ID, AudioFileDataID, SubtitleFileDataID, Volume, KeyID FROM movie ORDER BY ID DESC");

            // NameGen.db2
            PrepareStatement(HotfixStatements.SEL_NAME_GEN, "SELECT ID, Name, Race, Sex FROM name_gen ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_NAME_GEN_LOCALE, "SELECT ID, Name_lang FROM name_gen_locale WHERE locale = ?");

            // NamesProfanity.db2
            PrepareStatement(HotfixStatements.SEL_NAMES_PROFANITY, "SELECT ID, Name, Language FROM names_profanity ORDER BY ID DESC");

            // NamesReserved.db2
            PrepareStatement(HotfixStatements.SEL_NAMES_RESERVED, "SELECT ID, Name FROM names_reserved ORDER BY ID DESC");

            // NamesReservedLocale.db2
            PrepareStatement(HotfixStatements.SEL_NAMES_RESERVED_LOCALE, "SELECT ID, Name, LocaleMask FROM names_reserved_locale ORDER BY ID DESC");

            // OverrideSpellData.db2
            PrepareStatement(HotfixStatements.SEL_OVERRIDE_SPELL_DATA, "SELECT ID, SpellID1, SpellID2, SpellID3, SpellID4, SpellID5, SpellID6, SpellID7, SpellID8, " +
                "SpellID9, SpellID10, PlayerActionbarFileDataID, Flags FROM override_spell_data ORDER BY ID DESC");

            // Phase.db2
            PrepareStatement(HotfixStatements.SEL_PHASE, "SELECT ID, Flags FROM phase ORDER BY ID DESC");

            // PhaseXPhaseGroup.db2
            PrepareStatement(HotfixStatements.SEL_PHASE_X_PHASE_GROUP, "SELECT ID, PhaseID, PhaseGroupID FROM phase_x_phase_group ORDER BY ID DESC");

            // PlayerCondition.db2
            PrepareStatement(HotfixStatements.SEL_PLAYER_CONDITION, "SELECT ID, RaceMask, Time1, Time2, AuraSpellID1, AuraSpellID2, AuraSpellID3, AuraSpellID4, " +
                "FailureDescription, SkillID1, SkillID2, SkillID3, SkillID4, MinSkill1, MinSkill2, MinSkill3, MinSkill4, MaxSkill1, MaxSkill2, MaxSkill3, " +
                "MaxSkill4, PrevQuestID1, PrevQuestID2, PrevQuestID3, PrevQuestID4, CurrQuestID1, CurrQuestID2, CurrQuestID3, CurrQuestID4, " +
                "CurrentCompletedQuestID1, CurrentCompletedQuestID2, CurrentCompletedQuestID3, CurrentCompletedQuestID4, Explored1, Explored2, Achievement1, " +
                "Achievement2, Achievement3, Achievement4, AreaID1, AreaID2, AreaID3, AreaID4, Flags, MinReputation1, MinReputation2, MinReputation3, " +
                "AuraCount1, AuraCount2, AuraCount3, AuraCount4, LfgStatus1, LfgStatus2, LfgStatus3, LfgStatus4, LfgCompare1, LfgCompare2, LfgCompare3, " +
                "LfgCompare4, CurrencyCount1, CurrencyCount2, CurrencyCount3, CurrencyCount4, ClassMask, MinFactionID1, MinFactionID2, MinFactionID3, " +
                "SpellID1, SpellID2, SpellID3, SpellID4, ItemID1, ItemID2, ItemID3, ItemID4, ItemCount1, ItemCount2, ItemCount3, ItemCount4, LfgValue1, " +
                "LfgValue2, LfgValue3, LfgValue4, CurrencyID1, CurrencyID2, CurrencyID3, CurrencyID4, QuestKillMonster1, QuestKillMonster2, " +
                "QuestKillMonster3, QuestKillMonster4, QuestKillMonster5, QuestKillMonster6, MovementFlags1, MovementFlags2, MinLevel, MaxLevel, Gender, " +
                "NativeGender, SkillLogic, LanguageID, MinLanguage, MaxLanguage, MaxFactionID, MaxReputation, ReputationLogic, Unknown1, MinPVPRank, " +
                "MaxPVPRank, PvpMedal, PrevQuestLogic, CurrQuestLogic, CurrentCompletedQuestLogic, SpellLogic, ItemLogic, ItemFlags, AuraSpellLogic, " +
                "WorldStateExpressionID, WeatherID, PartyStatus, LifetimeMaxPVPRank, AchievementLogic, LfgLogic, AreaLogic, CurrencyLogic, QuestKillID, " +
                "QuestKillLogic, MinExpansionLevel, MaxExpansionLevel, MinExpansionTier, MaxExpansionTier, MinGuildLevel, MaxGuildLevel, PhaseUseFlags, " +
                "PhaseID, PhaseGroupID, MinAvgItemLevel, MaxAvgItemLevel, MinAvgEquippedItemLevel, MaxAvgEquippedItemLevel, ChrSpecializationIndex, " +
                "ChrSpecializationRole, PowerType, PowerTypeComp, PowerTypeValue, ModifierTreeID, MainHandItemSubclassMask FROM player_condition" +
                " ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_PLAYER_CONDITION_LOCALE, "SELECT ID, FailureDescription_lang FROM player_condition_locale WHERE locale = ?");

            // PowerDisplay.db2
            PrepareStatement(HotfixStatements.SEL_POWER_DISPLAY, "SELECT ID, GlobalStringBaseTag, PowerType, Red, Green, Blue FROM power_display ORDER BY ID DESC");

            // PowerType.db2
            PrepareStatement(HotfixStatements.SEL_POWER_TYPE, "SELECT ID, PowerTypeToken, PowerCostToken, RegenerationPeace, RegenerationCombat, MaxPower, " +
                "RegenerationDelay, Flags, PowerTypeEnum, RegenerationMin, RegenerationCenter, RegenerationMax, UIModifier FROM power_type ORDER BY ID DESC");

            // PrestigeLevelInfo.db2
            PrepareStatement(HotfixStatements.SEL_PRESTIGE_LEVEL_INFO, "SELECT ID, IconID, PrestigeText, PrestigeLevel, Flags FROM prestige_level_info ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_PRESTIGE_LEVEL_INFO_LOCALE, "SELECT ID, PrestigeText_lang FROM prestige_level_info_locale WHERE locale = ?");

            // PvpDifficulty.db2
            PrepareStatement(HotfixStatements.SEL_PVP_DIFFICULTY, "SELECT ID, MapID, BracketID, MinLevel, MaxLevel FROM pvp_difficulty ORDER BY ID DESC");

            // PvpReward.db2
            PrepareStatement(HotfixStatements.SEL_PVP_REWARD, "SELECT ID, HonorLevel, Prestige, RewardPackID FROM pvp_reward ORDER BY ID DESC");

            // QuestFactionReward.db2
            PrepareStatement(HotfixStatements.SEL_QUEST_FACTION_REWARD, "SELECT ID, QuestRewFactionValue1, QuestRewFactionValue2, QuestRewFactionValue3, " +
                "QuestRewFactionValue4, QuestRewFactionValue5, QuestRewFactionValue6, QuestRewFactionValue7, QuestRewFactionValue8, QuestRewFactionValue9, " +
                "QuestRewFactionValue10 FROM quest_faction_reward ORDER BY ID DESC");

            // QuestMoneyReward.db2
            PrepareStatement(HotfixStatements.SEL_QUEST_MONEY_REWARD, "SELECT ID, Money1, Money2, Money3, Money4, Money5, Money6, Money7, Money8, Money9, Money10" +
                " FROM quest_money_reward ORDER BY ID DESC");

            // QuestPackageItem.db2
            PrepareStatement(HotfixStatements.SEL_QUEST_PACKAGE_ITEM, "SELECT ID, ItemID, QuestPackageID, FilterType, ItemCount FROM quest_package_item ORDER BY ID DESC");

            // QuestSort.db2
            PrepareStatement(HotfixStatements.SEL_QUEST_SORT, "SELECT ID, SortName, SortOrder FROM quest_sort ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_QUEST_SORT_LOCALE, "SELECT ID, SortName_lang FROM quest_sort_locale WHERE locale = ?");

            // QuestV2.db2
            PrepareStatement(HotfixStatements.SEL_QUEST_V2, "SELECT ID, UniqueBitFlag FROM quest_v2 ORDER BY ID DESC");

            // QuestXp.db2
            PrepareStatement(HotfixStatements.SEL_QUEST_XP, "SELECT ID, Exp1, Exp2, Exp3, Exp4, Exp5, Exp6, Exp7, Exp8, Exp9, Exp10 FROM quest_xp ORDER BY ID DESC");

            // RandPropPoints.db2
            PrepareStatement(HotfixStatements.SEL_RAND_PROP_POINTS, "SELECT ID, EpicPropertiesPoints1, EpicPropertiesPoints2, EpicPropertiesPoints3, " +
                "EpicPropertiesPoints4, EpicPropertiesPoints5, RarePropertiesPoints1, RarePropertiesPoints2, RarePropertiesPoints3, RarePropertiesPoints4, " +
                "RarePropertiesPoints5, UncommonPropertiesPoints1, UncommonPropertiesPoints2, UncommonPropertiesPoints3, UncommonPropertiesPoints4, " +
                "UncommonPropertiesPoints5 FROM rand_prop_points ORDER BY ID DESC");

            // RewardPack.db2
            PrepareStatement(HotfixStatements.SEL_REWARD_PACK, "SELECT ID, Money, ArtifactXPMultiplier, ArtifactXPDifficulty, ArtifactCategoryID, TitleID, Unused" +
                " FROM reward_pack ORDER BY ID DESC");

            // RewardPackXItem.db2
            PrepareStatement(HotfixStatements.SEL_REWARD_PACK_X_ITEM, "SELECT ID, ItemID, RewardPackID, Amount FROM reward_pack_x_item ORDER BY ID DESC");

            // RulesetItemUpgrade.db2
            PrepareStatement(HotfixStatements.SEL_RULESET_ITEM_UPGRADE, "SELECT ID, ItemID, ItemUpgradeID FROM ruleset_item_upgrade ORDER BY ID DESC");

            // ScalingStatDistribution.db2
            PrepareStatement(HotfixStatements.SEL_SCALING_STAT_DISTRIBUTION, "SELECT ID, ItemLevelCurveID, MinLevel, MaxLevel FROM scaling_stat_distribution" +
                " ORDER BY ID DESC");

            // Scenario.db2
            PrepareStatement(HotfixStatements.SEL_SCENARIO, "SELECT ID, Name, Data, Flags, Type FROM scenario ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SCENARIO_LOCALE, "SELECT ID, Name_lang FROM scenario_locale WHERE locale = ?");

            // ScenarioStep.db2
            PrepareStatement(HotfixStatements.SEL_SCENARIO_STEP, "SELECT ID, Description, Name, ScenarioID, PreviousStepID, QuestRewardID, Step, Flags, CriteriaTreeID," +
                "BonusRequiredStepID FROM scenario_step ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SCENARIO_STEP_LOCALE, "SELECT ID, Description_lang, Name_lang FROM scenario_step_locale WHERE locale = ?");

            // SceneScript.db2
            PrepareStatement(HotfixStatements.SEL_SCENE_SCRIPT, "SELECT ID, Name, Script, PrevScriptId, NextScriptId FROM scene_script ORDER BY ID DESC");

            // SceneScriptPackage.db2
            PrepareStatement(HotfixStatements.SEL_SCENE_SCRIPT_PACKAGE, "SELECT ID, Name FROM scene_script_package ORDER BY ID DESC");

            // SkillLine.db2
            PrepareStatement(HotfixStatements.SEL_SKILL_LINE, "SELECT ID, DisplayName, Description, AlternateVerb, Flags, CategoryID, CanLink, IconFileDataID, " +
                "ParentSkillLineID FROM skill_line ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SKILL_LINE_LOCALE, "SELECT ID, DisplayName_lang, Description_lang, AlternateVerb_lang FROM skill_line_locale" +
                " WHERE locale = ?");

            // SkillLineAbility.db2
            PrepareStatement(HotfixStatements.SEL_SKILL_LINE_ABILITY, "SELECT ID, SpellID, RaceMask, SupercedesSpell, SkillLine, MinSkillLineRank, " +
                "TrivialSkillLineRankHigh, TrivialSkillLineRankLow, UniqueBit, TradeSkillCategoryID, AcquireMethod, NumSkillUps, Unknown703, ClassMask" +
                " FROM skill_line_ability ORDER BY ID DESC");

            // SkillRaceClassInfo.db2
            PrepareStatement(HotfixStatements.SEL_SKILL_RACE_CLASS_INFO, "SELECT ID, RaceMask, SkillID, Flags, SkillTierID, Availability, MinLevel, ClassMask" +
                " FROM skill_race_class_info ORDER BY ID DESC");

            // SoundKit.db2
            PrepareStatement(HotfixStatements.SEL_SOUND_KIT, "SELECT ID, VolumeFloat, MinDistance, DistanceCutoff, Flags, SoundEntriesAdvancedID, SoundType, " +
                "DialogType, EAXDef, VolumeVariationPlus, VolumeVariationMinus, PitchVariationPlus, PitchVariationMinus, PitchAdjust, BusOverwriteID, Unk700" +
                " FROM sound_kit ORDER BY ID DESC");

            // SpecializationSpells.db2
            PrepareStatement(HotfixStatements.SEL_SPECIALIZATION_SPELLS, "SELECT SpellID, OverridesSpellID, Description, SpecID, OrderIndex, ID" +
                " FROM specialization_spells ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SPECIALIZATION_SPELLS_LOCALE, "SELECT ID, Description_lang FROM specialization_spells_locale WHERE locale = ?");

            // Spell.db2
            PrepareStatement(HotfixStatements.SEL_SPELL, "SELECT Name, NameSubtext, Description, AuraDescription, MiscID, ID, DescriptionVariablesID FROM spell" +
                " ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SPELL_LOCALE, "SELECT ID, Name_lang, NameSubtext_lang, Description_lang, AuraDescription_lang FROM spell_locale" +
                " WHERE locale = ?");

            // SpellAuraOptions.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_AURA_OPTIONS, "SELECT ID, SpellID, ProcCharges, ProcTypeMask, ProcCategoryRecovery, CumulativeAura, " +
                "SpellProcsPerMinuteID, DifficultyID, ProcChance FROM spell_aura_options ORDER BY ID DESC");

            // SpellAuraRestrictions.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_AURA_RESTRICTIONS, "SELECT ID, SpellID, CasterAuraSpell, TargetAuraSpell, ExcludeCasterAuraSpell, " +
                "ExcludeTargetAuraSpell, DifficultyID, CasterAuraState, TargetAuraState, ExcludeCasterAuraState, ExcludeTargetAuraState" +
                " FROM spell_aura_restrictions ORDER BY ID DESC");

            // SpellCastTimes.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_CAST_TIMES, "SELECT ID, CastTime, MinCastTime, CastTimePerLevel FROM spell_cast_times ORDER BY ID DESC");

            // SpellCastingRequirements.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_CASTING_REQUIREMENTS, "SELECT ID, SpellID, MinFactionID, RequiredAreasID, RequiresSpellFocus, " +
                "FacingCasterFlags, MinReputation, RequiredAuraVision FROM spell_casting_requirements ORDER BY ID DESC");

            // SpellCategories.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_CATEGORIES, "SELECT ID, SpellID, Category, StartRecoveryCategory, ChargeCategory, DifficultyID, DefenseType, " +
                "DispelType, Mechanic, PreventionType FROM spell_categories ORDER BY ID DESC");

            // SpellCategory.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_CATEGORY, "SELECT ID, Name, ChargeRecoveryTime, Flags, UsesPerWeek, MaxCharges, ChargeCategoryType " +
                "FROM spell_category ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SPELL_CATEGORY_LOCALE, "SELECT ID, Name_lang FROM spell_category_locale WHERE locale = ?");

            // SpellClassOptions.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_CLASS_OPTIONS, "SELECT ID, SpellID, SpellClassMask1, SpellClassMask2, SpellClassMask3, SpellClassMask4, " +
                "SpellClassSet, ModalNextSpell FROM spell_class_options ORDER BY ID DESC");

            // SpellCooldowns.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_COOLDOWNS, "SELECT ID, SpellID, CategoryRecoveryTime, RecoveryTime, StartRecoveryTime, DifficultyID" +
                " FROM spell_cooldowns ORDER BY ID DESC");

            // SpellDuration.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_DURATION, "SELECT ID, Duration, MaxDuration, DurationPerLevel FROM spell_duration ORDER BY ID DESC");

            // SpellEffect.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_EFFECT, "SELECT EffectSpellClassMask1, EffectSpellClassMask2, EffectSpellClassMask3, EffectSpellClassMask4, ID, " +
                "SpellID, Effect, EffectAura, EffectBasePoints, EffectIndex, EffectMiscValue, EffectMiscValueB, EffectRadiusIndex, EffectRadiusMaxIndex, " +
                "ImplicitTarget1, ImplicitTarget2, DifficultyID, EffectAmplitude, EffectAuraPeriod, EffectBonusCoefficient, EffectChainAmplitude, " +
                "EffectChainTargets, EffectDieSides, EffectItemType, EffectMechanic, EffectPointsPerResource, EffectRealPointsPerLevel, EffectTriggerSpell, " +
                "EffectPosFacing, EffectAttributes, BonusCoefficientFromAP, PvPMultiplier FROM spell_effect ORDER BY ID DESC");

            // SpellEffectScaling.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_EFFECT_SCALING, "SELECT ID, Coefficient, Variance, ResourceCoefficient, SpellEffectID FROM spell_effect_scaling" +
                " ORDER BY ID DESC");

            // SpellEquippedItems.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_EQUIPPED_ITEMS, "SELECT ID, SpellID, EquippedItemInventoryTypeMask, EquippedItemSubClassMask, " +
                "EquippedItemClass FROM spell_equipped_items ORDER BY ID DESC");

            // SpellFocusObject.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_FOCUS_OBJECT, "SELECT ID, Name FROM spell_focus_object ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SPELL_FOCUS_OBJECT_LOCALE, "SELECT ID, Name_lang FROM spell_focus_object_locale WHERE locale = ?");

            // SpellInterrupts.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_INTERRUPTS, "SELECT ID, SpellID, AuraInterruptFlags1, AuraInterruptFlags2, ChannelInterruptFlags1, " +
                "ChannelInterruptFlags2, InterruptFlags, DifficultyID FROM spell_interrupts ORDER BY ID DESC");

            // SpellItemEnchantment.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_ITEM_ENCHANTMENT, "SELECT ID, EffectSpellID1, EffectSpellID2, EffectSpellID3, Name, EffectScalingPoints1, " +
                "EffectScalingPoints2, EffectScalingPoints3, TransmogCost, TextureFileDataID, EffectPointsMin1, EffectPointsMin2, EffectPointsMin3, " +
                "ItemVisual, Flags, RequiredSkillID, RequiredSkillRank, ItemLevel, Charges, Effect1, Effect2, Effect3, ConditionID, MinLevel, MaxLevel, " +
                "ScalingClass, ScalingClassRestricted, PlayerConditionID FROM spell_item_enchantment ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SPELL_ITEM_ENCHANTMENT_LOCALE, "SELECT ID, Name_lang FROM spell_item_enchantment_locale WHERE locale = ?");

            // SpellItemEnchantmentCondition.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_ITEM_ENCHANTMENT_CONDITION, "SELECT ID, LTOperandType1, LTOperandType2, LTOperandType3, LTOperandType4, " +
                "LTOperandType5, Operator1, Operator2, Operator3, Operator4, Operator5, RTOperandType1, RTOperandType2, RTOperandType3, RTOperandType4, " +
                "RTOperandType5, RTOperand1, RTOperand2, RTOperand3, RTOperand4, RTOperand5, Logic1, Logic2, Logic3, Logic4, Logic5, LTOperand1, LTOperand2, " +
                "LTOperand3, LTOperand4, LTOperand5 FROM spell_item_enchantment_condition ORDER BY ID DESC");

            // SpellLearnSpell.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_LEARN_SPELL, "SELECT ID, LearnSpellID, SpellID, OverridesSpellID FROM spell_learn_spell ORDER BY ID DESC");

            // SpellLevels.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_LEVELS, "SELECT ID, SpellID, BaseLevel, MaxLevel, SpellLevel, DifficultyID, MaxUsableLevel FROM spell_levels" +
                " ORDER BY ID DESC");

            // SpellMisc.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_MISC, "SELECT ID, Attributes, AttributesEx, AttributesExB, AttributesExC, AttributesExD, AttributesExE, " +
                "AttributesExF, AttributesExG, AttributesExH, AttributesExI, AttributesExJ, AttributesExK, AttributesExL, AttributesExM, Speed, " +
                "MultistrikeSpeedMod, CastingTimeIndex, DurationIndex, RangeIndex, SchoolMask, IconFileDataID, ActiveIconFileDataID FROM spell_misc" +
                " ORDER BY ID DESC");

            // SpellPower.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_POWER, "SELECT SpellID, ManaCost, ManaCostPercentage, ManaCostPercentagePerSecond, RequiredAura, " +
                "HealthCostPercentage, PowerIndex, PowerType, ID, ManaCostPerLevel, ManaCostPerSecond, ManaCostAdditional, PowerDisplayID, UnitPowerBarID" +
                " FROM spell_power ORDER BY ID DESC");

            // SpellPowerDifficulty.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_POWER_DIFFICULTY, "SELECT DifficultyID, PowerIndex, ID FROM spell_power_difficulty ORDER BY ID DESC");

            // SpellProcsPerMinute.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_PROCS_PER_MINUTE, "SELECT ID, BaseProcRate, Flags FROM spell_procs_per_minute ORDER BY ID DESC");

            // SpellProcsPerMinuteMod.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_PROCS_PER_MINUTE_MOD, "SELECT ID, Coeff, Param, SpellProcsPerMinuteID, Type FROM spell_procs_per_minute_mod" +
                " ORDER BY ID DESC");

            // SpellRadius.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_RADIUS, "SELECT ID, Radius, RadiusPerLevel, RadiusMin, RadiusMax FROM spell_radius ORDER BY ID DESC");

            // SpellRange.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_RANGE, "SELECT ID, MinRangeHostile, MinRangeFriend, MaxRangeHostile, MaxRangeFriend, DisplayName, " +
                "DisplayNameShort, Flags FROM spell_range ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SPELL_RANGE_LOCALE, "SELECT ID, DisplayName_lang, DisplayNameShort_lang FROM spell_range_locale WHERE locale = ?");

            // SpellReagents.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_REAGENTS, "SELECT ID, SpellID, Reagent1, Reagent2, Reagent3, Reagent4, Reagent5, Reagent6, Reagent7, Reagent8, " +
                "ReagentCount1, ReagentCount2, ReagentCount3, ReagentCount4, ReagentCount5, ReagentCount6, ReagentCount7, ReagentCount8 FROM spell_reagents" +
                " ORDER BY ID DESC");

            // SpellScaling.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_SCALING, "SELECT ID, SpellID, ScalesFromItemLevel, ScalingClass, MinScalingLevel, MaxScalingLevel" +
                " FROM spell_scaling ORDER BY ID DESC");

            // SpellShapeshift.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_SHAPESHIFT, "SELECT ID, SpellID, ShapeshiftExclude1, ShapeshiftExclude2, ShapeshiftMask1, ShapeshiftMask2, " +
                "StanceBarOrder FROM spell_shapeshift ORDER BY ID DESC");

            // SpellShapeshiftForm.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_SHAPESHIFT_FORM, "SELECT ID, Name, WeaponDamageVariance, Flags, CombatRoundTime, MountTypeID, CreatureType, " +
                "BonusActionBar, AttackIconFileDataID, CreatureDisplayID1, CreatureDisplayID2, CreatureDisplayID3, CreatureDisplayID4, PresetSpellID1, " +
                "PresetSpellID2, PresetSpellID3, PresetSpellID4, PresetSpellID5, PresetSpellID6, PresetSpellID7, PresetSpellID8 FROM spell_shapeshift_form" +
                " ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_SPELL_SHAPESHIFT_FORM_LOCALE, "SELECT ID, Name_lang FROM spell_shapeshift_form_locale WHERE locale = ?");

            // SpellTargetRestrictions.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_TARGET_RESTRICTIONS, "SELECT ID, SpellID, ConeAngle, Width, Targets, TargetCreatureType, DifficultyID, " +
                "MaxAffectedTargets, MaxTargetLevel FROM spell_target_restrictions ORDER BY ID DESC");

            // SpellTotems.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_TOTEMS, "SELECT ID, SpellID, Totem1, Totem2, RequiredTotemCategoryID1, RequiredTotemCategoryID2" +
                " FROM spell_totems ORDER BY ID DESC");

            // SpellXSpellVisual.db2
            PrepareStatement(HotfixStatements.SEL_SPELL_X_SPELL_VISUAL, "SELECT SpellID, SpellVisualID, ID, Chance, CasterPlayerConditionID, CasterUnitConditionID, " +
                "PlayerConditionID, UnitConditionID, IconFileDataID, ActiveIconFileDataID, Flags, DifficultyID, Priority FROM spell_x_spell_visual" +
                " ORDER BY ID DESC");

            // SummonProperties.db2
            PrepareStatement(HotfixStatements.SEL_SUMMON_PROPERTIES, "SELECT ID, Flags, Category, Faction, Type, Slot FROM summon_properties ORDER BY ID DESC");

            // TactKey.db2
            PrepareStatement(HotfixStatements.SEL_TACT_KEY, "SELECT ID, Key1, Key2, Key3, Key4, Key5, Key6, Key7, Key8, Key9, Key10, Key11, Key12, Key13, Key14, " +
                "Key15, Key16 FROM tact_key ORDER BY ID DESC");

            // Talent.db2
            PrepareStatement(HotfixStatements.SEL_TALENT, "SELECT ID, SpellID, OverridesSpellID, Description, SpecID, TierID, ColumnIndex, Flags, CategoryMask1, " +
                "CategoryMask2, ClassID FROM talent ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_TALENT_LOCALE, "SELECT ID, Description_lang FROM talent_locale WHERE locale = ?");

            // TaxiNodes.db2
            PrepareStatement(HotfixStatements.SEL_TAXI_NODES, "SELECT ID, PosX, PosY, PosZ, Name, MountCreatureID1, MountCreatureID2, MapOffsetX, MapOffsetY, Unk730, " +
                "FlightMapOffsetX, FlightMapOffsetY, MapID, ConditionID, LearnableIndex, Flags, UiTextureKitPrefixID, SpecialAtlasIconPlayerConditionID" +
                " FROM taxi_nodes ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_TAXI_NODES_LOCALE, "SELECT ID, Name_lang FROM taxi_nodes_locale WHERE locale = ?");

            // TaxiPath.db2
            PrepareStatement(HotfixStatements.SEL_TAXI_PATH, "SELECT `From`, `To`, ID, Cost FROM taxi_path ORDER BY ID DESC");

            // TaxiPathNode.db2
            PrepareStatement(HotfixStatements.SEL_TAXI_PATH_NODE, "SELECT LocX, LocY, LocZ, PathID, MapID, NodeIndex, ID, Flags, Delay, ArrivalEventID, " +
                "DepartureEventID FROM taxi_path_node ORDER BY ID DESC");

            // TotemCategory.db2
            PrepareStatement(HotfixStatements.SEL_TOTEM_CATEGORY, "SELECT ID, Name, CategoryMask, CategoryType FROM totem_category ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_TOTEM_CATEGORY_LOCALE, "SELECT ID, Name_lang FROM totem_category_locale WHERE locale = ?");

            // Toy.db2
            PrepareStatement(HotfixStatements.SEL_TOY, "SELECT ItemID, Description, Flags, CategoryFilter, ID FROM toy ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_TOY_LOCALE, "SELECT ID, Description_lang FROM toy_locale WHERE locale = ?");

            // TransmogHoliday.db2
            PrepareStatement(HotfixStatements.SEL_TRANSMOG_HOLIDAY, "SELECT ID, HolidayID FROM transmog_holiday ORDER BY ID DESC");

            // TransmogSet.db2
            PrepareStatement(HotfixStatements.SEL_TRANSMOG_SET, "SELECT Name, BaseSetID, UIOrder, ExpansionID, ID, Flags, QuestID, ClassMask, ItemNameDescriptionID, " +
                "TransmogSetGroupID FROM transmog_set ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_TRANSMOG_SET_LOCALE, "SELECT ID, Name_lang FROM transmog_set_locale WHERE locale = ?");

            // TransmogSetGroup.db2
            PrepareStatement(HotfixStatements.SEL_TRANSMOG_SET_GROUP, "SELECT Label, ID FROM transmog_set_group ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_TRANSMOG_SET_GROUP_LOCALE, "SELECT ID, Label_lang FROM transmog_set_group_locale WHERE locale = ?");

            // TransmogSetItem.db2
            PrepareStatement(HotfixStatements.SEL_TRANSMOG_SET_ITEM, "SELECT ID, TransmogSetID, ItemModifiedAppearanceID, Flags FROM transmog_set_item ORDER BY ID DESC");

            // TransportAnimation.db2
            PrepareStatement(HotfixStatements.SEL_TRANSPORT_ANIMATION, "SELECT ID, TransportID, TimeIndex, PosX, PosY, PosZ, SequenceID FROM transport_animation" +
                " ORDER BY ID DESC");

            // TransportRotation.db2
            PrepareStatement(HotfixStatements.SEL_TRANSPORT_ROTATION, "SELECT ID, TransportID, TimeIndex, X, Y, Z, W FROM transport_rotation ORDER BY ID DESC");

            // UnitPowerBar.db2
            PrepareStatement(HotfixStatements.SEL_UNIT_POWER_BAR, "SELECT ID, RegenerationPeace, RegenerationCombat, FileDataID1, FileDataID2, FileDataID3, " +
                "FileDataID4, FileDataID5, FileDataID6, Color1, Color2, Color3, Color4, Color5, Color6, Name, Cost, OutOfError, ToolTip, StartInset, " +
                "EndInset, StartPower, Flags, CenterPower, BarType, MinPower, MaxPower FROM unit_power_bar ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_UNIT_POWER_BAR_LOCALE, "SELECT ID, Name_lang, Cost_lang, OutOfError_lang, ToolTip_lang FROM unit_power_bar_locale" +
                " WHERE locale = ?");

            // Vehicle.db2
            PrepareStatement(HotfixStatements.SEL_VEHICLE, "SELECT ID, Flags, TurnSpeed, PitchSpeed, PitchMin, PitchMax, MouseLookOffsetPitch, CameraFadeDistScalarMin, " +
                "CameraFadeDistScalarMax, CameraPitchOffset, FacingLimitRight, FacingLimitLeft, CameraYawOffset, SeatID1, SeatID2, SeatID3, SeatID4, SeatID5, " +
                "SeatID6, SeatID7, SeatID8, VehicleUIIndicatorID, PowerDisplayID1, PowerDisplayID2, PowerDisplayID3, FlagsB, UILocomotionType, " +
                "MissileTargetingID FROM vehicle ORDER BY ID DESC");

            // VehicleSeat.db2
            PrepareStatement(HotfixStatements.SEL_VEHICLE_SEAT, "SELECT ID, Flags1, Flags2, Flags3, AttachmentOffsetX, AttachmentOffsetY, AttachmentOffsetZ, " +
                "EnterPreDelay, EnterSpeed, EnterGravity, EnterMinDuration, EnterMaxDuration, EnterMinArcHeight, EnterMaxArcHeight, ExitPreDelay, ExitSpeed, " +
                "ExitGravity, ExitMinDuration, ExitMaxDuration, ExitMinArcHeight, ExitMaxArcHeight, PassengerYaw, PassengerPitch, PassengerRoll, " +
                "VehicleEnterAnimDelay, VehicleExitAnimDelay, CameraEnteringDelay, CameraEnteringDuration, CameraExitingDelay, CameraExitingDuration, " +
                "CameraOffsetX, CameraOffsetY, CameraOffsetZ, CameraPosChaseRate, CameraFacingChaseRate, CameraEnteringZoom, CameraSeatZoomMin, " +
                "CameraSeatZoomMax, UISkinFileDataID, EnterAnimStart, EnterAnimLoop, RideAnimStart, RideAnimLoop, RideUpperAnimStart, RideUpperAnimLoop, " +
                "ExitAnimStart, ExitAnimLoop, ExitAnimEnd, VehicleEnterAnim, VehicleExitAnim, VehicleRideAnimLoop, EnterAnimKitID, RideAnimKitID, " +
                "ExitAnimKitID, VehicleEnterAnimKitID, VehicleRideAnimKitID, VehicleExitAnimKitID, CameraModeID, AttachmentID, PassengerAttachmentID, " +
                "VehicleEnterAnimBone, VehicleExitAnimBone, VehicleRideAnimLoopBone, VehicleAbilityDisplay, EnterUISoundID, ExitUISoundID FROM vehicle_seat" +
                " ORDER BY ID DESC");

            // WmoAreaTable.db2
            PrepareStatement(HotfixStatements.SEL_WMO_AREA_TABLE, "SELECT WMOGroupID, AreaName, WMOID, AmbienceID, ZoneMusic, IntroSound, AreaTableID, UWIntroSound, " +
                "UWAmbience, NameSet, SoundProviderPref, SoundProviderPrefUnderwater, Flags, ID, UWZoneMusic FROM wmo_area_table ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_WMO_AREA_TABLE_LOCALE, "SELECT ID, AreaName_lang FROM wmo_area_table_locale WHERE locale = ?");

            // WorldEffect.db2
            PrepareStatement(HotfixStatements.SEL_WORLD_EFFECT, "SELECT ID, TargetAsset, CombatConditionID, TargetType, WhenToDisplay, QuestFeedbackEffectID, " +
                "PlayerConditionID FROM world_effect ORDER BY ID DESC");

            // WorldMapArea.db2
            PrepareStatement(HotfixStatements.SEL_WORLD_MAP_AREA, "SELECT AreaName, LocLeft, LocRight, LocTop, LocBottom, Flags, MapID, AreaID, DisplayMapID, " +
                "DefaultDungeonFloor, ParentWorldMapID, LevelRangeMin, LevelRangeMax, BountySetID, BountyBoardLocation, ID, PlayerConditionID" +
                " FROM world_map_area ORDER BY ID DESC");

            // WorldMapOverlay.db2
            PrepareStatement(HotfixStatements.SEL_WORLD_MAP_OVERLAY, "SELECT ID, TextureName, TextureWidth, TextureHeight, MapAreaID, AreaID1, AreaID2, AreaID3, " +
                "AreaID4, OffsetX, OffsetY, HitRectTop, HitRectLeft, HitRectBottom, HitRectRight, PlayerConditionID, Flags FROM world_map_overlay" +
                " ORDER BY ID DESC");

            // WorldMapTransforms.db2
            PrepareStatement(HotfixStatements.SEL_WORLD_MAP_TRANSFORMS, "SELECT ID, RegionMinX, RegionMinY, RegionMinZ, RegionMaxX, RegionMaxY, RegionMaxZ, " +
                "RegionOffsetX, RegionOffsetY, RegionScale, MapID, AreaID, NewMapID, NewDungeonMapID, NewAreaID, Flags, Priority FROM world_map_transforms" +
                " ORDER BY ID DESC");

            // WorldSafeLocs.db2
            PrepareStatement(HotfixStatements.SEL_WORLD_SAFE_LOCS, "SELECT ID, LocX, LocY, LocZ, Facing, AreaName, MapID FROM world_safe_locs ORDER BY ID DESC");
            PrepareStatement(HotfixStatements.SEL_WORLD_SAFE_LOCS_LOCALE, "SELECT ID, AreaName_lang FROM world_safe_locs_locale WHERE locale = ?");
        }
    }

    public enum HotfixStatements
    {
        None = 0, 

        SEL_ACHIEVEMENT,
        SEL_ACHIEVEMENT_LOCALE,

        SEL_ANIM_KIT,

        SEL_AREA_GROUP_MEMBER,

        SEL_AREA_TABLE,
        SEL_AREA_TABLE_LOCALE,

        SEL_AREA_TRIGGER,

        SEL_ARMOR_LOCATION,

        SEL_ARTIFACT,
        SEL_ARTIFACT_LOCALE,

        SEL_ARTIFACT_APPEARANCE,
        SEL_ARTIFACT_APPEARANCE_LOCALE,

        SEL_ARTIFACT_APPEARANCE_SET,
        SEL_ARTIFACT_APPEARANCE_SET_LOCALE,

        SEL_ARTIFACT_CATEGORY,

        SEL_ARTIFACT_POWER,

        SEL_ARTIFACT_POWER_LINK,

        SEL_ARTIFACT_POWER_PICKER,

        SEL_ARTIFACT_POWER_RANK,

        SEL_ARTIFACT_QUEST_XP,

        SEL_AUCTION_HOUSE,
        SEL_AUCTION_HOUSE_LOCALE,

        SEL_BANK_BAG_SLOT_PRICES,

        SEL_BANNED_ADDONS,

        SEL_BARBER_SHOP_STYLE,
        SEL_BARBER_SHOP_STYLE_LOCALE,

        SEL_BATTLE_PET_BREED_QUALITY,

        SEL_BATTLE_PET_BREED_STATE,

        SEL_BATTLE_PET_SPECIES,
        SEL_BATTLE_PET_SPECIES_LOCALE,

        SEL_BATTLE_PET_SPECIES_STATE,

        SEL_BATTLEMASTER_LIST,
        SEL_BATTLEMASTER_LIST_LOCALE,

        SEL_BROADCAST_TEXT,
        SEL_BROADCAST_TEXT_LOCALE,

        SEL_CHARACTER_FACIAL_HAIR_STYLES,

        SEL_CHAR_BASE_SECTION,

        SEL_CHAR_SECTIONS,

        SEL_CHAR_START_OUTFIT,

        SEL_CHAR_TITLES,
        SEL_CHAR_TITLES_LOCALE,

        SEL_CHAT_CHANNELS,
        SEL_CHAT_CHANNELS_LOCALE,

        SEL_CHR_CLASSES,
        SEL_CHR_CLASSES_LOCALE,

        SEL_CHR_CLASSES_X_POWER_TYPES,

        SEL_CHR_RACES,
        SEL_CHR_RACES_LOCALE,

        SEL_CHR_SPECIALIZATION,
        SEL_CHR_SPECIALIZATION_LOCALE,

        SEL_CINEMATIC_CAMERA,

        SEL_CINEMATIC_SEQUENCES,

        SEL_CONVERSATION_LINE,

        SEL_CREATURE_DISPLAY_INFO,

        SEL_CREATURE_DISPLAY_INFO_EXTRA,

        SEL_CREATURE_FAMILY,
        SEL_CREATURE_FAMILY_LOCALE,

        SEL_CREATURE_MODEL_DATA,

        SEL_CREATURE_TYPE,
        SEL_CREATURE_TYPE_LOCALE,

        SEL_CRITERIA,

        SEL_CRITERIA_TREE,
        SEL_CRITERIA_TREE_LOCALE,

        SEL_CURRENCY_TYPES,
        SEL_CURRENCY_TYPES_LOCALE,

        SEL_CURVE,

        SEL_CURVE_POINT,

        SEL_DESTRUCTIBLE_MODEL_DATA,

        SEL_DIFFICULTY,
        SEL_DIFFICULTY_LOCALE,

        SEL_DUNGEON_ENCOUNTER,
        SEL_DUNGEON_ENCOUNTER_LOCALE,

        SEL_DURABILITY_COSTS,

        SEL_DURABILITY_QUALITY,

        SEL_EMOTES,

        SEL_EMOTES_TEXT,
        SEL_EMOTES_TEXT_LOCALE,

        SEL_EMOTES_TEXT_SOUND,

        SEL_FACTION,
        SEL_FACTION_LOCALE,

        SEL_FACTION_TEMPLATE,

        SEL_GAMEOBJECTS,
        SEL_GAMEOBJECTS_LOCALE,

        SEL_GAMEOBJECT_DISPLAY_INFO,

        SEL_GARR_ABILITY,
        SEL_GARR_ABILITY_LOCALE,

        SEL_GARR_BUILDING,
        SEL_GARR_BUILDING_LOCALE,

        SEL_GARR_BUILDING_PLOT_INST,

        SEL_GARR_CLASS_SPEC,
        SEL_GARR_CLASS_SPEC_LOCALE,

        SEL_GARR_FOLLOWER,
        SEL_GARR_FOLLOWER_LOCALE,

        SEL_GARR_FOLLOWER_X_ABILITY,

        SEL_GARR_PLOT,
        SEL_GARR_PLOT_LOCALE,

        SEL_GARR_PLOT_BUILDING,

        SEL_GARR_PLOT_INSTANCE,
        SEL_GARR_PLOT_INSTANCE_LOCALE,

        SEL_GARR_SITE_LEVEL,

        SEL_GARR_SITE_LEVEL_PLOT_INST,

        SEL_GEM_PROPERTIES,

        SEL_GLYPH_BINDABLE_SPELL,

        SEL_GLYPH_PROPERTIES,

        SEL_GLYPH_REQUIRED_SPEC,

        SEL_GUILD_COLOR_BACKGROUND,

        SEL_GUILD_COLOR_BORDER,

        SEL_GUILD_COLOR_EMBLEM,

        SEL_GUILD_PERK_SPELLS,

        SEL_HEIRLOOM,
        SEL_HEIRLOOM_LOCALE,

        SEL_HOLIDAYS,

        SEL_IMPORT_PRICE_ARMOR,

        SEL_IMPORT_PRICE_QUALITY,

        SEL_IMPORT_PRICE_SHIELD,

        SEL_IMPORT_PRICE_WEAPON,

        SEL_ITEM,

        SEL_ITEM_APPEARANCE,

        SEL_ITEM_ARMOR_QUALITY,

        SEL_ITEM_ARMOR_SHIELD,

        SEL_ITEM_ARMOR_TOTAL,

        SEL_ITEM_BAG_FAMILY,
        SEL_ITEM_BAG_FAMILY_LOCALE,

        SEL_ITEM_BONUS,

        SEL_ITEM_BONUS_LIST_LEVEL_DELTA,

        SEL_ITEM_BONUS_TREE_NODE,

        SEL_ITEM_CHILD_EQUIPMENT,

        SEL_ITEM_CLASS,
        SEL_ITEM_CLASS_LOCALE,

        SEL_ITEM_CURRENCY_COST,

        SEL_ITEM_DAMAGE_AMMO,

        SEL_ITEM_DAMAGE_ONE_HAND,

        SEL_ITEM_DAMAGE_ONE_HAND_CASTER,

        SEL_ITEM_DAMAGE_TWO_HAND,

        SEL_ITEM_DAMAGE_TWO_HAND_CASTER,

        SEL_ITEM_DISENCHANT_LOOT,

        SEL_ITEM_EFFECT,

        SEL_ITEM_EXTENDED_COST,

        SEL_ITEM_LEVEL_SELECTOR,

        SEL_ITEM_LEVEL_SELECTOR_QUALITY,

        SEL_ITEM_LEVEL_SELECTOR_QUALITY_SET,

        SEL_ITEM_LIMIT_CATEGORY,
        SEL_ITEM_LIMIT_CATEGORY_LOCALE,

        SEL_ITEM_MODIFIED_APPEARANCE,

        SEL_ITEM_PRICE_BASE,

        SEL_ITEM_RANDOM_PROPERTIES,
        SEL_ITEM_RANDOM_PROPERTIES_LOCALE,

        SEL_ITEM_RANDOM_SUFFIX,
        SEL_ITEM_RANDOM_SUFFIX_LOCALE,

        SEL_ITEM_SEARCH_NAME,
        SEL_ITEM_SEARCH_NAME_LOCALE,

        SEL_ITEM_SET,
        SEL_ITEM_SET_LOCALE,

        SEL_ITEM_SET_SPELL,

        SEL_ITEM_SPARSE,
        SEL_ITEM_SPARSE_LOCALE,

        SEL_ITEM_SPEC,

        SEL_ITEM_SPEC_OVERRIDE,

        SEL_ITEM_UPGRADE,

        SEL_ITEM_X_BONUS_TREE,

        SEL_KEYCHAIN,

        SEL_LFG_DUNGEONS,
        SEL_LFG_DUNGEONS_LOCALE,

        SEL_LIGHT,

        SEL_LIQUID_TYPE,
        SEL_LIQUID_TYPE_LOCALE,

        SEL_LOCK,

        SEL_MAIL_TEMPLATE,
        SEL_MAIL_TEMPLATE_LOCALE,

        SEL_MAP,
        SEL_MAP_LOCALE,

        SEL_MAP_DIFFICULTY,
        SEL_MAP_DIFFICULTY_LOCALE,

        SEL_MODIFIER_TREE,

        SEL_MOUNT,
        SEL_MOUNT_LOCALE,

        SEL_MOUNT_CAPABILITY,

        SEL_MOUNT_TYPE_X_CAPABILITY,

        SEL_MOUNT_X_DISPLAY,

        SEL_MOVIE,

        SEL_NAME_GEN,
        SEL_NAME_GEN_LOCALE,

        SEL_NAMES_PROFANITY,

        SEL_NAMES_RESERVED,

        SEL_NAMES_RESERVED_LOCALE,

        SEL_OVERRIDE_SPELL_DATA,

        SEL_PHASE,

        SEL_PHASE_X_PHASE_GROUP,

        SEL_PLAYER_CONDITION,
        SEL_PLAYER_CONDITION_LOCALE,

        SEL_POWER_DISPLAY,

        SEL_POWER_TYPE,

        SEL_PRESTIGE_LEVEL_INFO,
        SEL_PRESTIGE_LEVEL_INFO_LOCALE,

        SEL_PVP_DIFFICULTY,

        SEL_PVP_REWARD,

        SEL_QUEST_FACTION_REWARD,

        SEL_QUEST_MONEY_REWARD,

        SEL_QUEST_PACKAGE_ITEM,

        SEL_QUEST_SORT,
        SEL_QUEST_SORT_LOCALE,

        SEL_QUEST_V2,

        SEL_QUEST_XP,

        SEL_RAND_PROP_POINTS,

        SEL_REWARD_PACK,

        SEL_REWARD_PACK_X_ITEM,

        SEL_RULESET_ITEM_UPGRADE,

        SEL_SCALING_STAT_DISTRIBUTION,

        SEL_SCENARIO,
        SEL_SCENARIO_LOCALE,

        SEL_SCENARIO_STEP,
        SEL_SCENARIO_STEP_LOCALE,

        SEL_SCENE_SCRIPT,

        SEL_SCENE_SCRIPT_PACKAGE,

        SEL_SKILL_LINE,
        SEL_SKILL_LINE_LOCALE,

        SEL_SKILL_LINE_ABILITY,

        SEL_SKILL_RACE_CLASS_INFO,

        SEL_SOUND_KIT,

        SEL_SPECIALIZATION_SPELLS,
        SEL_SPECIALIZATION_SPELLS_LOCALE,

        SEL_SPELL,
        SEL_SPELL_LOCALE,

        SEL_SPELL_AURA_OPTIONS,

        SEL_SPELL_AURA_RESTRICTIONS,

        SEL_SPELL_CAST_TIMES,

        SEL_SPELL_CASTING_REQUIREMENTS,

        SEL_SPELL_CATEGORIES,

        SEL_SPELL_CATEGORY,
        SEL_SPELL_CATEGORY_LOCALE,

        SEL_SPELL_CLASS_OPTIONS,

        SEL_SPELL_COOLDOWNS,

        SEL_SPELL_DURATION,

        SEL_SPELL_EFFECT,

        SEL_SPELL_EFFECT_SCALING,

        SEL_SPELL_EQUIPPED_ITEMS,

        SEL_SPELL_FOCUS_OBJECT,
        SEL_SPELL_FOCUS_OBJECT_LOCALE,

        SEL_SPELL_INTERRUPTS,

        SEL_SPELL_ITEM_ENCHANTMENT,
        SEL_SPELL_ITEM_ENCHANTMENT_LOCALE,

        SEL_SPELL_ITEM_ENCHANTMENT_CONDITION,

        SEL_SPELL_LEARN_SPELL,

        SEL_SPELL_LEVELS,

        SEL_SPELL_MISC,

        SEL_SPELL_POWER,

        SEL_SPELL_POWER_DIFFICULTY,

        SEL_SPELL_PROCS_PER_MINUTE,

        SEL_SPELL_PROCS_PER_MINUTE_MOD,

        SEL_SPELL_RADIUS,

        SEL_SPELL_RANGE,
        SEL_SPELL_RANGE_LOCALE,

        SEL_SPELL_REAGENTS,

        SEL_SPELL_SCALING,

        SEL_SPELL_SHAPESHIFT,

        SEL_SPELL_SHAPESHIFT_FORM,
        SEL_SPELL_SHAPESHIFT_FORM_LOCALE,

        SEL_SPELL_TARGET_RESTRICTIONS,

        SEL_SPELL_TOTEMS,

        SEL_SPELL_X_SPELL_VISUAL,

        SEL_SUMMON_PROPERTIES,

        SEL_TACT_KEY,

        SEL_TALENT,
        SEL_TALENT_LOCALE,

        SEL_TAXI_NODES,
        SEL_TAXI_NODES_LOCALE,

        SEL_TAXI_PATH,

        SEL_TAXI_PATH_NODE,

        SEL_TOTEM_CATEGORY,
        SEL_TOTEM_CATEGORY_LOCALE,

        SEL_TOY,
        SEL_TOY_LOCALE,

        SEL_TRANSMOG_HOLIDAY,

        SEL_TRANSMOG_SET,
        SEL_TRANSMOG_SET_LOCALE,

        SEL_TRANSMOG_SET_GROUP,
        SEL_TRANSMOG_SET_GROUP_LOCALE,

        SEL_TRANSMOG_SET_ITEM,

        SEL_TRANSPORT_ANIMATION,

        SEL_TRANSPORT_ROTATION,

        SEL_UNIT_POWER_BAR,
        SEL_UNIT_POWER_BAR_LOCALE,

        SEL_VEHICLE,

        SEL_VEHICLE_SEAT,

        SEL_WMO_AREA_TABLE,
        SEL_WMO_AREA_TABLE_LOCALE,

        SEL_WORLD_EFFECT,

        SEL_WORLD_MAP_AREA,

        SEL_WORLD_MAP_OVERLAY,

        SEL_WORLD_MAP_TRANSFORMS,

        SEL_WORLD_SAFE_LOCS,
        SEL_WORLD_SAFE_LOCS_LOCALE,

        MAX_HOTFIXDATABASE_STATEMENTS
    }
}
