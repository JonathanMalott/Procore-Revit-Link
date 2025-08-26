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

## Building
1. Open the Visual Basic project in Visual Studio.
2. Build the add‑in (Debug or Release).
3. Copy the resulting **DLL** and accompanying **.addin** file to
   `%APPDATA%\Autodesk\Revit\Addins\2023`.
4. Launch Revit. The add‑in loads and shows a sidebar with procore.com.

## Working with OpenAI Codex
When asking Codex for help, mention that this is a Visual Basic .NET plugin for Revit 2023
that adds a dockable pane with a WebView.  Codex can then provide code snippets or
examples in the appropriate language and API context.

