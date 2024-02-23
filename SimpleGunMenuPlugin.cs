using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Menu;
using CounterStrikeSharp.API.Modules.Utils;

namespace SimpleGunMenuPlugin;

public partial class SimpleGunMenuPlugin : BasePlugin
{
    public override string ModuleName => "PistolsGunMenu";
    public override string ModuleVersion => "0.0.2";
    public override string ModuleAuthor => "Constummer & himeneko";
    public override string ModuleDescription => "Pistols Gun Menu Plugin";

    public override void Load(bool hotReload)
    {
    }
    
    [ConsoleCommand("gun")]
    [ConsoleCommand("guns")]
    [ConsoleCommand("pistols")]
    [ConsoleCommand("secondary")]
    public void Pistols(CCSPlayerController? player, CommandInfo info)
    {
        if (ValidatePlayer(player) == false)
        {
            return;
        }

        var gunMenu = new ChatMenu($"{info.GetCommandString.Split(" ")[0]} Menu");
        MenuHelper.GetGuns(gunMenu);
        ChatMenus.OpenMenu(player, gunMenu);
    }

    private static bool ValidatePlayer(CCSPlayerController? player)
    {
        if (player == null || player.IsBot || !player.IsValid)
        {
            return false;
        }

        if (player.PawnIsAlive == false)
        {
            player.PrintToChat("Only alive players can call this command");
            return false;
        }

        if(player.Team == CsTeam.Spectator) return false;
        if(player.Team == CsTeam.None) return false;
        
        return true;
    }
}
