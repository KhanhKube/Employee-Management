   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5   	       WPFApp.CountryWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFApp     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ CountryWindow��5
   	   $	��670��6   $	��710��6,   .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��30 �6   �� 5      $	��47* �6   �� 5      $
��513* �6   .+�5   
   �� $��Country Management��6   $��2��6-   $��0��6=   $��36(�6J   $��2��6X   $��Center=�5   	   $
�� 466��6&   �� 5   
   $�� 2, 2, 2, 2q�6   $��
Country ID��6%   $��0��6:   $��1��6J   $��2��6W   �� 5    
   -   5         ��Name$ txtCountryId��5       $��
4, 4, 4, 4q�6(   $��2��6<   $��1��6L   $�� ��6Y    �� TextWrapping$
 Wrap=�5!   	   $��2��6   �� 5#   
   $�� 2, 2, 2, 2q�6   $��Country Name��6%   $��0��6<   $��2��6L   $��2��6Y   �� 5$   
   -   5        $ txtCountryName��5$      $��
4, 4, 4, 4q�6*   $��2��6>   $��2��6N   $�� ��6[   $
 Wrap=�5%   	   $��2��6   �� 5'   
   $�� 2, 2, 2, 2q�6   $��	Region ID��6%   $��0��69   $��3��6I   $��2��6V   �� 5(   
   -   5         ��Name$ cboRegionId��5(      $��
4, 4, 4, 4q�6(   $��2��6<   $��3��6L   $��2��5)   	   �� 5+   
   $�� 2, 2, 2, 2q�6   $��Country��6%   $��0��67   $��4��6G   $��2��6T   �� 5-   
   $��Center=�6   $��0��60   $��4��6@   $��2��6M   .+�5.      �� $�� 2, 2, 2, 2q�6   $��Filter:��6)   �� 50      $�� 2, 2, 2, 2q�6   $��Search Country name:��6)   �� 51      -   5        $ txtSeachText��51      $��4 4 4 4q�6,   6=   �� 53      $�� 2, 2, 2, 2q�6   $��Search Region:��6)   �� 54      -   5        $ cboSeachRegion��54      $��4 4 4 4q�6/   6@   56      &   System.Windows.Controls.DataGrid  58   
   -   5          Name$ dgData��58      $��2��6#   $��4��63   $��2��6@      AutoGenerateColumns$ False��6T   	   Columns	 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6%      Header$ 
Country ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *	CountryId+  5<      $
 * 6%   $ Country Name��6/    6E   �� *CountryName+  5=      $
 * 6%   $ 	Region Id��6/    6B   �� *
RegionId+5?      �� 5A   
   -   5         ��Name$ 	btnCreate��5A      $��Create��6$   $
��Left=�65   $��
30 10 0 10q�6P   $��5��6d   $��2��6q   $	��120��5B   	   
������
�������$��3��6A   $��1��6U   5C   	   �� 5D   
   -	   5        $ 	btnUpdate��5D      $��Update��6$   $
��Left=�65   $��
90 10 0 10q�6P   $��5��6d   $��2��6q   $	��120��5E   	   
���"�"�
�������$��3��6B   5F   	   �� 5G   
   -
   5        $ 	btnDelete��5G      $��Delete��6$   $
��Left=�65   $��230 10 0 10q�6P   $��5��6e   $��2��6r   $	��120��5H   	   
��� ���
�������$��3��6<   5I   	   �� 5J   
   -   5        $ btnClose��5J      $��Close��6#   $
��Left=�63   $��370 10 0 10q�6N   $��5��6c   $��2��6p   $	��120��5K   	   
��� E��
�������$��3��6@   5L   	   5M      5N      