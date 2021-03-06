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
    /// Implementation of AllNews_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class AllNews_DetailViewModel : EntitiesBase.BindableBase, IViewModels.IAllNews_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AllNews_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public AllNews_DetailViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
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
        /// Delegate method for the TextToSpeechAllNews_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechAllNews_DetailStaticControlCommandDelegate() 
        {
	
				_speechService.TextToSpeech(CurrentRssSearchResult.Title + " " + CurrentRssSearchResult.Content);
        }
		

        private ICommand _textToSpeechAllNews_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechAllNews_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechAllNews_DetailStaticControlCommand
        {
            get { return _textToSpeechAllNews_DetailStaticControlCommand = _textToSpeechAllNews_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechAllNews_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareAllNews_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareAllNews_DetailStaticControlCommandDelegate() 
        {
	
				_shareService.Share(CurrentRssSearchResult.Title,CurrentRssSearchResult.Summary, CurrentRssSearchResult.FeedUrl);
        }
		

        private ICommand _shareAllNews_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareAllNews_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareAllNews_DetailStaticControlCommand
        {
            get { return _shareAllNews_DetailStaticControlCommand = _shareAllNews_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareAllNews_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartAllNews_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartAllNews_DetailStaticControlCommandDelegate() 
        {
	
				_liveTileService.PinToStart(typeof(IViewModels.IAllNews_DetailViewModel), CreateTileInfoAllNews_DetailStaticControl());
        }
		

        private ICommand _pinToStartAllNews_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartAllNews_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartAllNews_DetailStaticControlCommand
        {
            get { return _pinToStartAllNews_DetailStaticControlCommand = _pinToStartAllNews_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartAllNews_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the GoToSourceAllNews_DetailStaticControlCommand command.
        /// </summary>
        public  void GoToSourceAllNews_DetailStaticControlCommandDelegate() 
        {
	
				_navigationService.NavigateTo(string.IsNullOrEmpty(CurrentRssSearchResult.FeedUrl) ? null : new Uri(CurrentRssSearchResult.FeedUrl));
        }
		

        private ICommand _goToSourceAllNews_DetailStaticControlCommand;

        /// <summary>
        /// Gets the GoToSourceAllNews_DetailStaticControlCommand command.
        /// </summary>
        public ICommand GoToSourceAllNews_DetailStaticControlCommand
        {
            get { return _goToSourceAllNews_DetailStaticControlCommand = _goToSourceAllNews_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(GoToSourceAllNews_DetailStaticControlCommandDelegate); }
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
        /// Initializes a <see cref="Services.TileInfo" /> object for the AllNews_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoAllNews_DetailStaticControl()
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
