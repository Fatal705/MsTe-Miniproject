   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      ` \AutoReservation.Common, Version=3.0.0.2015, Culture=neutral, PublicKeyToken=80eb297b74898411�Xclr-namespace:AutoReservation.Common.DataTransferObjects;assembly=AutoReservation.Common*AutoReservation.Common.DataTransferObjects 5      \ XAutoReservation.Ui, Version=3.0.0.2015, Culture=neutral, PublicKeyToken=80eb297b74898411M+clr-namespace:AutoReservation.Ui.ConvertersAutoReservation.Ui.Converters 5      '   !AutoReservation.Ui.Views.AutoView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      9System&clr-namespace:System;assembly=mscorlib     5      kCommonXclr-namespace:AutoReservation.Common.DataTransferObjects;assembly=AutoReservation.Common     5      B
Converters+clr-namespace:AutoReservation.Ui.Converters     5        � 	Resources  5         AutoKlassen �� Source S� 
ObjectType   System.Enum S� 
MethodName S� MethodParameters M� TypeName;  5AutoReservation.Ui.Converters.AutoKlasseEnumConverter  AutoKlasseEnumConverterA  ;AutoReservation.Ui.Converters.BasistarifVisibilityConverter ! BasistarifVisibilityConverterA  ;AutoReservation.Ui.Converters.DetailViewVisibilityConverter ! DetailViewVisibilityConverter��%�   &	        &	 �     &	 �     &	 �     �� 5   
    5	      S� 5
      "  6%   $ GetNames��6G    5      M� 5      $ Common:AutoKlasse��6!   5      5        5   
   6-     5   
   63     5   
   63   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��20 �6   �� 5      $	��250 �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5!   
   �  5"      �� 5#      $��40 �6    �� 5$      $��* �6    .+�5&      �� $��0��6   $��0��6$   $��2��61   $��16(�5'      $��	UltraBold"�6"   $��Italic$�69   .��6L   
Auto-Liste5)      &   System.Windows.Controls.DataGrid  5*      -   5        $��dgAutos��5+      $��1��5*      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5+   &   	   AutoGenerateColumns	 .  
   SelectionMode$
 Single=�5,         
IsReadOnly . ��5-      �� *Autos+ �� SelectedItem 5.      �� *SelectedAuto+ �� Mode$ TwoWay=�   Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Marke��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Marke+  51      $ Auto Klasse��6)    6>   �� *
AutoKlasse+  52      $ 
Tagestarif��6)    6=   �� *
Tagestarif+  53      $ 
Basistarif��6)    6=   �� *
Basistarif+55      56      �� 57   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�58      �� $
��Left=�6   ��60   �� *LoadCommand+.��59      �� $��/Images/refresh_48_48.png��6   5:      �� 5;      $
��Left=�6   $��5,0,0,0q�6O   ��60   �� *
NewCommand+.��5<      �� $��/Images/add_48_48.png��6   5=      �� 5>      $
��Left=�6   $��5,0,0,0q�6R     ValidatedButtonStyle#���  6c   ��60   �� *DeleteCommand+.��5?      �� $��/Images/delete_48_48.png��6   5@      �� 5A      $
��Left=�6   $��5,0,0,0q�6P   #���  6a   ��60   �� *SaveCommand+.��5B      �� $��/Images/save_48_48.png��6   5C      �� 5D      $��5,0,0,0q�6   $
��Auto=�6,   $
��Auto=�6R   .��5E      �� 
���  ����6   �� *	ErrorText+67   5F      5G      � 5I   
   $��3��6   y�6   �� *SelectedAuto+ �� 	Converter# [ $ TwoWay=� 5J      �� 5K      $	��100 �6#   �� 5L      $	��150 �6#    5N      �� 5O      $��40 �6    �� 5P      $
��Auto �6    �� 5Q      $
��Auto �6    �� 5R      $
��Auto �6    �� 5S      $
��Auto �6    �� 5T      $��* �6    .+�5W      �� $��1��6   .��6!   Typ6&   �� 5X      $��2��6   .��6!   Marke6(   �� 5Y      $��3��6   .��6!   
Tagestarif6-   �� 5Z      $��4��6   .��6!   
Basistarif6-   �� 5\      $��0��6   $��0��6$   $��2��61   $��16(�5]      $��	UltraBold"�6"   $��Italic$�69   .��6L   Auto Editieren5_      �� 5`      $��1��6   $��1��6'   ��5a      ��  �� Source# [   �� SelectedIndex 5b      �� *SelectedAuto.AutoKlasse+# [ �� 5c      $��1��6   $��2��6&   ��63   �� *SelectedAuto.Marke+�� 5d      $��1��6   $��3��6&   ��63   �� *SelectedAuto.Tagestarif+�� 5e      $��1��6   $��4��6&   ��63   �� *SelectedAuto.Basistarif+y�6\   �� *SelectedAuto.AutoKlasse+# [ $ TwoWay=�5f      5g      5h      