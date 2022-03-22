using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam.Forms.VideoPlayer;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoView : ContentPage
    {
        String video;
        public VideoView()
        {
            InitializeComponent();
        }

        private async void Grabar_Clicked(object sender, EventArgs e)
        {
            await TakeVideoAsync();
        }
        async Task TakeVideoAsync()
        {
            try
            {
                var videoCapturado = await MediaPicker.CaptureVideoAsync();
                await LoadVideoAsync(videoCapturado);
            }
            catch (FeatureNotSupportedException fnsEx)
            {
               
            }
            catch (PermissionException pEx)
            {
                
            }
            catch (Exception ex)
            {
            }
        }

        async Task LoadVideoAsync(FileResult videoCapturado)
        {
           
            if (videoCapturado == null)
            {
                video = null;
                return;
            }

            var newFile = Path.Combine(FileSystem.CacheDirectory, videoCapturado.FileName);
            using (var stream = await videoCapturado.OpenReadAsync())
            using (var newStream = File.OpenWrite(newFile))
                await stream.CopyToAsync(newStream);

            video = newFile;

            UriVideoSource uriSourceVideo = new UriVideoSource()
            {
                Uri = video
            };
            videoPlayer.Source = uriSourceVideo;

        }
    }
}