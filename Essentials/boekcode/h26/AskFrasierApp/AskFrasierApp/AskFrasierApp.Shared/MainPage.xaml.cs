using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AskFrasierApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void askButton_Click(object sender, RoutedEventArgs e)
        {
            Frasier shrink = new Frasier();
            replyTextBlock.Text = shrink.GetReply(questionTextBox.Text);
        }
    }
}
