   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	   N JBreachingDroneElite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BreachingDroneEliteBreachingDroneElite 5   	   $   BreachingDroneElite.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   3local!clr-namespace:BreachingDroneElite     5   	   -   5          �Name$  Window��5   	    � Title$ Breaching Drone Elite 1.0��5   	   $��390.8��6+   $	��500��6:   .��5      � -   5         �Name$ BreachingDroneElite��5      $��
0,0,-0.4,0q�6(    � ColumnDefinitions 5   
   �� 5      ��5   
   �� 5       �� ImageSource$> 8https://i.gyazo.com/a5d0f9a2420474e065434995d9db7b7e.png��6    j� Stretch$ UniformToFill=�6`    �� Opacity$
 0.99Q�6x   .+�5   
   �� -   5         ��Name$ CaptureButton��5      $��Capture photo��6(   $
��Left=�6@   $��350,127,0,0q�6[   $	��Top=�6p   $��50��6�   $	��100��6�   
���   ����	#FFFF9300$
��Bold"�6�   �� 5   
   -   5        $ ClearImagesButton��5      $��B D E��6,   $
��Left=�6<   $��
350,25,0,0q�6W   $	��Top=�6k   $��50��6�   $	��100��6�   
���   �$
��Bold"�6�   ���	#FFFF93006�   �� 5   
   -   5        $ 	Start_BTN��5      $��Start Videofeed��6$   $
��Left=�6>   $��113,300,0,0q�6Y   $	��Top=�6n   $��50��6�   $	��100��6�   
���   ����	#FFFF9300$
��Bold"�6�   �� 5   
   -   5        $ 	Pause_BTN��5      $��Pause��6$   $
��Left=�64   $��218,300,0,0q�6O   $	��Top=�6d   $��50��6|   $��50��6�   
���   ����	#FFFF9300$
��Bold"�6�   �� 5   
   -   5        $ Stop_BTN��5      $
��Stop��6#   $
��Left=�62   $��
58,300,0,0q�6M   $	��Top=�6a   $��50��6y   $��50��6�   ���	#FFFF9300
���   �$
��Bold"�6�   �� 5   
   $
��Left=�6   $��470,600,0,-255.2q�6/   $
��Wrap=�6I   $	��AIG��6]   $	��Top=�6h   �� 5   
   $
��Left=�6   $	��100��6/   $��-15,318,0,-57.2q�6<   $	��Top=�6U   $��15��6m    J� RenderTransformOrigin$ 0.5,0.5&�6x   z�5      V� 5      .~�5      �� 	 �� ScaleX$	 -1Q�6%   �� 5      �� 5      T� 5       5!      5#      �� 5$   
   -   5        
 ��Name$
 imagebox��5$      $
��Left=�6"   $	��206��6=   $��	27,38,0,0q�6J   $	��Top=�6]   $	��297��6u   �� 5%   
   -	   5         ��Name$ textbox1��5%      $
��Left=�6$   $��23��6?   $��350,254,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $��SELECT * FROM face��6t   $	��Top=�6�   $	��120��6�   �� 5&   
   -
   5        $��Confirm��5&      $
��Left=�6#   $	��Top=�6>   $��81��6V   $��369,223,0,0q�6a   
���   ����	#FFFF9300$
��Bold"�6�   $��21��6�   5,      5.      