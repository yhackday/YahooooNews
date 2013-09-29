// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of Entertainment_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class Entertainment_DetailViewModel : EntitiesBase.BindableBase, IViewModels.IEntertainment_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="Entertainment_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public Entertainment_DetailViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
		private EntitiesBase.RssSearchResult _currentRssSearchResult;

        /// <summary>
        /// CurrentRssSearchResult property.
        /// </summary>		
        public EntitiesBase.RssSearchResult CurrentRssSearchResult
        {
            get
            {
				return _currentRssSearchResult;
            }
            set
            {
                SetProperty(ref _currentRssSearchResult, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechEntertainment_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechEntertainment_DetailStaticControlCommandDelegate() 
        {
	
				_speechService.TextToSpeech(CurrentRssSearchResult.Title + " " + CurrentRssSearchResult.Content);
        }
		

        private ICommand _textToSpeechEntertainment_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechEntertainment_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechEntertainment_DetailStaticControlCommand
        {
            get { return _textToSpeechEntertainment_DetailStaticControlCommand = _textToSpeechEntertainment_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechEntertainment_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareEntertainment_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareEntertainment_DetailStaticControlCommandDelegate() 
        {
	
				_shareService.Share(CurrentRssSearchResult.Title,CurrentRssSearchResult.Summary, CurrentRssSearchResult.FeedUrl);
        }
		

        private ICommand _shareEntertainment_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareEntertainment_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareEntertainment_DetailStaticControlCommand
        {
            get { return _shareEntertainment_DetailStaticControlCommand = _shareEntertainment_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareEntertainment_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartEntertainment_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartEntertainment_DetailStaticControlCommandDelegate() 
        {
	
				_liveTileService.PinToStart(typeof(IViewModels.IEntertainment_DetailViewModel), CreateTileInfoEntertainment_DetailStaticControl());
        }
		

        private ICommand _pinToStartEntertainment_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartEntertainment_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartEntertainment_DetailStaticControlCommand
        {
            get { return _pinToStartEntertainment_DetailStaticControlCommand = _pinToStartEntertainment_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartEntertainment_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceEntertainment_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceEntertainment_DetailStaticControlCommandDelegate() 
        {
	
				_navigationService.NavigateTo(string.IsNullOrEmpty(CurrentRssSearchResult.FeedUrl) ? null : new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceEntertainment_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceEntertainment_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceEntertainment_DetailStaticControlCommand
        {
            get { return _goToSourceEntertainment_DetailStaticControlCommand = _goToSourceEntertainment_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(GoToSourceEntertainment_DetailStaticControlCommandDelegate); }
        }
		public object NavigationContext
        {
            set
            {              
                if (!(value is EntitiesBase.RssSearchResult)) { return; }
                
                CurrentRssSearchResult = value as EntitiesBase.RssSearchResult;
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the Entertainment_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoEntertainment_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentRssSearchResult.Title,
                Title = CurrentRssSearchResult.Title,
                BackTitle = CurrentRssSearchResult.Title,
                BackContent = CurrentRssSearchResult.Content,
                Count = 0,
                BackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                BackBackgroundImagePath = CurrentRssSearchResult.ImageUrl,
                LogoPath = "DoWApp-Logo.png"
            };
            return tileInfo;
        }
    }
}