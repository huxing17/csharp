using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfHelloWorld
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSayHello_Click(object sender, RoutedEventArgs e)
        {
            textBoxShowHello.Text = "Hello,World!";
        }
    }
}

/*<Window x:Class="WpfHelloWorld.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfHelloWorld"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <Grid Margin="0,0,-192.4,-100" HorizontalAlignment="Left" Width="986">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="69*"/>
            <ColumnDefinition Width="917*"/>
        </Grid.ColumnDefinitions>
        <Grid.Background>
            <LinearGradientBrush EndPoint="0.5,1" StartPoint="0.5,0">
                <GradientStop Color="Black" Offset="0"/>
                <GradientStop Color="#FF499BDD" Offset="1"/>
            </LinearGradientBrush>
        </Grid.Background>
        <TextBox x:Name="textBoxShowHello" HorizontalAlignment="Left" Height="38" Margin="63.2,10,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="708" Grid.Column="1"/>
        <Button x:Name="buttonSayHello" Content="ClickMe" Grid.Column="1" HorizontalAlignment="Left" Margin="351.2,128,0,0" VerticalAlignment="Top" Width="150" Height="37" Click="buttonSayHello_Click"/>

    </Grid>
</Window>*/
