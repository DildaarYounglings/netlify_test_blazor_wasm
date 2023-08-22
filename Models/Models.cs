using netlify_test_blazor_wasm.Models;
using System.Collections.Generic;

namespace netlify_test_blazor_wasm.Models
{
    public class Board
    {
        public string BoardName { get; set; } = string.Empty;
        public List<BoardCardContainer> CardContainers = new();
        public bool IsCreatingCategory = false;
    }
    
    public class BoardCardContainer
    {
        public string BoardCardContainerName { get; set; } = string.Empty;
        public List<BoardCard> Cards = new();
        public bool IsCreatingCard = false;
        public bool isEditing = false;
        
    }

    public class BoardCard
    {
        public string? CardName {get;set;}
        public string? CardDescription {get;set;}
        public bool isEditing = false;
    }
}
