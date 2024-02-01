# PagerControlPolyfill

This is a polyfill for the [PagerControl control](https://github.com/microsoft/microsoft-ui-xaml/issues/60) that was [added in WinUI 2](https://github.com/microsoft/microsoft-ui-xaml/pull/3327) but has not yet been released in WinUI 3. 

The API is exactly the same as the WinUI 2 version. For the API please refer to https://learn.microsoft.com/en-us/windows/winui/api/microsoft.ui.xaml.controls.pagercontrol?view=winui-2.8-prerelease

## Installation
### Referencing the library
#### Using Git submodules
Add this repository as a submodule to your project. Then add a reference to the PagerControlPolyfill project in your solution.

To add the submodule, run the following command in your project's root directory:

* HTTPS: `git submodule add https://github.com/marcelwgn/PagerControlPolyfill.git`
* SSH: `git submodule add git@github.com:marcelwgn/PagerControlPolyfill.git`

#### NuGet
The package is available here: https://www.nuget.org/packages/PagerControlPolyfill/