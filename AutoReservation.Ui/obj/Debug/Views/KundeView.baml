   M S B A M L   `   `   `  ����\  XAutoReservation.Ui, Version=3.0.0.2015, Culture=neutral, PublicKeyToken=80eb297b74898411M+clr-namespace:AutoReservation.Ui.ConvertersAutoReservation.Ui.Converters  5      (    "AutoReservation.Ui.Views.KundeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      B
Converters+clr-namespace:AutoReservation.Ui.Converters     5        � 	Resources  5      A   ;AutoReservation.Ui.Converters.DetailViewVisibilityConverter !  DetailViewVisibilityConverter��%   &	          5   
   63   5      .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��* �6   �� 5      $��20 �6   �� 5      $	��250 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �  5      �� 5      $��40 �6    �� 5      $��* �6    .+�5      �� $��0��6   $��0��6$   $��2��61   $��16(�5      $��	UltraBold"�6"   $��Italic$�69   .��6L   Kunden-Liste5      &   System.Windows.Controls.DataGrid  5      -   5        $��dgKunden��5      $��1��5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5   '      AutoGenerateColumns .     SelectionMode$ Single=�5         
IsReadOnly . ��5       �� *Kunden+ �� SelectedItem 5!      �� *SelectedKunde+ �� Mode$ TwoWay=�	   Columns	 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Nachname��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
Nachname+  5$      $
 Vorname��6)    6:   �� *	Vorname+  5%      $
 Geburtsdatum��6)    6?   �� *Geburtsdatum+ �� StringFormat$ {0:dd.MM.yyyy}��$ TwoWay=�5'      5(      �� 5)   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5*      �� $
��Left=�6   ��60   �� *LoadCommand+.��5+      �� $��/Images/refresh_48_48.png��6   5,      �� 5-      $
��Left=�6   $��5,0,0,0q�6O   ��60   �� *
NewCommand+.��5.      �� $��/Images/add_48_48.png��6   5/      �� 50      $
��Left=�6   $��5,0,0,0q�6R     ValidatedButtonStyle#���  6c   ��60   �� *DeleteCommand+.��51      �� $��/Images/delete_48_48.png��6   52      �� 53      $
��Left=�6   $��5,0,0,0q�6P   #���  6a   ��60   �� *SaveCommand+.��54      �� $��/Images/save_48_48.png��6   55      �� 56      $��5,0,0,0q�6   $
��Auto=�6,   $
��Auto=�6R   .��57      �� 
���  ����6   �� *	ErrorText+67   58      59      � 5;   
   $��3��6   y�6   �� *SelectedKunde+ �� 	Converter# [  $ TwoWay=� 5<      �� 5=      $	��100 �6#   �� 5>      $	��150 �6#    5@      �� 5A      $��40 �6    �� 5B      $
��Auto �6    �� 5C      $
��Auto �6    �� 5D      $
��Auto �6    �� 5E      $��* �6    .+�5H      �� $��1��6   .��6!   
Nachname6+   �� 5I      $��2��6   .��6!   	Vorname6*   �� 5J      $��3��6   .��6!   Geburtsdatum6/   �� 5L      $��0��6   $��0��6$   $��2��61   $��16(�5M      $��	UltraBold"�6"   $��Italic$�69   .��6L   Kunde Editieren5O      �� 5P      $��1��6   $��1��6&   ��63   �� *SelectedKunde.Nachname+�� 5Q      $��1��6   $��2��6&   ��63   �� *SelectedKunde.Vorname+(  "System.Windows.Controls.DatePicker  5R      $��1��6   $��3��6)      DisplayDateEnd$ 
12/31/2020X�6j      DisplayDateStart$ 1/1/1900X�6�      SelectedDate 66   �� *SelectedKunde.Geburtsdatum+6�   5S      5T      5U      