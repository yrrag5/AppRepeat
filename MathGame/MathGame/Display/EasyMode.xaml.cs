// Author Garry Cummins
// Mobile App Repeat 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MathGame.Display
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class EasyMode : Page
    {
        private int staticNum1, staticNum2, staticResult, staticRandomResult, Score=0, State=1, HighScore=0, mode;
        private DispatcherTimer disTimer;

        // Progress bar for time
        private void setupProgressBar()
        {
            disTimer = new DispatcherTimer();
            disTimer.Tick += DisTimer_Tick;
            disTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            disTimer.Start();

            progressBar.Value = 9999;
        }//Progressbar

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested -=EasyMode_BackRequested;

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Windows.UI.Core.SystemNavigationManager.GetForCurrentView().BackRequested += EasyMode_BackRequested;
            disTimer = null;

            Play();
        }

        private async void EasyMode_BackRequested(object sender, Windows.UI.Core.BackRequestedEventArgs e)
        {
            e.Handled = true;
            disTimer.Stop();
            disTimer = null;

            var msg = new MessageDialog("App will be closed do you wish to continue?");
            var yes = new UICommand("Yes");
            var no = new UICommand("No");

            msg.Commands.Add(yes);
            msg.Commands.Add(no);
            IUICommand result = await msg.ShowAsync();

            if (result != null && result.Label.Equals("Yes"))
            {
                Frame.Navigate(typeof(GameOver), Score.ToString());
            }//if
        }

        private void DisTimer_Tick(object sender, object e)
        {
            progressBar.Value -= Conditions.Score.Speed;
            if(progressBar.Value <= 0)
            {
                disTimer.Stop();
                disTimer = null;

                Frame.Navigate(typeof(GameOver), Score.ToString());

            }
        }

        public EasyMode()
        {
            this.InitializeComponent();
        }

        private void btnTrue_Click(object sender, RoutedEventArgs e)
        {
            if(mode == 1)
            {
                score.Text = String.Format("Score{0}".ToUpper(), ++Score);
                txtState.Text = String.Format("{0}", ++State);
                disTimer.Stop();
                disTimer = null;
                Play();
            }

            else
            {
                disTimer.Stop();
                disTimer = null;

                Frame.Navigate(typeof(GameOver), Score.ToString());
            }
        }

        // Randomly generated questions while playing Easy Mode 
        private void Play()
        {
            Random rd = new Random();
            int value = rd.Next(1, 4);
            if (value == 1)
            {
                staticNum1 = rd.Next(1, 9);
                staticNum2 = rd.Next(0, staticNum1 - 1);
                staticResult = staticNum1 + staticNum2;
                staticRandomResult = rd.Next(0, 99);

                mode = rd.Next(0, 1);
                if (mode == 0)
                {
                    txtMath.Text = String.Format("{0} + {1} = {2}", staticNum1, staticNum2, staticRandomResult);
                }
                else
                {
                    txtMath.Text = String.Format("{0} + {1} = {2}", staticNum1, staticNum2, staticRandomResult);
                }
            }

            if (value == 2)
            {
                staticNum1 = rd.Next(1, 9);
                staticNum2 = rd.Next(0, staticNum1 - 1);
                staticResult = staticNum1 - staticNum2;
                staticRandomResult = rd.Next(0, 99);

                mode = rd.Next(0, 1);
                if (mode == 0)
                {
                    txtMath.Text = String.Format("{0} - {1} = {2}", staticNum1, staticNum2, staticRandomResult);
                }
                else
                {
                    txtMath.Text = String.Format("{0} - {1} = {2}", staticNum1, staticNum2, staticRandomResult);
                }
            }

            if (value == 3)
            {
                staticNum1 = rd.Next(1, 9);
                staticNum2 = rd.Next(0, staticNum1 - 1);
                staticResult = staticNum1 * staticNum2;
                staticRandomResult = rd.Next(0, 99);

                mode = rd.Next(0, 1);
                if (mode == 0)
                {
                    txtMath.Text = String.Format("{0} * {1} = {2}", staticNum1, staticNum2, staticRandomResult);
                }
                else
                {
                    txtMath.Text = String.Format("{0} * {1} = {2}", staticNum1, staticNum2, staticRandomResult);
                }
            }

            if (value == 4)
            {
                staticNum1 = rd.Next(1, 9);
                staticNum2 = rd.Next(1, staticNum1);
                staticResult = staticNum1 / staticNum2;
                staticRandomResult = rd.Next(0, 99);

                mode = rd.Next(0, 1);
                if (mode == 0)
                {
                    txtMath.Text = String.Format("{0} / {1} = {2}", staticNum1, staticNum2, staticRandomResult);
                }
                else
                {
                    txtMath.Text = String.Format("{0} / {1} = {2}", staticNum1, staticNum2, staticRandomResult);
                }
            }

            setupProgressBar();
        }

        // False button
        private void btnFalse_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0)
            {
                score.Text = String.Format("Score{0}".ToUpper(), ++Score);
                txtState.Text = String.Format("{0}", ++State);
                disTimer.Stop();
                disTimer = null;
                Play();
            }

            else
            {
                disTimer.Stop();
                disTimer = null;

                Frame.Navigate(typeof(GameOver), Score.ToString());
            }
        }
    }
}
