   M S B A M L   `   `   `  ����E  ALabWork6_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:LabWork6_7.PagesLabWork6_7.Pages  5          LabWork6_7.Pages.Viewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:LabWork6_7.Pages     5        N� Title$  Viewer��5	       N� 
Background
 ����� � 	Resources 5         TextBlockFont �� Property �� Value��%M   &	        �� 5   
   .�5      ��  � ��$ Oblique$�67   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.2* �6    � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $
��True��6   $��5 5 5 5q�5      $	��250��6(   .��5      �� $��0��6   ��6&   �� *
products+ �� SelectedItem 5       �� *SelectedProduct+��5!      �� 5"      .R�5#      �� .+�5$      �� $��18(�6(   ��66   ��  �� Path$ Title��� 5%      ��6(   �� $ Producer��� 5&      ��6(   �� $ Discription��� 5'      ��6(   �� $ Section��� 5(      ��6(   �� $ Prise�5)      5*      5,      5-      �� 5/   
   $��1��6   $��0��6%   	 � DataContext	 50      �� *SelectedProduct+.+�51      �� $'��!Выбранный элемент��6   �� 53      $��Название��6   �� 54      #��[  55      ��54      �� *Title+
 �� UpdateSourceTrigger$
 PropertyChanged=�55      �� 57      $��Описание��6   �� 58      #��[  59      ��58      �� *Discription+$
 PropertyChanged=�59      �� 5<      $ ��Производитель��6   �� 5=      #��[  5>      ��5=      �� *
Producer+$
 PropertyChanged=�5>      �� 5@      $��Категория��6   �� 5A      #��[  5B      ��5A      �� *	Section+$
 PropertyChanged=�5B      �� 5D      $��Цена��6   �� 5E      #��[  5F      ��5E      �� *Prise+$
 PropertyChanged=�5F      5G      5H      5I      