using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace cc_package_simplify
{
    public class BackgroundPlayer : System.Windows.Controls.Control
    {
        static BackgroundPlayer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BackgroundPlayer), new FrameworkPropertyMetadata(typeof(BackgroundPlayer)));
        }

        public string Source
        {
            get { return (string)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
          DependencyProperty.Register("Source", typeof(string), typeof(BackgroundPlayer), new FrameworkPropertyMetadata("", (a, b) =>
          {
              BackgroundPlayer bp = a as BackgroundPlayer;
              if (bp.Player != null)
              {
                  bp.Player.Source = new Uri(b.NewValue.ToString().Replace("~", AppDomain.CurrentDomain.BaseDirectory), UriKind.RelativeOrAbsolute);
              }
          }));

        private MediaElement _player;

        public MediaElement Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public override void OnApplyTemplate()
        {
            Player = GetTemplateChild("Media") as MediaElement;
            if (null == Player)
                throw new ArgumentNullException("Media");

            Player.LoadedBehavior = MediaState.Manual;
            Player.MediaEnded += Player_MediaEnded;
            Player.MediaOpened += Player_MediaOpened;
            Player.MediaFailed += Player_MediaFailed;
            Player.Loaded += Player_Loaded;
            if (!string.IsNullOrEmpty(Source))
            {
                Player.Source = new Uri(Source.Replace("~", AppDomain.CurrentDomain.BaseDirectory), UriKind.RelativeOrAbsolute);
                Player.Play();
            }
            base.OnApplyTemplate();
        }

        void Player_Loaded(object sender, RoutedEventArgs e)
        {
        }

        void Player_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
        }

        void Player_MediaOpened(object sender, RoutedEventArgs e)
        {
            //Player.Play();
        }

        void Player_MediaEnded(object sender, RoutedEventArgs e)
        {
            Player.Position = TimeSpan.FromMilliseconds(1);
            Player.Play();
        }

    }
}
