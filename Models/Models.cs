using netlify_test_blazor_wasm.Models;
using System.Collections.Generic;

namespace netlify_test_blazor_wasm.Models
{
    public class Board
    {
        public string BoardName { get; set; } = string.Empty;
    }
    
    public class BoardItemContainer
    {
        public string BoardItemContainerName { get; set; } = string.Empty;
    }

    public class BoardCardItem
    {
        public string? CardName {get;set;}
        public string? CardDescription {get;set;}
        public bool IsEditing = false;
    }
}
