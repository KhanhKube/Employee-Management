   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5   	       WPFApp.RegionWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFApp     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ RegionWindow��5
   	   $	��670��6   $	��710��6+   .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��30 �6   �� 5      $	��47* �6   �� 5      $
��513* �6   .+�5   
   �� $��Region Management��6   $��2��6,   $��0��6<   $��36(�6I   $��2��6W   $��Center=�5      $
�� 466��6*   �� 5   
   $�� 2, 2, 2, 2q�6   $��	Region ID��6%   $��0��69   $��1��6I   $��2��6V   �� 5   
   -   5         ��Name$ txtRegionId��5      $��
4, 4, 4, 4q�6'   $��2��6;   $��1��6K   $�� ��6X    �� TextWrapping$
 Wrap=�5       $��2��6!   �� 5"   
   $�� 2, 2, 2, 2q�6   $��Region Name��6%   $��0��6;   $��2��6K   $��2��6X   �� 5#   
   -   5        $ txtRegionName��5#      $��
4, 4, 4, 4q�6)   $��2��6=   $��2��6M   $�� ��6Z   $
 Wrap=�5$      $��2��6!   �� 5&   
   $�� 2, 2, 2, 2q�6   $��Region��6%   $��0��66   $��3��6F   $��2��6S   �� 5(   
   $��Center=�6   $��0��60   $��3��6@   $��2��6M   .+�5)      �� $�� 2, 2, 2, 2q�6   $��Filter:��6)   �� 5+      $�� 2, 2, 2, 2q�6   $��Search region name:��6)   �� 5,      -   5        $ txtSeachText��5,      $��4 4 4 4q�6,   6=   5.      &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ dgData��50      $��2��6#   $��3��63   $��2��6@      AutoGenerateColumns$ False��6T      Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6%   
   Header$
 	Region ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *
RegionId+  54      $	 * 6%   $
 Region Name��6/    6D   �� *
RegionName+56      �� 58   
   -   5         ��Name$ 	btnCreate��58      $��Create��6$   $
��Left=�65   $��
30 10 0 10q�6P   $��4��6d   $��2��6q   $	��120��59      
������
�������$��3��6E   $��1��6Y   5:      �� 5;   
   -   5        $ 	btnUpdate��5;      $��Update��6$   $
��Left=�65   $��
90 10 0 10q�6P   $��4��6d   $��2��6q   $	��120��5<      
���"�"�
�������$��3��6F   5=      �� 5>   
   -   5        $ 	btnDelete��5>      $��Delete��6$   $
��Left=�65   $��230 10 0 10q�6P   $��4��6e   $��2��6r   $	��120��5?      
��� ���
�������$��3��6@   5@      �� 5A   
   -	   5        $ btnClose��5A      $��Close��6#   $
��Left=�63   $��370 10 0 10q�6N   $��4��6c   $��2��6p   $	��120��5B      
��� E��
�������$��3��6D   5C      5D      5E      