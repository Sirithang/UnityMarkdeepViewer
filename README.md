# UnityMarkdeepViewer

**WIP : This is a bit hacky and prototypy**

Editor scripts allowing to display Markdown, markdeep and HMTL directly inside the Unity Editor

It use the internal Unity Webview (used for example by the AssetStore or the Collab windows) through reflexion.

It handles :

- HTML files (\*.html)
- Markdeep file (\*.md.html)
- Markdown file (\*.md)

Rendering is made with [Markdeep](https://casual-effects.com/markdeep/).

## Installation

Copy the MarkdeepViewer folder into your project.

## Usage

When you click on an .html, .md.html, .md file, a button appear on the Inspector to open it in the Markdeep viewer.
You can do that window, and the next file you open through the button will be open in that window.

## Styling

2 css are used by the system : `dark_style.css` and `light_style.css` in the folder `Markdeep/Plugins` 

## File format specification

Relative path works. E.g. `[Link to another file]("../other/files.md")`

### HTML

- HTML file are displayed as-is.
- If the HTML file don't have any stylesheet linked in the file, the default one will be injected before displaying

### Markdeep

- Markdeep are all file that finish by \*.md.html
- If the markdeep file don't have any stylesheet linked, the default one will be injected before displaying
- If you want to have 

### Markdown

- If a markdown file don't have a script tag linking to `markdeep.min.js` it will be injected when the page is displayed
- If there is no stylesheet linked to the file, the default one will be injected

## Known Issues

- Diagrams and files includes in Markdeep don't work, they break rendering of full file. if your file fail to render, check first that you don't have a diagrams or an include.

## TODO and possible improvement

- making a special marking (e.g. `$mdroot`) in a Markdeep file that link to the local markdeep folder to include the local offline markdeep file no matter where the markdeep file is.