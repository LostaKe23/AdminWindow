   M S B A M L   `   `   `  ����  AdminApp    AdminApp.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Admin Panel��5   	   $	��450��5   	   $	��800��6    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	   ���	#FFFAFAFA � 
ResizeMode$ CanResizeWithGrip=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� ���	#FF007ACC$��0��6(   $��30��65   ._�5      ]� .+�5      �� $3��-Административная панель��6   $��Center=�5      
�������$
��Bold"�5      $��10,0,0,0q�5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�66   .+�5      �� -   5        $��-��5      $��30��6)   $��30��64   ���	#FF007ACC
���������6n   Z� 6�   �� 5      -   5        $	��⧉��5      $��30��6)   $��30��64   ���	#FF007ACC
���������6u   Z� 6�   �� 5       -   5        $��X��5       $��30��6)   $��30��64   ���	#FF007ACC
���������6k   Z� 6�   5!      5"      5#      &   System.Windows.Controls.DataGrid  5&   
   $��1��6      AutoGenerateColumns$ False��5(         
IsReadOnly$
 True��5*      $��10q�5+      "   VerticalScrollBarVisibility$
 Auto=�5,      
����������	#FF007ACC$��1q�5/      ��5'      �� *	Clients+	 �� SelectedItem	 5)      �� *SelectedClient+
   Columns
 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *
FullName+  52      $ 
Адрес��6%    64   �� *	Address+  53      $ Год рождения��6%    6;   �� *YearOfBirth+  54      $ ЕГРН��6%    63   �� *EGRN+  55      $ Статус��6%    65   �� *Status+57      �� 5:   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $��10q�6X   .+�5;      �� 
���  ��$��0,0,0,10q�6H    �� TextAlignment$ Center=�6Z   ��6   �� *StatusMessage+6Z   �� 5<      $��Принять��6   $	��100��6'   $��5q�63   ���	#FF007ACC
���������6>   �� *ConfirmCommand+��6�   Z� �� 5=      $��Отклонить��6   $	��100��6)   $��5q�65   ���	#FF007ACC
���������6@   �� *RejectCommand+��6�   Z� 5>      5?      5@      