   M S B A M L   `   `   `  ����\  XAutoReservation.Ui, Version=3.0.0.2015, Culture=neutral, PublicKeyToken=80eb297b74898411C&clr-namespace:AutoReservation.Ui.ViewsAutoReservation.Ui.Views  5      #    AutoReservation.Ui.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      8Views&clr-namespace:AutoReservation.Ui.Views     5        � Title$"  Auto Reservation Application��5      $
��1024��5      $	��768��6    � 	Resources 5         ValidatedButtonStyle �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value��%�   &	        �� 5   
   " ��6-    5	      P� 5
       � {� .  . �5      ��  � y�$ 	Collapsed=�63   6G   5      5      5      .��5      � .+�5   
   �� .@�5      �� $��Autos��6   .��5      '   !AutoReservation.Ui.Views.AutoView  -   5          Name$ 
avAutoView��5   !   	 � DataContext	 5   !   �� 
 �� Path$
 AutoViewModel� �� Mode$ OneWay=�5      �� 5      $��Kunden��6   .��5      (   "AutoReservation.Ui.Views.KundeView  -   5          Name$ kvKundenView��5   "   	 5   "   �� $
 KundeViewModel�$ OneWay=�5      �� 5      $��Reservationen��6   .��5      .   (AutoReservation.Ui.Views.ReservationView  -   5          Name$ kvReservationen��5   (   	 5   (   �� $
 ReservationViewModel�$ OneWay=�5      5      5      5       