   M S B A M L   `   `   `  ����G  CmarjetaUredi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:marjetaUredi.ViewsmarjetaUredi.Views  5      $    marjetaUredi.Views.AddUserView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:marjetaUredi.Views     5      
�������.��5	      �   � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $	��300 �6#   �� 5      $	��300 �6#   �� 5      $
��Auto �6#   .+�5      ��  �� Orientation$ Vertical=�6   $��5q�60   .+�5      �� $��5q�6   $	��Ime��6'   �� 5      $��Center=�6   $��5,5,5,8q�65   $��30��6F   ��6R   �� *
UserName+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��5q�6   $��Priimek��6'   �� 5      $��Center=�6   $��5,5,5,8q�65   $��30��6F   ��6R   �� *
LastName+$ PropertyChanged=�6�   �� 5      $��5q�6   $��razred��6'   �� 5      $��Center=�6   $��5,5,5,8q�65   $��30��6F   ��6R   �� *	UserClass+$ PropertyChanged=�6�   �� 5      $��5q�6   $��starost��6'   �� 5       $��Center=�6   $��5,5,5,8q�65   $��30��6F   ��6R   �� *	UserAge+$ PropertyChanged=�6�   �� 5#      $��5q�6   $��Dodaj uprabnika��6$   $
��auto��6>   $��40��6K   $��Center=�6W   $��DemiBold"�6t   $��25(�6�   ��6�   �� *
AddCommand+5$      �� 5(      $ Vertical=�6   $��5q�60   $��1��6;   .+�5)      �� $��10q�6   $!��TEST INotifyPropertyChanged��6(   $��Center=�6K   $
��Bold"�6h   �� 5*      -   5        $��InputTB��5*      $��5q�6~   $	��250��6�   $��18(�6�   $��Center=�6�   ��6*   �� *
UserName+$ PropertyChanged=� �� Mode$ OneWayToSource=�6�   �� 5+      -   5        $��ResultTB��5+      $��5q�6,   $
��auto��67   $
��auto��6_   $��18(�6m   ��6D   �� *
UserName+6m   �� 5-      -   5        $��	SetButton��5-      $��
Yellowtail)�6*   $	��Set��6Z   $��Center=�6h   $	��100��6�   $��25(�6�   $��5q�6�   5/      53      55      56      