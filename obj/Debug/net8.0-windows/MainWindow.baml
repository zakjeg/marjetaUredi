   M S B A M L   `   `   `  ����G  CmarjetaUredi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:marjetaUredimarjetaUredi  5   	       marjetaUredi.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:marjetaUredi     5   	   -   5        
�������  � WindowStyle$
  None=�5        � Title$ Marjeta Uredi��5	   	   $	��720��6   $
��1280��6,   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6      CornerRadius$ 0��6/      CaptionHeight$ 0Q�6@   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� 
����� �$��2��6$   $��0q�62   �� 5   
   ���#555555$��0��6#   $��0q�61   �� 5!   
   $
��auto��6   $
��Left=�6   
������ 
������ $
��Home��6�   ��6l   �� *UpdateViewCommand+.��5"      ��  �� Orientation$ 
Horizontal=�6   .+�5#      �� $��10,1,1,1q�6   $��Assets/Icons/chapel.png��6+   $��30��6L   $��28��6W   $��Center=�6c   $��0��6~   $
��Left=�6�   �� 5$      $��5,1,5,0q�6   $��20(�6-   $��Consolas)�6;   $��Center=�6Q   
�������$��Marjeta Uredi��6   $��0��6�   $
��Left=�6�   5%      5&      �� 5(   
   $��0��6   $ 
Horizontal=�6"   $��Right=�6;   .+�5)      �� -   5        $��btnMinimize��5)      $��_��6(   $��40��64   $��30��6?   
������ 
������ 
�������6�   �� 5*      -   5        $��btnMaximize��5*      $
��🗖��6(   $��40��65   $��30��6@   
������ 
������ 
�������6�   �� 5+      -   5        $
��Left=�5+      $��Bottom=�60   $��40��6K   $��30��6V   $
��Left=�6b   $��0q�6�   ��6�   Z� ��6�   Z� ��5,      �� 5-      	 �� 
TargetType"	 ��6   .�5.      �� 
 �� Property
 � �� �� Value
 ���� 67   �� 5/      
 � �� 50      �� 51   "    �� 
TargetType" ��62   .R�52   &   �� #��z��6-   ._�53   *   �� $��Center=�6;   $��Center=�6X   54   '   55   #   57       �� Triggers 58      P� 59       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5:   "   �� 
 � ��
 �  ��6?   5;      5=      .��5?      �� $��X��6   
�������6%   5@      5A      � 5G   
   $��1��6    5H      �� 5I      $	��200 �6#   �� 5J      $��* �6#   .+�5M      �� 
�����_�$��0��6)   $��0q�69   �� 5N      
�������$��1��6)   $��0q�69   �� 5Q      $��5q�6   $��1��6$   $��0��61   $ Vertical=�6A   .+�5R      �� -   5        $��btnHome��5R      $��Domov��6(   $
��auto��68   $��30��6E   $��5q�6Q   $
��Home��6�   ��6\   �� *UpdateViewCommand+6�   �� 5S      -   5        $��btnUserList��5S      $��Seznam uporabnikov��6,   $
��auto��6I   $��30��6V   $��5q�6b   $��UserList��6�   ��6m   �� *UpdateViewCommand+6�   �� 5T      -   5        $��	btnUnused��5T      $��
Dejavnosti��6*   $
��auto��6?   $��30��6L   $��5q�6X   $��
Activities��6�   ��6c   �� *UpdateViewCommand+6�   �� 5U      -   5        $��
btnAddUser��5U      $��Dodaj Uporabnika��6+   $
��auto��6F   $��30��6S   $��5q�6_   $��AddUser��6�   ��6j   �� *UpdateViewCommand+6�   5W      �� 5Z      $��1��6   ��6-   �� *SelectedViewModel+5\      5^      5_      