using ItemGenerator.Domain.Common;

namespace ItemGenerator.Domain.Enumerations;

public sealed class Skill : Enumeration<Skill>
{
    private Skill(byte value, string name) : base(value, name) { }
    public static readonly Skill Amazon = new(0, "Amazon Skills");
    public static readonly Skill AmazonBowAndCrossbow = new(1, "Bow and Crossbow Skills (Amazon Only)");
    public static readonly Skill AmazonJavelinAndSpear = new(2, "Javelin and Spear Skills (Amazon Only)");
    public static readonly Skill AmazonPassiveAndMagic = new(3, "Passive and Magic Skills (Amazon Only)");
    public static readonly Skill Assassin = new(4, "Assassin Skills");
    public static readonly Skill AssassinMartialArts = new(5, "Martial Arts (Assassin Only)");
    public static readonly Skill AssassinShadowDisciplines = new(6, "Shadow Disciplines (Assassin Only)");
    public static readonly Skill AssassinTraps = new(7, "Traps (Assassin Only)");
    public static readonly Skill Barbarian = new(8, "Barbarian");
    public static readonly Skill BarbarianCombatMasteries = new(1, "Combat Masteries (Barbarian Only)");
    public static readonly Skill BarbarianCombatSkills = new(10, "Combat Skills (Barbarian Only)");
    public static readonly Skill BarbarianWarcies = new(11, "Warcies (Barbarian Only)");
    public static readonly Skill Druid = new(12, "Druid Skills");
    public static readonly Skill DruidElemental = new(13, "Elemental Skills (Druid Only)");
    public static readonly Skill DruidShapeshifting = new(14, "Shapeshifting Skills (Druid Only)");
    public static readonly Skill DruidSummoning = new(15, "Summoning Skills (Druid Only)");
    public static readonly Skill Necromancer = new(16, "Necromancer Skills");
    public static readonly Skill NecromancerCurses = new(17, "Curses (Necromancer Only)");
    public static readonly Skill NecromancerPoisonAndBone = new(18, "Poison and Bone Skills (Necromancer Only)");
    public static readonly Skill NecromancerSummoning = new(19, "Summoning Skills (Necromancer Only)");
    public static readonly Skill Paladin = new(20, "Paladin Skills");
    public static readonly Skill PaladinCombatSkills = new(21, "Combat Skills (Paladin Only)");
    public static readonly Skill PaladinDefensiveAuras = new(22, "Defensive Auras (Paladin Only)");
    public static readonly Skill PaladinOffensiveAuras = new(23, "Offensive Auras (Paladin Only)");
    public static readonly Skill Sorceress = new(24, "Sorceress Skills");
    public static readonly Skill SorceressCold = new(25, "Cold Skills (Sorceress Only)");
    public static readonly Skill SorceressFire = new(26, "Fire Skills (Sorceress Only)");
    public static readonly Skill SorceressLightning = new(27, "Lightning Skills (Sorceress Only)");
}