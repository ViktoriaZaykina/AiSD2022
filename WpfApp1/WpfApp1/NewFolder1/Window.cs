using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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

            Grid mainGrid = new Grid();
            Content = mainGrid;

            Uri uri = new Uri("Resources/fon.jpg", UriKind.Relative);
            BitmapImage bitmap = new BitmapImage(uri);
            ImageBrush imgbrush = new ImageBrush(bitmap);

            RowDefinition row = new RowDefinition();
            row.Height = GridLength.Auto;
            mainGrid.RowDefinitions.Add(row);

            RowDefinition row1 = new RowDefinition();
            row1.Height = GridLength.Auto;
            mainGrid.RowDefinitions.Add(row1);

            ResizeMode = ResizeMode.CanMinimize;
            SizeToContent = SizeToContent.Height;
            Width = 1500;

            Button btn = new Button();
            btn.Content = "Старт!";
            btn.FontSize = 52;
            //btn.Width = 10;
            btn.Height = 100;
            btn.FontWeight = FontWeights.Bold;
            btn.HorizontalAlignment = HorizontalAlignment.Stretch;
            btn.VerticalAlignment = VerticalAlignment.Center;

            btn.Click += ButtonOnClick;
            mainGrid.Children.Add(btn);
            Grid.SetRow(btn, 1);

            Canvas canv1 = new Canvas();
            canv1.Background = imgbrush;
            canv1.Height = 700;
            mainGrid.Children.Add(canv1);


            Ellipse elips = new Ellipse();
            elips.Fill = Brushes.Red;
            elips.Width = 100;
            elips.Height = 100;
            Canvas.SetTop(elips, 600);
            Canvas.SetLeft(elips, 0);
            canv1.Children.Add(elips);
            Grid.SetRow(canv1, 0);


        }
        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            MessageBox.Show("5 минут полёт нормальный!", Title);
            double w = ActualHeight;
        }

    }
}