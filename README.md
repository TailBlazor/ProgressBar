# TailBlazor.ProgressBar

Blazor ProgressBar using tailwindcss

A beautiful tailwindcss progress bar that offers easy customization through tailwind's classes.

![Nuget](https://img.shields.io/nuget/v/TailBlazor.ProgressBar.svg)

![Demo](screenshot.gif)

## Getting Setup

You can install the package via the NuGet package manager just search for TailBlazor.ProgressBar. You can also install via powershell using the following command.

`Install-Package TailBlazor.ProgressBar`

Or via the dotnet CLI.

`dotnet add package TailBlazor.ProgressBar`

### 1. Add Imports

Add line to your \_Imports.razor

```
@using TailBlazor.ProgressBar
```

### 2. Create your Progress Bar

by default everything is already configured for a medium sized progress bar.

```
<TailBlazorProgressBar />
```

### 3. Customize styles

We give you tons of options to customize just about everything. The table below outlines the parameters you can set.

Parameter | Default Value
--- | ---
`BackgroundClass` | `bg-gray-100 rounded`
`Class` | `rounded bg-gradient-to-br animate-pulse from-purple-500 to-red-600`
`Height` | `2`
`Percentage` |  `50`


```
<TailBlazorProgressBar Percentage=85 BackgroundClass="bg-gradient-to-br from-indigo-400 to-red-300 rounded-full" class="bg-gray-300 opacity-40 rounded-md" Height=3 />
```

Using animation-pulse on the `class` parameter brings the bar into focus for the user.

### 4. Adjusting progress

Pass an int from 0-100 into the `Percentage` parameter to have it automatically update it's position. Adjust this percentage on the fly to have it update in real time.