   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5      7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  68        WpfApp1.Views.LaunchesList   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Views     5      7
viewmodels clr-namespace:WpfApp1.ViewModels     68   .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ? $??0??6    ? ColumnDefinitions 5      ?? 5      $??* ?6#   ?? 5      $
??auto ?6#   ?? 5      $
??auto ?6#   ?? 5      $
??auto ?6#   .+?5      ?? $??0??6   $??24(?6(   $??All Launches??66   ?? 5      $??2??6   $??
Add Launch??6%   ??6:   ?? *AddLaunchCommand+?? 5      $??1??6   $
??Back??6%   ??64   ?? *BackCommand+?? 5      $??3??6   $??Details??6%   ??67   ?? *DetailsLaunchCommand+5      ?? 5   
   $??1??6   $??10q?6d   ??6   ?? *LaunchesFilter+ ?? UpdateSourceTrigger$ PropertyChanged=?6d   ?? 5   
   -   5         ??Name$ LaunchesListView??5       $??2??6   $??0 25 0 0q?64   $	??400??5"      ??5    F   ?? *LaunchesCollectionView+ ?? SelectedItem 5!   B   ?? *SelectedItem+ ?? View 5#      ?? 5$      .P?5%      ?? $??Flight Number??6%    ?? CellTemplate 5&      ?? 5'      .R?5(   "   ??  ?? Padding$ 	20 0 20 0q?6J   ??6,   ?? *FlightNumber+6J   5)      5+      ?? 5,      $??Launch Date??6%    5-      ?? 5.      .R?5/   "   ?? $ 	20 0 20 0q?6K   ??6,   ?? *LaunchDateUtc+6K   50      52      ?? 53      $??Launch Success??6%    54      ?? 55      .R?56   "   ?? $ 	20 0 20 0q?6K   ??6,   ?? *LaunchSuccess+6K   57      59      ?? 5:      $??Mission Name??6%    5;      ?? 5<      .R?5=   "   ?? $ 	20 0 20 0q?6I   ??6,   ?? *MissionName+6I   5>      5@      ?? 5A      $??Upcoming??6%    5B      ?? 5C      .R?5D   "   ?? $ 	20 0 20 0q?6F   ??6,   ?? *
Upcoming+6F   5E      5G      5H      5J      ? 5K   
   $??3??6   .+?5L      ?? -   5         ??Name$ LaunchSelectedTextBlock??5L      $'??!Select an item to see description??69   $??10q?6b   $
??Wrap=?6n   5M      5N      5O      