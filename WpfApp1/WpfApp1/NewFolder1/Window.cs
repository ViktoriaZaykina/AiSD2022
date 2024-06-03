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
            elips1.Clip = new CombinedGeometry(GeometryCombineMode.Exclude,new RectangleGeometry(new Rect(new System.Windows.Point(0, elips1.Height / 2), new Size(elips1.Width, elips1.Height / 2))),
            new EllipseGeometry(new System.Windows.Point(elips1.Width / 2, elips1.Width), elips1.Width / 2 * 0.7, elips1.Width * 0.8));
            Canvas.SetLeft(rec, 250);
            Canvas.SetTop(rec, 700 - rec.Height);
            Canvas.SetLeft(elips1, Canvas.GetLeft(rec) + (rec.Width - elips1.Width) / 2);
            Canvas.SetTop(elips1, Canvas.GetTop(rec) - elips1.Height + 20);
            canv1.Children.Add(elips1);

            Uri uri2 = new Uri("Resources/redb.png", UriKind.Relative);
            BitmapImage bitmap2 = new BitmapImage(uri2);
            ImageBrush imgbrush2 = new ImageBrush(bitmap2);

            Ellipse elips2 = new Ellipse();
            elips2.Fill = imgbrush2;
            elips2.Width = 90;
            elips2.Height = 90;
            Canvas.SetLeft(elips2, 0);
            Canvas.SetTop(elips2, 610);
            canv1.Children.Add(elips2);

            Rectangle rec2 = new Rectangle();
            rec2.Width = 50;
            rec2.Height = 280;
            rec2.Fill = Brushes.RosyBrown;
            rec2.Stroke = Brushes.Black;
            Canvas.SetLeft(rec2, 900);
            Canvas.SetTop(rec2, 700 - rec2.Height);
            canv1.Children.Add(rec2);

            Uri uri3 = new Uri("Resources/svin2.png", UriKind.Relative);
            BitmapImage bitmap3 = new BitmapImage(uri3);
            ImageBrush imgbrush3 = new ImageBrush(bitmap3);

            Ellipse elips3 = new Ellipse();
            elips3.Fill = imgbrush3;
            elips3.Width = 110;
            elips3.Height = 105;
            Canvas.SetLeft(elips3, 870);
            Canvas.SetTop(elips3, 318);
            canv1.Children.Add(elips3);

            Rectangle rec3 = new Rectangle();
            rec3.Width = 280;
            rec3.Height = 50;
            rec3.Fill = Brushes.RosyBrown;
            rec3.Stroke = Brushes.Black;
            Canvas.SetLeft(rec3, 950);
            Canvas.SetTop(rec3, 550);
            canv1.Children.Add(rec3);

            Rectangle rec4 = new Rectangle();
            rec4.Width = 50;
            rec4.Height = 400;
            rec4.Fill = Brushes.RosyBrown;
            rec4.Stroke = Brushes.Black;
            Canvas.SetLeft(rec4, 1180);
            Canvas.SetTop(rec4, 700 - rec4.Height);
            canv1.Children.Add(rec4);

            Uri uri4 = new Uri("Resources/svin1.png", UriKind.Relative);
            BitmapImage bitmap4 = new BitmapImage(uri4);
            ImageBrush imgbrush4 = new ImageBrush(bitmap4);

            Ellipse elips4 = new Ellipse();
            elips4.Fill = imgbrush4;
            elips4.Width = 115;
            elips4.Height = 105;
            Canvas.SetLeft(elips4, 1148);
            Canvas.SetBottom(elips4,396);
            canv1.Children.Add(elips4);

        }
        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            MessageBox.Show("5 минут полёт нормальный!", Title);
            double w = ActualHeight;
        }

    }
}