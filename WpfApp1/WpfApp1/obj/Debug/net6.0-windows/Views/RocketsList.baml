   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5          WpfApp1.Views.RocketsList   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Views     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ? $??0??6    ? ColumnDefinitions 5      ?? 5      $??* ?6#   ?? 5      $
??auto ?6#   ?? 5      $
??auto ?6#   .+?5      ?? $??0??6   $??24(?6(   $??All Rockets??66   ?? 5      $??2??6   $??
Add Rocket??6%   ??6:   ?? *AddRocketCommand+?? 5      $??1??6   $
??Back??6%   ??64   ?? *BackCommand+5      ?? 5   
   $??1??6   $??0 25 0 0q?6    ??62   ?? *	Rockets+ ?? View 5      ?? 5      .P?5      ?? $??Rocket Name??6%    ?? CellTemplate 5      ?? 5       .R?5!   "   ??  ?? Padding$ 	20 0 20 0q?6H   ??6,   ?? *
RocketName+6H   5"      5$      ?? 5%      $??	Rocket ID??6%    5&      ?? 5'      .R?5(   "   ?? $ 	20 0 20 0q?6G   ??6,   ?? *
RocketID+6G   5)      5+      ?? 5,      $??Engine number??6%    5-      ?? 5.      .R?5/   "   ?? $ 	20 0 20 0q?6J   ??6,   ?? *EngineNumber+6J   50      52      ?? 53      $??Engine type??6%    54      ?? 55      .R?56   "   ?? $ 	20 0 20 0q?6H   ??6,   ?? *
EngineType+6H   57      59      5:      5<      5=      5>      