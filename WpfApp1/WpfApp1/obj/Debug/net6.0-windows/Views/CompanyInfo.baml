   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.ViewsWpfApp1.Views  5          WpfApp1.Views.CompanyInfo   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Views     5      .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??0??5      $??24(?5      $??Space X??5      ?? 5   
   $??1??5      $??14(?5      $????SpaceX designs, manufactures and launches advanced rockets and spacecraft. The company was founded in 2002 to revolutionize space technology, with the ultimate goal of enabling people to live on other planets.??5       ?? TextAlignment$ Center=?5      $
??Wrap=?5      ?? 5   
   $??2??5      $??0 25 0 0q?5       ?? Orientation$ 
Horizontal=?5       $??Center=?5!      .+?5"      ?? $??Launches??5#      $??0 0 10 0q?5%      ??5$      ?? *LaunchesCommand+5%      ?? 5&      $??Rockets??5'      $??	10 0 10 0q?5)      ??5(      ?? *RocketsCommand+5)      ?? 5*      $??Ships??5+      $??10 0 0 0q?5-      ??5,      ?? *ShipsCommand+5-      5.      ?? 5/   
   $??3??50      $&?? Fetch data from API to SQLite =)??51      $??100 250 100 10q?53      ??52      ?? *	FetchData+53      54      55      