   M S B A M L   `   `   `  ����\  XAutoReservation.Ui, Version=3.0.0.2015, Culture=neutral, PublicKeyToken=80eb297b74898411M+clr-namespace:AutoReservation.Ui.ConvertersAutoReservation.Ui.Converters  5      .    (AutoReservation.Ui.Views.ReservationView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      B
Converters+clr-namespace:AutoReservation.Ui.Converters     5        � 	Resources  5      A   ;AutoReservation.Ui.Converters.DetailViewVisibilityConverter !  DetailViewVisibilityConverter��%   &	          5   
   63   5      .��5      �  � ColumnDefinitions 5	   
   �� 5
      $��* �6   �� 5      $��20 �6   �� 5      $	��250 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �  5      �� 5      $��40 �6    �� 5      $��* �6    .+�5      �� $��0��6   $��0��6$   $��2��61   $��16(�5      $��	UltraBold"�6"   $��Italic$�69   .��6L   Reservations-Liste5      &   System.Windows.Controls.DataGrid  5      -   5        $��dgReservationen��5      $��1��5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5   .      AutoGenerateColumns .     SelectionMode$ Single=�5         
IsReadOnly . ��5       �� *Reservationen+ �� SelectedItem 5!      �� *SelectedReservation+ �� Mode$ TwoWay=�	   Columns	 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Reservations Nr.��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *ReservationNr+  5$      $	
 Von��6)    66   �� *Von+ �� StringFormat$ {0:dd.MM.yyyy}��$ TwoWay=�  5%      $	
 Bis��6)    66   �� *Bis+$ {0:dd.MM.yyyy}��$ TwoWay=�  5&      $

 Auto��6)    67   �� *
Auto.Marke+  5'      $
 Nachname��6)    6;   �� *Kunde.Nachname+  5(      $
 Vorname��6)    6:   �� *Kunde.Vorname+5*      5+      �� 5,   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5-      �� $
��Left=�6   ��60   �� *LoadCommand+.��5.      �� $��/Images/refresh_48_48.png��6   5/      �� 50      $
��Left=�6   $��5,0,0,0q�6O   ��60   �� *
NewCommand+.��51      �� $��/Images/add_48_48.png��6   52      �� 53      $
��Left=�6   $��5,0,0,0q�6R     ValidatedButtonStyle#���  6c   ��60   �� *DeleteCommand+.��54      �� $��/Images/delete_48_48.png��6   55      �� 56      $
��Left=�6   $��5,0,0,0q�6P   #���  6a   ��60   �� *SaveCommand+.��57      �� $��/Images/save_48_48.png��6   58      �� 59      $��5,0,0,0q�6   $
��Auto=�6,   $
��Auto=�6R   .��5:      �� 
���  ����6   �� *	ErrorText+67   5;      5<      � 5>   
   $��3��6   y�6   �� *SelectedReservation+ �� 	Converter# [  $ TwoWay=� 5?      �� 5@      $	��100 �6#   �� 5A      $	��150 �6#    5C      �� 5D      $��40 �6    �� 5E      $
��Auto �6    �� 5F      $
��Auto �6    �� 5G      $
��Auto �6    �� 5H      $
��Auto �6    �� 5I      $
��Auto �6    �� 5J      $��* �6    .+�5M      �� $��1��6   .��6!   Reservations Nr.63   �� 5N      $��2��6   .��6!   Von6&   �� 5O      $��3��6   .��6!   Bis6&   �� 5P      $��4��6   .��6!   Auto6'   �� 5Q      $��5��6   .��6!   Kunde6(   �� 5S      $��0��6   $��0��6$   $��2��61   $��16(�5T      $��	UltraBold"�6"   $��Italic$�69   .��6L   Reservation Editieren5V      �� 5W      $��1��6   $��1��6&    �� 
IsReadOnly . ��63   �� *#!SelectedReservation.ReservationNr+6f   (  "System.Windows.Controls.DatePicker  5X      $��1��6   $��2��6)      DisplayDateEnd$ 
12/31/2020X�6g      DisplayDateStart$ 1/1/2000X�6�      SelectedDate 66   �� *SelectedReservation.Von+6�     5Y      $��1��6   $��3��6)   $ 
12/31/2020X�6g   $ 1/1/2000X�6�    66   �� *SelectedReservation.Bis+6�   �� 5Z      $��1��6   $��4��6'    �� SelectedValuePath$ Id��6{    �� DisplayMemberPath$ Marke��6�   ��64   �� *Autos+ �� SelectedValue 6R   �� *SelectedAutoId+6�   �� 5[      $��1��6   $��5��6'   $ Id��6}   ��64   �� *Kunden+ 6S   �� *SelectedKundeId+��5\      �� 5]      .R�5^      �� $ 
Horizontal=�6%   .+�5_      �� ��6(   �� *	Vorname+�� 5`      $�� ��6(   �� 5a      ��6(   �� *
Nachname+5b      5c      5e      5f      5g      5h      