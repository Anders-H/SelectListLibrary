# SelectListLibrary

The SelectListLibrary holds controls (currently one) for letting a user select *one* item from a list. Uses Windows Forms in .NET 6.0.

Install: `Install-Package SelectListLibrary`

The **SelectList** is based on the ListView control, with the following changes:

 - `MultiSelect` is removed, always false
 - `FullRowSelect` is removed, always true
 - The `SelectedItems` list is replaced by the `SelectedItem` property
 - A new `ItemSelected` event is added
 
