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
            Grid.SetRow(canv1, 0);

            Rectangle rec = new Rectangle();
            rec.Width = 40;
            rec.Height = 180;
            rec.Fill = Brushes.RosyBrown;
            rec.Stroke = Brushes.Black;
            canv1.Children.Add(rec);
            Ellipse elips1 = new Ellipse();
            elips1.Width = 160;
            elips1.Height = elips1.Width * 2;
            elips1.Fill = Brushes.RosyBrown;
            elips1.Stroke = Brushes.Black;
            elips1.Clip = new CombinedGeometry(
              GeometryCombineMode.Exclude,
              new RectangleGeometry(new Rect(new System.Windows.Point(0, elips1.Height / 2), new Size(elips1.Width, elips1.Height / 2))),
              new EllipseGeometry(new System.Windows.Point(elips1.Width / 2, elips1.Width), elips1.Width / 2 * 0.7, elips1.Width * 0.8));
            Canvas.SetLeft(rec, 250);
            Canvas.SetTop(rec, 700 - rec.Height);
            Canvas.SetLeft(elips1, Canvas.GetLeft(rec) + (rec.Width - elips1.Width) / 2);
            Canvas.SetTop(elips1, Canvas.GetTop(rec) - elips1.Height + 20);
            canv1.Children.Add(elips1); 
        }
        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            MessageBox.Show("5 минут полёт нормальный!", Title);
            double w = ActualHeight;
        }

    }
}