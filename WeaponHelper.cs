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
                {"格洛克",                           new("weapon_glock")},
                {"P2000",                            new("weapon_hkp2000")},
                {"USP",                              new("weapon_usp_silencer")},
                {"Tec9",                             new("weapon_tec9")},
                {"P250",                             new("weapon_p250")},
                {"CZ75",                             new("weapon_cz75a")},
                {"双枪",                             new("weapon_elite")},
                {"FN57",                             new("weapon_fiveseven")},
                {"R8",                               new("weapon_revolver")},
                {"沙鹰",                             new("weapon_deagle")},
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
                {"weapon_deagle",                      new("weapon_deagle")},
            };
            return (weapons, weaponCheckers);
        }
    }
}
