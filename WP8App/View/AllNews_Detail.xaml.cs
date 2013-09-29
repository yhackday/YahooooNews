// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   PageCS.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Entities=WPAppStudio.Entities;
using Ioc=WPAppStudio.Ioc;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Paging;
using Repositories=WPAppStudio.Repositories;
using WPAppStudio;

namespace WPAppStudio.View
{
    /// <summary>
    /// Phone application page for AllNews_Detail.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class AllNews_Detail : PhoneApplicationPage
    {       
        /// <summary>
        /// Initializes the phone application page for AllNews_Detail and all its components.
        /// </summary>
        public AllNews_Detail()
        {
            InitializeComponent();        
			if (Resources.Contains("PanoramaAllNews_Detail0AppBar"))
				PhonePage.SetApplicationBar(this, Resources["PanoramaAllNews_Detail0AppBar"] as BindableApplicationBar);                            
		}
		
        private void panoramaAllNews_Detail_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramaAllNews_Detail(PanoramaAllNews_Detail.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramaAllNews_Detail(PanoramaItem panoramaItem)        
        {
			if (Resources.Contains(panoramaItem.Name + "AppBar"))
			{
				PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);            
				ApplicationBar.IsVisible = true;
            }
		    else if(ApplicationBar != null)
		        ApplicationBar.IsVisible = false;
        }
 
        /// <summary>
        /// Called when the page becomes the active page.
        /// </summary>
        /// <param name="e">Contains information about the navigation done.</param>
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            string currentId;
			
            if (NavigationContext.QueryString.TryGetValue("currentID", out currentId))
            {
				var dataSource = new Ioc.Container().Resolve<Repositories.IAllNews_RSS>();
				AddHomeAppBarButton();
				var pinnedItem  = (await dataSource.GetData()).FirstOrDefault(x => IsPinnedItem(x.Title.ToString(), currentId));
				if(pinnedItem==null)
					MessageBox.Show(Localization.AppResources.PinError);
				((IViewModels.IAllNews_DetailViewModel)DataContext).CurrentRssSearchResult = pinnedItem;				
			}
		}

        private static bool IsPinnedItem(string itemId, string currentId)
        {
            itemId = itemId.Trim();
            currentId = HttpUtility.UrlDecode(currentId.Trim());
            return itemId.Equals(currentId, StringComparison.InvariantCultureIgnoreCase);
        }
		
        private void AddHomeAppBarButton()
        {
            if (ApplicationBar.Buttons.Count >= 4 ||
                ApplicationBar.Buttons.Cast<ApplicationBarIconButton>().Any(button => button.Text == "Home")) 
                return;
						
			var homeIcon = new ApplicationBarIconButton() {IconUri = new Uri("/Images/Icons/Light/Home.png", UriKind.Relative), IsEnabled = true, Text = "Home"};
            homeIcon.Click += delegate 
			{ 
				new Ioc.Container().Resolve<IServices.INavigationService>().NavigateTo<IViewModels.IAllNews_NewsViewModel>(); 
				while (NavigationService.RemoveBackEntry() != null);
			};
            ApplicationBar.Buttons.Add(homeIcon);
        }
    }
}
