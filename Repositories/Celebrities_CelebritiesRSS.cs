// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSource.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EntitiesBase=WPAppStudio.Entities.Base;
using RepositoriesBase=WPAppStudio.Repositories.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// RSS data source.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class Celebrities_CelebritiesRSS : ICelebrities_CelebritiesRSS 
    {
        private RepositoriesBase.IXmlDataSource _xmlDataSource; 
        private ObservableCollection<EntitiesBase.RssSearchResult> _data = new ObservableCollection<EntitiesBase.RssSearchResult>();

		private const string RssUrl = "https://apps.windowsstore.com/Home/Rss";

        /// <summary>
        /// Initializes a new instance of the <see cref="Celebrities_CelebritiesRSS" /> class.
        /// </summary>
        /// <param name="xmlDataSource">A XML based data source.</param>
        public Celebrities_CelebritiesRSS(RepositoriesBase.IXmlDataSource xmlDataSource)
        {
            _xmlDataSource = xmlDataSource;
        }

        /// <summary>
        /// Retrieves the data from a RSS data source (https://apps.windowsstore.com/Home/Rss), in an observable collection of RssSearchResult items.
        /// </summary>
        /// <returns>An observable collection of RssSearchResult items.</returns>
        public async Task<ObservableCollection<EntitiesBase.RssSearchResult>> GetData()
        {
            return await LoadData();
        }
						
		/// <summary>
        /// Retrieves the data from a RSS data source (https://apps.windowsstore.com/Home/Rss), filtered by a filter specification, in an observable collection of RssSearchResult items.
        /// </summary>
		/// <param name="filter">Filter operation specification</param>
        /// <returns>An observable collection of RssSearchResult items.</returns>
        public async Task<ObservableCollection<EntitiesBase.RssSearchResult>> Search(FilterSpecification filter)
        {
			var data = await LoadData();
            return RepositoriesBase.Filter<EntitiesBase.RssSearchResult>.FilterCollection(filter, data);
        }

        private async Task<ObservableCollection<EntitiesBase.RssSearchResult>> LoadData()
        {
            var feed = await _xmlDataSource.LoadRemote<System.ServiceModel.Syndication.SyndicationFeed>(RssUrl);
			var defaultImage = feed.ImageUrl != null ? feed.ImageUrl.AbsoluteUri : null;
            return feed != null && feed.Items != null ? new ObservableCollection<EntitiesBase.RssSearchResult>(feed.Items.Select(i=>new EntitiesBase.RssSearchResult(i, defaultImage))) : new ObservableCollection<EntitiesBase.RssSearchResult>();
        }
	}	
}