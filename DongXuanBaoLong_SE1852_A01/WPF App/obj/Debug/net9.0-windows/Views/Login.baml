   M S B A M L   `   `   `  ����M  IDongXuanBaoLongWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:DongXuanBaoLongWPF.ViewsDongXuanBaoLongWPF.Views  5   	   $    DongXuanBaoLongWPF.Views.Login   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:DongXuanBaoLongWPF.Views     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&    � 	Resources 5
         	BoolToVis��%   &	        �� 5   
   6'   5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0,0,0,10q�6"   .+�5      �� $��	Login as:��6   �� 5      -   5         ��Name$ loginRoleComboBox��5       �� SelectedValuePath$ Content��5       �� SelectedValue 5      �� *SelectedRole+ �� UpdateSourceTrigger$ PropertyChanged=�.@�5      �� $��Customer��6   �� 5      $��Employee��6   5      5      �� 5"   
   $��1��6   y�6"   �� *
IsCustomer+ �� 	Converter# [  .+�5#      �� $��Phone:��6   �� 5$      ��6   �� *Phone+$ PropertyChanged=�5%      �� 5(   
   $��1��6   y�6"   �� *
IsEmployee+# [  .+�5)      �� $��	Username:��6   �� 5*      ��6   �� *
UserName+$ PropertyChanged=��� 5+      $��	Password:��6   G� 5,      -   5         G�Name$ employeePasswordBox��5,      5-      �� 50   
   $��3��6   	 �� Orientation$	 
Horizontal=�6"   $��0,10,0,0q�6;   $��Center=�6M   .+�51      �� -   5        $��Login��51      $��5q�6?   52      53      54      