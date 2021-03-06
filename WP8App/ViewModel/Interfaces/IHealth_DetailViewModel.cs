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
    /// Health_Detail ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IHealth_DetailViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentRssSearchResult property.
        /// </summary>
		EntitiesBase.RssSearchResult CurrentRssSearchResult { get; set; }
        
        /// <summary>
        /// Gets the TextToSpeechHealth_DetailStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechHealth_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareHealth_DetailStaticControlCommand command.
        /// </summary>
		ICommand ShareHealth_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartHealth_DetailStaticControlCommand command.
        /// </summary>
		ICommand PinToStartHealth_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the GoToSourceHealth_DetailStaticControlCommand command.
        /// </summary>
		ICommand GoToSourceHealth_DetailStaticControlCommand { get; }

	}
}
