using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
                webView.Source = new Uri(videoUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading YouTube video: {ex.Message}");
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
    }
}
