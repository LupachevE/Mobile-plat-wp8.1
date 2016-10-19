using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Phone.UI.Input;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента пустой страницы см. по адресу http://go.microsoft.com/fwlink/?LinkID=390556

namespace edu_bstu_iipo_13_pri_lupachev
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class SecondPage : Page
    {
        public SecondPage()
        {
            this.InitializeComponent();
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;
        }

        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;

            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
            if (frame.CanGoBack)
                frame.GoBack();
            e.Handled = true;
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные события, описывающие, каким образом была достигнута эта страница.
        /// Этот параметр обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;

            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
            if (frame.CanGoBack)
                frame.GoBack();
        }

        CoreApplicationView view = CoreApplication.GetCurrentView();
        
        private void button_Click(object sender, RoutedEventArgs e)
        {

            FileOpenPicker filePicker = new FileOpenPicker();
            filePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            filePicker.ViewMode = PickerViewMode.Thumbnail;

            filePicker.FileTypeFilter.Clear();
            filePicker.FileTypeFilter.Add(".bmp");
            filePicker.FileTypeFilter.Add(".png");
            filePicker.FileTypeFilter.Add(".jpeg");
            filePicker.FileTypeFilter.Add(".jpg");

            filePicker.PickSingleFileAndContinue();
            view.Activated += viewActivated;

            //var captureManager = new MediaCapture();
            //captureManager.InitializeAsync();

            //try
            //{
            //    captureManager = new Windows.Media.Capture.MediaCapture();
            //    captureManager.InitializeAsync();

            //    if (captureManager.MediaCaptureSettings.VideoDeviceId != "" && captureManager.MediaCaptureSettings.AudioDeviceId != "")
            //    {
            //        System.Diagnostics.Debug.WriteLine("Init successful");


            //        //captureManager.RecordLimitationExceeded += new Windows.Media.Capture.RecordLimitationExceededEventHandler(RecordLimitationExceeded);
            //        //captureManager.Failed += new Windows.Media.Capture.MediaCaptureFailedEventHandler(Failed);
            //    }
            //    else
            //    {
            //        System.Diagnostics.Debug.WriteLine("No Device");
            //    }
            //    captureManager.StartPreviewAsync();
            //    captureManager1.Source = captureManager;
            //    captureManager.StartPreviewAsync();
            //    StorageFile file = ApplicationData.Current.LocalFolder.CreateFileAsync("Photo.jpg", CreationCollisionOption.ReplaceExisting);
            //    captureManager.CapturePhotoToStorageFileAsync(Windows.Media.MediaProperties.ImageEncodingProperties.CreateJpeg(), file);
            //}
            //catch (Exception exception)
            //{
            //    System.Diagnostics.Debug.WriteLine("Exception raised!!!!:" + exception);
            //}
        }

        private async void viewActivated(CoreApplicationView sender, IActivatedEventArgs args1)
        {

            FileOpenPickerContinuationEventArgs args = args1 as FileOpenPickerContinuationEventArgs;

            if (args != null)
            {
                if (args.Files.Count == 0) return;

                view.Activated -= viewActivated;
                StorageFile storageFile = args.Files[0];
                var stream = await storageFile.OpenAsync(Windows.Storage.FileAccessMode.Read);
                var bitmapImage = new Windows.UI.Xaml.Media.Imaging.BitmapImage();
                await bitmapImage.SetSourceAsync(stream);

                //var decoder = Windows.Graphics.Imaging.BitmapDecoder.CreateAsync(stream);
                image.Source = bitmapImage;
                imageGrid.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
            }
        }

        private void image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FileOpenPicker filePicker = new FileOpenPicker();
            filePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            filePicker.ViewMode = PickerViewMode.Thumbnail;

            filePicker.FileTypeFilter.Clear();
            filePicker.FileTypeFilter.Add(".bmp");
            filePicker.FileTypeFilter.Add(".png");
            filePicker.FileTypeFilter.Add(".jpeg");
            filePicker.FileTypeFilter.Add(".jpg");

            filePicker.PickSingleFileAndContinue();
            view.Activated += viewActivated;
        }

        private void addAssoc_Click(object sender, RoutedEventArgs e)
        {
            TextBox temp = new TextBox();
            temp.Name = "assoc" + (assocStack.Children.Count + 1);
            temp.Margin = new Thickness(10, 10, 9.667, 0);
            assocStack.Children.Add(temp);
        }
        private void animatedGrid_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            image.Projection = new PlaneProjection();
            animateDown.Begin();
        }

        private void animatedGrid_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            animateUp.Begin();
        }
    }
}
