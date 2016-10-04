using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Calls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Windows;
using Windows.ApplicationModel.Email;
// Документацию по шаблону элемента "Пустая страница" см. по адресу http://go.microsoft.com/fwlink/?LinkId=391641

namespace edu_bstu_iipo_13_pri_lupachev
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            //var i = edu_bstu_iipo_13_pri_lupachev.App.Current.Resources;
            ////AppResources 

            //i.ToString();
        }

        /// <summary>
        /// Вызывается перед отображением этой страницы во фрейме.
        /// </summary>
        /// <param name="e">Данные события, описывающие, каким образом была достигнута эта страница.
        /// Этот параметр обычно используется для настройки страницы.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Подготовьте здесь страницу для отображения.

            // TODO: Если приложение содержит несколько страниц, обеспечьте
            // обработку нажатия аппаратной кнопки "Назад", выполнив регистрацию на
            // событие Windows.Phone.UI.Input.HardwareButtons.BackPressed.
            // Если вы используете NavigationHelper, предоставляемый некоторыми шаблонами,
            // данное событие обрабатывается для вас.
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(inputTextBox.Text) && inputTextBox.Text != "Введите номер")
                PhoneCallManager.ShowPhoneCallUI(inputTextBox.Text, "Неизвестный контакт");
            else
                PhoneCallManager.ShowPhoneCallUI(numberValue.Text, "Неизвестный контакт");

        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(inputTextBox.Text))
                inputTextBox.Text = "Введите номер";
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (inputTextBox.Text == "Введите номер")
                inputTextBox.Text = "";
        }

        private void numberValue_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PhoneCallManager.ShowPhoneCallUI(numberValue.Text, "Неизвестный контакт");
            
        }

        private void emailValue_Tapped(object sender, TappedRoutedEventArgs e)
        {
            EmailRecipient sendTo = new EmailRecipient()
            {
                Name = "Student",
                Address = emailValue.Text
            };
            
            EmailMessage mail = new EmailMessage();
            mail.Subject = "this is the Subject";
            mail.Body = "this is the Body";
            
            mail.To.Add(sendTo);
            EmailManager.ShowComposeNewEmailAsync(mail);
        }
    }
}
