   M S B A M L   `   `   `  ����J  Fmegacasting.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:megacasting.WPF.Viewsmegacasting.WPF.Views  5      $    megacasting.WPF.Views.UserView   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:megacasting.WPF.Views     5      ���#393E46.��5	      � -   5          �Name$  myGrid��5	       � ColumnDefinitions 5
   
   �� 5      $��200pt �6   �� 5      $��* �6   �� 5      $��200pt �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��100pt �6   �� 5      $
��60pt �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��1��6,   $��3��6>   .+�5      �� $��Utilisateur��6   $��25(�6*   $	��2pxq�68   $��Center=�6N   ���#F8F4EA6r   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridUser��5         AutoGenerateColumns$ False��5      ���#00ADB5$��1��5      $��Stretch=�5         SelectionMode$ Single=�5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5      ��5   -   �� *Users+ �� SelectedItem 5      �� *SelectedUser+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 Nom��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Nom+  5       $
 Prenom��6)    69   �� *Prenom+  5!      $
 Date de naissance��6)    6D   �� *DateNaissance+  5"      $
 	Telephone��6)    6<   �� *	Telephone+  5#      $
 Email��6)    68   �� *Email+  5$      $
 Ville��6)    68   �� *Ville+5&      5'      �� 5(   
   $ Vertical=�6   $��1��6,   $��3��6:   .+�5)      �� $ 
Horizontal=�6   .+�5*      �� $��Nom :��6   
�������6(   �� 5+      -   5         ��Name$	 Nom��5+      $	��100��6I   ��6'   �� *SelectedUser.Nom+6W   �� 5,      $��Prenom :��6   
�������6+   �� 5-      -   5        $ Prenom��5-      $	��100��6O   ��6*   �� *SelectedUser.Prenom+6]   �� 5.      $��Date de naissance :��6   
�������66   (  "System.Windows.Controls.DatePicker  5/      -   5          Name$ DateNaissance��5/         SelectedDateFormat$ Short=�64      Text 6O   �� *SelectedUser.DateNaissance+�� 50      $��Téléphone :��6   
�������6.   �� 51      -   5        $ 	Telephone��51      $	��100��6U   ��6-   �� *SelectedUser.Telephone+6c   52      �� 53      $ 
Horizontal=�6   .+�54      �� $��Mail :��6   
�������6)   �� 55      -   5        $
 Mail��55      $	��100��6L   ��6(   �� *SelectedUser.Email+6Z   �� 56      $��Ville :��6   
�������6*   �� 57      -   5        $ Ville��57      $	��100��6M   ��6)   �� *SelectedUser.Ville+6[   58      59      �� 5:   
   $ 
Horizontal=�6   $��Right=�6.   $��2��6J   $��3��6X   .+�5;      �� -	   5         ��Name$ ModifierUser��5;      $��Modifier��6+   $
��30pt��6>   $
��50pt��6L   $	��5ptq�6Y   ���#00ADB56{   �� 5<      -
   5        $ SupprimerUser��5<      $��	Supprimer��6,   $
��30pt��6@   $
��50pt��6N   $	��5ptq�6[   ���#00ADB56}   �� 5=      -   5        $ AjouterUser��5=      $��Ajouter��6*   $
��30pt��6<   $
��50pt��6J   $	��5ptq�6W   ���#00ADB56y   5>      5?      5@      