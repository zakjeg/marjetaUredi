   M S B A M L   `   `   `  ����G  CmarjetaUredi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:marjetaUredi.ViewsmarjetaUredi.Views  5      %    marjetaUredi.Views.UserListView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:marjetaUredi.Views     5      
�������.��5	      �   � RowDefinitions  5
   
   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   �� $��Seznam uporabnikov��6   $��24(�6.   $
��Bold"�6<   $��Center=�6N   $��10q�6k   � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��200 �6#   .+�5      &   System.Windows.Controls.DataGrid     HeadersVisibility$ Column=�6   
���   �$��10q�6G      CanUserAddRows$ False��5         CanUserDeleteRows$ False��6.      
IsReadOnly$
 True��6H      AutoGenerateColumns$ False��5      ��5      �� *	usersList+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� *SelectedItem+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn
   Header$
 ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+6L     5!      $
 	FirstName��6)   $ 3* 6Z    6<   �� *	FirstName+6Z     5"      $
 LastName��6)   $ 4* 6X    6;   �� *
LastName+6X     5#      $
 Class��6)   $ 1* 6R    68   �� *Class+6R     5$      $	
 Age��6)   $ 1* 6N    66   �� *Age+6N     5%      $
 
FotoPermit��6)   $ 1* 6\    6=   �� *
FotoPermit+6\     5&      $
 AddInfo��6)   $ 4* 6V    6:   �� *	AddInfo+6V     5'      $
 RfidUID��6)   $ 4* 6V    6:   �� *	RfidUID+6V   5)      �� 5,      $��1��6    �� Orientation$ Vertical=�6)   $��0,10,5,5q�6@   .+�5.      �� $	��Ime��6   $��20(�6'   �� 5/      $��30��6   $��20(�6&   ��64   �� *SelectedItem.FirstName+$ PropertyChanged=��� 50      $��Priimek��6   $��20(�6+   �� 51      $��30��6   $��20(�6&   ��64   �� *SelectedItem.LastName+$ PropertyChanged=��� 52      $��Razred��6   $��20(�6*   �� 53      $��30��6   $��20(�6&   ��64   �� *SelectedItem.Class+$ PropertyChanged=��� 55      $��Shrani spremembe��6   $��15(�64   $��DemiBold"�6B   $��30��6X   $��Bottom=�6d   $��0,30,0,0q�6   57      5<      5E      5F      