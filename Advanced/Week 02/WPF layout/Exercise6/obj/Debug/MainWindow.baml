   M S B A M L   `   `   `  ����D  @Exercise6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Exercise6	Exercise6  5   	       Exercise6.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Exercise6     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   ]� .+�5      o� $	��Top=�6   $	��Top=�6(   
������.@�5      m� $
��File��6   .@�5      m� $
��Save��6   m� 5      -   5         m�Name$ exitItem��5      $
��Exit��61   5      m� 5      $
��Help��6   .@�5      m� -   5        $ 	aboutItem��5      $��About��62   5      5      �� 5       �� Orientation$ 
Horizontal=�6   $��Bottom=�62   $��Stretch=�6J   $��Bottom=�6h   .+�5      �� -   5         ��Name$ 	statusBar��5      $��Status Bar Message...��6/   
������� �� Padding$ 5q�6^   $	��520��6j   5      �� 5      $ Vertical=�6   $
��Left=�60   $	��135��6F   
�������.+�5      �� -   5         ��Name$ kleurButton��5      $��Wijzig kleur��6.   $	��2.5q�6E   �� 5      -   5        $ versmalButton��5      $��Venster versmallen��60   $	��2.5q�6M   �� 5      -   5        $ verwijderButton��5      $��Verwijder rechthoeken��63   $	��2.5q�6S   5      �� 5      .+�5       � $	��270��6    � RowDefinitions 5!      �� 5"      $��1* �6(   �� 5#      $��1* �6(    � ColumnDefinitions 5%      �� 5&      $��1* �6+   �� 5'      $��1* �6+   .+�5*      �� -   5         ��Name$ 
linksBoven��5*       $��0��64   $��0��6D   $��5q�6Q   
����  �6\   �� 5+      -   5        $ rechtsBoven��5+       $��1��65   $��0��6E   $��5q�6R   
��� � �6]   �� 5,      -	   5        $ 
linksOnder��5,       $��0��64   $��1��6D   $��5q�6Q   
������6\   �� 5-      -
   5        $ rechtsOnder��5-       $��1��65   $��1��6E   $��5q�6R   
����� �6]   5/      50      54      56      57      