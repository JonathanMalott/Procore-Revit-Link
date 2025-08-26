# Procore Revit Link

This repository describes a simple Autodesk Revit 2023 add‑in written in **Visual Basic .NET**.  
When the add‑in is loaded, it creates a dockable sidebar containing a WebView that displays [procore.com](https://www.procore.com/).

The project is intended as a minimal example for experimenting with the Revit API and for
future conversations with OpenAI Codex about building or extending Revit plug‑ins.

## Requirements
- Autodesk Revit 2023
- Visual Studio 2022 or later
- .NET Framework 4.8
- Revit 2023 SDK (provides references and templates)

## Building and Loading in Revit
1. Clone or download this repository.
2. Open `ProcoreRevitLink.vbproj` in **Visual Studio 2022** (with the Revit 2023 SDK installed).
3. Build the project via **Build ➜ Build ProcoreRevitLink** (Debug or Release).
4. Copy the compiled `ProcoreRevitLink.dll` from `bin/<Configuration>` and the `ProcoreRevitLink.addin` manifest to `%APPDATA%\Autodesk\Revit\Addins\2023` (e.g. `C:\Users\<User>\AppData\Roaming\Autodesk\Revit\Addins\2023`).
5. Launch Revit 2023.
6. If the dockable pane is not visible, enable it from **View ➜ User Interface ➜ Procore**.

## Working with OpenAI Codex
When asking Codex for help, mention that this is a Visual Basic .NET plugin for Revit 2023
that adds a dockable pane with a WebView.  Codex can then provide code snippets or
examples in the appropriate language and API context.

