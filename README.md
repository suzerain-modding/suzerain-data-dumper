# Suzerain Data Dumper

Suzerain Data Dumper is a mod that dumps game data into a JSON file. You can then use [Suzerain Data Viewer](https://github.com/suzerain-modding/suzerain-data-viewer) to inspect the data.

Suzerain Data Dumper is intended for modders to view technical details about existing content in the game. For more information about modding Suzerain, see [Suzerain Modding Kit](https://github.com/suzerain-modding/suzerain-modding-kit).

## Installation

Suzerain Data Dumper is built for Windows x64. It may run on Linux through Proton.

1. Follow Suzerain Modding Kit's [Installing Mods](https://suzerain-modding.github.io/suzerain-modding-kit/guides/user/installing-mods.html) guide to learn how to install mods.
2. Download Suzerain Data Dumper from [releases](https://github.com/suzerain-modding/suzerain-data-dumper/releases) and add it to your `Mods` folder as explained in the Installing Mods guide.

## Usage

1. Launch Suzerain and wait for the main menu to appear.
2. Press Ctrl+Shift+E to enable the overlay.
3. While the overlay is active:
    - Press Ctrl+Shift+E again to cancel.
    - Press Ctrl+E to dump entity data.
    - Press Ctrl+S to dump Sordland conversations.
    - Press Ctrl+R to dump Rizia conversations.
4. The file path of the generated JSON file will be printed to the MelonLoader console.
5. Use [Suzerain Data Viewer](https://github.com/suzerain-modding/suzerain-data-viewer) to generate a static HTML site based on the data for easy inspection.

## Building from Source

This contributor workflow is verified on Windows. Full builds require the game and
MelonLoader assemblies; Visual Studio is optional for command-line builds.

1. Install the .NET SDK version pinned in `global.json` (**10.0.402**) and keep the .NET 6
   Desktop Runtime required by MelonLoader installed. The SDK supplies the C# 12 compiler;
   the mod still targets `net6.0`.
2. Launch Suzerain with MelonLoader once to generate its interop assemblies, then close it.
3. If needed, copy `Directory.Build.local.props.example` to `Directory.Build.local.props`.
   The local file is ignored by Git. Set `GamePath` to your installation using an absolute path.
4. From the repository root, run:

```powershell
pwsh -NoProfile -File scripts/preflight.ps1
dotnet build -c Debug -p:Platform=x64
dotnet build -c Release -p:Platform=x64
```

Ordinary builds do not install the mod. Output defaults to
`artifacts/bin/SuzerainDataDumper/debug/` or `release/`; preflight prints the exact DLL path.
`ArtifactsPath`, `StagingPath`, and `DeploymentPath` can also be changed in the local file.
Staging defaults to `artifacts/staging/<Configuration>/<Platform>/`, and deployment defaults
to `$(GamePath)/Mods`. Command-line MSBuild properties override local settings.

To collect only the mod DLL and available PDB under a `Mods` subdirectory:

```powershell
dotnet build -c Debug -p:Platform=x64 -t:Stage
```

Close Suzerain, then install explicitly:

```powershell
dotnet build -c Debug -p:Platform=x64 -t:Deploy
```

`Deploy` builds and stages before copying the DLL and available PDB to `DeploymentPath`.
It does not copy Unity, game, or loader dependencies. Deployment can require additional
filesystem permission. Restricted shells may not see the game process, so verify that it
is closed yourself. Launch through Steam afterward and inspect the MelonLoader log.

The preflight checks SDK/runtime availability, all project reference paths, loader versions,
startup-log versions, and writable artifact/staging paths. Missing dependencies return a
nonzero exit code. Logs describe the last launch, not guaranteed current interop freshness.
Set `ExpectedGameVersion` locally if you want a version-mismatch warning for a specific build.

It does not build, launch, or deploy. Deployment write access is checked only when explicitly
requested with `-CheckDeploymentAccess`, which creates and removes a temporary file in that
directory. Other options are `-Configuration`, `-GamePath`, `-ArtifactsPath`, `-StagingPath`,
and `-DeploymentPath`.

For a restricted build shell, these process-local settings can avoid denied .NET first-run
and workload checks:

```powershell
$env:DOTNET_CLI_HOME = Join-Path (Get-Location) 'artifacts/dotnet-home'
$env:DOTNET_SKIP_FIRST_TIME_EXPERIENCE = '1'
$env:DOTNET_ADD_GLOBAL_TOOLS_TO_PATH = '0'
$env:DOTNET_GENERATE_ASPNET_CERTIFICATE = 'false'
$env:MSBuildEnableWorkloadResolver = 'false'
```

The preflight sets these in its own process; apply them in the build shell as well if needed.
NuGet downloads and deployment can still require separate access.

## Disclaimer

Suzerain Data Dumper is an unofficial, community-made tool for dumping Suzerain game data. It is not affiliated with, endorsed by, or sponsored by Torpor Games. Suzerain is the property of Torpor Games.
