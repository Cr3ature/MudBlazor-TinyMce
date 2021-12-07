using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace TinyMcePOC.Client.Pages.Components
{
    public partial class TextEditorComponent : MudDebouncedInput<string>
    {
        private readonly string _apiKey = "ts8ahgwtonepf070o23a2qc05j3tum8l2sj9eozleav2kywf";

        private readonly Guid _identifier = Guid.NewGuid();
        private Dictionary<string, object>? _editorConf;

        [Parameter] public bool Inline { get; set; }
        [Parameter] public string? Label { get; set; }

        protected override void OnInitialized()
        {
            _editorConf = new()
            {
                { "selector", $"div#{_identifier}" },
                { "menubar", false },
                { "plugins", "link lists image media code autoresize" },
                { "toolbar", "styleselect | forecolor backcolor | bold italic strikethrough subscript superscript underline | alignleft aligncenter alignright alignjustify | numlist bullist outdent indent | link image media | code" },
                { "height", 300 },
                { "autoresize_bottom_margin", 50 },
                { "media_live_embeds", true },
                { "toolbar_sticky", true },
                { "toolbar_sticky_offset", 64 },
            };
        }
    }
}