   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5   	       WPFApp.DepartmentWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFApp     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ DepartmentWindow��5
   	   $	��670��6"   $	��710��6/   .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��80 �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��30 �6   �� 5      $	��47* �6   �� 5      $
��513* �6   .+�5   
   �� $��Department Management��6   $��2��60   $��0��6@   $��36(�6M   $��2��6[   $��Center=�5      $
�� 466��6.   �� 5    
   $�� 2, 2, 2, 2q�6   $��Department ID��6%   $��0��6=   $��1��6M   $��2��6Z   �� 5!   
   -   5         ��Name$ txtDepartmentId��5!      $��
4, 4, 4, 4q�6+   $��2��6?   $��1��6O   $�� ��6\    �� TextWrapping$
 Wrap=�5"      $��2��6%   �� 5$   
   $�� 2, 2, 2, 2q�6   $��Department Name��6%   $��0��6?   $��2��6O   $��2��6\   �� 5%   
   -   5        $ txtDepartmentName��5%      $��
4, 4, 4, 4q�6-   $��2��6A   $��2��6Q   $�� ��6^   $
 Wrap=�5&      $��2��6%   �� 5(   
   $�� 2, 2, 2, 2q�6   $��
Manager ID��6%   $��0��6:   $��3��6J   $��2��6W   �� 5)   
   -   5         ��Name$ cboManagerId��5)      $��
4, 4, 4, 4q�6)   $��2��6=   $��3��6M   $��2��5*      �� 5,   
   $�� 2, 2, 2, 2q�6   $��Location ID��6%   $��0��6;   $��4��6K   $��2��6X   �� 5-   
   -   5        $ cboLocationId��5-      $��
4, 4, 4, 4q�6*   $��2��6>   $��4��6N   $��2��5.      �� 50   
   $�� 2, 2, 2, 2q�6   $��
Department��6%   $��0��6:   $��5��6J   $��2��6W   �� 52   
   $��Center=�6   $��0��60   $��5��6@   $��2��6M   .+�53      �� $�� 2, 2, 2, 2q�6   $��Filter:��6)   �� 55      $�� 2, 2, 2, 2q�6   $��Search department name:��6)   �� 56      -   5        $ txtSeachText��56      $��4 4 4 4q�6,   6=   �� 58      $�� 2, 2, 2, 2q�6   $��Search Manager:��6)   �� 59      -   5        $ cboSeachManager��59      $��4 4 4 4q�60   6A   �� 5;      $�� 2, 2, 2, 2q�6   $��Search Location:��6)   �� 5<      -   5        $ cboSeachLocation��5<      $��4 4 4 4q�61   6B   5=      &   System.Windows.Controls.DataGrid  5?   
   -	   5          Name$ dgData��5?      $��2��6#   $��5��63   $��2��6@      AutoGenerateColumns$ False��6T   	   Columns	 5A      0  *System.Windows.Controls.DataGridTextColumn  5B      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6%      Header$ Department ID��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *DepartmentId+  5C      $
 * 6%   $ Department Name��6/    6H   �� *DepartmentName+  5D      $
 * 6%   $ 
Manager Id��6/    6C   �� *	ManagerId+  5E      $
 * 6%   $ Location Id��6/    6D   �� *
LocationId+5G      �� 5I   
   -
   5         ��Name$ 	btnCreate��5I      $��Create��6$   $
��Left=�65   $��
30 10 0 10q�6P   $��6��6d   $��2��6q   $	��120��5J      
������
�������$��3��6I   $��1��6]   5K      �� 5L   
   -   5        $ 	btnUpdate��5L      $��Update��6$   $
��Left=�65   $��
90 10 0 10q�6P   $��6��6d   $��2��6q   $	��120��5M      
���"�"�
�������$��3��6J   5N      �� 5O   
   -   5        $ 	btnDelete��5O      $��Delete��6$   $
��Left=�65   $��230 10 0 10q�6P   $��6��6e   $��2��6r   $	��120��5P      
��� ���
�������$��3��6D   5Q      �� 5R   
   -   5        $ btnClose��5R      $��Close��6#   $
��Left=�63   $��370 10 0 10q�6N   $��6��6c   $��2��6p   $	��120��5S      
��� E��
�������$��3��6H   5T      5U      5V      