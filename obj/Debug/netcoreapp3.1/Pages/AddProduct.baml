   M S B A M L   `   `   `  ����E  ALabWork6_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LabWork6_7.PagesLabWork6_7.Pages  5      !    LabWork6_7.Pages.AddProduct   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:LabWork6_7.Pages     5        N� Title$  
AddProduct��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��5* �6   .+�5   
   �� $��0��6   .+�5      �� $ ��\Images\Add_Photo_Icon.png��6   $��5 5 5 5q�5      5      � 5   
   $��1��6   .+�5      �� .+�5      �� $��Название��6   .��5      �� $��3 3 3 3q�6   
���������5       ��  �� Path$ NewProduct.Title�5!      �� 5#      $ ��Производитель��6   .��5$      �� $��3 3 3 3q�6   
���������5%      �� $ NewProduct.Producer�5&      �� 5(      $��Описание��6   .��5)      �� $��3 3 3 3q�6   
���������5*      �� $ NewProduct.Discription�5+      �� 5-      $��Цена��6   .��5.      �� $��3 3 3 3q�6   
���������5/      �� $ NewProduct.Prise�50      �� 52      $��3 3 3 3q�6    �� SelectedValue 6,   �� $ Selected�.@�53      ��  �� 
IsSelected$
 True��6#   .��54      �� $��Drawing��6$   55      �� 57      $��MechanicalDrawing��6    �� 59      $��Writing��6    5:      �� 5<      $��Ok��6   $��1 3 1 3q�6&   ��5=      �� *AddNew+5?      5A      5B      5C      