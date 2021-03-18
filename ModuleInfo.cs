using OrbitalShell.Component.Shell.Module;
using OrbitalShell.Lib;

/// <summary>
/// declare a shell module
/// </summary>
[assembly: ShellModule("OrbitalShell-Module-{ModuleCsID}")]
[assembly: ModuleTargetPlateform(TargetPlatform.Any)]
[assembly: ModuleShellMinVersion("{ModuleShellMinVersion}")]
[assembly: ModuleAuthors("{ModuleAuthors}")]
namespace OrbitalShell.Module.{ModuleCsID}
{
    public class ModuleInfo { }
}
