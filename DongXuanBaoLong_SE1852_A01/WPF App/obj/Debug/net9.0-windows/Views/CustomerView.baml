   M S B A M L   `   `   `  ����M  IDongXuanBaoLongWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:DongXuanBaoLongWPF.ViewModelsDongXuanBaoLongWPF.ViewModels  5      +    %DongXuanBaoLongWPF.Views.CustomerView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      :vm+clr-namespace:DongXuanBaoLongWPF.ViewModels     5      .��5	      � $��10q�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0,0,0,10q�6,   .+�5      �� $��Company Name��6   �� 5      ��6   �� *Input.CompanyName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��Contact Name��6   �� 5      ��6   �� *Input.ContactName+$ PropertyChanged=��� 5      $��Contact Title��6   �� 5      ��6   �� *Input.ContactTitle+$ PropertyChanged=��� 5      $��Address��6   �� 5      ��6   �� *Input.Address+$ PropertyChanged=��� 5      $��Phone��6   �� 5      ��6   �� *Input.Phone+$ PropertyChanged=��� 5!      $��Search by contact name��6   �� 5"      -   5         ��Name$ 	SearchBox��5"      $��5q�6)   5#      &   System.Windows.Controls.DataGrid  5&   
   $��1��6      AutoGenerateColumns$ False��5)      ��5'      �� *	Customers+ �� SelectedItem 5(      �� *SelectedCustomer+ �� Mode$ TwoWay=�   Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   
IsReadOnly$
	 True��6P   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *
CustomerID+6P     5,      $ Company Name��6%   
 6;   �� *CompanyName+  5-      $ Contact Name��6%   
 6;   �� *ContactName+  5.      $ Title��6%   
 64   �� *ContactTitle+  5/      $ Address��6%   
 66   �� *	Address+  50      $ Phone��6%   
 64   �� *Phone+52      �� 55   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��0,10,0,0q�6X   .+�56      �� -   5        $	��Add��56      $��5q�65   �� 57      -   5        $��Update��57      $��5q�6;   �� 58      -   5        $��Delete��58      $��5q�6;   �� 59      -   5        $��Search��59      $��5q�6;   5:      5;      5<      