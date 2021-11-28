using System.ComponentModel;

namespace GameSearchApi.Models.Enums
{
    public enum SearchTypes
    {
        [Description("GameSearch")]
        GameSearch,
        
        [Description("GenreSearch")]
        GenreSearch,
        
        [Description("DeveloperSearch")]
        DeveloperSearch,
        
        [Description("PlatformSearch")]
        PlatformSearch,
        
        [Description("TitleSearch")]
        TitleSearch,
        
        [Description("ReleaseYearSearch")]
        ReleaseYearSearch,
        
        [Description("GiveMeAGame")]
        GiveMeAGame
    }
}