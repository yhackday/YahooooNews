// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// Entertainment_Detail ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IEntertainment_DetailViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentRssSearchResult property.
        /// </summary>
		EntitiesBase.RssSearchResult CurrentRssSearchResult { get; set; }
        
        /// <summary>
        /// Gets the TextToSpeechEntertainment_DetailStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechEntertainment_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareEntertainment_DetailStaticControlCommand command.
        /// </summary>
		ICommand ShareEntertainment_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartEntertainment_DetailStaticControlCommand command.
        /// </summary>
		ICommand PinToStartEntertainment_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the GoToSourceEntertainment_DetailStaticControlCommand command.
        /// </summary>
		ICommand GoToSourceEntertainment_DetailStaticControlCommand { get; }

	}
}