# FF Feud

**FF Feud** is a Family Feud style hosting helper for FINAL FANTASY XIV. It provides a comprehensive interface for game show hosts to manage questions, track scores, and output game states to chat with style.

## Features

*   **Question Database**: Manage a library of custom questions and answers.
*   **Host Control Panel**: A dedicated interface to reveal answers, track strikes, and manage the game flow.
*   **Team Scoring**: Built-in team scoring with automatic total calculations.
*   **Chat Integration**: Output reveals, scores, and game status directly to party, FC, or event chat channels with customizable templates.


## Installation

To install **FF Feud**, you can add the custom plugin repository to Dalamud in-game.

### 1. In-Game Installation (Recommended)
1. Open FINAL FANTASY XIV and type `/xlsettings` in your chat window to open the Dalamud Settings.
2. Navigate to the **Experimental** tab.
3. Scroll down to the **Custom Plugin Repositories** section.
4. Copy and paste the following URL into the empty slot:
   ```
   https://raw.githubusercontent.com/Tomok2404/TomokPlugins/main/pluginmaster.json
   ```
5. Click the **+** (Add) button and then click **Save and Close** at the bottom.
6. Open `/xlplugins` in chat, search for **FF Feud**, and click **Install**!

### 2. Developer / Manual Version (For Devs)
1. Build the plugin in your IDE or run `dotnet build`.
2. Open `/xlsettings` in-game and go to the **Experimental** tab.
3. Under **Dev Plugin Locations**, add the absolute path to your compiled `FFFeudPlugin.dll`.
4. Open `/xlplugins` and enable the plugin from the **Installed Dev Plugins** category.

## Usage
Use `/fffeud` to open the main host panel.

---


