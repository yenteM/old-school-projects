using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using ContosoCookbookUniversal.Data;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RecipeBrowser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private IEnumerable<RecipeDataGroup> groups;
        
        public MainPage()
        {
            this.InitializeComponent();

            LoadGroups();

            groupsList.SelectionChanged += groupsList_SelectionChanged; 
        }

        void groupsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RecipeDataGroup group = (RecipeDataGroup) groupsList.SelectedValue;
            recipeList.ItemsSource = group.Items;
        }

        private async void LoadGroups()
        {
            groups = await RecipeDataSource.GetGroupsAsync();
            this.groupsList.ItemsSource = groups;
        }
    }
}
