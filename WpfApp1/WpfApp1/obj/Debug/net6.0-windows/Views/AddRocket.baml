   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5          WpfApp1.Views.AddRocket   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Views     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??0??5      $??24(?5      $??Add new rocket??5      ? 5   
   $??1??6   $??0 25 0 0q?6     5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    .+?5      ?? $??0??6   $
??Name??6%   ?? 5      $??1??6   $??0 5 0 0q?6#   ??64   ?? *Name+ ?? UpdateSourceTrigger$ PropertyChanged=?5      ? 5   
   $??2??6   $??0 10 0 0q?6     5       ?? 5!      $
??auto ?6    ?? 5"      $
??auto ?6     ? ColumnDefinitions 5$      ?? 5%      $
??auto ?6#   ?? 5&      $
??auto ?6#   .+?5(      ?? $??0??6   $??0??6%   $??Engines number??65   ?? 5)      $??1??6   $??0??6#   $??0 5 0 0q?6v   ??63   ?? *EngineNumber+$ PropertyChanged=?6v   ?? 5+      $??0??6   $??1??6%   $??Engines type??65   $??5 0 0 0q?6I   ?? 5,      $??1??6   $??1??6#   $??0 5 0 0q?6t   ??63   ?? *
EngineType+$ PropertyChanged=?6t   5-      ?? 5/   
   $??3??6   $??0 25 0 0q?6"    ?? Orientation$ 
Horizontal=?64   .+?50      ?? $	??Add??6   ??6#   ?? *
AddCommand+?? 51      $??Cancel??6   $??5 0 0 0q?6H   ??6&   ?? *CancelCommand+6H   52      53      54      