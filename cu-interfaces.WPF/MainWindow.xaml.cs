using cu_interfaces.LIB.Klassen;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace cu_interfaces.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Televisie tvWoonkamer;
        Radio radioKeuken;
        SmartLamp lampGang;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tvWoonkamer = new Televisie("woonkamer");
            radioKeuken = new Radio("keuken");
            lampGang = new SmartLamp("gang");
        }

        private void btnTvWoonkamerPower_Click(object sender, RoutedEventArgs e)
        {
            if (tvWoonkamer.IsOn)
            {
                lblTvWoonkamer.Content = tvWoonkamer.PowerOff();
                lblTvWoonkamer.Background = Brushes.Red;
            }
            else
            {
                lblTvWoonkamer.Content = tvWoonkamer.PowerOn();
                lblTvWoonkamer.Background = Brushes.Green;
            }
        }

        private void btnSmartLampGangPower_Click(object sender, RoutedEventArgs e)
        {
            if (lampGang.IsOn)
            {
                lblSmartLampGang.Content = lampGang.PowerOff();
                lblSmartLampGang.Background = Brushes.Red;
            }
            else
            {
                lblSmartLampGang.Content = lampGang.PowerOn();
                lblSmartLampGang.Background = Brushes.Green;
            }
            
        }

        private void btnRadioKeuken_Click(object sender, RoutedEventArgs e)
        {
            if (radioKeuken.IsOn)
            {
                lblRadioKeuken.Content = radioKeuken.PowerOff();
                lblRadioKeuken.Background = Brushes.Red;
            }
            else
            {
                lblRadioKeuken.Content = radioKeuken.PowerOn();
                lblRadioKeuken.Background = Brushes.Green;
            }
        }

        private void btnTvWoonKamerVolumeDown_Click(object sender, RoutedEventArgs e)
        {
            if (tvWoonkamer.IsOn)
            {
                tvWoonkamer.VolumeDown();
                lblTvWoonKamerVolume.Content = tvWoonkamer.CurrentVolume;
            }
        }

        private void btnTvWoonKamerVolumeUp_Click(object sender, RoutedEventArgs e)
        {
            if (tvWoonkamer.IsOn)
            {
                tvWoonkamer.VolumeUp();
                lblTvWoonKamerVolume.Content = tvWoonkamer.CurrentVolume;
            }
        }

        private void btnRadioKeukenVolumeDown_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnRadioKeukenVolumeUp_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnCheckConnections_Click(object sender, RoutedEventArgs e)
        {
        }
        
        private void btnCheckInterfaceImplementation_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
