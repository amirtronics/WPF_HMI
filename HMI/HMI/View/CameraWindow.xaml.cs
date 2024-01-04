using System.Net;
using System.Security.Policy;
using System.Windows;

namespace HMI.View
{
    /// <summary>
    /// Interaction logic for CameraWindow.xaml
    /// </summary>
    public partial class CameraWindow : Window
    {
        public CameraWindow()
        {
            InitializeComponent();
        }

        private void btnRaw_Click(object sender, RoutedEventArgs e)
        {
            string videoUrl = $"http://10.2.2.128:8080/stream?topic=/baumer/image_raw";

            try
            {
                // Navigate to the YouTube video URL
                cameraDisconnectedImage.Visibility = Visibility.Hidden;
 
                WebRequest request = WebRequest.Create(videoUrl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception();
                }

                bool result = webView.IsEnabled;
                webView.Source = new Uri(videoUrl);
            }
            catch (Exception ex)
            {
                cameraDisconnectedImage.Visibility = Visibility.Visible;
                //MessageBox.Show($"Error loading YouTube video: {ex.Message}");
            }
        }

        private void btnAngle_Click(object sender, RoutedEventArgs e)
        {
            string videoUrl = $"http://10.2.2.128:8080/stream?topic=/baumer/image_angle";

            try
            {
                // Navigate to the YouTube video URL
                webView.Source = new Uri(videoUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading YouTube video: {ex.Message}");
            }
        }

        private void btnVideo_Click(object sender, RoutedEventArgs e)
        {
            string videoUrl = $"http://10.2.2.128:8080/stream?topic=/image";

            try
            {
                // Navigate to the YouTube video URL
                webView.Source = new Uri(videoUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading YouTube video: {ex.Message}");
            }
        }

        private void webView_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cameraDisconnectedImage.Visibility = Visibility.Hidden;
        }
    }
}
