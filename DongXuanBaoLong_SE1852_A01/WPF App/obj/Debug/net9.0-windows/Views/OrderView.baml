   M S B A M L   `   `   `  ����  DongXuanBaoLongWPF(    "DongXuanBaoLongWPF.Views.OrderView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      � $��10q�6     � RowDefinitions  5
   
   �� 5      $
��2.5* �6   �� 5      $
��2.5* �6   �� 5      $��4* �6   .+�5   
   �� $��Orders��6   $��0��6#   $
��Bold"�60   $��0,0,0,10q�6B   .��5      &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��5         
IsReadOnly$
 True��5      $��5q�5      ��5      �� *Orders+ �� SelectedItem 5      �� *SelectedOrder+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Order ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *	OrderID+6W     5      $ Customer��6)   $ * 6\    6;   �� *CustomerName+6\     5      $ Employee��6)   $ * 6\    6;   �� *EmployeeName+6\     5      $ 
Order Date��6)   $ * 6[    6=   �� *	OrderDate+6[   5      5      �� 5!   
   $��Order Items��6   $��1��6(   $
��Bold"�65   $��0,0,0,10q�6G   .��5"        $ False��5#      $
 True��5$      $��5q�5%      ��5"      �� *SelectedOrderItems+ 5&        5'      $ 
Product ID��6)   $ * 6[    6=   �� *	ProductID+6[     5(      $ Product Name��6)   $ 2* 6_    6?   �� *ProductName+6_     5)      $ Quantity��6)   $ * 6X    6;   �� *
Quantity+6X     5*      $ 
Unit Price��6)   $ * 6[    6=   �� *	UnitPrice+6[     5+      $ Discount��6)   $ * 6X    6;   �� *
Discount+6X   5-      5.      �� 51   
   $��Create New Order��6   $��2��6-   $
��Bold"�6:   .��52      �� $
��Auto=�6   .��53      �� $��10q�6   .+�56      �� $��Search Product:��6    $��SemiBold"�67   $��0,0,0,5q�6M   �� 57      	 �� Orientation$	 
Horizontal=�6!   $��0,0,0,5q�6:   .+�58      �� $	��200��6"   $��0,0,6,0q�6v   ��6.   �� *ProductSearchText+
 �� UpdateSourceTrigger$
 PropertyChanged=�6v   �� 59      -   5        $��Search��59   !   $��80��62   6=   5:      �� 5;       �� DisplayMemberPath$ ProductName��5=      $��80��5>      $��0,0,0,10q�6*   ��5;      �� *
Products+ 5<      �� *SelectedProduct+5>   *   �� 5A      $��Search Customer:��6    $��SemiBold"�68   $��0,10,0,5q�6N   �� 5B      $	 
Horizontal=�6!   $��0,0,0,5q�6:   .+�5C      �� $	��200��6"   $��0,0,6,0q�6w   ��6.   �� *CustomerSearchText+$
 PropertyChanged=�6w   �� 5D      -   5        $��Search��5D   !   $��80��62   6=   5E      �� 5F      $ ContactName��5H      $��80��5I      $��0,0,0,10q�6*   ��5F      �� *	Customers+ 5G      �� *SelectedCustomer+5I   *   �� 5L      $	 
Horizontal=�6!   $��0,10,0,0q�6:   .+�5M      �� $��	Quantity:��6$   $��Center=�65   $��0,0,5,0q�6P   �� 5N      $��50��6"   $��0,0,20,0q�6l   ��6-   �� *
Quantity+$
 PropertyChanged=�6l   �� 5P      $��	Discount:��6$   $��Center=�65   $��0,0,5,0q�6P   �� 5Q      $��50��6"   $��0,0,20,0q�6l   ��6-   �� *
Discount+$
 PropertyChanged=�6l   �� 5S      $��	Customer:��6$   $��Center=�65   $��0,0,5,0q�6P   �� 5T      $	��100��6"   $��0,0,20,0q�6q   ��6.   �� *CustomerName+$
 PropertyChanged=�6q   �� 5V      $��Product:��6$   $��Center=�64   $��0,0,5,0q�6O   �� 5W      $	��100��6"   $��0,0,20,0q�6p   ��6.   �� *ProductName+$
 PropertyChanged=�6p   �� 5Y      -   5        $��	Add Order��5Y   !   $
��10,2q�6L   5Z      5[      5\      5]      5^      5_      