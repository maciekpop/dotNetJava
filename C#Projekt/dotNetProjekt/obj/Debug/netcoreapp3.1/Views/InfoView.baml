   M S B A M L   `   `   `  ����H  DdotNetProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:dotNetProjekt.ViewsdotNetProjekt.Views  5      "    dotNetProjekt.Views.InfoView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:dotNetProjekt.Views     5      .��5	      � 
���   �  � ColumnDefinitions  5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6%   $��6��62   
���/���$��36(�6_   $��WorkerHourTracker��6m   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $��	dataLabel��5      $��Data: ��6!   $
��Left=�62   $��Bottom=�6M   $��0��6h   $��0��6x   $��4��6�   $��16(�6�   &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ dataGrid��5&      $��0��6%   $��1��65   $��4��6B   $��5,5,5,5q�6V   $��4��6g   $	��300��6x   $	��500��6�   $
��Left=�6�   $
��Auto=�6�   5(      �� 5*   
   -   5        $��showAllDataButton��5*      $��Show all employees��6*   $��4��6G   $��2��6W   $��10,0,0,0q�6d   $	��Top=�6w   6�   �� 5+   
   -   5        $��textWorkerName��5+      $��Give employee name��6(   $��4��6B   $��2��6R   $��10,0,0,0q�6_   $��Center=�6q   $	��120��6�   �� 5,   
   -   5        $��showOneWorker��5,      $��Search employee��6&   $��4��6@   $��2��6P   $��Bottom=�6]   $��10,0,0,1q�6x   6�   �� 5-   
   -   5        $��textWorkerID��5-      $��Give employee ID��6&   $��4��6>   $��3��6N   $��10,1,0,0q�6[   $	��Top=�6m   $	��120��6�   �� 5.   
   -   5        $��showWorkerTimes��5.      $��Show employee times��6(   $��4��6F   $��3��6V   $��10,0,0,0q�6c   $��Center=�6v   6�   �� 5/   
   -   5        $��schowMyTimes��5/      $��Show my times��6%   $��4��6=   $��3��6M   $��10,0,0,0q�6Z   $��Bottom=�6m   6�   50      51      