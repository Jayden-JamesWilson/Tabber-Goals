   M S B A M L   `   `   `  ����G  CTabber Goals, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Tabber_GoalsTabber_Goals  5   	       Tabber_Goals.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Tabber_Goals     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z   '  !System.Windows.Shell.WindowChrome   WindowChrome 5	        5
   
      CaptionHeight$ 0Q�6      ResizeBorderThickness$ 10q�6)      GlassFrameThickness$ 1q�6D   .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      .+�5   
   �� -   5         ��Name$ Titlebar��5      $��0��6#   ��5      �� 5      	 �� Color$	 	#FF18939A��6"   ._�5      ]� ��.  .+�5      �� -   5        
 ��Name$
 CloseButton��5   C      TitlebarButtons#���   6   $	��✕��6X   $��Right=�6d   6{   �� 5      -   5        $
 MaximizeButton��5   C   #���   6   $	��▢��6[   $��Right=�6g   6~   �� 5       -   5        $
 MinimizeButton��5    C   #���   6   $	��—��6[   $��Right=�6g   6~   5"      5#      �� 5$   
   $
��Left=�6   $	��257��6+   $��130,120,0,0q�68   $��1��6M   $	��Top=�6Z   $	��260��6r   $ ��/Main/Tabber-Bot-315px.png��6~   $
��Fill=�6�   �� 5%   
   $��Button��6   $
��Left=�6"   $��40��6=   $��160,295,0,0q�6I   $��1��6^   $	��Top=�6k   $	��215��6�   #���   6�   ���	#FFCF1A1A���	#FF7321216�   �� 5&   
   -   5          ComboBoxStyle1#���  5&      $
��Left=�6<   $��145,340,0,0q�6W   $��1��6l   $	��Top=�6y   $	��230��6�   ���	#FFBB3535���	#FFCE1313.@�5'      �� m� 5(      �� 5)      �� 5*      5+      5,      5-      