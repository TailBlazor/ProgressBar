using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace TailBlazor.ProgressBar
{
    public partial class TailBlazorProgressBar
    {
        [Parameter] public string Class { get; set; } = "rounded bg-gradient-to-br animate-pulse from-purple-500 to-red-600";
        [Parameter] public int Percentage { get; set; } = 50;
        [Parameter] public int Height { get; set; } = 2;
        [Parameter] public string BackgroundClass { get; set; } = "bg-gray-100 rounded";

        private int _percentage = 50;

        protected override void OnInitialized() {
            _percentage = Percentage > 100 ? 100 : Percentage < 0 ? 0 : Percentage;
            StateHasChanged();
        }
    }
}
