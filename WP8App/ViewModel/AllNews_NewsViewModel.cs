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
    /// Implementation of AllNews_News ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class AllNews_NewsViewModel : EntitiesBase.BindableBase, IViewModels.IAllNews_NewsViewModel
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ILockScreenService _lockScreenService;
		private readonly Repositories.IAllNews_RSS _allNews_RSS;
		private readonly Repositories.IBusiness_YahooBusiness _business_YahooBusiness;
		private readonly Repositories.ICelebrities_CelebritiesRSS _celebrities_CelebritiesRSS;
		private readonly Repositories.IEntertainment_EntertainmentRSS _entertainment_EntertainmentRSS;
		private readonly Repositories.IHealth_HealthRSS _health_HealthRSS;
		private readonly Repositories.IMedia_MediaRSS _media_MediaRSS;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AllNews_NewsViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="lockScreenService">The Lock Screen Service.</param>
        /// <param name="allNews_RSS">The All News_ R S S.</param>
        /// <param name="business_YahooBusiness">The Business_ Yahoo Business.</param>
        /// <param name="celebrities_CelebritiesRSS">The Celebrities_ Celebrities R S S.</param>
        /// <param name="entertainment_EntertainmentRSS">The Entertainment_ Entertainment R S S.</param>
        /// <param name="health_HealthRSS">The Health_ Health R S S.</param>
        /// <param name="media_MediaRSS">The Media_ Media R S S.</param>
        public AllNews_NewsViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ILockScreenService lockScreenService, Repositories.IAllNews_RSS allNews_RSS, Repositories.IBusiness_YahooBusiness business_YahooBusiness, Repositories.ICelebrities_CelebritiesRSS celebrities_CelebritiesRSS, Repositories.IEntertainment_EntertainmentRSS entertainment_EntertainmentRSS, Repositories.IHealth_HealthRSS health_HealthRSS, Repositories.IMedia_MediaRSS media_MediaRSS)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_lockScreenService = lockScreenService;
			_allNews_RSS = allNews_RSS;
			_business_YahooBusiness = business_YahooBusiness;
			_celebrities_CelebritiesRSS = celebrities_CelebritiesRSS;
			_entertainment_EntertainmentRSS = entertainment_EntertainmentRSS;
			_health_HealthRSS = health_HealthRSS;
			_media_MediaRSS = media_MediaRSS;
        }
		
		private ObservableCollection<EntitiesBase.RssSearchResult> _allNews_NewsListControlCollection;

        /// <summary>
        /// AllNews_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> AllNews_NewsListControlCollection
        {
            get
            {
                if(_allNews_NewsListControlCollection == null)
					RefreshAllNews_NewsListControlCollectionDelegate();
				return _allNews_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _allNews_NewsListControlCollection, value);
            }
        }
		private EntitiesBase.RssSearchResult _selectedAllNews_NewsListControlCollection;

        /// <summary>
        /// SelectedAllNews_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedAllNews_NewsListControlCollection
        {
            get
            {
				return _selectedAllNews_NewsListControlCollection;
            }
            set
            {
                _selectedAllNews_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IAllNews_DetailViewModel>(_selectedAllNews_NewsListControlCollection);
            }
        }
		private ObservableCollection<EntitiesBase.RssSearchResult> _business_NewsListControlCollection;

        /// <summary>
        /// Business_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> Business_NewsListControlCollection
        {
            get
            {
                if(_business_NewsListControlCollection == null)
					RefreshBusiness_NewsListControlCollectionDelegate();
				return _business_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _business_NewsListControlCollection, value);
            }
        }
		private EntitiesBase.RssSearchResult _selectedBusiness_NewsListControlCollection;

        /// <summary>
        /// SelectedBusiness_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedBusiness_NewsListControlCollection
        {
            get
            {
				return _selectedBusiness_NewsListControlCollection;
            }
            set
            {
                _selectedBusiness_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IBusiness_DetailViewModel>(_selectedBusiness_NewsListControlCollection);
            }
        }
		private ObservableCollection<EntitiesBase.RssSearchResult> _celebrities_NewsListControlCollection;

        /// <summary>
        /// Celebrities_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> Celebrities_NewsListControlCollection
        {
            get
            {
                if(_celebrities_NewsListControlCollection == null)
					RefreshCelebrities_NewsListControlCollectionDelegate();
				return _celebrities_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _celebrities_NewsListControlCollection, value);
            }
        }
		private EntitiesBase.RssSearchResult _selectedCelebrities_NewsListControlCollection;

        /// <summary>
        /// SelectedCelebrities_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedCelebrities_NewsListControlCollection
        {
            get
            {
				return _selectedCelebrities_NewsListControlCollection;
            }
            set
            {
                _selectedCelebrities_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.ICelebrities_EntertainmentViewModel>(_selectedCelebrities_NewsListControlCollection);
            }
        }
		private ObservableCollection<EntitiesBase.RssSearchResult> _entertainment_NewsListControlCollection;

        /// <summary>
        /// Entertainment_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> Entertainment_NewsListControlCollection
        {
            get
            {
                if(_entertainment_NewsListControlCollection == null)
					RefreshEntertainment_NewsListControlCollectionDelegate();
				return _entertainment_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _entertainment_NewsListControlCollection, value);
            }
        }
		private EntitiesBase.RssSearchResult _selectedEntertainment_NewsListControlCollection;

        /// <summary>
        /// SelectedEntertainment_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedEntertainment_NewsListControlCollection
        {
            get
            {
				return _selectedEntertainment_NewsListControlCollection;
            }
            set
            {
                _selectedEntertainment_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IEntertainment_DetailViewModel>(_selectedEntertainment_NewsListControlCollection);
            }
        }
		private ObservableCollection<EntitiesBase.RssSearchResult> _health_NewsListControlCollection;

        /// <summary>
        /// Health_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> Health_NewsListControlCollection
        {
            get
            {
                if(_health_NewsListControlCollection == null)
					RefreshHealth_NewsListControlCollectionDelegate();
				return _health_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _health_NewsListControlCollection, value);
            }
        }
		private EntitiesBase.RssSearchResult _selectedHealth_NewsListControlCollection;

        /// <summary>
        /// SelectedHealth_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedHealth_NewsListControlCollection
        {
            get
            {
				return _selectedHealth_NewsListControlCollection;
            }
            set
            {
                _selectedHealth_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IHealth_DetailViewModel>(_selectedHealth_NewsListControlCollection);
            }
        }
		private ObservableCollection<EntitiesBase.RssSearchResult> _media_NewsListControlCollection;

        /// <summary>
        /// Media_NewsListControlCollection property.
        /// </summary>		
        public ObservableCollection<EntitiesBase.RssSearchResult> Media_NewsListControlCollection
        {
            get
            {
                if(_media_NewsListControlCollection == null)
					RefreshMedia_NewsListControlCollectionDelegate();
				return _media_NewsListControlCollection;     
            }
            set
            {
                SetProperty(ref _media_NewsListControlCollection, value);
            }
        }
		private EntitiesBase.RssSearchResult _selectedMedia_NewsListControlCollection;

        /// <summary>
        /// SelectedMedia_NewsListControlCollection property.
        /// </summary>		
        public EntitiesBase.RssSearchResult SelectedMedia_NewsListControlCollection
        {
            get
            {
				return _selectedMedia_NewsListControlCollection;
            }
            set
            {
                _selectedMedia_NewsListControlCollection = value;
                if (value != null)
                    _navigationService.NavigateTo<IViewModels.IMedia_DetailViewModel>(_selectedMedia_NewsListControlCollection);
            }
        }

        /// <summary>
        /// Delegate method for the RefreshAllNews_NewsListControlCollection command.
        /// </summary>
        public async void RefreshAllNews_NewsListControlCollectionDelegate(int pageNumber= 0) 
        {
			try
			{
				LoadingAllNews_NewsListControlCollection = true;
	
				AllNews_NewsListControlCollection = await _allNews_RSS.GetData();
			}
            catch (Exception ex)
            {
				AllNews_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingAllNews_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingAllNews_NewsListControlCollection;
		
        public bool LoadingAllNews_NewsListControlCollection
        {
            get { return _loadingAllNews_NewsListControlCollection; }
            set { SetProperty(ref _loadingAllNews_NewsListControlCollection, value); }
        }

        private ICommand _refreshAllNews_NewsListControlCollection;

        /// <summary>
        /// Gets the RefreshAllNews_NewsListControlCollection command.
        /// </summary>
        public ICommand RefreshAllNews_NewsListControlCollection
        {
            get { return _refreshAllNews_NewsListControlCollection = _refreshAllNews_NewsListControlCollection ?? new ViewModelsBase.DelegateCommand<int>(RefreshAllNews_NewsListControlCollectionDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshBusiness_NewsListControlCollection command.
        /// </summary>
        public async void RefreshBusiness_NewsListControlCollectionDelegate(int pageNumber= 0) 
        {
			try
			{
				LoadingBusiness_NewsListControlCollection = true;
	
				Business_NewsListControlCollection = await _business_YahooBusiness.GetData();
			}
            catch (Exception ex)
            {
				Business_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingBusiness_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingBusiness_NewsListControlCollection;
		
        public bool LoadingBusiness_NewsListControlCollection
        {
            get { return _loadingBusiness_NewsListControlCollection; }
            set { SetProperty(ref _loadingBusiness_NewsListControlCollection, value); }
        }

        private ICommand _refreshBusiness_NewsListControlCollection;

        /// <summary>
        /// Gets the RefreshBusiness_NewsListControlCollection command.
        /// </summary>
        public ICommand RefreshBusiness_NewsListControlCollection
        {
            get { return _refreshBusiness_NewsListControlCollection = _refreshBusiness_NewsListControlCollection ?? new ViewModelsBase.DelegateCommand<int>(RefreshBusiness_NewsListControlCollectionDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshCelebrities_NewsListControlCollection command.
        /// </summary>
        public async void RefreshCelebrities_NewsListControlCollectionDelegate(int pageNumber= 0) 
        {
			try
			{
				LoadingCelebrities_NewsListControlCollection = true;
	
				Celebrities_NewsListControlCollection = await _celebrities_CelebritiesRSS.GetData();
			}
            catch (Exception ex)
            {
				Celebrities_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingCelebrities_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingCelebrities_NewsListControlCollection;
		
        public bool LoadingCelebrities_NewsListControlCollection
        {
            get { return _loadingCelebrities_NewsListControlCollection; }
            set { SetProperty(ref _loadingCelebrities_NewsListControlCollection, value); }
        }

        private ICommand _refreshCelebrities_NewsListControlCollection;

        /// <summary>
        /// Gets the RefreshCelebrities_NewsListControlCollection command.
        /// </summary>
        public ICommand RefreshCelebrities_NewsListControlCollection
        {
            get { return _refreshCelebrities_NewsListControlCollection = _refreshCelebrities_NewsListControlCollection ?? new ViewModelsBase.DelegateCommand<int>(RefreshCelebrities_NewsListControlCollectionDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshEntertainment_NewsListControlCollection command.
        /// </summary>
        public async void RefreshEntertainment_NewsListControlCollectionDelegate(int pageNumber= 0) 
        {
			try
			{
				LoadingEntertainment_NewsListControlCollection = true;
	
				Entertainment_NewsListControlCollection = await _entertainment_EntertainmentRSS.GetData();
			}
            catch (Exception ex)
            {
				Entertainment_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingEntertainment_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingEntertainment_NewsListControlCollection;
		
        public bool LoadingEntertainment_NewsListControlCollection
        {
            get { return _loadingEntertainment_NewsListControlCollection; }
            set { SetProperty(ref _loadingEntertainment_NewsListControlCollection, value); }
        }

        private ICommand _refreshEntertainment_NewsListControlCollection;

        /// <summary>
        /// Gets the RefreshEntertainment_NewsListControlCollection command.
        /// </summary>
        public ICommand RefreshEntertainment_NewsListControlCollection
        {
            get { return _refreshEntertainment_NewsListControlCollection = _refreshEntertainment_NewsListControlCollection ?? new ViewModelsBase.DelegateCommand<int>(RefreshEntertainment_NewsListControlCollectionDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshHealth_NewsListControlCollection command.
        /// </summary>
        public async void RefreshHealth_NewsListControlCollectionDelegate(int pageNumber= 0) 
        {
			try
			{
				LoadingHealth_NewsListControlCollection = true;
	
				Health_NewsListControlCollection = await _health_HealthRSS.GetData();
			}
            catch (Exception ex)
            {
				Health_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingHealth_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingHealth_NewsListControlCollection;
		
        public bool LoadingHealth_NewsListControlCollection
        {
            get { return _loadingHealth_NewsListControlCollection; }
            set { SetProperty(ref _loadingHealth_NewsListControlCollection, value); }
        }

        private ICommand _refreshHealth_NewsListControlCollection;

        /// <summary>
        /// Gets the RefreshHealth_NewsListControlCollection command.
        /// </summary>
        public ICommand RefreshHealth_NewsListControlCollection
        {
            get { return _refreshHealth_NewsListControlCollection = _refreshHealth_NewsListControlCollection ?? new ViewModelsBase.DelegateCommand<int>(RefreshHealth_NewsListControlCollectionDelegate); }
        }

        /// <summary>
        /// Delegate method for the RefreshMedia_NewsListControlCollection command.
        /// </summary>
        public async void RefreshMedia_NewsListControlCollectionDelegate(int pageNumber= 0) 
        {
			try
			{
				LoadingMedia_NewsListControlCollection = true;
	
				Media_NewsListControlCollection = await _media_MediaRSS.GetData();
			}
            catch (Exception ex)
            {
				Media_NewsListControlCollection = null;
		
                Debug.WriteLine(ex.ToString());
                _dialogService.Show(Localization.AppResources.rssError + Environment.NewLine + Localization.AppResources.TryAgain);
            }
            finally
            {
				LoadingMedia_NewsListControlCollection = false;
			}
        }
		
		
        private bool _loadingMedia_NewsListControlCollection;
		
        public bool LoadingMedia_NewsListControlCollection
        {
            get { return _loadingMedia_NewsListControlCollection; }
            set { SetProperty(ref _loadingMedia_NewsListControlCollection, value); }
        }

        private ICommand _refreshMedia_NewsListControlCollection;

        /// <summary>
        /// Gets the RefreshMedia_NewsListControlCollection command.
        /// </summary>
        public ICommand RefreshMedia_NewsListControlCollection
        {
            get { return _refreshMedia_NewsListControlCollection = _refreshMedia_NewsListControlCollection ?? new ViewModelsBase.DelegateCommand<int>(RefreshMedia_NewsListControlCollectionDelegate); }
        }

        /// <summary>
        /// Delegate method for the SetLockScreenCommand command.
        /// </summary>
        public  void SetLockScreenCommandDelegate() 
        {
	
				_lockScreenService.SetLockScreen("DoWapp-Splashscreen-WXGA-black.png");
        }
		

        private ICommand _setLockScreenCommand;

        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
        public ICommand SetLockScreenCommand
        {
            get { return _setLockScreenCommand = _setLockScreenCommand ?? new ViewModelsBase.DelegateCommand(SetLockScreenCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the AboutCommand command.
        /// </summary>
        public  void AboutCommandDelegate() 
        {
	
				_navigationService.NavigateTo<IViewModels.IAboutViewModel>();
        }
		

        private ICommand _aboutCommand;

        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
        public ICommand AboutCommand
        {
            get { return _aboutCommand = _aboutCommand ?? new ViewModelsBase.DelegateCommand(AboutCommandDelegate); }
        }
    }
}
