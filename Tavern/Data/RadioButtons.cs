using Microsoft.AspNetCore.Components;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

public class RadioButtons : ComponentBase
{

    [Inject]
    public ProtectedLocalStorage localSetting { get; set; } = default!;

    public string selected { get; private set; } = "deselected";

    protected override async Task OnInitializedAsync() {
        var result = await localSetting.GetAsync<string>("radioButtonSelection");
        selected = result.Success ? result.Value : null;
    }

    public async Task onSelectionChanged(string value) {
        if (selected == value)
        {
            selected = null;
        }
        else
        {
            selected = value;
        }

        await localSetting.SetAsync("radioButtonSelection", selected);

        StateHasChanged();
    }

    public bool isChecked(string value) => value == selected;
}