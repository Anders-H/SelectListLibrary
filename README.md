# SelectListLibrary

The SelectListLibrary holds controls (currently one) for letting a user select *one* item from a list. Uses Windows Forms in .NET 8.0.

Install:

```Install-Package SelectListLibrary```

## Features

- An enhanced ListView control for single selection.
- A prompt dialog for selecting an item from a list.

The `SelectList` is based on the `ListView` control, with the following changes:

 - `MultiSelect` is removed, always false
 - `FullRowSelect` is removed, always true
 - The `SelectedItems` list is replaced by the `SelectedItem` property
 - A new `ItemSelected` event is added

The `Prompt` class provides an `Ask` method to show a dialog with a list, allowing the user to select an item.
