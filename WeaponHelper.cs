namespace SimpleGunMenuPlugin;

public partial class SimpleGunMenuPlugin
{
    public class Weapon
    {
        public Weapon(string giveName)
        {
            GiveName = giveName;
        }

        public string GiveName { get; set; }
    }

    private static class WeaponHelper
    {
        internal static (Dictionary<string, Weapon> Weapons, Dictionary<string, Weapon> WeaponCheckers) LoadWeapons()
        {
            var weapons = new Dictionary<string, Weapon>(StringComparer.InvariantCultureIgnoreCase)
            {
                {"Glock-18",                           new("weapon_glock")},
                {"P2000",                              new("weapon_hkp2000")},
                {"USP-S",                              new("weapon_usp_silencer")},
                {"Tec-9",                              new("weapon_tec9")},
                {"P250",                               new("weapon_p250")},
                {"CZ75-Auto",                          new("weapon_cz75a")},
                {"Dual Berettas",                      new("weapon_elite")},
                {"Five-SeveN",                         new("weapon_fiveseven")},
                {"R8 Revolver",                        new("weapon_revolver")},
                {"Desert Eagle",                       new("weapon_deagle")},
            };

            ///Duplicates of weapons dictionarys value objects givename property.
            ///<see cref="MenuHelper.RemoveCurrentWeapon"/>
            var weaponCheckers = new Dictionary<string, Weapon>(StringComparer.InvariantCultureIgnoreCase)
            {

                {"weapon_glock",                       new("weapon_glock")},
                {"weapon_hkp2000",                     new("weapon_hkp2000")},
                {"weapon_usp_silencer",                new("weapon_usp_silencer")},
                {"weapon_tec9",                        new("weapon_tec9")},
                {"weapon_p250",                        new("weapon_p250")},
                {"weapon_cz75a",                       new("weapon_cz75a")},
                {"weapon_fiveseven",                   new("weapon_fiveseven")},
                {"weapon_elite",                       new("weapon_elite")},
                {"weapon_revolver",                    new("weapon_revolver")},
                {"Desert Eagle",                       new("weapon_deagle")},
            };
            return (weapons, weaponCheckers);
        }
    }
}
