   M S B A M L   `   `   `  ����M  IDongXuanBaoLongWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:DongXuanBaoLongWPF.ViewModelsDongXuanBaoLongWPF.ViewModels  5      )    #DongXuanBaoLongWPF.Views.ReportView   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      :vm+clr-namespace:DongXuanBaoLongWPF.ViewModels     5      .��5	      � $��10q�6     � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   .+�5      �� $��From:��6   $��Center=�6%   $��0,0,5,0q�6@   (  "System.Windows.Controls.DatePicker  5      $��0,0,10,0q�6;      SelectedDate 6   �� *
FromDate+6;   �� 5      $	��To:��6   $��Center=�6#   $��0,0,5,0q�6>     5      $��0,0,10,0q�69    6   �� *ToDate+69   �� 5      -   5        $��Load Report��5      6+   5      &   System.Windows.Controls.DataGrid  5   
   $��1��6      AutoGenerateColumns$ False��5      $��	0,10,0,10q�5         
IsReadOnly$
 True��5      ��5      �� *
Statistics+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Period+	 �� StringFormat$	 {0:yyyy-MM-dd}��6m     5!      $ Total Orders��6%   $ * 6[    6;   �� *TotalOrders+6[     5"      $ Total Revenue��6%   $ 2* 6m    6<   �� *TotalRevenue+$	 C��6m   5$      �� 5'   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5(      �� -   5        $��Export to CSV��5(      $��5q�6-   68   5*      5+      5,      