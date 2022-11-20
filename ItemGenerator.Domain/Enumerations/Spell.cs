using ItemGenerator.Domain.Common;

namespace ItemGenerator.Domain.Enumerations;

public sealed class Spell : Enumeration<Spell>
{
    private Spell(byte value, string name) : base(value, name) { }
    public static readonly Spell AmazonColdArrow = new(0, "Cold Arrow");
    public static readonly Spell AmazonChargedStrike = new(1, "Charged Strike");
    public static readonly Spell AmazonExplodingArrow = new(2, "Exploding Arrow");
    public static readonly Spell AmazonFireArrow = new(3, "Fire Arrow");
    public static readonly Spell AmazonFreezingArrow = new(4, "Freezing Arrow");
    public static readonly Spell AmazonIceArrow = new(5, "Ice Arrow");
    public static readonly Spell AmazonInnerSight = new(6, "Inner Sight");
    public static readonly Spell AmazonLightningStrike = new(7, "Lightning Strike");
    public static readonly Spell AmazonMagicArrow = new(8, "Magic Arrow");
    public static readonly Spell AmazonMultipleShot = new(9, "Multiple Shot");
    public static readonly Spell AmazonPowerStrike = new(10, "Power Strike");
    public static readonly Spell BarbarianBash = new(11, "Bash");
    public static readonly Spell BarbarianConcentrate = new(12, "Concentrate");
    public static readonly Spell BarbarianGrimWard = new(13, "Grim Ward");
    public static readonly Spell BarbarianStun = new(14, "Stun");
    public static readonly Spell DruidFirestorm = new(15, "Firestorm");
    public static readonly Spell DruidFissure = new(16, "Fissure");
    public static readonly Spell DruidTornado = new(17, "Tornado");
    public static readonly Spell DruidTwister = new(18, "Twister");
    public static readonly Spell DruidVolcano = new(19, "Volcano");
    public static readonly Spell NecromancerAttraction = new(20, "Attraction");
    public static readonly Spell NecromancerBoneSpear = new(21, "Bone Spear");
    public static readonly Spell NecromancerBoneSpirit = new(22, "Bone Spirit");
    public static readonly Spell NecromancerConfusion = new(23, "Confusion");
    public static readonly Spell NecromancerDimVision = new(24, "Dim Vision");
    public static readonly Spell NecromancerLifeTap = new(25, "Life Tap");
    public static readonly Spell NecromancerLowerResist = new(26, "Lower Resist");
    public static readonly Spell NecromancerPoisonDagger = new(27, "Poison Dagger");
    public static readonly Spell NecromancerPoisonNova = new(28, "Poison Nova");
    public static readonly Spell NecromancerTeeth = new(29, "Teeth");
    public static readonly Spell NecromancerTerror = new(30, "Terror");
    public static readonly Spell NecromancerWeaken = new(31, "Weaken");
    public static readonly Spell PaladinBlessedHammer = new(32, "Blessed Hammer");
    public static readonly Spell PaladinHolyBolt = new(33, "Holy Bolt");
    public static readonly Spell PaladinSacrifice = new(34, "Sacrifice");
    public static readonly Spell PaladinVengeance = new(35, "Vengeance");
    public static readonly Spell PaladinZeal = new(36, "Zeal");
    public static readonly Spell SorceressBlizzard = new(37, "Blizzard");
    public static readonly Spell SorceressChargedBolt = new(38, "Charged Bolt");
    public static readonly Spell SorceressChainLightning = new(39, "Chain Lightning");
    public static readonly Spell SorceressEnchant = new(40, "Enchant");
    public static readonly Spell SorceressFireBall = new(41, "Fire Ball");
    public static readonly Spell SorceressFireBolt = new(42, "Fire Bolt");
    public static readonly Spell SorceressFrostNova = new(43, "Frost Nova");
    public static readonly Spell SorceressFrozenOrb = new(44, "Frozen Orb");
    public static readonly Spell SorceressGlacialSpike = new(45, "Glacial Spike");
    public static readonly Spell SorceressIceBlast = new(46, "Ice Blast");
    public static readonly Spell SorceressIceBolt = new(47, "Ice Bolt");
    public static readonly Spell SorceressLightning = new(48, "Lightning");
    public static readonly Spell SorceressMeteor = new(49, "Meteor");
    public static readonly Spell SorceressNova = new(50, "Nova");
    public static readonly Spell SorceressTelekinesis = new(51, "Telekinesis");
    public static readonly Spell SorceressTeleportation = new(52, "Teleportation");
}