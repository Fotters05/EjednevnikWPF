   M S B A M L   `   `   `  ����H  DWpfEjednevnik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfEjednevnikWpfEjednevnik  5   	       WpfEjednevnik.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfEjednevnik     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ 
datePicker��5      $��0��6)   $��0��69   $
��Left=�6F   $��30��6a   $��10q�6m   $	��Top=�6y   $	��200��6�   6�   �� 5   
   -   5         ��Name$ listBox��5      $��0��6#   $��1��63   $��2��6@   $��10q�6T    �� DisplayMemberPath$ Title��6~   ��6`   �� *notes+6�   �� 5   
   -   5         ��Name$ titleTextBox��5      $��1��6(   $��0��68   $��30��6E   $��10q�6Q    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��300��6�   �� 5   
   -   5        $ descriptionTextBox��5      $��1��6.   $��1��6>   $	��200��6K   $��10q�6X   $
 Wrap=�6d   $	��Top=�6x   $	��300��6�   �� 5   
   $��1��6   $��2��6%    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��10q�6g   .+�5      �� -   5        $	��Add��5      $��5q�6#   $��75��6.   69   �� 5      -   5        $
��Edit��5      $��5q�6$   $��75��6/   6:   �� 5      -   5        $��Delete��5      $��5q�6&   $��75��61   6<   �� 5      -   5        $
��View��5      $��5q�6$   $��75��6/   6:   5      5      5       