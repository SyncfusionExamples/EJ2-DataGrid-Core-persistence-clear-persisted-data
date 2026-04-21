
# ASP.NET Core EJ2 DataGrid – Clear Persistence on Page Refresh

This repository contains a sample ASP.NET Core application that demonstrates clearing persisted state data of a Syncfusion EJ2 DataGrid when a page refresh is triggered. The sample focuses on disabling grid persistence, removing stored values from browser local storage, and reloading the grid with a clean state.

## Project Overview

The Syncfusion EJ2 Grid supports state persistence using browser local storage. This feature retains paging, sorting, and filtering states across reloads. In certain scenarios, the persisted state must be reset manually. This project illustrates clearing the stored grid state at runtime using JavaScript and a custom refresh button.

The implementation uses an ASP.NET Core Razor view with an EJ2 Grid bound to a server-side data source. A refresh button is provided to reset the grid state and reload the page without retaining any previous configuration.

## Features

- ASP.NET Core Razor-based EJ2 Grid
- Grid persistence enabled by default
- Manual reset of persisted grid data
- Browser local storage cleanup using JavaScript
- Page reload with a fresh grid state

## Prerequisites

- Visual Studio 2022
- .NET SDK compatible with ASP.NET Core
- Syncfusion EJ2 ASP.NET Core packages

## Implementation Details

When the **Refresh page** button is clicked, the grid instance is accessed through JavaScript. Persistence is disabled, the grid-related local storage key is cleared, the grid instance is destroyed, and the page is reloaded. This process ensures that no previously saved grid state is applied.

## Running the Project

1. Clone or download this repository to your local machine.
    ```
    git clone <repo_link>
    ```
2. Open the solution file in Visual Studio 2022.
3. Restore NuGet packages by rebuilding the solution.
4. Run the project and interact with the grid.
5. Use the **Refresh page** button to clear persisted grid data.

## Reference

- Related forum discussion: https://www.syncfusion.com/forums/148167/how-to-disable-persistence-from-javascript
- [Getting started with ASP.NET CORE Grid](https://ej2.syncfusion.com/aspnetcore/documentation/grid/getting-started-core) 
- [State Management](https://ej2.syncfusion.com/aspnetcore/documentation/grid/state-management)
- [API Reference](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.grids.grid.html)

