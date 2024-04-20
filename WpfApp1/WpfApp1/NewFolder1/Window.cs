using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace AB
{
    class ABWindow : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new ABWindow());
        }
        public ABWindow()
        {
            Title = "Angry Birds";

            Uri uri = new Uri("https://wp-top.ru/wp-content/uploads/2023/04/genshin-impakt-1091576.jpg");
            BitmapImage bitmap = new BitmapImage(uri);
            Image img = new Image();
            img.Source = bitmap;
            img.Stretch = Stretch.UniformToFill;
            Content = img;

            Button btn = new Button();
            btn.Content = "Старт!";
            btn.Click += ButtonOnClick;
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            Content = btn;
        }
        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            MessageBox.Show("The button has been clicked and all is well.", Title);
        }

    }
}