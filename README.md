# Suzerain Data Dumper

Suzerain Data Dumper is a mod that dumps game data into a JSON file. You can then use [Suzerain Data Viewer](https://github.com/suzerain-modding/suzerain-data-viewer) to inspect the data.

Suzerain Data Dumper is intended for modders to view technical details about existing content in the game. For more information about modding Suzerain, see [Suzerain Modding Kit](https://github.com/suzerain-modding/suzerain-modding-kit).

## Installation

1. Follow Suzerain Modding Kit's Installing Mods guide (TODO: link SMK installing mods guide) to learn how to install mods.
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

## Disclaimer

Suzerain Data Dumper is an unofficial, community-made tool for dumping Suzerain game data. It is not affiliated with, endorsed by, or sponsored by Torpor Games. Suzerain is the property of Torpor Games.
