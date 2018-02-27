# UnityMarkdeepViewer

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

## File format specification

### HTML

- HTML file are displayed as-is.
- If the HTML file don't have any stylesheet linked in the file, the default one will be injected before displaying

### Markdeep

- Markdeep are all file that finish by \*.md.html
- If the markdeep file don't have any stylesheet linked, the default one will be injected before displaying

### Markdown

- If a markdown file don't have a script tag linking to `markdeep.min.js` it will be injected when the page is displayed
- If there is no stylesheet linked to the file, the default one will be injected