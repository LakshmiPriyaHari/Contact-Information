   M S B A M L   `   `   `  ????U  QPersonal Information Class, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Personal_Information_ClassPersonal_Information_Class  5   	   -    'Personal_Information_Class.DetailWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Personal_Information_Class     5   	     ? Title$  Address Detail??5   	   $	??400??6    $	??400??6-    ? WindowStartupLocation$ CenterOwner=?69    ? 
ResizeMode$ NoResize=?6]   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??* ?6   6)   ?? 5      $??* ?6   6)   ?? 5      $??* ?6   6)   ?? 5      $??* ?6   6)   ?? 5      $??* ?6   6)    ? ColumnDefinitions 5   
   ?? 5      6!   ?? 5      6!   .+?5   
   ?? $??0??6   $??Address Details??5      $??2??5      $??Center=?5      $??25(?5      $
??Bold"?5      5      ?? 5   
   $??1??6   $??0??5      $??Name :??5      $??Right=?5       $??20(?5!      ?? 5"   
   $??2??6   $??0??5#      $??	Address :??5$      $??Right=?5%      $??20(?5&      ?? 5'   
   $??3??6   $??0??5(      $??Age :??5)      $??Right=?5*      $??20(?5+      ?? 5,   
   $??4??6   $??0??5-      $??Phone Number :??5.      $??Right=?5/      $??20(?50      ?? 52   
   $??1??6   $??1??6   $??20(?54      ??53      ?? *SelectedItem.Name+54      ?? 55   
   $??2??6   $??1??6   $??20(?57      ??56      ?? *SelectedItem.Address+57      ?? 58   
   $??3??6   $??1??6   $??20(?5:      ??59      ?? *SelectedItem.Age+5:      ?? 5;   
   $??4??6   $??1??6   $??20(?5=      ??5<      ?? *SelectedItem.PhoneNumber+5=      5>      5?      