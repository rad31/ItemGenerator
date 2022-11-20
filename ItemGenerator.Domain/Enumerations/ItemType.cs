using ItemGenerator.Domain.Common;

namespace ItemGenerator.Domain.Enumerations;

public sealed class ItemType : Enumeration<ItemType>
{
    public readonly ulong BitMask;
    private ItemType(byte value, string name, ulong bitMask)
        : base(value, name)
    {
        BitMask = bitMask;
    }
    public static readonly ItemType AmazonBow = new(0, "AmazonBow", 1UL);
    public static readonly ItemType AmazonJavelin = new(1, "AmazonJavelin", 1UL << 1);
    public static readonly ItemType AmazonSpear = new(2, "AmazonSpear", 1UL << 2);
    public static readonly ItemType Amulet = new(3, "Amulet", 1UL << 3);
    public static readonly ItemType AssassinClaws = new(4, "AssassinClaws", 1UL << 4);
    public static readonly ItemType Axe = new(5, "Axe", 1UL << 5);
    public static readonly ItemType BarbarianHelm = new(6, "BarbarianHelm", 1UL << 6);
    public static readonly ItemType Belt = new(7, "Belt", 1UL << 7);
    public static readonly ItemType BodyArmor = new(8, "BodyArmor", 1UL << 8);
    public static readonly ItemType Boots = new(9, "Boots", 1UL << 9);
    public static readonly ItemType Bow = new(10, "Bow", 1UL << 10);
    public static readonly ItemType CharmSmall = new(11, "CharmSmall", 1UL << 11);
    public static readonly ItemType CharmGrand = new(12, "CharmGrand", 1UL << 12);
    public static readonly ItemType CharmLarge = new(13, "CharmLarge", 1UL << 13);
    public static readonly ItemType Circlet = new(14, "Circlet", 1UL << 14);
    public static readonly ItemType Club = new(15, "Club", 1UL << 15);
    public static readonly ItemType Crossbow = new(16, "Crossbow", 1UL << 16);
    public static readonly ItemType Dagger = new(17, "Dagger", 1UL << 17);
    public static readonly ItemType Gloves = new(18, "Gloves", 1UL << 18);
    public static readonly ItemType Hammer = new(19, "Hammer", 1UL << 19);
    public static readonly ItemType Helm = new(20, "Helm", 1UL << 20);
    public static readonly ItemType DruidHelm = new(21, "DruidHelm", 1UL << 21);
    public static readonly ItemType Javelin = new(22, "Javelin", 1UL << 22);
    public static readonly ItemType Jewel = new(23, "Jewel", 1UL << 23);
    public static readonly ItemType Mace = new(24, "Mace", 1UL << 24);
    public static readonly ItemType NecromancerShield = new(25, "NecromancerShield", 1UL << 25);
    public static readonly ItemType PaladinShield = new(26, "PaladinShield", 1UL << 26);
    public static readonly ItemType Polearm = new(27, "Polearm", 1UL << 27);
    public static readonly ItemType Ring = new(28, "Ring", 1UL << 28);
    public static readonly ItemType Scepter = new(29, "Scepter", 1UL << 29);
    public static readonly ItemType Shield = new(30, "Shield", 1UL << 30);
    public static readonly ItemType Spear = new(31, "Spear", 1UL << 31);
    public static readonly ItemType Staff = new(32, "Staff", 1UL << 32);
    public static readonly ItemType SorceressOrb = new(33, "SorceressOrb", 1UL << 33);
    public static readonly ItemType Sword = new(34, "Sword", 1UL << 34);
    public static readonly ItemType ThrowingAxe = new(35, "ThrowingAxe", 1UL << 35);
    public static readonly ItemType ThrowingKnife = new(36, "ThrowingKnife", 1UL << 36);
    public static readonly ItemType Wand = new(37, "Wand", 1UL << 37);
    public static readonly ItemType RodType = new(38, "RodType",
        Scepter.BitMask |
        Staff.BitMask |
        Wand.BitMask);
    public static readonly ItemType BluntType = new(39, "BluntType",
        Club.BitMask |
        Hammer.BitMask |
        Mace.BitMask |
        RodType.BitMask);
    public static readonly ItemType SpearType = new(40, "SpearType",
        AmazonJavelin.BitMask |
        AmazonSpear.BitMask |
        Javelin.BitMask |
        Spear.BitMask);
    public static readonly ItemType MeleeType = new(41, "MeleeType",
        Axe.BitMask |
        Dagger.BitMask |
        SorceressOrb.BitMask |
        Polearm.BitMask |
        Sword.BitMask |
        BluntType.BitMask |
        SpearType.BitMask);
    public static readonly ItemType MissileType = new(42, "MissileType",
        Bow.BitMask |
        AmazonBow.BitMask |
        Crossbow.BitMask);
    public static readonly ItemType ThrowingType = new(43, "ThrowingType",
        Javelin.BitMask |
        AmazonJavelin.BitMask |
        ThrowingAxe.BitMask |
        ThrowingKnife.BitMask);
    public static readonly ItemType RangedType = new(44, "RangedType",
        MissileType.BitMask |
        ThrowingType.BitMask);
    public static readonly ItemType WeaponType = new(45, "WeaponType",
        MeleeType.BitMask |
        RangedType.BitMask);
    public static readonly ItemType HelmType = new(46, "HelmType",
        BarbarianHelm.BitMask |
        Circlet.BitMask |
        DruidHelm.BitMask |
        Helm.BitMask);
    public static readonly ItemType ShieldType = new(47, "ShieldType",
        PaladinShield.BitMask |
        NecromancerShield.BitMask |
        Shield.BitMask);

    public static readonly ItemType ArmorType = new(48, "ArmorType",
        BodyArmor.BitMask |
        HelmType.BitMask |
        ShieldType.BitMask |
        Gloves.BitMask |
        Boots.BitMask |
        Belt.BitMask);
}