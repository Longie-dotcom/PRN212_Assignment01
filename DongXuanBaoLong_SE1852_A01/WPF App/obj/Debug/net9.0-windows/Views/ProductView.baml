   M S B A M L   `   `   `  ����M  IDongXuanBaoLongWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:DongXuanBaoLongWPF.ViewModelsDongXuanBaoLongWPF.ViewModels  5      *    $DongXuanBaoLongWPF.Views.ProductView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      :vm+clr-namespace:DongXuanBaoLongWPF.ViewModels     5      .��5	      � $��10q�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��0,0,0,10q�6,   .+�5      �� $��Product Name��6   �� 5      ��6   �� *Input.ProductName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5      $��Supplier ID��6   �� 5      ��6   �� *Input.SupplierID+$ PropertyChanged=��� 5      $��Category ID��6   �� 5      ��6   �� *Input.CategoryID+$ PropertyChanged=��� 5      $��Quantity Per Unit��6   �� 5      ��6   �� *Input.QuantityPerUnit+$ PropertyChanged=��� 5      $��
Unit Price��6   �� 5      ��6   �� *Input.UnitPrice+$ PropertyChanged=��� 5!      $��Units In Stock��6   �� 5"      ��6   �� *Input.UnitsInStock+$ PropertyChanged=��� 5$      $��Units On Order��6   �� 5%      ��6   �� *Input.UnitsOnOrder+$ PropertyChanged=��� 5'      $��Reorder Level��6   �� 5(      ��6   �� *Input.ReorderLevel+$ PropertyChanged=��� 5*      $ 
Horizontal=�6   $��Center=�62   .+�5+      �� $��Discontinued:��6   $��Center=�61   $��0,5,5,0q�6L   �� 5,       d� 	IsChecked 6   �� *Input.Discontinued+$ PropertyChanged=�5-      5.      &   System.Windows.Controls.DataGrid  51   
   $��1��6      AutoGenerateColumns$ False��54      $��	0,10,0,10q�55      ��52      �� *
Products+ �� SelectedItem 53      �� *SelectedProduct+ �� Mode$ TwoWay=�   Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   
IsReadOnly$
	 True��6O   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *	ProductID+6O     58      $
 Name��6%   
 63   �� *ProductName+  59      $ Supplier ID��6%   
 6:   �� *
SupplierID+  5:      $ Category ID��6%   
 6:   �� *
CategoryID+  5;      $ Quantity/Unit��6%   
 6<   �� *QuantityPerUnit+  5<      $ Price��6%   
 64   �� *	UnitPrice+  5=      $ In Stock��6%   
 67   �� *UnitsInStock+  5>      $ On Order��6%   
 67   �� *UnitsOnOrder+  5?      $ Reorder Level��6%   
 6<   �� *ReorderLevel+4  .System.Windows.Controls.DataGridCheckBoxColumn  5@      $ Discontinued��6)   
 6?   �� *Discontinued+5B      �� 5E   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5F      �� -   5        $	��Add��5F      $��5q�6#   6.   �� 5G      -   5        $��Update��5G      $��5q�6&   61   �� 5H      -   5        $��Delete��5H      $��5q�6&   61   �� 5I      -   5         ��Name$ 	SearchBox��5I      $	��200��6)   $
��20,0q�65   �� 5J      -   5        $��Search��5J      6&   5K      5L      5M      