using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Baddie_Clicks_v2._0
{
    /// <summary>
    /// Just a prototype for now. Trying to rework the previous version into
    /// something that's easy to reuse and change.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Kills kills = new Kills();
        private MediaPlayerElement mediaPlayer = new MediaPlayerElement();
        private Eyebot eyebot = new Eyebot();
        private DispatcherTimer Update = new DispatcherTimer();
        private int framesPerSec = 1000 / 30;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /* Just prototyping right now. So this event is fired when the 
             * player clicks on the button. That click will set the timer's
             * interval to 1.5 minutes and then assigns an event handler
             * that will fire every time the timer ticks. Tongue Twister!!!
             */
            Update.Tick += GameTimer_Tick1;
            Update.Interval = TimeSpan.FromMilliseconds(framesPerSec);
            Update.Start();
        }

        private void GameTimer_Tick1(object sender, object e)
        {
            AddEnemies();
        }

        private void AddEnemies()
        {
            /* Don't worry about the attack and movement methods for now.
             * Just focus on making the enemies appear at their own specific spawn rates
             * For example, eyebots will spawn every 1.5 minutes while spaceships will
             * spawn every 2 minutes. I will most likely have to use multi-threading in order
             * to accomplish this goal.
             */
            AddEyebot();
            //AddSpaceship();
        }

        private void AddSpaceship()
        {
            throw new NotImplementedException();
        }

        private void AddEyebot()
        {
            DispatcherTimer eyebotSpawnRate = new DispatcherTimer();
            Eyebot eyebot = new Eyebot();

            eyebotSpawnRate.Interval = TimeSpan.FromMilliseconds(eyebot.SpawnRate);
        }
    }
}
