   M S B A M L   `   `   `  ����H  DdotNetProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:dotNetProjekt.ViewsdotNetProjekt.Views  5      "    dotNetProjekt.Views.TimeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:dotNetProjekt.Views     5      X TXceed.Wpf.Toolkit, Version=3.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit  6>   .��5	      � 
��� ���  � ColumnDefinitions  5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��80 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5    
   �� $��1��6   $��1��6%   $��5��62   $��36(�6F   $��WorkerHourTracker��6T   $��Center=�6m   $��Center=�6�   �� 5"   
   $��1��6   $��3��6$   $��20(�61   $��Beginning Time: ��6?   &   Xceed.Wpf.Toolkit.DateTimePicker  5#   
   -   5        $��DateTimePickerBegin��5#   Z   $��2��6   $��3��6.   $��Center=�6<   $	��180��6v   �� 5$   
   $��1��6   $��5��6$   $��20(�61   $��
End Time: ��6?     5%   
   -   5        $��DateTimePickerEnd��5%   Z   $��2��6   $��5��6.   $��Center=�6<   $	��180��6t   �� 5&   
   -   5        $��RegisterBtn��5&      $��1��6$   $��2��64   $��7��6H   $��Register��6U   6i   �� 5'   
   $��/Views/timeImag.png��6   $��3��6-   $��4��6=   $��2��6Q   $��8��6^   5)      5*      