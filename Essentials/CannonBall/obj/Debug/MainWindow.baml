   M S B A M L   `   `   `  ����E  ACannonBall, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CannonBall
CannonBall  5   	       CannonBall.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CannonBall     5   	     � Title$  
MainWindow��5   	   $	��350��6   $��661.667��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 
canonImage��5
      $��image/Canon.png��6$   $
��Left=�6=   $��25��6X   $��
18,280,0,0q�6d   $	��Top=�6x   $��28��6�   �� 5   
   -   5        $��canonCanvas��5      $
��Left=�6$   
�������$	��240��6R   $��46,72,-126,0q�6_   $	��Top=�6u   $	��600��6�   �� 5   
   -   5         ��Name$ 
speedLabel��5      $��Speed (m/s)��6$   $
��Left=�6:   $��	51,10,0,0q�6U   $	��Top=�6h   $��75��6�   �� 5   
   -   5        $ 
angleLabel��5      $��Angle��6$   $
��Left=�64   $��	51,41,0,0q�6O   $	��Top=�6b   $��75��6z   �� 5   
   -   5        $ selectedSpeedLabel��5      $��  ��6,   $
��Left=�69   $��
275,10,0,0q�6T   $	��Top=�6h   �� 5   
   -   5        $ selectedAngleLabel��5      $��  ��6,   $
��Left=�69   $��
275,41,0,0q�6T   $	��Top=�6h   �� 5   
   -   5         ��Name$ speedSlider��5       � Minimum$ 10Q�6&    � Maximum$ 90Q�63    �� TickFrequency$ 1Q�6@   $
��Left=�6R   $��
143,18,0,0q�6m   $	��Top=�6�   $	��127��6�   6�   �� 5   
   -   5        $ angleSlider��5      $ 10Q�6&   $ 80Q�63   $ 1Q�6@   $
��Left=�6R   $��
143,49,0,0q�6m   $	��Top=�6�   $	��127��6�   6�   �� 5   
   -	   5        $ distanceLabel��5      $��Distance��6'   $
��Left=�6:   $��
383,10,0,0q�6U   $	��Top=�6i   �� 5   
   -
   5        $ heightLabel��5      $��Height��6%   $
��Left=�66   $��
383,41,0,0q�6Q   $	��Top=�6e   �� 5   
   -   5        $ actualDistanceLabel��5      $��X meter��6-   $
��Left=�6?   $��
443,10,0,0q�6Z   $	��Top=�6n   �� 5   
   -   5        $ actualHeightLabel��5      $��X meter��6+   $
��Left=�6=   $��
443,41,0,0q�6X   $	��Top=�6l   �� 5   
   -   5         ��Name$ shootButton��5      $��Shoot��6&   $
��Left=�66   $��
302,34,0,0q�6Q   $	��Top=�6e   $��76��6}   6�   5      5      