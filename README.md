# UnityMarkdeepViewer

# DEPRECATED 

This was using the old Webview in the Unity editor which was removed in more recent version, so this won't work in more
recent Unity version. Keeping this here as reference.

## Readme

**WIP : This is a bit hacky and prototypy**

Editor scripts allowing to display Markdown, Markdeep and HMTL directly inside the Unity Editor

It use the internal Unity Webview (used for example by the AssetStore or the Collab windows) recreated through reflection.

It handles :

- HTML files (\*.html)
- Markdeep file (\*.md.html)
- Markdown file (\*.md)

Rendering is made with [Markdeep](https://casual-effects.com/markdeep/).

## Installation

There is 2 way to use the tool :

### Multiple files

Copy the MarkdeepViewer folder into your project.

### Single File install

To make it less invasive and easier to embed in other project, a single file version is available in the root of that project or
through the release of the github page.

Just **copy the MarkdeepViewerSingleFile.cs file into an Editor folder anywhere in your project or package**

The single file version is just the 2 C# files of the editor window copied into a single one, and the markdeep and css files stored
as string in that file class.

**At runtime, the tool will create the 3 files in the Library folder so they can be referenced when the tool create the javascript to render**

It is build through an editor script. The file CreateSingleFileVersion in MarkdeepViewer/Editor take care of creating it through
a menu in the Unity editor.

## Usage

When you click on an .html, .md.html, .md file, a button appear on the Inspector to open it in the Markdeep viewer.
You can dock that window, and the next file you open through the button will be open in that window instead of a new one.

## Styling

2 css are used by the system : `dark_style.css` and `light_style.css` in the folder `Markdeep/Plugins`

## File format specification

Relative path works. E.g. `[Link to another file]("../other/files.md")`

### HTML

- HTML file are displayed as-is.
- If the HTML file don't have any stylesheet, the default one will be added before displaying

### Markdeep

- Markdeep are all file that finish by \*.md.html
- If the markdeep file don't have any stylesheet, the default one will be added before displaying
- If the Markdeep file don't include the Markdeep `markdeep.min.js` script, it will be added before displaying

### Markdown

- If a markdown file don't have a script tag linking to `markdeep.min.js` it will be injected when the page is displayed
- If there is no stylesheet linked to the file, the default one will be injected

## Known Issues and Limitations

- Diagrams and files includes in Markdeep don't work, they break rendering of full file. if your file fail to render, check first that you don't have a diagrams or an include.

## TODO and possible improvement

- Making a special marking (e.g. `$mdroot`) in a Markdeep file that link to the local markdeep folder (or the one in Library folder for single file install) so users can include the local offline markdeep
file no matter where the rendered file is in the project folder (and support being moved around).
